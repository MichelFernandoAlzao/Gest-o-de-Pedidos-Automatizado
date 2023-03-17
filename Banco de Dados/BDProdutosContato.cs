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
    public class BDProdutosContato
    {
        public string cpID { get; set; }
        public string cpRegContatoDR { get; set; }
        public string cpProdutoDR { get; set; }
        public string cpValorOfertado { get; set; }
        public string cpAceito { get; set; }
        public string cpQuantidade { get; set; }
        public string cpMsgErro { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();


        public void InsereDados()
        {
            string sSQL = "INSERT INTO OPProdRegContato (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpRegContatoDR != null)
            {
                sqlCampos += "OPPRCRegContatoDR, ";

                sqlConteudo += "'" + cpRegContatoDR + "',";
            }
            if (cpProdutoDR != null)
            {
                sqlCampos += "OPPRCProdutoDR, ";

                sqlConteudo += "'" + cpProdutoDR + "',";
            }

            if (cpValorOfertado != null)
            {
                cpValorOfertado = cpValorOfertado.Replace(",", ".");
                sqlCampos += "OPPRCVlrOfertado, ";

                sqlConteudo += "'" + cpValorOfertado + "',";
            }

            if (cpAceito != null)
            {
                sqlCampos += "OPPRCAceito, ";

                sqlConteudo += "'" + cpAceito + "',";
            }

            if (cpQuantidade != null)
            {
                sqlCampos += "OPPRCQuantidade, ";

                sqlConteudo += "'" + cpQuantidade + "',";
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
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }
        public List<BDProdutosContato> CarregaDados()
        {
            List<BDProdutosContato> lstProdContato = new List<BDProdutosContato>();
            string slqSelect = "SELECT * FROM OPProdRegContato ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (cpID != null)
            {
                sqlWhere = "WHERE OPProdRegContato = " + cpID;
            }
            if (cpRegContatoDR != "")
            {
                sqlWhere = "WHERE OPPRCRegContatoDR = '" + cpRegContatoDR + "'";
                ClausulaWhere = 'S';
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
                    BDProdutosContato bDRegOcorrencias = new BDProdutosContato();
                    bDRegOcorrencias.cpID = dr["OPProdRegContato"].ToString();
                    bDRegOcorrencias.cpRegContatoDR = dr["OPPRCRegContatoDR"].ToString();
                    bDRegOcorrencias.cpProdutoDR = dr["OPPRCProdutoDR"].ToString();
                    bDRegOcorrencias.cpValorOfertado = dr["OPPRCVlrOfertado"].ToString();
                    bDRegOcorrencias.cpAceito = dr["OPPRCAceito"].ToString();
                    bDRegOcorrencias.cpQuantidade = dr["OPPRCQuantidade"].ToString();


                    lstProdContato.Add(bDRegOcorrencias);

                }

                //Desconectar
                conexao.desconectar();
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstProdContato;
        }


        public void AlteraDados()
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPProdRegContato = '" + cpID + "'";

            sSQL = "UPDATE OPProdRegContato SET ";


            if (cpRegContatoDR != null)
            {
                sqlconteudo += "OPPRCRegContatoDR = '" + cpRegContatoDR.ToString() + "',";
            }
            if (cpProdutoDR != null)
            {
                sqlconteudo += "OPPRCProdutoDR = '" + cpProdutoDR.ToString() + "',";
            }
            if (cpValorOfertado != null)
            {
                sqlconteudo += "OPPRCVlrOfertado = '" + cpValorOfertado.ToString() + "',";
            }
            if (cpAceito != null)
            {
                sqlconteudo += "OPPRCAceito = '" + cpAceito.ToString() + "',";
            }
            if (cpQuantidade != null)
            {
                sqlconteudo += "OPPRCQuantidade = '" + cpQuantidade.ToString() + "',";
            }


            sSQL = sSQL + sqlconteudo.Remove(sqlconteudo.Length - 1);
            sSQL = sSQL + sqlWhere;

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM OPProdRegContato WHERE OPProdRegContato = '" + cpID + "'";

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }
    }
}
