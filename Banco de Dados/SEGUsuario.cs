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
        public string ID { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public char Administrador { get; set; }
        public char GerenciaCadastros { get; set; }
        public char Operacional { get; set; }
        public char Seguranca { get; set; }
        public string MsgErro { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados(string inUsuario, string inNome)
        {
            string sqlComando = "INSERT INTO SEGUsuarios";
            sqlComando += "(USUsuario,USNome,USSenha)";
            sqlComando += "VALUES ('" + Usuario.ToString() + "','" + Nome.ToString() + "','" + Senha.ToString() + "')";

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


        public List<SEGUsuario> CarregaDados(string inID, string inUsuario, string inNome,string inSenha)
        {
            List<SEGUsuario> lstUsuarios = new List<SEGUsuario>();

            string slqSelect = "SELECT * FROM SEGUsuarios ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';

            if (inID != "")
            {
                sqlWhere = "WHERE SEGUsuarios = " + inID;
                ClausulaWhere = 'S';
            }
            else
            {
                    sqlWhere += "USUsuario = '" + inUsuario + "' AND USSenha = '" + inSenha + "'";
                    ClausulaWhere = 'S';   
            }
            if (ClausulaWhere == 'S')
            {
                slqSelect += sqlWhere;
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
                    SEGUsuario objUsuario = new SEGUsuario();
                    objUsuario.ID = dr["SEGUsuarios"].ToString();
                    objUsuario.Administrador = Convert.ToChar(dr["USAdministrador"]);
                    objUsuario.GerenciaCadastros = Convert.ToChar(dr["USGernciaCadastros"]);
                    objUsuario.Operacional = Convert.ToChar(dr["USOperacional"]);
                    objUsuario.Usuario = dr["USUsuario"].ToString();
                    objUsuario.Nome = dr["USNome"].ToString();
                    objUsuario.Senha = dr["USSenha"].ToString();
                    objUsuario.Seguranca = Convert.ToChar(dr["USSeguranca"]);

                    
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
    }
}
