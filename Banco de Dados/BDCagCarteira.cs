using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados
{
    public class BDCagCarteira
    {
        string LCaminhoBanco;
        public string cpID { get; set; }
        public string cpSigla { get; set; }
        public string cpDescricao { get; set; }
        public string cpPotencial { get; set; }
        public string cpMsgErro { get; set; }


        public void InsereDados(string inCmainhoBanco)
        {
            LCaminhoBanco = inCmainhoBanco;
            string sSQL = "INSERT INTO CDCarteira (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpSigla != null)
            {
                sqlCampos += "CDCSigla, ";

                sqlConteudo += "'" + cpSigla + "',";
            }
            if (cpDescricao != null)
            {
                sqlCampos += "CDCDescricao, ";

                sqlConteudo += "'" + cpDescricao + "',";
            }

            if (cpPotencial != null)
            {
                sqlCampos += "CDCPotencial, ";

                sqlConteudo += "'" + cpPotencial.Replace(",",".") + "',";
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
        public List<BDCagCarteira> CarregaDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            List<BDCagCarteira> lstCadCarteira = new List<BDCagCarteira>();
            string slqSelect = "SELECT * FROM CDCarteira ";
            string sqlWhere = "WHERE ";
            string ClausulaWhere = "N";
            if (cpID != null)
            {
                sqlWhere = "WHERE CDCarteira = " + cpID;
                ClausulaWhere = "S";
            }
            //if (cpSigla != "")
            //{
            //    sqlWhere += "CDCSigla like '%" + cpSigla + "%' " + "AND";
            //    ClausulaWhere = 'S';
            //}
            //if (cpDescricao != "")
            //{
            //    sqlWhere += "CDCDescricao like '%" + cpDescricao + "%' " + "AND";
            //    ClausulaWhere = 'S';
            //}
            //if (cpPotencial != "")
            //{
            //    sqlWhere += "CDCPotencial = '" + cpPotencial + "' " + "AND";
            //    ClausulaWhere = 'S';
            //}
            if (ClausulaWhere == "S")
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
                    BDCagCarteira bDCadCarteira = new BDCagCarteira();
                    bDCadCarteira.cpID = dr["CDCarteira"].ToString();
                    bDCadCarteira.cpSigla = dr["CDCSigla"].ToString();
                    bDCadCarteira.cpDescricao = dr["CDCDescricao"].ToString();
                    bDCadCarteira.cpPotencial = dr["CDCPotencial"].ToString();
                    

                    lstCadCarteira.Add(bDCadCarteira);

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
            return lstCadCarteira;
        }


        public void AlteraDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDCarteira = '" + cpID + "'";

            sSQL = "UPDATE CDCarteira SET ";


            if (cpSigla != null)
            {
                sqlconteudo += "CDCSigla = '" + cpSigla.ToString() + "',";
            }
            if (cpDescricao != null)
            {
                sqlconteudo += "CDCDescricao = '" + cpDescricao.ToString() + "',";
            }
            if (cpPotencial != null)
            {
                sqlconteudo += "CDCPotencial = '" + cpPotencial.ToString() + "',";
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

            sSQL = "DELETE FROM CDCarteira WHERE CDCarteira = '" + cpID + "'";

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
