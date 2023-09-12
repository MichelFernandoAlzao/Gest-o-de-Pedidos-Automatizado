using Banco_de_Dados;
using Camada_Relatorios;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    }
}
