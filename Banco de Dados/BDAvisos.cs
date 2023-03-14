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
    public class BDAvisos
    {
        public string cpID { get; set; }
        public string cpAviso { get; set; }
        public string cpDataInicio { get; set; }
        public string cpDataTermino { get; set; }
        public string cpUsuarioDR { get; set; }
        public string cpMsgErro { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados()
        {

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPAvisos (";
            sqlconteudo = " VALUES (";

            if (cpAviso.ToString() != "")
            {
                sqlCampos += "OPAAviso, ";

                sqlconteudo += "'" + cpAviso.ToString() + "',";
            }
            if (cpDataInicio.ToString() != "")
            {
                sqlCampos += "OPADataInicio, ";

                sqlconteudo += "'" + cpDataInicio.ToString() + "',";
            }
            if (cpDataTermino.ToString() != "")
            {
                sqlCampos += "OPADataTermino, ";

                sqlconteudo += "'" + cpDataTermino.ToString() + "',";
            }
            if (cpUsuarioDR.ToString() != "")
            {
                sqlCampos += "OPAUsuarioDR, ";

                sqlconteudo += "'" + cpUsuarioDR.ToString() + "',";
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
            string sqlWhere = " WHERE OPAvisos = '" + cpID + "'";

            sSQL = "UPDATE OPAvisos SET ";

            if (cpAviso != null)
            {
                sqlconteudo += "OPAAviso = '" + cpAviso.ToString() + "',";
            }
            if (cpDataInicio != null)
            {
                sqlconteudo += "OPADataInicio = '" + cpDataInicio.ToString() + "',";
            }
            if (cpDataTermino != null)
            {
                sqlconteudo += "OPADataTremino = '" + cpDataTermino.ToString() + "',";
            }
            if (cpUsuarioDR != null)
            {
                sqlconteudo += "OPAUsuario = '" + cpUsuarioDR.ToString() + "',";
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

        public List<BDAvisos> CarregaDados()
        {
            List<BDAvisos> lstAvisos = new List<BDAvisos>();
            string slqSelect = "SELECT * FROM OPAvisos ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';

            if (cpID != null)
            {
                if (cpID != "")
                {
                    sqlWhere = "WHERE OPAvisos = '" + cpID + "'";
                    ClausulaWhere = 'S';
                }
            }
            if (cpUsuarioDR != null)
            {
                if (cpUsuarioDR != "")
                {
                    sqlWhere = "WHERE OPAUsuarioDR = '" + cpUsuarioDR + "'";
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
                    BDAvisos bDParametros = new BDAvisos();
                    bDParametros.cpID = dr["OPAviso"].ToString();
                    bDParametros.cpID = dr["OPAAviso"].ToString();
                    bDParametros.cpDataInicio = dr["OPADataInicio"].ToString();
                    bDParametros.cpDataTermino = dr["OPADataTermino"].ToString();
                    bDParametros.cpUsuarioDR = dr["OPAusuarioDR"].ToString();

                    lstAvisos.Add(bDParametros);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstAvisos;
        }

        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM OPAviso WHERE OPAviso = '" + cpID + "'";

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

