using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace Banco_de_Dados
{
    public class SEGUsuario
    {
        string LCaminhoBanco;
        public string ID { get; set; }
        public string Usuario { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Administrador { get; set; }
        public string GerenciaCadastros { get; set; }
        public string Operacional { get; set; }
        public string Meta { get; set; }
        public string Seguranca { get; set; }
        public string MsgErro { get; set; }



        public void InsereDados(string inCmainhoBanco)
        {
            LCaminhoBanco = inCmainhoBanco;
            string sqlComando = "INSERT INTO SEGUsuarios";
            sqlComando += "(USUsuario,USNome,USSenha,USAdministrador,USGernciaCadastros,USOperacional,USSeguranca)";
            sqlComando += "VALUES ('" + Usuario + "','" + Nome + "','" + Usuario + "','" + Administrador + "','" + GerenciaCadastros + "','" + Operacional + "','" + Seguranca + "')";

            Conexao conexao = new Conexao(LCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sqlComando;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                MsgErro = "";
            }
            catch (SqlException e)
            {
                MsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }


        public List<SEGUsuario> CarregaDados(string inCaminhoBanco, string inID, string inUsuario, string inNome,string inSenha)
        {
            LCaminhoBanco = inCaminhoBanco;
            List<SEGUsuario> lstUsuarios = new List<SEGUsuario>();

            string slqSelect = "SELECT * FROM SEGUsuarios ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if(inID != null)
            {
                if (inID != "")
                {
                    sqlWhere = "WHERE SEGUsuarios = " + inID;
                    ClausulaWhere = 'S';
                }
            }
            
            if(inUsuario != null)
            {
                if (inUsuario != "" && inSenha != "")
                {
                    sqlWhere += "USUsuario = '" + inUsuario + "' AND USSenha = '" + inSenha + "'";
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
                    SEGUsuario objUsuario = new SEGUsuario();
                    objUsuario.ID = dr["SEGUsuarios"].ToString();
                    objUsuario.Administrador = dr["USAdministrador"].ToString();
                    objUsuario.Contato = dr["USContato"].ToString();
                    objUsuario.Email = dr["USEmail"].ToString();
                    objUsuario.GerenciaCadastros = dr["USGernciaCadastros"].ToString();
                    objUsuario.Operacional = dr["USOperacional"].ToString();
                    objUsuario.Usuario = dr["USUsuario"].ToString();
                    objUsuario.Nome = dr["USNome"].ToString();
                    objUsuario.Senha = dr["USSenha"].ToString();
                    objUsuario.Seguranca = dr["USSeguranca"].ToString();
                    objUsuario.Meta = dr["USMeta"].ToString();


                    lstUsuarios.Add(objUsuario);

                }

                //Desconectar
                conexao.desconectar();
                MsgErro = "";
            }
            catch (SqlException e)
            {
                MsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstUsuarios;
        }

        public void AlteraDados(string inCaminhoBanco)
        {
            MsgErro = "";
            LCaminhoBanco = inCaminhoBanco;
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE SEGUsuarios = '" + ID + "'";

            sSQL = "UPDATE SEGUsuarios SET ";

            if (Usuario != null)
            {
                sqlconteudo += "USUsuario = '" + Usuario.ToString() + "',";
            }
            if (Nome != null)
            {
                sqlconteudo += "USNome = '" + Nome.ToString() + "',";
            }
            if (Email != null)
            {
                sqlconteudo += "USEmail = '" + Email.ToString() + "',";
            }
            if (Contato != null)
            {
                sqlconteudo += "USContato = '" + Contato.ToString() + "',";
            }
            if (Senha != null)
            {
                sqlconteudo += "USSenha = '" + Senha.ToString() + "',";
            }
            if (Administrador != null)
            {
                sqlconteudo += "USAdministrador = '" + Administrador.ToString() + "',";
            }
            if (GerenciaCadastros != null)
            {
                sqlconteudo += "USGernciaCadastros = '" + GerenciaCadastros.ToString() + "',";
            }
            if (Operacional != null)
            {
                sqlconteudo += "USOperacional = '" + Operacional.ToString() + "',";
            }
            if (Seguranca != null)
            {
                sqlconteudo += "USSeguranca = '" + Seguranca.ToString() + "',";
            }
            if (Meta != null)
            {
                sqlconteudo += "USMeta = '" + Meta.ToString() + "',";
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
                MsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }
    }
}
