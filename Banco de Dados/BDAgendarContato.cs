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
        string LCaminhoBanco;
        public string cpID {  get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpDataContato { get; set; }
        public string cpIDUsuarioDR { get; set; }
        public string cpNome { get; set; }
        public string cpFone { get; set; }
        public string cpAtendido { get; set; }
        public string cpMsgErro { get; set; }




        public void InsereDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPAgendarContato (";
            sqlconteudo = " VALUES (";

            if(cpEmpresaDR != null)
            {
                if (cpEmpresaDR.ToString() != "")
                {
                    sqlCampos += "OPACEmpresaDR, ";

                    sqlconteudo += "'" + cpEmpresaDR.ToString() + "',";
                }
            }
            
            if(cpDataContato != null)
            {
                if (cpDataContato.ToString() != "")
                {
                    sqlCampos += "OPACDataContato, ";

                    sqlconteudo += "'" + cpDataContato.ToString() + "',";
                }
            }
            if (cpFone != null)
            {
                if(cpFone.ToString() != "")
                {
                    sqlCampos += "APCAFone, ";
                    sqlconteudo += "'" + cpFone.ToString() + "',";
                }
                
            }

            if (cpNome != null)
            {
                if(cpNome.ToString() != "")
                {
                    sqlCampos += "OPACNome, ";
                    sqlconteudo += "'" + cpNome.ToString() + "',";
                }
            }

            if (cpIDUsuarioDR != null)
            {
                if (cpIDUsuarioDR.ToString() != "")
                {
                    sqlCampos += "OPACUsuarioDR, ";

                    sqlconteudo += "'" + cpIDUsuarioDR.ToString() + "',";
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
        public void AlteraDados(string inCaminhoBanco)
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPAgendarContato = '" + cpID + "'";

            sSQL = "UPDATE OPAgendarContato SET ";

            
            if (cpAtendido != null)
            {
                sqlconteudo += "OPACAtendido = '" + cpAtendido.ToString() + "'";
            }
            sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            sSQL = sSQL + sqlWhere;

            Conexao conexao = new Conexao(LCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

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
        #endregion


        public List<BDAgendarContato> CarregaDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

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
                    BDAgendarContato bDParametros = new BDAgendarContato();
                    bDParametros.cpID = dr["OPAgendarContato"].ToString();
                    bDParametros.cpEmpresaDR = dr["OPACEmpresaDR"].ToString();
                    bDParametros.cpDataContato = dr["OPACDataContato"].ToString();
                    bDParametros.cpIDUsuarioDR = dr["OPACUsuarioDR"].ToString();
                    bDParametros.cpAtendido = dr["OPACAtendido"].ToString();


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

        public void Excluir(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";

            sSQL = "DELETE FROM OPAgendarContato WHERE OPAgendarContato = '" + cpID + "'";

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
