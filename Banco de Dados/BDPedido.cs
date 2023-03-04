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
    public class BDPedido
    {
        string cpID { get; set; }
        string cpEmpresaDR { get; set; }
        string cpPedidoExterno { get; set; }
        string cpDataContato { get; set; }
        string cpDataConfirmacao { get; set; }
        string cpNatureOperacaoDR { get; set; }
        string cpObservacoes { get; set; }
        string cpVlrTotalPedido { get; set; }
        string cpVlrItensFaturando { get; set; }
        string cpVlrImpostos { get; set; }
        string cpComissao { get; set; }
        string cpVendedorDR { get; set; }
        string cpMsgerro { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados(string[] LParametros)
        {

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPPedido (";
            sqlconteudo = " VALUES (";

            if (cpEmpresaDR.ToString() != "")
            {
                sqlCampos += "OPPEmpresaDR, ";

                sqlconteudo += "'" + cpEmpresaDR.ToString() + "',";
            }
            if (cpPedidoExterno.ToString() != "")
            {
                sqlCampos += "OPPPedidoExterno, ";

                sqlconteudo += "'" + cpPedidoExterno.ToString() + "',";
            }
            if (cpDataContato.ToString() != "")
            {
                sqlCampos += "OPPDataContato, ";

                sqlconteudo += "'" + cpDataContato.ToString() + "',";
            }
            if (cpDataConfirmacao.ToString() != "")
            {
                sqlCampos += "OPPDataConfirmacao, ";

                sqlconteudo += "'" + cpDataConfirmacao.ToString() + "',";
            }
            if (cpNatureOperacaoDR.ToString() != "")
            {
                sqlCampos += "OPPNaturezaDR, ";

                sqlconteudo += "'" + cpNatureOperacaoDR.ToString() + "',";
            }
            if (cpObservacoes != "")
            {
                sqlCampos += "OPPObservacao, ";

                sqlconteudo += "'" + cpObservacoes.ToString() + "',";
            }
            if (cpVlrTotalPedido != "")
            {
                sqlCampos += "OPPVlrTotalPeddo, ";

                sqlconteudo += "'" + cpVlrTotalPedido + "',";
            }
            if (cpVlrItensFaturando != "")
            {
                sqlCampos += "OPPVlritensFaturando, ";

                sqlconteudo += "'" + cpVlrItensFaturando + "',";
            }
            if (cpVlrImpostos != "")
            {
                sqlCampos += "OPPVlrimpostos, ";

                sqlconteudo += "'" + cpVlrImpostos + "',";
            }
            if (cpComissao != null)
            {
                sqlCampos += "OPPComissao, ";

                sqlconteudo += "'" + cpComissao + "',";
            }
            if (cpVendedorDR != null)
            {
                sqlCampos += "OPPVendedorDR, ";

                sqlconteudo += "'" + cpVendedorDR + "',";
            }


            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

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
                cpMsgerro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void AlteraDados()
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPPedido = '" + cpID + "'";

            sSQL = "UPDATE CDCadastroEmpresas SET ";

            if (cpPedidoExterno != null)
            {
                sqlconteudo += "OPPPedidoExterno = '" + cpPedidoExterno.ToString() + "',";
            }
            if (cpDataConfirmacao != null)
            {
                sqlconteudo += "OPPDataConfirmacao = '" + cpDataConfirmacao.ToString() + "',";
            }
            if (cpObservacoes != null)
            {
                sqlconteudo += "OPPObservacao = " + cpObservacoes.ToString() + ",";
            }
            if (cpVlrTotalPedido != null)
            {
                sqlconteudo += "OPPVlrTotalPeddo = '" + cpVlrTotalPedido.ToString() + "',";
            }
            if (cpVlrItensFaturando != null)
            {
                sqlconteudo += "OPPVlritensFaturando = '" + cpVlrItensFaturando.ToString() + "',";
            }
            if (cpVlrImpostos != null)
            {
                sqlconteudo += "OPPVlrimpostos = '" + cpVlrImpostos.ToString() + "',";
            }
            if (cpComissao != null)
            {
                sqlconteudo += "OPPComissao = '" + cpComissao + "',";
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
                cpMsgerro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDPedido> CarregaDados(string id, string inEmpresaDR, string inVendedorDR)
        {
            List<BDPedido> lstPedido = new List<BDPedido>();
            string slqSelect = "SELECT * FROM OPPedido ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (id != "")
            {
                sqlWhere = "WHERE OPPedido = '" + id + "'";
                ClausulaWhere = 'S';
            }
            else
            {
                if (inEmpresaDR != "")
                {
                    sqlWhere += "OPPEmpresaDR = '" + inEmpresaDR + "' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (inVendedorDR != "")
                {
                    sqlWhere += "OPPVendeorDR like " + inVendedorDR + "%' " + "AND";
                    ClausulaWhere = 'S';
                }

            }

            if (ClausulaWhere == 'S')
            {
                if (id != "")
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
                    BDPedido bDPedido = new BDPedido();
                    bDPedido.cpID = dr["OPPPedido"].ToString();
                    bDPedido.cpEmpresaDR = dr["OPPEmpresaDR"].ToString();
                    bDPedido.cpPedidoExterno = dr["OPPPedidoExterno"].ToString();
                    bDPedido.cpDataContato = dr["OPPDataContato"].ToString();
                    bDPedido.cpDataConfirmacao = dr["OPPDataConfirmacao"].ToString();
                    bDPedido.cpNatureOperacaoDR = dr["OPPNaturezaDR"].ToString();
                    bDPedido.cpObservacoes = dr["OPPObservacao"].ToString();
                    bDPedido.cpVlrTotalPedido = dr["OPPVlrTotalPeddo"].ToString();
                    bDPedido.cpVlrItensFaturando = dr["OPPVlritensFaturando"].ToString();
                    bDPedido.cpVlrImpostos = dr["OPPVlrimpostos"].ToString();
                    bDPedido.cpComissao = dr["OPPComissao"].ToString();
                    bDPedido.cpVendedorDR = dr["OPPVendedorDR"].ToString();

                    lstPedido.Add(bDPedido);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgerro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstPedido;
        }
    }
}
