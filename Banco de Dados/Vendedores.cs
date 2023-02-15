using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados
{
    public class Vendedores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string MsgErro { get; set; }


        public void CarregaDados(string[] LParametros,int Id)
        {
            string[] PParametros = LParametros;
            try
            {
                string sSQL = "";

                sSQL = "SELECT VENDNome,VENDApelido ";
                sSQL += "FROM DICVendedor";
                sSQL += "WHERE DICVendeor = " + Id;

                
                

            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
            }

        }

        public void InsereDados(string[] LParametros)
        {
            string[] PParametros = LParametros;
            try
            {
                string sSQL = "";

                sSQL = "INSERT INTO DICVendeore ";
                sSQL += "(VENDNome,VENDApelido)";
                sSQL += "VALUES ('" + Nome + "," + Apelido + ")";

                

            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
            }

        }
    }


}

