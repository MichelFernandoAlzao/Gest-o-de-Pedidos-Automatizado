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
        public string cpLivre { get; set; }
        public string Carteira { get; set; }
        public string Distribuidor { get; set; }
        public string Fabricante { get; set; }
        public string Fornecedor { get; set; }
        public string Aviso { get; set; }
        public string Ativo { get; set; }
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
            if (cpLivre != "")
            {
                sqlCampos += "CDCELivre, ";

                sqlconteudo += "'" + cpLivre.ToString() + "',";
            }
            if (Carteira != null)
            {
                if (Carteira != "")
                {
                    sqlCampos += "CDCECarteiraDR, ";

                    sqlconteudo += "'" + Carteira.ToString() + "',";
                }
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
            if(Ativo != null)
            {
                sqlCampos += "CDCEAtivo, ";
                sqlconteudo += "'" + Ativo + "',";
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
                if(RazaoSocial != "")
                {
                    sqlconteudo += "CDCERazaoSocial = '" + RazaoSocial.ToString() + "',";
                }
            }
            if(RazaoFantasia != null)
            {
                if(RazaoFantasia != "")
                {
                    sqlconteudo += "CDCERazaoFantasia = '" + RazaoFantasia.ToString() + "',";
                }
            }
            if(CNPJ != null)
            {
                if(CNPJ != "")
                {
                    sqlconteudo += "CDCECNPJ = '" + CNPJ.ToString() + "',";
                }
            }
            if (InscricaoEstadual != null)
            {
                if(InscricaoEstadual != "")
                {
                    sqlconteudo += "CDCEInscricao = '" + InscricaoEstadual.ToString() + "',";
                }
            }
            if (Vendedor != null)
            {
                if(Vendedor != "")
                {
                    sqlconteudo += "CDCEVendedor = '" + Vendedor.ToString() + "',";
                }
            }
            if (Cliente != null)
            {
                if(Cliente != "")
                {
                    sqlconteudo += "CDCECliente = '" + Cliente.ToString() + "',";
                }
            }
            if (cpLivre != null)
            {
                if (Cliente != "")
                {
                    sqlconteudo += "CDCELivre = '" + cpLivre.ToString() + "',";
                }
            }
            if (Carteira != null)
            {
                if(Carteira != "")
                {
                    sqlconteudo += "CDCECarteiraDR = '" + Carteira.ToString() + "',";
                }
            }
            if (Distribuidor != null)
            {
                if(Distribuidor != "")
                {
                    sqlconteudo += "CDCEDistribuidor = '" + Distribuidor + "',";
                }
            }
            if (Fabricante != null)
            {
                if(Fabricante != "")
                {
                    sqlconteudo += "CDCEFabricante = '" + Fabricante + "',";
                }
            }
            if (Fornecedor != null)
            {
                if(Fornecedor != "")
                {
                    sqlconteudo += "CDCEFornecedor = '" + Fornecedor + "',";
                }
            }
            if (RegiaodeVenda != null)
            {
                if(RegiaodeVenda != "")
                {
                    sqlconteudo += "CDCERegVenda = '" + RegiaodeVenda + "',";
                }
            }

            if (Qualificacao != null)
            {
                if(Qualificacao != "")
                {
                    sqlconteudo += "CDCEQualificacao =  '" + Qualificacao + "',";
                }
            }

            if(DiasAtraso != null)
            {
                if(DiasAtraso != "")
                {
                    sqlconteudo += "CDCEDiasAtraso = '" + DiasAtraso + "',";
                }
            }

            if(RegCobranca != null)
            {
                if(RegCobranca != "")
                {
                    sqlconteudo += "CDCERegCobranca = '" + RegCobranca + "',";
                }
            }

            if (Aviso != null)
            {
                if(Aviso != "")
                {
                    sqlconteudo += "CDCEAviso = '" + Aviso + "',";
                }
            }
            if (Ativo != null)
            {
                if(Ativo != "")
                {
                    sqlconteudo += "CDCEAtivo = '" + Ativo + "',";
                }
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

        public void AlteraVendedor(string inCaminhoBanco, string inVendedorAnterior, string inNovoVendedor)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDCadastroEmpresas = '" + Id + "'";

            sSQL = "UPDATE CDCadastroEmpresas SET ";
            sSQL += "CDCEVendedor = '" + inVendedorAnterior + "' ";
            sSQL += "WHERE CDCEVendedor = '" + inNovoVendedor + "'";



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

        public void PassaParaLivreIndividual(string inCaminhoBanco, string inEstado, string inCarteira,string inVendedor)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            //string sqlconteudo = "";
            //string sqlWhere = " WHERE CDCadastroEmpresas = '" + Id + "'";

            sSQL = "UPDATE CDCadastroEmpresas SET ";
            sSQL += "CDCELivre = '" + inEstado + "' ";
            if(inCarteira != "")
            {
                sSQL += "WHERE CDCECarteiraDR = '" + inCarteira + "'";
            }
            if(inVendedor != "")
            {
                sSQL += "WHERE CDCEVendedor = '" + inVendedor + "'";
            }
            
            //sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            //sSQL = sSQL + sqlWhere;

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

        public List<BDCadastroGeral> CarregaDados(string inCaminhobanco,string id ,string pRazaoSocial, string pRazaoFantasia, string pCNPJ, string pInscricao, string pVendedor, string pCliente, string pDistribuidor, string pFabricante, string pFornecedor, string inLivre, string inCarteira)
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
                if(pRazaoSocial != null)
                {
                    if (pRazaoSocial.Replace(" ","") != "")
                    {
                        sqlWhere += " CDCERazaoSocial like '%" + pRazaoSocial + "%' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if(pRazaoFantasia != null)
                {
                    if (pRazaoFantasia.Replace(" ", "") != "")
                    {
                        sqlWhere += " CDCERazaoFantasia like '%" + pRazaoFantasia + "%' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if(pCNPJ != null)
                {
                    if (pCNPJ != "")
                    {
                        sqlWhere += " CDCECNPJ like '" + pCNPJ + "%' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if(pInscricao != null)
                {
                    if (pInscricao != "")
                    {
                        sqlWhere += " CDCEInscricao like '" + pInscricao + "%' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }

                if (pCliente != null)
                {
                    if (pCliente != "")
                    {
                        sqlWhere += " CDCECliente like '" + pCliente + "' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }

                if (pVendedor != null)
                {
                    if (pVendedor != "" && (cpLivre != null && cpLivre != ""))
                    {
                        sqlWhere += " (CDCEVendedor = " + pVendedor + " " + " OR CDCELivre like '" + inLivre + "') " + "AND";;
                        ClausulaWhere = 'S';
                    }
                    else if(pVendedor != "" && (cpLivre == null || cpLivre == ""))
                    {
                        sqlWhere += " CDCEVendedor = '" + pVendedor + "' " + "AND";
                        ClausulaWhere = 'S';
                    }
                    else
                    {
                        if (inLivre != "" && cpLivre != null)
                        {
                            sqlWhere = sqlWhere.Remove(sqlWhere.Length - 3);
                            sqlWhere += "CDCELivre like '" + inLivre + "' " + "AND";
                            ClausulaWhere = 'S';
                        }
                    }
                }



                if (pDistribuidor != null)
                {
                    if (pDistribuidor != "")
                    {
                        sqlWhere += " CDCEDistribuidor like '" + pDistribuidor + "' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if(pFabricante != null)
                {
                    if (pFabricante != "")
                    {
                        sqlWhere += " CDCEFabricante like '" + pFabricante + "' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if(pFornecedor != null)
                {
                    if (pFornecedor != "")
                    {
                        sqlWhere += " CDCEFornecedor like '" + pFornecedor + "' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if (inCarteira != null)
                {
                    if (inCarteira != "")
                    {
                        sqlWhere += " CDCECarteiraDR like '" + inCarteira + "' " + "AND";
                        ClausulaWhere = 'S';
                    }
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
                    bDCadastro.Ativo = dr["CDCEAtivo"].ToString();
                    bDCadastro.RazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDCadastro.RazaoFantasia = dr["CDCERazaoFantasia"].ToString();
                    bDCadastro.CNPJ = dr["CDCECNPJ"].ToString();
                    bDCadastro.InscricaoEstadual = dr["CDCEInscricao"].ToString();
                    bDCadastro.Vendedor = dr["CDCEVendedor"].ToString();
                    bDCadastro.Cliente = dr["CDCECliente"].ToString();
                    bDCadastro.cpLivre = dr["CDCELivre"].ToString();
                    bDCadastro.Carteira = dr["CDCECarteiraDR"].ToString();
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

        public List<BDCadastroGeral> CarregaDadosPorVendedor(string inCaminhobanco, string pVendedor)
        {
            LCaminhoBanco = inCaminhobanco;
            List<BDCadastroGeral> lstCadastros = new List<BDCadastroGeral>();
            string slqSelect = "SELECT * FROM CDCadastroEmpresas ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';

            if (pVendedor != "")
            {
                sqlWhere += " CDCEVendedor = '" + pVendedor + "'";
                ClausulaWhere = 'S';
            }
            if(RazaoSocial != null)
            {
                if (RazaoSocial != "")
                {
                    if (pVendedor != "")
                    {
                        sqlWhere += " AND CDCERazaoSocial like '%" + RazaoSocial + "%'";
                        ClausulaWhere = 'S';
                    }
                    else
                    {
                        sqlWhere += " CDCERazaoSocial like '%" + RazaoSocial + "%'";
                        ClausulaWhere = 'S';
                    }
                    
                }
            }
            if(CNPJ != null)
            {
                if (CNPJ != "")
                {
                    if(pVendedor != "")
                    {
                        sqlWhere += " AND CDCECNPJ like '%" + CNPJ + "%'";
                    }
                    else
                    {
                        sqlWhere += "CDCECNPJ like '%" + CNPJ + "%'";
                    }
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
                    BDCadastroGeral bDCadastro = new BDCadastroGeral();
                    bDCadastro.Id = dr["CDCadastroEmpresas"].ToString();
                    bDCadastro.Aviso = dr["CDCEAviso"].ToString();
                    bDCadastro.Ativo = dr["CDCEAtivo"].ToString();
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