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
            con.ConnectionString = inCaminhoBanco;
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