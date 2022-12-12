using System.Data;
using System.Data.SqlClient; 
namespace Banco_de_Dados
    
{
    public class BDCadastroGeral
    {
        public string RazaoSocial { get; set; }
        public string RazaoFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public int Vendedor { get; set; }
        public char Cliente { get; set; }
        public char Distribuidor { get; set; }
        public char Fabricante { get; set; }
        public char Fornecedor { get; set; }
        public string MsgErro { get; set; }
        


        public void  CarregaDados(ListLParametros)
        {
            string sqlComando;
            sqlComando = "SELECT *";
            sqlComando += "FROM DICCadastroGeral";

            if(RazaoSocial != "")
            {
                sqlComando += "WHERE DICRazaoSocial = '" + pRazaoSocial + "'";
            }
            if(CNPJ != "")
            {
                sqlComando += "WHERE CADGCNPJ = '" + pCNPJ + "'";
            }
            List<BDCadastroGeral> Dados = new List<BDCadastroGeral>();
            BDConexao conexao = new BDConexao();
            conexao.LimparParametros();
             DataTable DataTableDados = conexao.ExecutarConsulta(ParameteroConexao,System.Data.CommandType.Text, sqlComando);

            DataTableReader dataTableReader = new DataTableReader(DataTableDados);

            foreach (DataRow dataRow in dataTableReader)
                {
                    BDCadastroGeral CadastroBanco = new BDCadastroGeral();
                    CadastroBanco.RazaoSocial = dataRow[0].ToString();
                    CadastroBanco.RazaoFantasia = dataRow[1].ToString();
                    CadastroBanco.CNPJ = dataRow[2].ToString();
                    CadastroBanco.InscricaoEstadual = dataRow[3].ToString();
                    CadastroBanco.Vendedor = Convert.ToInt32(dataRow[4]);
                    CadastroBanco.Cliente = Convert.ToChar(dataRow[5]);
                    CadastroBanco.Distribuidor = Convert.ToChar(dataRow[6]);
                    CadastroBanco.Fabricante = Convert.ToChar(dataRow[7]);
                    CadastroBanco.Fornecedor = Convert.ToChar(dataRow[8]);

                    Dados.Add(CadastroBanco);
                }

        }

        public void InsereDados(List<string> LParametros)
        {
            List<string> PParametros = LParametros;
            try
            {
                string sSQL = "";

                sSQL = "";

                ConectaBanco ObjConexao = new ConectaBanco();
                ObjConexao.ExecuteCommand(PParametros,"Connection_Developer", sSQL);
                
            }
            catch (Exception ex)
            { 
                MsgErro = ex.Message;
            }
            
        }
    }
}