﻿using System;
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
    public class BDCadProdutos
    {
        string LCaminhoBanco;

        public string cpID { get; set; }
        public string cpDescricao { get; set; }
        public string cpDataCadastro { get; set; }
        public string cpCodigoFabricante { get; set; }
        public string cpDescFornecedor { get; set; }
        public string cpFabricanteDR { get; set; }
        public string cpMelhorFornecedorDR { get; set; }
        public string cpAtivo { get; set; }
        public string cpOperacional { get; set; }
        public string cpForaDeLinha { get; set; }
        public string cpDescritivo { get; set; }
        public string cpMsgErro { get; set; }




        public void InsereDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            string sSQL = "INSERT INTO CDPRodutos (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpDescricao != null)
            {
                if(cpDescricao != "")
                {
                    sqlCampos += "CDPDescricao, ";

                    sqlConteudo += "'" + cpDescricao + "',";
                }
                
            }

            if (cpDataCadastro != null)
            {
                if(cpDataCadastro != "")
                {
                    sqlCampos += "CDPDataCadastro, ";

                    sqlConteudo += "'" + cpDataCadastro + "',";
                }
                
            }

            if (cpCodigoFabricante != null)
            {
                if(cpCodigoFabricante != "")
                {
                    sqlCampos += "CDPCodigoFabricante, ";

                    sqlConteudo += "'" + cpCodigoFabricante + "',";
                }
                
            }

            if (cpDescFornecedor != null)
            {
                if(cpDescFornecedor != "")
                {
                    sqlCampos += "CDPDescFornecedor, ";

                    sqlConteudo += "'" + cpDescFornecedor + "',";
                }
                
            }

            if (cpFabricanteDR != null)
            {
                if(cpFabricanteDR != "")
                {
                    sqlCampos += "CDPFabricanteDR, ";

                    sqlConteudo += "'" + cpFabricanteDR + "',";
                }
                
            }
            if (cpMelhorFornecedorDR != null)
            {
                if(cpMelhorFornecedorDR != "")
                {
                    sqlCampos += "CDPMelhorFornecedorDR, ";

                    sqlConteudo += "'" + cpMelhorFornecedorDR + "',";
                }
                
            }
            if (cpAtivo != null)
            {
                if(cpAtivo != "")
                {
                    sqlCampos += "CDPAtivo, ";

                    sqlConteudo += "'" + cpAtivo + "',";
                }
                
            }
            if (cpOperacional != null)
            {
                if(cpOperacional != "")
                {
                    sqlCampos += "CDPOperacional, ";

                    sqlConteudo += "'" + cpOperacional + "',";
                }
                
            }
            if (cpForaDeLinha != null)
            {
                if(cpForaDeLinha != "")
                {
                    sqlCampos += "CDPForaDeLinha, ";

                    sqlConteudo += "'" + cpForaDeLinha + "',";
                }
                
            }
            if (cpDescritivo != null)
            {
                if(cpDescritivo != "")
                {
                    sqlCampos += "CDPDescritivo, ";

                    sqlConteudo += "'" + cpDescritivo + "',";
                }
                
            }


            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlConteudo.Remove(sqlConteudo.Length - 1) + ")";

            Conexao conexao = new Conexao(LCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT IDENT_CURRENT ('CDPRodutos') AS Current_Identity";
                string LID = Convert.ToString(cmd.ExecuteScalar());

                cpID = LID;
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
        public List<BDCadProdutos> CarregaDados(string inCaminhoBanco)
        {

            LCaminhoBanco = inCaminhoBanco;

            List<BDCadProdutos> lstCadprodutos = new List<BDCadProdutos>();
            string slqSelect = "SELECT * FROM CDProdutos ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            if(cpID != null)
            {
                if (cpID != "")
                {
                    sqlWhere = "WHERE CDProdutos = " + cpID;
                    ClausulaWhere = 'S';
                }
            }
            
            else
            {
                if(cpCodigoFabricante != null)
                {
                    if (cpCodigoFabricante.Replace(" ", "") != "")
                    {
                        sqlWhere += "CDPCodigoFabricante like '%" + cpCodigoFabricante + "%' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
                if(cpDescricao != null)
                {
                    if (cpDescricao.Replace(" ","") != "")
                    {
                        sqlWhere += "CDPDescricao like '%" + cpDescricao + "%' " + "AND";
                        ClausulaWhere = 'S';
                    }
                }
            }
            if (ClausulaWhere == 'S')
            {
                if(cpID != null)
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
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    BDCadProdutos bDCadProdutos = new BDCadProdutos();
                    bDCadProdutos.cpID = dr["CDProdutos"].ToString();
                    bDCadProdutos.cpDescricao = dr["CDPDescricao"].ToString();
                    bDCadProdutos.cpDataCadastro = dr["CDPDataCadastro"].ToString();
                    bDCadProdutos.cpCodigoFabricante = dr["CDPCodigoFabricante"].ToString();
                    bDCadProdutos.cpDescFornecedor = dr["CDPDescFornecedor"].ToString();
                    bDCadProdutos.cpFabricanteDR = dr["CDPFabricanteDR"].ToString();
                    bDCadProdutos.cpMelhorFornecedorDR = dr["CDPMelhorFornecedorDR"].ToString();
                    bDCadProdutos.cpAtivo = dr["CDPAtivo"].ToString();
                    bDCadProdutos.cpOperacional = dr["CDPOperacional"].ToString();
                    bDCadProdutos.cpForaDeLinha = dr["CDPForaDeLinha"].ToString();
                    bDCadProdutos.cpDescritivo = dr["CDPDescritivo"].ToString();

                    lstCadprodutos.Add(bDCadProdutos);

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
            return lstCadprodutos;
        }


        public void AlteraDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDProdutos = '" + cpID + "'";

            sSQL = "UPDATE CDProdutos SET ";


            if (cpDescricao != null)
            {
                sqlconteudo += "CDPDescricao = '" + cpDescricao.ToString() + "',";
            }
            if (cpCodigoFabricante != null)
            {
                sqlconteudo += "CDPCodigoFabricante = '" + cpCodigoFabricante.ToString() + "',";
            }
            if (cpDescFornecedor != null)
            {
                sqlconteudo += "CDPDescFornecedor = '" + cpDescFornecedor.ToString() + "',";
            }
            if (cpFabricanteDR != null)
            {
                sqlconteudo += "CDPFabricanteDR = '" + cpFabricanteDR.ToString() + "',";
            }
            if (cpMelhorFornecedorDR != null)
            {
                sqlconteudo += "CDPMelhorFornecedorDR = '" + cpMelhorFornecedorDR.ToString() + "',";
            }
            if (cpAtivo != null)
            {
                sqlconteudo += "CDPAtivo = '" + cpAtivo.ToString() + "',";
            }
            if (cpOperacional != null)
            {
                sqlconteudo += "CDPOperacional = '" + cpOperacional.ToString() + "',";
            }
            if (cpForaDeLinha != null)
            {
                sqlconteudo += "CDPForaDeLinha = '" + cpForaDeLinha.ToString() + "',";
            }
            if (cpDescritivo != null)
            {
                sqlconteudo += "CDPDescritivo = '" + cpDescritivo.ToString() + "',";
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
                cpMsgErro = "";
            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void Excluir(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";

            sSQL = "DELETE FROM CDProdutos WHERE CDProdutos = '" + cpID + "'";

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
