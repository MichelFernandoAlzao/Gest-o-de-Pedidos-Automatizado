using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{

    public class Conexao
    {
        public string[] Parametros = new string[0];
        int i = 0;
        SqlConnection con = new SqlConnection();
        //Contrutor
        public Conexao(string inCaminhoBanco)
        {
            string LCaminhoBanco = inCaminhoBanco;
            string connectionString = LCaminhoBanco;
            con.ConnectionString = connectionString;
        }

        //Metodo Conectar

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}