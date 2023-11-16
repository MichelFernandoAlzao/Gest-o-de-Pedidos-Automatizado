using Banco_de_Dados;
using Camada_Relatorios;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarregaRelatorios
{
    public class RelCadastroDeEmpresas
    {
        public List<CadastrosDeEmpresas> CarregaRelatorioRDLC(string inCaminhoBanco, string[] inParametrosRel)
        {
            CadastrosDeEmpresas objCadastrosDeEmpresas = new CadastrosDeEmpresas();
            string inVendedor = inParametrosRel[1];
            string inCarteira = inParametrosRel[2];
            string inAtivo = inParametrosRel[3];

            DataTable DTCadastrosEmpresas = new DataTable();
            string sSQL = "";

            sSQL = "SELECT CDCadastroEmpresas, CDCERazaoSocial, CDCERazaoFantasia , CDCECNPJ, CDCEInscricao, CDENDRua, CDENDNumero, CDCENDCidade, CDCTelefone, USUsuario ";
            sSQL += "FROM CDCadastroEmpresas ";
            sSQL += "LEFT OUTER JOIN CDCarteira ON CDCECarteiraDR = CDCarteira ";
            sSQL += "INNER JOIN SEGUsuarios ON CDCEVendedor = SEGUsuarios ";
            sSQL += "LEFT OUTER JOIN CDContatos ON CDCCadastroEmpresaDR = CDCadastroEmpresas ";
            sSQL += "LEFT OUTER JOIN CDCadEnderecos ON CDCENDEmpresaDR = CDCadastroEmpresas ";

            if(inVendedor != "")
            {
                sSQL += "WHERE CDCEVendedor = '" + inVendedor + "'";
            }
            if(inCarteira != "")
            {
                sSQL += "WHERE CDCECarteiraDR = '" + inCarteira + "'";
            }
            if((inVendedor != "" || inCarteira != "") && inAtivo != "")
            {
                sSQL += " AND CDCEAtivo = 'S'";
            }
            if (inVendedor == "" && inCarteira == "" && inAtivo != "")
            {
                sSQL += " WHERE CDCEAtivo = 'S'";
            }

            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<CadastrosDeEmpresas> lstCadastroDeEmperas = new List<CadastrosDeEmpresas>();
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTCadastrosEmpresas.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTCadastrosEmpresas.Rows)
                {
                    CadastrosDeEmpresas bDCadastroEmpresas = new CadastrosDeEmpresas();
                    bDCadastroEmpresas.cpID = dr["CDCadastroEmpresas"].ToString();
                    bDCadastroEmpresas.cpRazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDCadastroEmpresas.cpRazaoFantasia = dr["CDCERazaoFantasia"].ToString();
                    bDCadastroEmpresas.cpCNPJ = dr["CDCECNPJ"].ToString();
                    bDCadastroEmpresas.cpInscricao = dr["CDCEInscricao"].ToString();
                    bDCadastroEmpresas.cpRua = dr["CDENDRua"].ToString();
                    bDCadastroEmpresas.cpNumero = dr["CDENDNumero"].ToString();
                    bDCadastroEmpresas.cpCidade = dr["CDCENDCidade"].ToString();
                    bDCadastroEmpresas.cpFone = dr["CDCTelefone"].ToString();
                    bDCadastroEmpresas.cpVendedor = dr["USUsuario"].ToString();
                    

                    lstCadastroDeEmperas.Add(bDCadastroEmpresas);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                
            }
            cmd.Dispose();

            
            return lstCadastroDeEmperas;
        }

        public List<CadastrosDeEmpresas> CarregaRelatorioSemContatoRDLC(string inCaminhoBanco, string[] inParametrosRel)
        {
            CadastrosDeEmpresas objCadastrosDeEmpresas = new CadastrosDeEmpresas();
            string PVendedor = inParametrosRel[1];
            string PPrazo = inParametrosRel[2];
            string PAtivo = inParametrosRel[3];
            string PSContato = inParametrosRel[4];

            DataTable DTCadastrosEmpresas = new DataTable();
            string sSQL = "";
            string sWHERE = "";

            sSQL = "SELECT CDCadastroEmpresas, CDCERazaoSocial, CDCERazaoFantasia , CDCECNPJ, CDCEInscricao, CDENDRua, CDENDNumero, CDCENDCidade, CDCTelefone, USUsuario ";
            sSQL += "FROM CDCadastroEmpresas ";
            sSQL += "LEFT OUTER JOIN CDCarteira ON CDCECarteiraDR = CDCarteira ";
            sSQL += "LEFT OUTER JOIN CDCadEnderecos ON CDCENDEmpresaDR = CDCadastroEmpresas ";
            sSQL += "LEFT OUTER JOIN CDContatos ON CDCCadastroEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN SEGUsuarios ON CDCEVendedor = SEGUsuarios ";
            if (PSContato == "N")
            {
                sSQL += "LEFT OUTER JOIN OPRegContatosEmpresa ON OPRCEEmpresaDR = CDCadastroEmpresas ";
                if (PVendedor != "")
                {
                    sWHERE += "WHERE CDCEVendedor = '" + PVendedor + "'";
                }
                if (PPrazo != "")
                {
                    if (sWHERE != "")
                    {
                        sWHERE += " AND OPRCEDataContato < DATEADD(DAY,-"+ PPrazo+",SYSDATETIME()) ";
                    }
                    else
                    {
                        sWHERE += " WHERE OPRCEDataContato < DATEADD(DAY,-"+ PPrazo+",SYSDATETIME()) ";
                    }

                }
                if (PAtivo != "")
                {
                    if (sWHERE != "")
                    {
                        sWHERE += " AND CDCEAtivo = 'S'";
                    }
                    else
                    {
                        sWHERE += " WHERE CDCEAtivo = 'S'";
                    }

                }
            }
            else if(PSContato == "S")
            {
                sWHERE += "WHERE CDCadastroEmpresas not in (select OPRCEEmpresaDR from OPRegContatosEmpresa) ";
                if (PVendedor != "")
                {
                    sWHERE += "WHERE CDCEVendedor = '" + PVendedor + "'";
                }
            }
            

            if(sWHERE != "")
            {
                sSQL += sWHERE;
            }

            if(PSContato == "N")
            {
                sSQL += "group by CDCadastroEmpresas,CDCERazaoSocial,CDCERazaoFantasia,CDCECNPJ,CDCEInscricao,CDENDRua,CDENDNumero,CDCENDCidade,CDCTelefone,USUsuario,OPRCEDataContato ";
                sSQL += "ORDER BY OPRCEDataContato Desc ";
            }
            
            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<CadastrosDeEmpresas> lstCadastroDeEmperas = new List<CadastrosDeEmpresas>();
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTCadastrosEmpresas.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTCadastrosEmpresas.Rows)
                {
                    CadastrosDeEmpresas bDCadastroEmpresas = new CadastrosDeEmpresas();
                    bDCadastroEmpresas.cpID = dr["CDCadastroEmpresas"].ToString();
                    bDCadastroEmpresas.cpRazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDCadastroEmpresas.cpRazaoFantasia = dr["CDCERazaoFantasia"].ToString();
                    bDCadastroEmpresas.cpCNPJ = dr["CDCECNPJ"].ToString();
                    bDCadastroEmpresas.cpInscricao = dr["CDCEInscricao"].ToString();
                    bDCadastroEmpresas.cpRua = dr["CDENDRua"].ToString();
                    bDCadastroEmpresas.cpNumero = dr["CDENDNumero"].ToString();
                    bDCadastroEmpresas.cpCidade = dr["CDCENDCidade"].ToString();
                    bDCadastroEmpresas.cpFone = dr["CDCTelefone"].ToString();
                    bDCadastroEmpresas.cpVendedor = dr["USUsuario"].ToString();


                    lstCadastroDeEmperas.Add(bDCadastroEmpresas);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {

            }
            cmd.Dispose();


            return lstCadastroDeEmperas;
        }
    }
}
