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
        string LcaminhoBanco;
        public string cpID { get; set; }
        public string cpComissao { get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpImpInclu { get; set; }
        public string cpPedidoExterno { get; set; }
        public string cpDataContato { get; set; }
        public string cpDataConfirmacao { get; set; }
        public string cpNatureOperacaoDR { get; set; }
        public string cpObservacoes { get; set; }
        public string cpPrazoEntrega { get; set; }
        public string cpPrazoPagamento { get; set; }
        public string cpStatus { get; set; }
        public string cpValidadeProposta { get; set; }
        public string cpVlrFatMinimo { get; set; }
        public string cpVlrTotalPedido { get; set; }
        public string cpVlrItensFaturando { get; set; }
        public string cpVlrImpostos { get; set; }
        public string cpVendedorDR { get; set; }
        
        public string cpMsgErro { get; set; }



        public void InsereDados(string inCmainhoBanco)
        {
            LcaminhoBanco = inCmainhoBanco;
            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPPPedido (";
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
            if (cpObservacoes != null)
            {
                sqlCampos += "OPPObservacao, ";

                sqlconteudo += "'" + cpObservacoes.ToString() + "',";
            }
            if(cpVlrTotalPedido != null)
            {
                if (cpVlrTotalPedido != "")
                {
                    sqlCampos += "OPPVlrTotalPeddo, ";

                    sqlconteudo += "'" + cpVlrTotalPedido + "',";
                }
            }
            
            if(cpVlrItensFaturando != null)
            {
                if (cpVlrItensFaturando != "")
                {
                    sqlCampos += "OPPVlritensFaturando, ";

                    sqlconteudo += "'" + cpVlrItensFaturando + "',";
                }
            }
            if (cpValidadeProposta != null)
            {
                if (cpValidadeProposta != "")
                {
                    sqlCampos += "OPPValidadeProposta, ";

                    sqlconteudo += "'" + cpValidadeProposta + "',";
                }
            }

            if (cpVlrFatMinimo != null)
            {
                if (cpVlrFatMinimo != "")
                {
                    sqlCampos += "OPPVlrFatMinimo, ";

                    sqlconteudo += "'" + cpVlrFatMinimo.Replace(",",".") + "',";
                }
            }


            if (cpVlrImpostos != null)
            {
                if (cpVlrImpostos != "")
                {
                    sqlCampos += "OPPVlrimpostos, ";

                    sqlconteudo += "'" + cpVlrImpostos + "',";
                }
            }
            
            if(cpComissao != null)
            {
                if (cpComissao != "")
                {
                    sqlCampos += "OPPComissao, ";

                    sqlconteudo += "'" + cpComissao + "',";
                }
            }
            
            if (cpVendedorDR != null)
            {
                sqlCampos += "OPPVendedorDR, ";

                sqlconteudo += "'" + cpVendedorDR + "',";
            }

            if (cpStatus != null)
            {
                sqlCampos += "OPPStatus, ";

                sqlconteudo += "'" + cpStatus + "',";
            }

            if(cpPrazoPagamento != null)
            {
                sqlCampos += "OPPPrazoPagamento, ";

                sqlconteudo += "'" + cpPrazoPagamento + "',";
            }

            if (cpPrazoEntrega != null)
            {
                sqlCampos += "OPPPrazoEntrega, ";

                sqlconteudo += "'" + cpPrazoEntrega + "',";
            }

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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

        public void AlteraDados(string inCmainhoBanco)
        {

            LcaminhoBanco = inCmainhoBanco;
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPPPedido = '" + cpID + "'";

            sSQL = "UPDATE OPPPedido SET ";

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
                sqlconteudo += "OPPObservacao = '" + cpObservacoes.ToString() + "',";
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
            if (cpVlrFatMinimo != null)
            {
                sqlconteudo += "OPPVlrFatMinimo = '" + cpVlrFatMinimo.ToString().Replace(",",".") + "',";
            }
            if (cpValidadeProposta != null)
            {
                sqlconteudo += "OPPValidadeProposta = '" + cpValidadeProposta.ToString() + "',";
            }
            if (cpComissao != null)
            {
                sqlconteudo += "OPPComissao = '" + cpComissao + "',";
            }
            if (cpVendedorDR != null)
            {
                sqlconteudo += "OPPVendedorDR = '" + cpVendedorDR + "',";
            }
            if (cpStatus != null)
            {
                sqlconteudo += "OPPStatus = '" + cpStatus + "',";
            }
            if (cpPrazoPagamento != null)
            {
                sqlconteudo += "OPPPrazoPagamento = '" + cpPrazoPagamento + "',";
            }
            if (cpPrazoEntrega != null)
            {
                sqlconteudo += "OPPPrazoEntrega = '" + cpPrazoEntrega + "',";
            }
            if (cpImpInclu != null)
            {
                sqlconteudo += "OPPImpostosInclusos = '" + cpImpInclu + "',";
            }

            sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            sSQL = sSQL + sqlWhere;

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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

        public List<BDPedido> CarregaDados(string inCaminhoBanco,string id, string inEmpresaDR, string inVendedorDR)
        {
            LcaminhoBanco = inCaminhoBanco;

            List<BDPedido> lstPedido = new List<BDPedido>();
            string slqSelect = "SELECT * FROM OPPPedido ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (id != "")
            {
                sqlWhere = "WHERE OPPPedido = '" + id + "'";

                if (inVendedorDR != "")
                {
                    sqlWhere += " AND OPPVendedorDR = '" + inVendedorDR + "'";
                }

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
                    sqlWhere += "OPPVendedorDR like '" + inVendedorDR + "%' " + "AND";
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

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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
                    bDPedido.cpVlrFatMinimo = dr["OPPVlrFatMinimo"].ToString();
                    bDPedido.cpValidadeProposta = dr["OPPValidadeProposta"].ToString();
                    bDPedido.cpVendedorDR = dr["OPPVendedorDR"].ToString();
                    bDPedido.cpStatus = dr["OPPStatus"].ToString();
                    bDPedido.cpPrazoEntrega = dr["OPPPrazoEntrega"].ToString();
                    bDPedido.cpPrazoPagamento = dr["OPPPrazoPagamento"].ToString();
                    bDPedido.cpImpInclu = dr["OPPImpostosInclusos"].ToString();

                    lstPedido.Add(bDPedido);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstPedido;
        }


        public void Excluir(string inCmainhoaBanco)
        {
            LcaminhoBanco = inCmainhoaBanco;
            string sSQL = "";

            sSQL = "DELETE FROM OPPPedido WHERE OPPPedido = '" + cpID + "'";

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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

        public List<BDPedido> CarregaDadosData(string inCaminhoBanco,string inDataInicio, string inDataTermino, string inVendedorDR)
        {
            LcaminhoBanco = inCaminhoBanco;
            List<BDPedido> lstPedido = new List<BDPedido>();
            string slqSelect = "SELECT * FROM OPPPedido WHERE (OPPDataConfirmacao >= '" + inDataInicio + "' AND OPPDataConfirmacao <= '" + inDataTermino + "') AND OPPVendedorDR = '" + inVendedorDR + "'";

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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
                    bDPedido.cpStatus = dr["OPPConcluido"].ToString();
                    bDPedido.cpStatus = dr["OPPStatus"].ToString();
                    bDPedido.cpPrazoEntrega = dr["OPPPrazoEntrega"].ToString();
                    bDPedido.cpPrazoPagamento = dr["OPPPrazpPagamento"].ToString();
                    bDPedido.cpImpInclu = dr["OPPImpostosInclusos"].ToString();

                    lstPedido.Add(bDPedido);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstPedido;
        }


        public List<BDPedido> CarregaDadosUltVenda(string inCmainhoBanco, string inProduto)
        {
            LcaminhoBanco = inCmainhoBanco;
            List<BDPedido> lstPedido = new List<BDPedido>();
            string slqSelect = "SELECT TOP 1 OPPPedido FROM OPPPedido ";
            string sqlWhere = "WHERE ";
            string Orderby = "Order by OPPDataConfirmacao desc";
            char ClausulaWhere = 'N';
            if(cpEmpresaDR != null)
            {
                if (cpEmpresaDR != "")
                {
                    sqlWhere = "WHERE OPPEmpresaDR = '" + cpEmpresaDR + "' ";
                    ClausulaWhere = 'S';
                }
            }
            
            if(cpVendedorDR != null)
            {
                if (cpVendedorDR != "")
                {
                    sqlWhere += "OPPVendedorDR like '" + cpVendedorDR + "%' ";
                    ClausulaWhere = 'S';
                }
            }

            //if (inProduto != null)
            //{
            //    if (inProduto != "")
            //    {
            //        slqSelect = "SELECT TOP 1 OPPPedido FROM OPPPedido INNER JOIN  ";
            //        sqlWhere = "WHERE ";
            //        Orderby = "Order by OPPDataConfirmacao desc";
            //    }   
            //}       
                    
            slqSelect = slqSelect + sqlWhere + Orderby;

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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

                    lstPedido.Add(bDPedido);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstPedido;
        }

        public List<BDPedido> CarregaDadosUltVendaProduto(string inCaminhoBanco,string inProduto)
        {
            LcaminhoBanco = inCaminhoBanco;
            List<BDPedido> lstPedido = new List<BDPedido>();
            string slqSelect = "select TOP 1 OPPPedido from OPItensPedido INNER JOIN OPPPedido on OPITPPedidoDR = OPPPedido where OPITPProdutoDR = " + inProduto + "order by OPPDataConfirmacao desc ";

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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

                    lstPedido.Add(bDPedido);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstPedido;
        }
    }
}
