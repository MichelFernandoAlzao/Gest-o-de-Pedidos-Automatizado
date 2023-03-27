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
    public class BDRegOcorrencias
    {
        string LCaminhoBanco;
        public string cpID { get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpFornecedorDR { get; set; }
        public string cpDataOcorrencia { get; set; }
        public string cpDataResolucao { get; set; }
        public string cpDescricao { get; set; }
        public string cpPedidoDR { get; set; }
        public string cpMsgErro { get; set; }




        public void InsereDados(string inCmainhoBanco)
        {
            LCaminhoBanco = inCmainhoBanco;
            string sSQL = "INSERT INTO OPRegOcorrencias (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpEmpresaDR != null)
            {
                sqlCampos += "OPROEmpresaDR, ";

                sqlConteudo += "'" + cpEmpresaDR + "',";
            }
            if (cpFornecedorDR != null)
            {
                sqlCampos += "OPROFornecedorDR, ";

                sqlConteudo += "'" + cpFornecedorDR + "',";
            }

            if (cpDataOcorrencia != null)
            {
                sqlCampos += "OPRODataOcorrencia, ";

                sqlConteudo += "'" + cpDataOcorrencia + "',";
            }

            if (cpDataResolucao != null)
            {
                sqlCampos += "OPRODataResolucao, ";

                sqlConteudo += "'" + cpDataResolucao + "',";
            }

            if (cpDescricao != null)
            {
                sqlCampos += "OPRODescricao, ";

                sqlConteudo += "'" + cpDescricao + "',";
            }

            if (cpPedidoDR != null)
            {
                sqlCampos += "OPROPedidoDR, ";

                sqlConteudo += "'" + cpPedidoDR + "',";
            }

            

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlConteudo.Remove(sqlConteudo.Length - 1) + ")";

            Conexao conexao = new Conexao(LCaminhoBanco);
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
        public List<BDRegOcorrencias> CarregaDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            List<BDRegOcorrencias> lstRegOcorrencias = new List<BDRegOcorrencias>();
            string slqSelect = "SELECT * FROM OPRegOcorrencias ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (cpID != null)
            {
                sqlWhere = "WHERE OPRegOcorrencias = " + cpID;
            }
            if (cpEmpresaDR != "")
            {
                sqlWhere = "WHERE OPROEmpresaDR = '" + cpEmpresaDR + "'";
                ClausulaWhere = 'S';
            }
            else
            {
                if (cpDataOcorrencia != "")
                {
                    sqlWhere += "OPRODataOcorrencia like '%" + cpDataOcorrencia + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (cpDataResolucao != "")
                {
                    sqlWhere += "OPRODataResolucao like '%" + cpDataResolucao + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (cpPedidoDR != "")
                {
                    sqlWhere += "OPROPedidoDR = '" + cpPedidoDR + "' " + "AND";
                    ClausulaWhere = 'S';
                }


            }
            if (ClausulaWhere == 'S')
            {
                slqSelect += sqlWhere;
            }

            Conexao conexao = new Conexao(LCaminhoBanco);
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
                    BDRegOcorrencias bDRegOcorrencias = new BDRegOcorrencias();
                    bDRegOcorrencias.cpID = dr["OPRegOcorrencias"].ToString();
                    bDRegOcorrencias.cpEmpresaDR = dr["OPROEmpresaDR"].ToString();
                    bDRegOcorrencias.cpFornecedorDR = dr["OPROFornecedorDR"].ToString();
                    bDRegOcorrencias.cpDataOcorrencia = dr["OPRODataOcorrencia"].ToString();
                    bDRegOcorrencias.cpDataResolucao = dr["DataResolucao"].ToString();
                    bDRegOcorrencias.cpDescricao = dr["OPRODescricao"].ToString();
                    bDRegOcorrencias.cpPedidoDR = dr["OPROPedidoDR"].ToString();
                    

                    lstRegOcorrencias.Add(bDRegOcorrencias);

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
            return lstRegOcorrencias;
        }


        public void AlteraDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPRegOcorrencias = '" + cpID + "'";

            sSQL = "UPDATE OPRegOcorrencias SET ";


            if (cpEmpresaDR != null)
            {
                sqlconteudo += "OPROEmpresaDR = '" + cpEmpresaDR.ToString() + "',";
            }
            if (cpFornecedorDR != null)
            {
                sqlconteudo += "OPROFornecedorDR = '" + cpFornecedorDR.ToString() + "',";
            }
            if (cpDataOcorrencia != null)
            {
                sqlconteudo += "OPRODataOcorrencia = '" + cpDataOcorrencia.ToString() + "',";
            }
            if (cpDataResolucao != null)
            {
                sqlconteudo += "OPRODataResolucao = '" + cpDataResolucao.ToString() + "',";
            }
            if (cpDescricao != null)
            {
                sqlconteudo += "OPRODescricao = '" + cpDescricao.ToString() + "',";
            }
            if (cpPedidoDR != null)
            {
                sqlconteudo += "OPROPedidoDR = '" + cpPedidoDR.ToString() + "',";
            }
            
            sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            sSQL = sSQL + sqlWhere;

            Conexao conexao = new Conexao(LCaminhoBanco);
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

        public void Excluir(string inCmainhoBanco)
        {
            LCaminhoBanco = inCmainhoBanco;
            string sSQL = "";

            sSQL = "DELETE FROM OPRegOcorrencias WHERE OPRegOcorrencias = '" + cpID + "'";

            Conexao conexao = new Conexao(LCaminhoBanco);
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
    }
}
