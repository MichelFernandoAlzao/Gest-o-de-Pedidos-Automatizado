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
    public class BDRegistroContato
    {
        string LCaminhoBanco;
        public string cpID { get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpDataContato { get; set; }
        public string cpRegistro { get; set; }
        public string cpUsuarioDR { get; set; }
        public string cpMsgErro { get; set; }



        public void InsereDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPRegContatosEmpresa (";
            sqlconteudo = " VALUES (";

            if (cpEmpresaDR.ToString() != "")
            {
                sqlCampos += "OPRCEEmpresaDR, ";

                sqlconteudo += "'" + cpEmpresaDR.ToString() + "',";
            }
            if (cpDataContato.ToString() != "")
            {
                sqlCampos += "OPRCEDataContato, ";

                sqlconteudo += "'" + cpDataContato.ToString() + "',";
            }

            if (cpRegistro != null)
            {
                if (cpRegistro.ToString() != "")
                {
                    sqlCampos += "OPRCERegistro, ";

                    sqlconteudo += "'" + cpRegistro.ToString() + "',";
                }
            }


            if (cpUsuarioDR != null)
            {
                if (cpUsuarioDR.ToString() != "")
                {
                    sqlCampos += "OPRCEUsuarioDR, ";

                    sqlconteudo += "'" + cpUsuarioDR.ToString() + "',";
                }
            }




            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

            Conexao conexao = new Conexao(LCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;




            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery().ToString();

                //Obtem a ID do registro criado e retorna a tela
                cmd.CommandText = "SELECT IDENT_CURRENT ('OPRegContatosEmpresa') AS Current_Identity";
                string LID = Convert.ToString(cmd.ExecuteScalar());

                cpID = LID;
                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void AlteraDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPRegContatosEmpresa = '" + cpID + "'";

            sSQL = "UPDATE OPRegContatosEmpresa SET ";

            if (cpEmpresaDR != null)
            {
                sqlconteudo += "OPRCEEmpresaDR = '" + cpEmpresaDR.ToString() + "',";
            }
            if (cpDataContato != null)
            {
                sqlconteudo += "OPRCEDataContato = '" + cpDataContato.ToString() + "',";
            }
            if (cpRegistro != null)
            {
                sqlconteudo += "OPRCERegistro = '" + cpRegistro.ToString() + "',";
            }
            if (cpUsuarioDR != null)
            {
                sqlconteudo += "OPRCEUsuarioDR = '" + cpUsuarioDR.ToString() + "',";
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

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDRegistroContato> CarregaDados(string inCmainhoBanco)
        {
            LCaminhoBanco = inCmainhoBanco;
            List<BDRegistroContato> lstRegContato = new List<BDRegistroContato>();
            string slqSelect = "SELECT * FROM OPRegContatosEmpresa ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';

            if(cpID != null)
            {
                if (cpID != "")
                {
                    sqlWhere = "WHERE OPRegContatosEmpresa = '" + cpID + "'";
                    ClausulaWhere = 'S';
                }
            }
            if (cpEmpresaDR != null)
            {
                if (cpEmpresaDR != "")
                {
                    sqlWhere = "WHERE OPRCEEmpresaDR = '" + cpEmpresaDR + "'";
                    ClausulaWhere = 'S';
                }
            }
            if (cpUsuarioDR != null)
            {
                if (cpUsuarioDR != "")
                {
                    sqlWhere = "WHERE OPRCEUsuarioDR = '" + cpUsuarioDR + "'";
                    ClausulaWhere = 'S';
                }
            }


            if (ClausulaWhere == 'S')
            {
                if (cpID != "" || cpEmpresaDR != "")
                {
                    slqSelect += sqlWhere;
                }
                else
                {
                    slqSelect += sqlWhere.Remove(sqlWhere.Length - 3);
                }
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
                    BDRegistroContato bDRegContato = new BDRegistroContato();
                    bDRegContato.cpID = dr["OPRegContatosEmpresa"].ToString();
                    bDRegContato.cpEmpresaDR = dr["OPRCEEmpresaDR"].ToString();
                    bDRegContato.cpDataContato = dr["OPRCEDataContato"].ToString();
                    bDRegContato.cpRegistro = dr["OPRCERegistro"].ToString();
                    bDRegContato.cpUsuarioDR = dr["OPRCEusuarioDR"].ToString();

                    lstRegContato.Add(bDRegContato);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstRegContato;
        }

        
        public void Excluir(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            string sSQL = "";

            sSQL = "DELETE FROM OPRegContatosEmpresa WHERE OPRegContatosEmpresa = '" + cpID + "'";

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
