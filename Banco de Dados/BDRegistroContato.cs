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
        public string cpID { get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpDataContato { get; set; }
        public string cpSugestao { get; set; }
        public string cpReclamacao { get; set; }
        public string cpUsuarioDR { get; set; }
        public string cpMsgErro { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados()
        {

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

            if (cpSugestao != null)
            {
                if (cpSugestao.ToString() != "")
                {
                    sqlCampos += "OPRCESugestao, ";

                    sqlconteudo += "'" + cpSugestao.ToString() + "',";
                }
            }

            if (cpReclamacao != null)
            {
                if (cpReclamacao.ToString() != "")
                {
                    sqlCampos += "OPRCEReclamacao, ";

                    sqlconteudo += "'" + cpReclamacao.ToString() + "',";
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

            cmd.CommandText = sSQL;




            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cpID = cmd.ExecuteNonQuery().ToString();
                //Desconectar
                conexao.desconectar();

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
            if (cpSugestao != null)
            {
                sqlconteudo += "OPRCESugestao = '" + cpSugestao.ToString() + "',";
            }
            if (cpUsuarioDR != null)
            {
                sqlconteudo += "OPAUsuarioDR = '" + cpUsuarioDR.ToString() + "',";
            }
            if (cpReclamacao != null)
            {
                sqlconteudo += "OPRCEReclamacao = '" + cpReclamacao.ToString() + "',";
            }

            if (cpUsuarioDR != null)
            {
                sqlconteudo += "OPRCEUsuarioDR = '" + cpUsuarioDR.ToString() + "',";
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

        public List<BDRegistroContato> CarregaDados()
        {
            List<BDRegistroContato> lstRegContato = new List<BDRegistroContato>();
            string slqSelect = "SELECT * FROM OPRegContatosEmpresa ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';

            if (cpEmpresaDR != null)
            {
                if (cpID != "")
                {
                    sqlWhere = "WHERE OPAvisos = '" + cpEmpresaDR + "'";
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
                    bDRegContato.cpSugestao = dr["OPRCESugestao"].ToString();
                    bDRegContato.cpReclamacao = dr["OPRCEReclamacao"].ToString();
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

        
        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM OPRegContatosEmpresa WHERE OPRegContatosEmpresa = '" + cpID + "'";

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
