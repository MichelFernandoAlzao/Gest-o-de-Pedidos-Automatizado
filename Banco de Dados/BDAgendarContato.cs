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
    public class BDAgendarContato
    {
        public string cpID {  get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpDataContato { get; set; }
        public string cpIDUsuarioDR { get; set; }
        public string cpMsgErro { get; set; }


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados()
        {

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPAgendarContato (";
            sqlconteudo = " VALUES (";

            if (cpEmpresaDR.ToString() != "")
            {
                sqlCampos += "OPACEmpresaDR, ";

                sqlconteudo += "'" + cpEmpresaDR.ToString() + "',";
            }
            if (cpDataContato.ToString() != "")
            {
                sqlCampos += "OPACDataContato, ";

                sqlconteudo += "'" + cpDataContato.ToString() + "',";
            }
            if (cpIDUsuarioDR.ToString() != "")
            {
                sqlCampos += "OPACUsuarioDR, ";

                sqlconteudo += "'" + cpIDUsuarioDR.ToString() + "',";
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

        #region Não é necessario AlteraDados, pois só deve ser criado ou excluido
        //public void AlteraDados()
        //{
        //    string sSQL = "";
        //    string sqlconteudo = "";
        //    string sqlWhere = " WHERE OPAvisos = '" + cpID + "'";

        //    sSQL = "UPDATE OPAvisos SET ";

        //    if (cpAviso != null)
        //    {
        //        sqlconteudo += "OPAAviso = '" + cpAviso.ToString() + "',";
        //    }
        //    if (cpDataInicio != null)
        //    {
        //        sqlconteudo += "OPADataInicio = '" + cpDataInicio.ToString() + "',";
        //    }
        //    if (cpDataTermino != null)
        //    {
        //        sqlconteudo += "OPADataTremino = '" + cpDataTermino.ToString() + "',";
        //    }
        //    if (cpUsuarioDR != null)
        //    {
        //        sqlconteudo += "OPAUsuarioDR = '" + cpUsuarioDR.ToString() + "',";
        //    }
        //    if (cpTodos != null)
        //    {
        //        sqlconteudo += "OPATodos = '" + cpTodos.ToString() + "',";
        //    }
        //    sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
        //    sSQL = sSQL + sqlWhere;

        //    cmd.CommandText = sSQL;

        //    try
        //    {
        //        cmd.Connection = conexao.conectar();
        //        //Executar o comando
        //        cmd.ExecuteNonQuery();
        //        //Desconectar
        //        conexao.desconectar();

        //    }
        //    catch (SqlException e)
        //    {
        //        cpMsgErro = e.Message.ToString();
        //    }
        //    cmd.Dispose();
        //}
        #endregion


        public List<BDAgendarContato> CarregaDados()
        {
            List<BDAgendarContato> lstAgendarContato = new List<BDAgendarContato>();
            string slqSelect = "SELECT * FROM OPAgendarContato ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';

            if (cpIDUsuarioDR != null)
            {
                if (cpIDUsuarioDR != "")
                {
                    sqlWhere = "WHERE OPACUsuarioDR = '" + cpIDUsuarioDR + "'";
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
                    BDAgendarContato bDParametros = new BDAgendarContato();
                    bDParametros.cpID = dr["OPAgendarContato"].ToString();
                    bDParametros.cpEmpresaDR = dr["OPACEmpresaDR"].ToString();
                    bDParametros.cpDataContato = dr["OPACDataContato"].ToString();
                    bDParametros.cpIDUsuarioDR = dr["OPACUsuarioDR"].ToString();


                    lstAgendarContato.Add(bDParametros);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstAgendarContato;
        }

        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM OPAgendarContato WHERE OPAgendarContato = '" + cpID + "'";

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
