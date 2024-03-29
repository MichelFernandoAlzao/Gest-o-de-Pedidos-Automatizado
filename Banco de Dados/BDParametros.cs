﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace Banco_de_Dados
{
    public class BDParametros
    {
        string LcaminhoBanco;
        public string cpID { get; set; }
        public string cpDiasContato { get; set; }
        public string cpDiasUltVenda { get; set; }
        public string cpEmpresaDR { get; set; }
        public string cpMsgErro { get; set; }



        public void InsereDados(string inCmainhoBanco)
        {
            LcaminhoBanco = inCmainhoBanco;
            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPParametros (";
            sqlconteudo = " VALUES (";

            if (cpDiasContato.ToString() != "")
            {
                sqlCampos += "OPPUltimoContato, ";

                sqlconteudo += "'" + cpDiasContato.ToString() + "',";
            }
            if (cpDiasUltVenda.ToString() != "")
            {
                sqlCampos += "OPPDiasUltVenda, ";

                sqlconteudo += "'" + cpDiasUltVenda.ToString() + "',";
            }
            if (cpEmpresaDR.ToString() != "")
            {
                sqlCampos += "OPPEmpresaDR, ";

                sqlconteudo += "'" + cpEmpresaDR.ToString() + "',";
            }
           

            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

            Conexao conexao = new Conexao(LcaminhoBanco);
            SqlCommand cmd = new SqlCommand();

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

        public void AlteraDados(string inCmainhoBanco)
        {
            LcaminhoBanco = inCmainhoBanco;
            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPParametros = '" + cpID + "'";

            sSQL = "UPDATE OPParametros SET ";

            if (cpDiasContato != null)
            {
                sqlconteudo += "OPPUltimoContato = '" + cpDiasContato.ToString() + "',";
            }
            if (cpDiasUltVenda != null)
            {
                sqlconteudo += "OPPDiasUltVenda = '" + cpDiasUltVenda.ToString() + "',";
            }
            if (cpEmpresaDR != null)
            {
                sqlconteudo += "OPPEmpresaDR = '" + cpEmpresaDR.ToString() + "',";
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

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDParametros> CarregaDados(string inCmainhoBanco)
        {
            LcaminhoBanco = inCmainhoBanco;

            List<BDParametros> lstParametros = new List<BDParametros>();
            string slqSelect = "SELECT * FROM OPParametros ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';
            
            if(cpID != null)
            {
                if (cpID != "")
                {
                    sqlWhere = "WHERE OPParametros = '" + cpID + "'";
                    ClausulaWhere = 'S';
                }
            }
            

            if (ClausulaWhere == 'S')
            {
                if (cpID != "")
                {
                    slqSelect += sqlWhere;
                }
                else
                {
                    slqSelect += sqlWhere.Remove(sqlWhere.Length - 3);
                }
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
                    BDParametros bDParametros = new BDParametros();
                    bDParametros.cpID = dr["OPParametros"].ToString();
                    bDParametros.cpDiasContato = dr["OPPUltimoContato"].ToString();
                    bDParametros.cpDiasUltVenda = dr["OPPDiasUltVenda"].ToString();
                    bDParametros.cpEmpresaDR = dr["OPPEmpresaDR"].ToString();

                    lstParametros.Add(bDParametros);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstParametros;
        }

        public void Excluir(string inCaminhoBanco)
        {
            LcaminhoBanco = inCaminhoBanco;
            string sSQL = "";

            sSQL = "DELETE FROM OPParametros WHERE OPParametros = '" + cpID + "'";

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
