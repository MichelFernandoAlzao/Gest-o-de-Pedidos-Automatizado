using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{

    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Contrutor
        public Conexao(string inCaminhoBanco)
        {
            string LCaminhoBanco = inCaminhoBanco;
            string server = "187.67.153.12,1971";
            string database = "GPA";
            string username = "Michel";
            string password = "Michel11041997@";

            // string de conexão
            string connectionString = $"Server={server};Database={database};User Id={username};Password={password};";

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