using System.Data;
using Banco_de_Dados;
using DAL;
using System.Data.SqlClient;
namespace Banco_de_Dados

{
    public class BDCadastroGeral
    {
        public string Id { get; set; }
        public string RazaoSocial { get; set; }
        public string RazaoFantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Vendedor { get; set; }
        public char Cliente { get; set; }
        public char Distribuidor { get; set; }
        public char Fabricante { get; set; }
        public char Fornecedor { get; set; }
        public string Aviso { get; set; }
        public string Qualificacao { get; set; }
        public string RegCobranca { get; set; }
        public string RegiaodeVenda { get; set; }
        public string MsgErro { get; set; }
        public string Parametros { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        //public List<BDCadastroGeral> CarregaDados(string[] inParametros, string ID, string inRazaoSocial, string inCNPJ)
        //{
            
            
        //    BDCadastroGeral objCadastroGeral = new BDCadastroGeral();
        //    objCadastroGeral.RazaoSocial = inRazaoSocial;
        //    objCadastroGeral.CNPJ = inCNPJ;
        //    objCadastroGeral.Id = ID;
        //    string sqlComando;
        //    sqlComando = "SELECT *";
        //    sqlComando += "FROM CDCadastroEmpresas";
        //    SqlDataReader Dados;
        //    List<BDCadastroGeral> lstCadastroGeral = new List<BDCadastroGeral>();
        //    if (objCadastroGeral.Id == "")
        //    {
        //        MsgErro = "Nenhum Cadastro informado";
        //    }
        //    if (RazaoSocial != "")
        //    {
        //        sqlComando += "AND CEDERazaoSocial = '" + objCadastroGeral.RazaoSocial + "'";
        //    }
        //    if (CNPJ != "")
        //    {
        //        sqlComando += "AND CDCECNPJ = '" + objCadastroGeral.CNPJ + "'";
        //    }
        //    cmd.CommandText = sqlComando;
            
        //    try
        //    {
        //        cmd.Connection = conexao.conectar();
        //        //Executar o comando
        //        Dados = cmd.ExecuteReader();
        //        //Desconectar
        //        conexao.desconectar();
        //        foreach (DataRow dr in Dados)
        //        {
        //            BDCadastroGeral bDCadastroGeral = new BDCadastroGeral();
        //            bDCadastroGeral.RazaoSocial = dr["CDCERazaoSocial"].ToString();
        //            bDCadastroGeral.RazaoFantasia = dr["CDCERazaoFantasia"].ToString();
        //            bDCadastroGeral.CNPJ = dr["CDCECNPJ"].ToString();
        //            bDCadastroGeral.InscricaoEstadual = dr["CDCEInscricao"].ToString();
        //            bDCadastroGeral.Vendedor = dr["CDCEVendedor"].ToString();
        //            bDCadastroGeral.Cliente = Convert.ToChar(dr["CDCECliente"]);
        //            bDCadastroGeral.Distribuidor = Convert.ToChar(dr["CDCEDistribuidor"]);
        //            bDCadastroGeral.Fabricante = Convert.ToChar(dr["CDCEGFabricante"]);
        //            bDCadastroGeral.Fornecedor = Convert.ToChar(dr["CDCEFornecedor"]);



        //            lstCadastroGeral.Add(bDCadastroGeral);
        //        }
        //    }
        //    catch (SqlException e)
        //    {
        //        MsgErro = e.Message.ToString();
        //    }
           
            
            

        //    return lstCadastroGeral;
        //}

        
        public void InsereDados(string[] LParametros)
        {
            string[] PParametros = LParametros;

            string sqlComando = "INSERT INTO CDCadastroEmpresas";
            sqlComando += "(CDCERazaoSocial,CDCERazaoFantasia,CDCECNPJ,CDCEInscricao,CDCEVendedor,CDCECliente,CDCEDistribuidor,CDCEFabricante,CDCEFornecedor)";
            sqlComando += "VALUES ('" + RazaoSocial.ToString() + "','" + RazaoFantasia.ToString() + "','" + CNPJ.ToString() + "','" + InscricaoEstadual.ToString() + "','" + Vendedor.ToString() + "','" + Cliente.ToString() + "','" + Distribuidor.ToString() + "','" + Fabricante.ToString() + "','" + Fornecedor.ToString() + "')";

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

        public void AlteraDados(string[] Lparametros, BDCadastroGeral OBJAtualiza)
        {
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            objCadastro = OBJAtualiza;
            string sSQL = "";
            string sqlCampos = "";
            string sqlconteudo = "(";

            sSQL = "UPDATE CDCadastroEmpresas SET (";

            if (objCadastro.RazaoSocial.ToString() != "")
            {
                sqlCampos += "CDCERazaoSocial, ";

                sqlconteudo += objCadastro.RazaoSocial.ToString() + ",";
            }
            if(objCadastro.RazaoFantasia.ToString() != "")
            {
                sqlCampos += "CDCERazaoFantasia, ";

                sqlconteudo += objCadastro.RazaoFantasia.ToString() + ",";
            }
            if(objCadastro.CNPJ.ToString() != "")
            {
                sqlCampos += "CDCECNPJ, ";

                sqlconteudo += objCadastro.CNPJ.ToString() + ",";
            }
            if (objCadastro.InscricaoEstadual.ToString() != "")
            {
                sqlCampos += "CDCEInscricao, ";

                sqlconteudo += objCadastro.InscricaoEstadual.ToString() + ",";
            }
            if (objCadastro.Vendedor.ToString() != "")
            {
                sqlCampos += "CDCECNPJ, ";

                sqlconteudo += objCadastro.Vendedor.ToString() + ",";
            }
            if (objCadastro.Cliente != 0)
            {
                sqlCampos += "CDCECliente, ";

                sqlconteudo += objCadastro.Cliente.ToString() + ",";
            }
            if (objCadastro.Distribuidor != 0)
            {
                sqlCampos += "CDCEDistribuidor, ";

                sqlconteudo += Distribuidor + ",";
            }
            if (Fabricante != 0)
            {
                sqlCampos += "CDCEFabricante, ";

                sqlconteudo += Fabricante + ",";
            }
            if (Fornecedor != 0)
            {
                sqlCampos += "CDCEFornecedor, ";

                sqlconteudo += Fornecedor + ",";
            }

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 2) + ")";

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

        public List<BDCadastroGeral> CarregaDados(string id ,string pRazaoSocial, string pRazaoFantasia, string pCNPJ, string pInscricao, string pVendedor, string pCliente, string pDistribuidor, string pFabricante, string pFornecedor)
        {
            List<BDCadastroGeral> lstCadastros = new List<BDCadastroGeral>();
            string slqSelect = "SELECT * FROM CDCadastroEmpresas ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if(id != "")
            {
                sqlWhere = "WHERE CDCadastroEmpresas = " + id;
            }
            else
            {
                if (pRazaoSocial != "")
                {
                    sqlWhere += "CDCERazaoSocial like '%" + pRazaoSocial + "%' " +"AND";
                    ClausulaWhere = 'S';
                }
                if (pRazaoFantasia != "")
                {
                    sqlWhere += "CDCERazaoFantasia like " + pRazaoFantasia;
                    ClausulaWhere = 'S';
                }
                if (pCNPJ != "")
                {
                    sqlWhere += "CDCECNPJ like " + pCNPJ;
                    ClausulaWhere = 'S';
                }
                if (pInscricao != "")
                {
                    sqlWhere += "CDCEInscricao like " + pInscricao;
                    ClausulaWhere = 'S';
                }
                if (pVendedor != "")
                {
                    sqlWhere += "CDCEVendedor = " + pVendedor;
                    ClausulaWhere = 'S';
                }
                if (pCliente != "")
                {
                    sqlWhere += "CDCECliente like " + pCliente;
                    ClausulaWhere = 'S';
                }
                if (pDistribuidor != "")
                {
                    sqlWhere += "CDCEDistribuidor like " + pDistribuidor;
                    ClausulaWhere = 'S';
                }
                if (pFabricante != "")
                {
                    sqlWhere += "CDCEFabricante like " + pFabricante;
                    ClausulaWhere = 'S';
                }
                if (pFornecedor != "")
                {
                    sqlWhere += "CDCEFornecedor like " + pFornecedor;
                    ClausulaWhere = 'S';
                }
                if (ClausulaWhere == 'S')
                {
                    slqSelect += sqlWhere.Remove(sqlWhere.Length - 3);
                }
            }
            

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
                    bDCadastro.RazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDCadastro.RazaoFantasia = dr["CDCERazaoFantasia"].ToString();
                    bDCadastro.CNPJ = dr["CDCECNPJ"].ToString();
                    bDCadastro.InscricaoEstadual = dr["CDCEInscricao"].ToString();
                    bDCadastro.Vendedor = dr["CDCEVendedor"].ToString();
                    bDCadastro.Cliente = Convert.ToChar(dr["CDCECliente"]);
                    bDCadastro.Distribuidor = Convert.ToChar(dr["CDCEDistribuidor"]);
                    bDCadastro.Fabricante = Convert.ToChar(dr["CDCEFabricante"]);
                    bDCadastro.Fornecedor = Convert.ToChar(dr["CDCEFornecedor"]);

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