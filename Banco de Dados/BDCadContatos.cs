using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Banco_de_Dados;
using DAL;
using System.Data.SqlClient;

namespace Banco_de_Dados
{
    public class BDCadContatos
    {
        public string cpID { get; set; }
        public string cpNome { get; set; }
        public string cpCargo { get; set; }
        public string cpTelefone { get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpEmail { get; set; }
        public DateTime cpAniversario { get; set; }
        public string cpComprador { get; set; }
        public string cpGerencia { get; set; }
        public string cpAnotacoes { get; set; }
        public string MsgErro { get; set; }


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();


        public void InsereDados()
        {
            string sSQL = "INSERT INTO CDContatos (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";
            
            if(cpAniversario!= null)
            {
                sqlCampos += "CDCAniversario, ";

                sqlConteudo += "'" + cpAniversario + "',";
            } 

            if(cpAnotacoes != null)
            {
                sqlCampos += "CDCAnotacoes, ";

                sqlConteudo += "'" + cpAnotacoes + "',";
            }

            if(cpCargo != null)
            {
                sqlCampos += "CDCCargoDR, ";

                sqlConteudo += "'" + cpCargo + "',";
            }

            if(cpComprador != null)
            {
                sqlCampos += "CDCComprador, ";

                sqlConteudo += "'" + cpComprador + "',";
            }

            if(cpEmpresaDR != null)
            {
                sqlCampos += "CDCCadastroEmpresaDR, ";

                sqlConteudo += "'" + cpEmpresaDR + "',";
            }
            if(cpEmail != null)
            {
                sqlCampos += "CDCEmail, ";

                sqlConteudo += "'" + cpEmail + "',";
            }
            if(cpNome != null)
            {
                sqlCampos += "CDCNome, ";

                sqlConteudo += "'" + cpNome + "',";
            }
            if(cpGerencia != null)
            {
                sqlCampos += "CDCGerencia, ";

                sqlConteudo += "'" + cpGerencia + "',";
            }
            if(cpTelefone != null)
            {
                sqlCampos += "CDCTelefone, ";

                sqlConteudo += "'" + cpTelefone + "',";
            }

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlConteudo.Remove(sqlConteudo.Length - 1) + ")";

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
        public List<BDCadContatos> CarregaDados(string inIDEmpresa)
        {
            List<BDCadContatos> lstContatos = new List<BDCadContatos>();
            string slqSelect = "SELECT * FROM CDContatos ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (cpID != null)
            {
                sqlWhere = "WHERE CDContatos = " + cpID;
            }
            if(inIDEmpresa != "")
            {
                sqlWhere = "WHERE CDCCadastroEmpresaDR = '" + inIDEmpresa + "'";
                ClausulaWhere = 'S';
            }
            else
            {
                if(cpEmpresaDR != "")
                {
                    sqlWhere += "CDCCadastroEmpresaDR = '" + cpEmpresaDR + "' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (cpNome != "")
                {
                    sqlWhere += "CDCNome like '%" + cpNome + "%' " + "AND";
                    ClausulaWhere = 'S';
                }
                if (cpComprador != "")
                {
                    sqlWhere += "CDCComprador = '" + cpComprador + "' " + "AND";
                    ClausulaWhere = 'S';
                }
                

            }
            if (ClausulaWhere == 'S')
            {
                slqSelect += sqlWhere;
            }

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
                    BDCadContatos bDContato = new BDCadContatos();
                    bDContato.cpID = dr["CDContatos"].ToString();
                    bDContato.cpAniversario = Convert.ToDateTime(dr["CDCAniversario"]);
                    bDContato.cpAnotacoes = dr["CDCAnotacoes"].ToString();
                    bDContato.cpEmpresaDR = dr["CDCCadastroEmpresaDR"].ToString();
                    bDContato.cpCargo = dr["CDCCargoDR"].ToString();
                    bDContato.cpComprador = dr["CDCComprador"].ToString();
                    bDContato.cpEmail = dr["CDCEmail"].ToString();
                    bDContato.cpGerencia = dr["CDCGerencia"].ToString();
                    bDContato.cpNome = dr["CDCNome"].ToString();
                    bDContato.cpTelefone = dr["CDCTelefone"].ToString();

                    lstContatos.Add(bDContato);

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
            return lstContatos;
        }


        public void AlteraDados(BDCadContatos OBJAtualiza)
        {
            BDCadContatos objContato = new BDCadContatos();
            objContato = OBJAtualiza;
            string sSQL = "";
            string sqlCampos = "";
            string sqlconteudo = "(";
            string sqlWhere = " WHERE CDContatos = '" + objContato.cpID + "'";

            sSQL = "UPDATE CDContatos SET (";

            if (objContato.cpAniversario.ToString() != "")
            {
                sqlCampos += "CDCAniversario, ";

                sqlconteudo += "'" + objContato.cpAniversario.ToString() + "',";
            }
            if (objContato.cpAnotacoes.ToString() != "")
            {
                sqlCampos += " CDCAnotacoes, ";

                sqlconteudo += "'" + objContato.cpAnotacoes.ToString() + "',";
            }
            if (objContato.cpEmpresaDR.ToString() != "")
            {
                sqlCampos += "CDCCadastroEmpresaDR, ";

                sqlconteudo += "'" + objContato.cpEmpresaDR.ToString() + "',";
            }
            if (objContato.cpCargo.ToString() != "")
            {
                sqlCampos += "CDCCargoDR, ";

                sqlconteudo += "'" + objContato.cpCargo.ToString() + "',";
            }
            if (objContato.cpComprador.ToString() != "")
            {
                sqlCampos += "CDCComprador, ";

                sqlconteudo += "'" + objContato.cpComprador.ToString() + "',";
            }
            if (objContato.cpEmail != "")
            {
                sqlCampos += "CDCEmail, ";

                sqlconteudo += "'" + objContato.cpEmail.ToString() + "',";
            }
            if (objContato.cpGerencia.ToString() != "")
            {
                sqlCampos += "CDCGerencia, ";

                sqlconteudo += "'" + objContato.cpGerencia + "',";
            }
            if (objContato.cpNome.ToString() != "")
            {
                sqlCampos += "CDCNome, ";

                sqlconteudo += "'" + objContato.cpNome.ToString() + "',";
            }
            if (objContato.cpTelefone != "")
            {
                sqlCampos += "CDCTelefone, ";

                sqlconteudo += "'" + objContato.cpTelefone.ToString() + "',";
            }



            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";
            sSQL += sqlWhere;

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

    }
}
