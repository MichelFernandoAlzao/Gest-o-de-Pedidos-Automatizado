using System.Data;
using Banco_de_Dados;
using DAL;
using System.Data.SqlClient;
namespace Banco_de_Dados

{
    public class BDCadastroGeral
    {
        string LCaminhoBanco;
        public string Id { get; set; }
        public string RazaoSocial { get; set; }
        public string RazaoFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }
        public string Distribuidor { get; set; }
        public string Fabricante { get; set; }
        public string Fornecedor { get; set; }
        public string Aviso { get; set; }
        public string Qualificacao { get; set; }
        public string DiasAtraso { get; set; }
        public string RegCobranca { get; set; }
        public string RegiaodeVenda { get; set; }
        public string MsgErro { get; set; }
        public string Parametros { get; set; }

        
        public void InsereDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO CDCadastroEmpresas (";
            sqlconteudo = " VALUES (";

            if (RazaoSocial.ToString() != "")
            {
                sqlCampos += "CDCERazaoSocial, ";

                sqlconteudo += "'" + RazaoSocial.ToString() + "',";
            }
            if (RazaoFantasia.ToString() != "")
            {
                sqlCampos += "CDCERazaoFantasia, ";

                sqlconteudo += "'" + RazaoFantasia.ToString() + "',";
            }
            if (CNPJ.ToString() != "")
            {
                sqlCampos += "CDCECNPJ, ";

                sqlconteudo += "'" + CNPJ.ToString() + "',";
            }
            if (InscricaoEstadual.ToString() != "")
            {
                sqlCampos += "CDCEInscricao, ";

                sqlconteudo += "'" + InscricaoEstadual.ToString() + "',";
            }
            if (Vendedor.ToString() != "")
            {
                sqlCampos += "CDCEVendedor, ";

                sqlconteudo += "'" + Vendedor.ToString() + "',";
            }
            if (Cliente != "")
            {
                sqlCampos += "CDCECliente, ";

                sqlconteudo += "'" + Cliente.ToString() + "',";
            }
            if (Distribuidor != "")
            {
                sqlCampos += "CDCEDistribuidor, ";

                sqlconteudo += "'" + Distribuidor + "',";
            }
            if (Fabricante != "")
            {
                sqlCampos += "CDCEFabricante, ";

                sqlconteudo += "'" + Fabricante + "',";
            }
            if (Fornecedor != "")
            {
                sqlCampos += "CDCEFornecedor, ";

                sqlconteudo += "'" + Fornecedor + "',";
            }
            if (RegiaodeVenda != null)
            {
                sqlCampos += "CDCERegVenda, ";

                sqlconteudo += "'" + RegiaodeVenda + "',";
            }

            if (Qualificacao!= null)
            {
                sqlCampos += "CDCEQualificacao, ";

                sqlconteudo += "'" + Qualificacao + "',";
            }

            if (DiasAtraso.ToString() != "")
            {
                sqlCampos += "CDCEDiasAtraso, ";

                sqlconteudo += "'" + DiasAtraso + "',";
            }

            if (RegCobranca != null)
            {
                sqlCampos += "CDCERegCobranca, ";

                sqlconteudo += "'" + RegCobranca + "',";
            }

            if (Aviso != null)
            {
                sqlCampos += "CDCEAviso, ";

                sqlconteudo += "'" + Aviso + "',";
            }

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";


            Conexao conexao = new Conexao(LCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;




            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT IDENT_CURRENT ('CDCadastroEmpresas') AS Current_Identity";
                string LID = Convert.ToString(cmd.ExecuteScalar());

                Id = LID;
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

        public void AlteraDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDCadastroEmpresas = '" + Id + "'";

            sSQL = "UPDATE CDCadastroEmpresas SET ";

            if (RazaoSocial != null)
            {
                sqlconteudo+= "CDCERazaoSocial = '" + RazaoSocial.ToString() + "',";
            }
            if(RazaoFantasia != null)
            {
                sqlconteudo += "CDCERazaoFantasia = '" + RazaoFantasia.ToString() + "',";
            }
            if(CNPJ != null)
            {
                sqlconteudo += "CDCECNPJ = '" + CNPJ.ToString() + "',";
            }
            if (InscricaoEstadual != null)
            {
                sqlconteudo += "CDCEInscricao = '" + InscricaoEstadual.ToString() + "',";
            }
            if (Vendedor != null)
            {
                sqlconteudo += "CDCEVendedor = '" + Vendedor.ToString() + "',";
            }
            if (Cliente != null)
            {
                sqlconteudo += "CDCECliente = '" + Cliente.ToString() + "',";
            }
            if (Distribuidor != null)
            {
                sqlconteudo += "CDCEDistribuidor = '" + Distribuidor + "',";
            }
            if (Fabricante != null)
            {
                sqlconteudo += "CDCEFabricante = '" + Fabricante + "',";
            }
            if (Fornecedor != null)
            {
                sqlconteudo += "CDCEFornecedor = '" + Fornecedor + "',";
            }
            if (RegiaodeVenda != null)
            {
                sqlconteudo += "CDCERegVenda = '" + RegiaodeVenda + "',";
            }

            if (Qualificacao != null)
            {
                sqlconteudo += "CDCEQualificacao =  '" + Qualificacao + "',";
            }

            if(DiasAtraso != null)
            {
                sqlconteudo += "CDCEDiasAtraso = '" + DiasAtraso + "',";
            }

            if(RegCobranca != null)
            {
                sqlconteudo += "CDCERegCobranca = '" + RegCobranca + "',";
            }

            if (Aviso != null)
            {
                sqlconteudo += "CDCEAviso = '" + Aviso + "',";
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
                MsgErro = "";
            }
            catch (SqlException e)
            {
                MsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDCadastroGeral> CarregaDados(string inCaminhobanco,string id ,string pRazaoSocial, string pRazaoFantasia, string pCNPJ, string pInscricao, string pVendedor, string pCliente, string pDistribuidor, string pFabricante, string pFornecedor)
        {
            LCaminhoBanco = inCaminhobanco;
            List<BDCadastroGeral> lstCadastros = new List<BDCadastroGeral>();
            string slqSelect = "SELECT * FROM CDCadastroEmpresas ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if(id != "")
            {
                sqlWhere = "WHERE CDCadastroEmpresas = '" + id + "'";
                ClausulaWhere = 'S';
            }
            else
            {
                if (pRazaoSocial != "")
                {
                    sqlWhere += " CDCERazaoSocial like '%" + pRazaoSocial + "%' " +"AND";
                    ClausulaWhere = 'S';
                }
                if (pRazaoFantasia != "")
                {
                    sqlWhere += " CDCERazaoFantasia like " + pRazaoFantasia + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pCNPJ != "")
                {
                    sqlWhere += " CDCECNPJ like " + pCNPJ + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pInscricao != "")
                {
                    sqlWhere += " CDCEInscricao like " + pInscricao + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pVendedor != "")
                {
                    sqlWhere += " CDCEVendedor = " + pVendedor + " " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pCliente != "")
                {
                    sqlWhere += " CDCECliente like " + pCliente + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pDistribuidor != "")
                {
                    sqlWhere += " CDCEDistribuidor like " + pDistribuidor + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pFabricante != "")
                {
                    sqlWhere += " CDCEFabricante like " + pFabricante + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (pFornecedor != "")
                {
                    sqlWhere += " CDCEFornecedor like " + pFornecedor + "%' " + "AND";
                    ClausulaWhere = 'S';
                }

            }

            if (ClausulaWhere == 'S')
            {
                if(id != "")
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
                SqlDataReader reader =  cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    BDCadastroGeral bDCadastro = new BDCadastroGeral();
                    bDCadastro.Id = dr["CDCadastroEmpresas"].ToString();
                    bDCadastro.Aviso = dr["CDCEAviso"].ToString();
                    bDCadastro.RazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDCadastro.RazaoFantasia = dr["CDCERazaoFantasia"].ToString();
                    bDCadastro.CNPJ = dr["CDCECNPJ"].ToString();
                    bDCadastro.InscricaoEstadual = dr["CDCEInscricao"].ToString();
                    bDCadastro.Vendedor = dr["CDCEVendedor"].ToString();
                    bDCadastro.Cliente = dr["CDCECliente"].ToString();
                    bDCadastro.Distribuidor = dr["CDCEDistribuidor"].ToString();
                    bDCadastro.Fabricante = dr["CDCEFabricante"].ToString();
                    bDCadastro.Fornecedor = dr["CDCEFornecedor"].ToString();

                    lstCadastros.Add(bDCadastro);
                    
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
            return lstCadastros;
        }
    }
}