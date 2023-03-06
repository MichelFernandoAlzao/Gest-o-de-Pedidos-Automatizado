using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace Banco_de_Dados
{
    public  class BDNatOperacao
    {
        public string cpID { get; set; }
        public string cpDescricao { get; set; }
        public string cpVenda { get; set; }
        public string cpBonificacao { get; set; }
        public string cpBrinde { get; set; }
        public string cpInterno { get; set; }
        public string cpRestrito { get; set; }
        public string cpMsgErro { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public void InsereDados()
        {

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO CDNatOperacao (";
            sqlconteudo = " VALUES (";

            if (cpDescricao.ToString() != "")
            {
                sqlCampos += "CDNODescricao, ";

                sqlconteudo += "'" + cpDescricao.ToString() + "',";
            }
            if (cpVenda.ToString() != "")
            {
                sqlCampos += "CDNOVenda, ";

                sqlconteudo += "'" + cpVenda.ToString() + "',";
            }
            if (cpBonificacao.ToString() != "")
            {
                sqlCampos += "CDNOBonificacao, ";

                sqlconteudo += "'" + cpBonificacao.ToString() + "',";
            }
            if (cpBrinde.ToString() != "")
            {
                sqlCampos += "CDNOBrinde, ";

                sqlconteudo += "'" + cpBrinde.ToString() + "',";
            }
            if (cpInterno.ToString() != "")
            {
                sqlCampos += "CDNOInterno, ";

                sqlconteudo += "'" + cpInterno.ToString() + "',";
            }
            if (cpRestrito != "")
            {
                sqlCampos += "CDNORestrito, ";

                sqlconteudo += "'" + cpRestrito.ToString() + "',";
            }
            


            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

            cmd.CommandText = sSQL;




            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cpID = cmd.ExecuteNonQuery().ToString();
                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void AlteraDados()
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDNatOperacao = '" + cpID + "'";

            sSQL = "UPDATE CDNatOperacao SET ";

            if (cpDescricao != null)
            {
                sqlconteudo += "CDNODescricao = '" + cpDescricao.ToString() + "',";
            }
            if (cpVenda != null)
            {
                sqlconteudo += "CDNOVenda = '" + cpVenda.ToString() + "',";
            }
            if (cpBonificacao != null)
            {
                sqlconteudo += "CDNOBonificacao = " + cpBonificacao.ToString() + ",";
            }
            if (cpBrinde != null)
            {
                sqlconteudo += "CDNOBrinde = '" + cpBrinde.ToString() + "',";
            }
            if (cpInterno != null)
            {
                sqlconteudo += "CDNOInterno = '" + cpInterno.ToString() + "',";
            }
            if (cpRestrito != null)
            {
                sqlconteudo += "CDNORestrito = '" + cpRestrito.ToString() + "',";
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

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDNatOperacao> CarregaDados(string id)
        {
            List<BDNatOperacao> lstNatoperacao = new List<BDNatOperacao>();
            string slqSelect = "SELECT * FROM CDNatOperacao ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if (id != "")
            {
                sqlWhere = "WHERE CDNatOperacao = '" + id + "'";
                ClausulaWhere = 'S';
            }
           
            if (ClausulaWhere == 'S')
            {
                if (id != "")
                {
                    slqSelect += sqlWhere;
                }
                else
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
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    BDNatOperacao bDNatOperacao = new BDNatOperacao();
                    bDNatOperacao.cpID = dr["CDNatOperacao"].ToString();
                    bDNatOperacao.cpDescricao = dr["CDNODescricao"].ToString();
                    bDNatOperacao.cpVenda = dr["CDNOVenda"].ToString();
                    bDNatOperacao.cpBonificacao = dr["CDNOBonificacao"].ToString();
                    bDNatOperacao.cpBrinde = dr["CDNOBrinde"].ToString();
                    bDNatOperacao.cpInterno = dr["CDNOInterno"].ToString();
                    bDNatOperacao.cpRestrito = dr["CDNORestrito"].ToString();
                    
                    lstNatoperacao.Add(bDNatOperacao);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstNatoperacao;
        }

        public List<BDNatOperacao> CarregaDadosTotal()
        {
            List<BDNatOperacao> lstNatoperacao = new List<BDNatOperacao>();
            string slqSelect = "SELECT * FROM CDNatOperacao ";
            
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
                    BDNatOperacao bDNatOperacao = new BDNatOperacao();
                    bDNatOperacao.cpID = dr["CDNatOperacao"].ToString();
                    bDNatOperacao.cpDescricao = dr["CDNODescricao"].ToString();
                    bDNatOperacao.cpVenda = dr["CDNOVenda"].ToString();
                    bDNatOperacao.cpBonificacao = dr["CDNOBonificacao"].ToString();
                    bDNatOperacao.cpBrinde = dr["CDNOBrinde"].ToString();
                    bDNatOperacao.cpInterno = dr["CDNOInterno"].ToString();
                    bDNatOperacao.cpRestrito = dr["CDNORestrito"].ToString();

                    lstNatoperacao.Add(bDNatOperacao);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstNatoperacao;
        }
        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM CDNatOperacao WHERE CDNatOperacao = '" + cpID + "'";

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
