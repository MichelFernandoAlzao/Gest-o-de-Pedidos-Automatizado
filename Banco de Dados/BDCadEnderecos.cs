using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data.SqlClient;

namespace Banco_de_Dados
{
    public class BDCadEnderecos
    {
        string LcaminhoBanco;

        public string cpID { get; set; }
        public string cpIdentificacao { get; set; }
        public string cpRua { get; set; }
        public string cpNumero { get; set; }
        public string cpBairro { get; set; }
        public string cpCidade { get; set; }
        public string cpEstado { get; set; }
        public string cpCEP { get; set; }
        public string cpReferencia { get; set; }
        public string cpEndFisico { get; set; }
        public string cpEndCobranca { get; set; }
        public string cpCadastroDR { get; set; }
        public string MsgErro { get; set; }


        public void InsereDados(string inCaminhoBanco)
        {

            LcaminhoBanco = inCaminhoBanco;

            string sSQL = "INSERT INTO CDCadEnderecos (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpIdentificacao != null)
            {
                sqlCampos += "CDENDIdentificacao, ";

                sqlConteudo += "'" + cpIdentificacao + "',";
            }

            if (cpRua != null)
            {
                sqlCampos += "CDENDRua, ";

                sqlConteudo += "'" + cpRua + "',";
            }

            if (cpNumero != null)
            {
                sqlCampos += "CDENDNumero, ";

                sqlConteudo += "'" + cpNumero + "',";
            }
            if (cpCEP != null)
            {
                sqlCampos += "CDCENDCEP, ";

                sqlConteudo += "'" + cpCEP + "',";
            }

            if (cpBairro != null)
            {
                sqlCampos += "CDCENDBairro, ";

                sqlConteudo += "'" + cpBairro + "',";
            }

            if (cpCidade != null)
            {
                sqlCampos += "CDCENDCidade, ";

                sqlConteudo += "'" + cpCidade + "',";
            }
            if (cpEstado != null)
            {
                sqlCampos += "CDCENDEstado, ";

                sqlConteudo += "'" + cpEstado + "',";
            }
            if (cpEndFisico != null)
            {
                sqlCampos += "CDCENDEndFisico, ";

                sqlConteudo += "'" + cpEndFisico + "',";
            }
            if (cpEndCobranca != null)
            {
                sqlCampos += "CDCENDEndCobranca, ";

                sqlConteudo += "'" + cpEndCobranca + "',";
            }
            if (cpCadastroDR != null)
            {
                sqlCampos += "CDCENDEmpresaDR, ";

                sqlConteudo += "'" + cpCadastroDR + "',";
            }
            if (cpReferencia != null)
            {
                sqlCampos += "CDCENDReferencia, ";

                sqlConteudo += "'" + cpReferencia + "',";
            }

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlConteudo.Remove(sqlConteudo.Length - 1) + ")";


            Conexao conexao = new Conexao(LcaminhoBanco);
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
        public List<BDCadEnderecos> CarregaDados(string inCaminhoBanco,string inIDEmpresa)
        {
            LcaminhoBanco = inCaminhoBanco;

            List<BDCadEnderecos> lstEnderecos = new List<BDCadEnderecos>();
            string slqSelect = "SELECT * FROM CDCadEnderecos ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (cpID != null)
            {
                sqlWhere = "WHERE CDCadEnderecos = " + cpID;
            }
            if (inIDEmpresa != "")
            {
                sqlWhere = "WHERE CDCENDEmpresaDR = '" + inIDEmpresa + "'";
                ClausulaWhere = 'S';
            }
            
            if (ClausulaWhere == 'S')
            {
                slqSelect += sqlWhere;
            }


            Conexao conexao = new Conexao(LcaminhoBanco);
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
                    BDCadEnderecos bDEndereco = new BDCadEnderecos();
                    bDEndereco.cpID = dr["CDCadEnderecos"].ToString();
                    bDEndereco.cpIdentificacao = dr["CDENDIdentificacao"].ToString();
                    bDEndereco.cpRua = dr["CDENDRua"].ToString();
                    bDEndereco.cpCEP = dr["CDCENDCEP"].ToString();
                    bDEndereco.cpNumero = dr["CDENDNumero"].ToString();
                    bDEndereco.cpBairro = dr["CDCENDBairro"].ToString();
                    bDEndereco.cpCidade = dr["CDCENDCidade"].ToString();
                    bDEndereco.cpEstado = dr["CDCENDEstado"].ToString();
                    bDEndereco.cpEndFisico = dr["CDCENDEndFisico"].ToString();
                    bDEndereco.cpEndCobranca = dr["CDCENDEndCobranca"].ToString();
                    bDEndereco.cpCadastroDR = dr["CDCENDEmpresaDR"].ToString();
                    bDEndereco.cpReferencia = dr["CDCENDReferencia"].ToString();


                    lstEnderecos.Add(bDEndereco);

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
            return lstEnderecos;
        }


        public void AlteraDados(string inCaminhoBanco)
        {
            LcaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDCadEnderecos = '" + cpID + "'";

            sSQL = "UPDATE CDCadEnderecos SET ";

            if (cpIdentificacao != null)
            {
                sqlconteudo += "CDENDIdentificacao = '" + cpIdentificacao.ToString() + "',";
            }
            if (cpRua != null)
            {
                sqlconteudo += " CDENDRua = '" + cpRua.ToString() + "',";
            }
            if (cpNumero != null)
            {
                sqlconteudo += "CDENDNumero = '" + cpNumero.ToString() + "',";
            }
            if (cpBairro != null)
            {
                sqlconteudo += "CDCENDBairro = '" + cpBairro.ToString() + "',";
            }
            if (cpCidade != null)
            {
                sqlconteudo += "CDCENDCidade = '" + cpCidade.ToString() + "',";
            }
            if (cpEstado != null)
            {
                sqlconteudo += "CDCENDEstado = '" + cpEstado.ToString() + "',";
            }
            if (cpEndFisico != null)
            {
                sqlconteudo += "CDCENDEndFisico = '" + cpEndFisico.ToString() + "',";
            }
            if (cpEndCobranca != null)
            {
                sqlconteudo += "CDCENDEndCobranca = '" + cpEndCobranca.ToString() + "',";
            }
            if (cpCadastroDR != null)
            {
                sqlconteudo += "CDCENDEmpresaDR = '" + cpCadastroDR.ToString() + "',";
            }
            if (cpReferencia != null)
            {
                sqlconteudo += "CDCENDReferencia = '" + cpReferencia.ToString() + "',";
            }
            if (cpCEP != null)
            {
                sqlconteudo += "CDCENDCEP = '" + cpCEP.ToString() + "',";
            }



            sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            sSQL = sSQL + sqlWhere;


            Conexao conexao = new Conexao(LcaminhoBanco);
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

        public void Excluir(string inCaminhoBanco)
        {

            LcaminhoBanco = inCaminhoBanco;

            string sSQL = "";

            sSQL = "DELETE FROM CDCadEnderecos WHERE CDCadEnderecos = '" + cpID + "'";


            Conexao conexao = new Conexao(LcaminhoBanco);
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
    }
}
