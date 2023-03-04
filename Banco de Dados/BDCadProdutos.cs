using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Banco_de_Dados;
using DAL;
using System.Data.SqlClient;


namespace Banco_de_Dados
{
    public class BDCadProdutos
    {
        public string cpID { get; set; }
        public string cpDescricao { get; set; }
        public string cpDataCadastro { get; set; }
        public string cpCodigoFabricante { get; set; }
        public string cpDescFornecedor { get; set; }
        public string cpFabricanteDR { get; set; }
        public string cpMelhorFornecedorDR { get; set; }
        public string cpAtivo { get; set; }
        public string cpOperacional { get; set; }
        public string cpForaDeLinha { get; set; }
        public string cpDescritivo { get; set; }
        public string cpMsgErro { get; set; }


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados()
        {
            string sSQL = "INSERT INTO CDPRodutos (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpDescricao != null)
            {
                sqlCampos += "CDPDescricao, ";

                sqlConteudo += "'" + cpDescricao + "',";
            }

            if (cpDataCadastro != null)
            {
                sqlCampos += "CDPDataCadastro, ";

                sqlConteudo += "'" + cpDataCadastro + "',";
            }

            if (cpCodigoFabricante != null)
            {
                sqlCampos += "CDPCodigoFabricante, ";

                sqlConteudo += "'" + cpCodigoFabricante + "',";
            }

            if (cpDescFornecedor != null)
            {
                sqlCampos += "CDPDescFornecedor, ";

                sqlConteudo += "'" + cpDescFornecedor + "',";
            }

            if (cpFabricanteDR != null)
            {
                sqlCampos += "CDPFabricanteDR, ";

                sqlConteudo += "'" + cpFabricanteDR + "',";
            }
            if (cpMelhorFornecedorDR != null)
            {
                sqlCampos += "CDPMelhorFornecedorDR, ";

                sqlConteudo += "'" + cpMelhorFornecedorDR + "',";
            }
            if (cpAtivo != null)
            {
                sqlCampos += "CDPAtivo, ";

                sqlConteudo += "'" + cpAtivo + "',";
            }
            if (cpOperacional != null)
            {
                sqlCampos += "CDPOperacional, ";

                sqlConteudo += "'" + cpOperacional + "',";
            }
            if (cpForaDeLinha != null)
            {
                sqlCampos += "CDPForaDeLinha, ";

                sqlConteudo += "'" + cpForaDeLinha + "',";
            }
            if (cpDescritivo != null)
            {
                sqlCampos += "CDPDescritivo, ";

                sqlConteudo += "'" + cpDescritivo + "',";
            }


            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlConteudo.Remove(sqlConteudo.Length - 1) + ")";

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
        public List<BDCadProdutos> CarregaDados()
        {
            List<BDCadProdutos> lstCadprodutos = new List<BDCadProdutos>();
            string slqSelect = "SELECT * FROM CDProdutos ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (cpID != "")
            {
                sqlWhere = "WHERE CDProdutos = " + cpID;
            }
            else
            {
                if (cpCodigoFabricante != "")
                {
                    sqlWhere += "CDPCodigoFabricante = '" + cpCodigoFabricante + "' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (cpDescricao != "")
                {
                    sqlWhere += "CDPDescricao like '%" + cpDescricao + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
             
            }
            if (ClausulaWhere == 'S')
            {
                slqSelect += sqlWhere;
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
                    BDCadProdutos bDCadProdutos = new BDCadProdutos();
                    bDCadProdutos.cpID = dr["CDProdutos"].ToString();
                    bDCadProdutos.cpDescricao = dr["CDPDescricao"].ToString();
                    bDCadProdutos.cpDataCadastro = dr["CDPDataCadastro"].ToString();
                    bDCadProdutos.cpCodigoFabricante = dr["CDPCodigoFabricante"].ToString();
                    bDCadProdutos.cpDescFornecedor = dr["CDPDescFornecedor"].ToString();
                    bDCadProdutos.cpFabricanteDR = dr["CDPFabricanteDR"].ToString();
                    bDCadProdutos.cpMelhorFornecedorDR = dr["CDPMelhorFornecedorDR"].ToString();
                    bDCadProdutos.cpAtivo = dr["CDPAtivo"].ToString();
                    bDCadProdutos.cpOperacional = dr["CDPOperacional"].ToString();
                    bDCadProdutos.cpForaDeLinha = dr["CDPForaDeLinha"].ToString();
                    bDCadProdutos.cpDescritivo = dr["CDPDescritivo"].ToString();

                    lstCadprodutos.Add(bDCadProdutos);

                }

                //Desconectar
                conexao.desconectar();
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstCadprodutos;
        }


        public void AlteraDados()
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDProdutos = '" + cpID + "'";

            sSQL = "UPDATE CDProdutos SET ";


            if (cpDescricao != null)
            {
                sqlconteudo += "CDPDescricao = '" + cpDescricao.ToString() + "',";
            }
            if (cpCodigoFabricante != null)
            {
                sqlconteudo += "CDPCodigoFabricante = '" + cpCodigoFabricante.ToString() + "',";
            }
            if (cpDescFornecedor != null)
            {
                sqlconteudo += "CDPDescFornecedor = '" + cpDescFornecedor.ToString() + "',";
            }
            if (cpFabricanteDR != null)
            {
                sqlconteudo += "CDPFabricanteDR = '" + cpFabricanteDR.ToString() + "',";
            }
            if (cpMelhorFornecedorDR != null)
            {
                sqlconteudo += "CDPMelhorFornecedorDR = '" + cpMelhorFornecedorDR.ToString() + "',";
            }
            if (cpAtivo != null)
            {
                sqlconteudo += "CDPAtivo = '" + cpAtivo.ToString() + "',";
            }
            if (cpOperacional != null)
            {
                sqlconteudo += "CDPOperacional = '" + cpOperacional.ToString() + "',";
            }
            if (cpForaDeLinha != null)
            {
                sqlconteudo += "CDPForaDeLinha = '" + cpForaDeLinha.ToString() + "',";
            }
            if (cpDescritivo != null)
            {
                sqlconteudo += "CDPDescritivo = '" + cpDescritivo.ToString() + "',";
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
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM CDProdutos WHERE CDProdutos = '" + cpID + "'";

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
