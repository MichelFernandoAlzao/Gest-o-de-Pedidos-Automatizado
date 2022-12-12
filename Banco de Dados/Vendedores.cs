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


        public void CarregaDados(List<string> LParametros,int Id)
        {
            List<string> PParametros = LParametros;
            try
            {
                string sSQL = "";

                sSQL = "SELECT VENDNome,VENDApelido ";
                sSQL += "FROM DICVendedor";
                sSQL += "WHERE DICVendeor = " + Id;

                ConectaBanco ObjConexao = new ConectaBanco();
                ObjConexao.ExecuteCommand(PParametros, "Connection_Developer", sSQL);

            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
            }

        }

        public void InsereDados(List<string> LParametros)
        {
            List<string> PParametros = LParametros;
            try
            {
                string sSQL = "";

                sSQL = "INSERT INTO DICVendeore ";
                sSQL += "(VENDNome,VENDApelido)";
                sSQL += "VALUES ('" + Nome + "," + Apelido + ")";

                ConectaBanco ObjConexao = new ConectaBanco();
                ObjConexao.ExecuteCommand(PParametros, "Connection_Developer", sSQL);

            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
            }

        }
    }


}

