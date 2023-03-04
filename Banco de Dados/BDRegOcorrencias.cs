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
    internal class BDRegOcorrencias
    {
        public string cpID { get; set; }
        public string cpEmpresaDR { get; set; }
        string cpData { get; set; }
        string cpDescricao { get; set; }
        string cpPedidoDR { get; set; }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();


        public void InsereDados()
        {
            string sSQL = "INSERT INTO OPRegOcorrencias (";
            string sqlCampos = "";
            string sqlConteudo = " VALUES (";

            if (cpEmpresaDR != null)
            {
                sqlCampos += "OPRO, ";

                sqlConteudo += "'" + cpEmpresaDR + "',";
            }

            if (cpAnotacoes != null)
            {
                sqlCampos += "CDCAnotacoes, ";

                sqlConteudo += "'" + cpAnotacoes + "',";
            }

            if (cpCargo != null)
            {
                sqlCampos += "CDCCargoDR, ";

                sqlConteudo += "'" + cpCargo + "',";
            }

            if (cpComprador != null)
            {
                sqlCampos += "CDCComprador, ";

                sqlConteudo += "'" + cpComprador + "',";
            }

            if (cpEmpresaDR != null)
            {
                sqlCampos += "CDCCadastroEmpresaDR, ";

                sqlConteudo += "'" + cpEmpresaDR + "',";
            }
            if (cpEmail != null)
            {
                sqlCampos += "CDCEmail, ";

                sqlConteudo += "'" + cpEmail + "',";
            }
            if (cpNome != null)
            {
                sqlCampos += "CDCNome, ";

                sqlConteudo += "'" + cpNome + "',";
            }
            if (cpGerencia != null)
            {
                sqlCampos += "CDCGerencia, ";

                sqlConteudo += "'" + cpGerencia + "',";
            }
            if (cpTelefone != null)
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
            if (inIDEmpresa != "")
            {
                sqlWhere = "WHERE CDCCadastroEmpresaDR = '" + inIDEmpresa + "'";
                ClausulaWhere = 'S';
            }
            else
            {
                if (cpEmpresaDR != "")
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


        public void AlteraDados()
        {
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE CDContatos = '" + cpID + "'";

            sSQL = "UPDATE CDContatos SET ";

            if (cpAniversario != null)
            {
                sqlconteudo += "CDCAniversario = '" + cpAniversario.ToString() + "',";
            }
            if (cpAnotacoes != null)
            {
                sqlconteudo += " CDCAnotacoes = '" + cpAnotacoes.ToString() + "',";
            }
            if (cpEmpresaDR != null)
            {
                sqlconteudo += "CDCCadastroEmpresaDR = '" + cpEmpresaDR.ToString() + "',";
            }
            if (cpCargo != null)
            {
                sqlconteudo += "CDCCargoDR = '" + cpCargo.ToString() + "',";
            }
            if (cpComprador != null)
            {
                sqlconteudo += "CDCComprador = '" + cpComprador.ToString() + "',";
            }
            if (cpEmail != null)
            {
                sqlconteudo += "CDCEmail = '" + cpEmail.ToString() + "',";
            }
            if (cpGerencia != null)
            {
                sqlconteudo += "CDCGerencia = '" + cpGerencia + "',";
            }
            if (cpNome != null)
            {
                sqlconteudo += "CDCNome = '" + cpNome.ToString() + "',";
            }
            if (cpTelefone != null)
            {
                sqlconteudo += "CDCTelefone = '" + cpTelefone.ToString() + "',";
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
                MsgErro = "";
            }
            catch (SqlException e)
            {
                MsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public void Excluir()
        {
            string sSQL = "";

            sSQL = "DELETE FROM CDContatos WHERE CDContatos = '" + cpID + "'";

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
