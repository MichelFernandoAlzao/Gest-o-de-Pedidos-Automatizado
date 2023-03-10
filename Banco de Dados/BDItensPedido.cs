using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace Banco_de_Dados
{
    public class BDItensPedido
    {
        public string cpID { get; set; }
        public string cpProdutoID { get; set; }
        public string cpQunatidade { get; set; }
        public string cpLote { get; set; }
        public string cpValorUnit { get; set; }
        public string cpFornecedor { get; set; }
        public string cpValorFornecedor { get; set; }
        public string cpPedidoDR { get; set; }
        public string cpMsgErro { get; set; }


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados()
        {

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPItensPedido (";
            sqlconteudo = " VALUES (";

            if (cpProdutoID.ToString() != "")
            {
                sqlCampos += "OPITPProdutoDR, ";

                sqlconteudo += "'" + cpProdutoID.ToString() + "',";
            }
            if (cpQunatidade.ToString() != "")
            {
                sqlCampos += "OPITPQuantidade, ";

                sqlconteudo += "'" + cpQunatidade.ToString() + "',";
            }
            if (cpLote.ToString() != "")
            {
                sqlCampos += "OPITPLote, ";

                sqlconteudo += "'" + cpLote.ToString() + "',";
            }
            if (cpValorUnit.ToString() != "")
            {
                sqlCampos += "OPITPValorUnitario, ";

                sqlconteudo += "'" + cpValorUnit.ToString() + "',";
            }
            if (cpFornecedor.ToString() != "")
            {
                sqlCampos += "OPITPFornecedorDR, ";

                sqlconteudo += "'" + cpFornecedor.ToString() + "',";
            }
            if (cpValorFornecedor.ToString() != "")
            {
                sqlCampos += "OPITPValorFornecedor, ";

                sqlconteudo += "'" + cpValorFornecedor.ToString() + "',";
            }
            if (cpPedidoDR != null)
            {
                sqlCampos += "OPITPPedidoDR, ";

                sqlconteudo += "'" + cpPedidoDR.ToString() + "',";
            }
           

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteScalar();
                //Desconectar

                cmd.CommandText = "SELECT IDENT_CURRENT ('OPPPedido') AS Current_Identity";
                string LID = Convert.ToString(cmd.ExecuteScalar());

                cpID = LID;


                conexao.desconectar();
                cpMsgErro = "";


            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void AlteraDados()
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPItensPedido = '" + cpID + "'";

            sSQL = "UPDATE OPItensPedido SET ";

            if (cpProdutoID != null)
            {
                sqlconteudo += "OPITPProdutoDR = '" + cpProdutoID.ToString() + "',";
            }
            if (cpQunatidade != null)
            {
                sqlconteudo += "OPITPQuantidade = '" + cpQunatidade.ToString() + "',";
            }
            if (cpLote != null)
            {
                sqlconteudo += "OPITPLote = '" + cpLote.ToString() + "',";
            }
            if (cpValorUnit != null)
            {
                sqlconteudo += "OPITPValorUnitario = '" + cpValorUnit.ToString() + "',";
            }
            if (cpFornecedor != null)
            {
                sqlconteudo += "OPITPFornecedorDR = '" + cpFornecedor.ToString() + "',";
            }
            if (cpValorFornecedor != null)
            {
                sqlconteudo += "OPITPValorFornecedor = '" + cpValorFornecedor.ToString() + "',";
            }
            if (cpPedidoDR != null)
            {
                sqlconteudo += "OPITPPedidoDR = '" + cpPedidoDR.ToString() + "',";
            }
            

            sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            sSQL = sSQL + sqlWhere;

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDItensPedido> CarregaDados()
        {
            List<BDItensPedido> lstITPedido = new List<BDItensPedido>();
            string slqSelect = "SELECT * FROM OPItensPedido ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (cpID != "")
            {
                sqlWhere = "WHERE OPItensPedido = '" + cpID + "'";
                ClausulaWhere = 'S';
            }
            else
            {
                if (cpPedidoDR != "")
                {
                    sqlWhere += "OPITPPedidoDR = '" + cpPedidoDR + "' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (cpValorUnit != "")
                {
                    sqlWhere += "OPITPValorUnitario like " + cpValorUnit + "%' " + "AND";
                    ClausulaWhere = 'S';
                }

            }

            if (ClausulaWhere == 'S')
            {
                if (cpID != "")
                {
                    slqSelect += sqlWhere;
                }
                else
                {
                    slqSelect += sqlWhere.Remove(sqlWhere.Length - 3);
                }
            }
            cmd.CommandText = slqSelect;
            var dt = new DataTable();

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    BDItensPedido bDITPedido = new BDItensPedido();
                    bDITPedido.cpID = dr["OPItensPedido"].ToString();
                    bDITPedido.cpProdutoID = dr["OPITPProdutoDR"].ToString();
                    bDITPedido.cpQunatidade = dr["OPITPQuantidade"].ToString();
                    bDITPedido.cpLote = dr["OPITPLote"].ToString();
                    bDITPedido.cpValorUnit = dr["OPITPValorUnitario"].ToString();
                    bDITPedido.cpFornecedor = dr["OPITPFornecedorDR"].ToString();
                    bDITPedido.cpValorFornecedor = dr["OPITPValorFornecedor"].ToString();
                    bDITPedido.cpPedidoDR = dr["OPITPPedidoDR"].ToString();

                    lstITPedido.Add(bDITPedido);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstITPedido;
        }
        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM OPItensPedido WHERE OPItensPedido = '" + cpID + "'";

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }
        public void ExcluirviaPedido()
        {
            string sSQL = "";

            sSQL = "DELETE FROM OPItensPedido WHERE OPITPPedidoDR = '" + cpPedidoDR + "'";

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }
    }
}
