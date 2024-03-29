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
    public class BDAvisos
    {
        string LCaminhoBanco;
        public string cpID { get; set; }
        public string cpAviso { get; set; }
        public string cpConfirmado { get; set; }
        public string cpDataInicio { get; set; }
        public string cpDataTermino { get; set; }
        public string cpUsuarioDR { get; set; }
        public string cpTodos { get; set; }
        public string cpMsgErro { get; set; }



        public void InsereDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL;
            string sqlCampos = "";
            string sqlconteudo;

            sSQL = "INSERT INTO OPAvisos (";
            sqlconteudo = " VALUES (";

            if (cpAviso.ToString() != "")
            {
                sqlCampos += "OPAAviso, ";

                sqlconteudo += "'" + cpAviso.ToString() + "',";
            }
            if (cpDataInicio.ToString() != "")
            {
                sqlCampos += "OPADataInicio, ";

                sqlconteudo += "'" + cpDataInicio.ToString() + "',";
            }

            if(cpDataTermino != null)
            {
                if (cpDataTermino.ToString() != "")
                {
                    sqlCampos += "OPADataTermino, ";

                    sqlconteudo += "'" + cpDataTermino.ToString() + "',";
                }
            }
            
            if(cpUsuarioDR != null)
            {
                if (cpUsuarioDR.ToString() != "")
                {
                    sqlCampos += "OPAUsuarioDR, ";

                    sqlconteudo += "'" + cpUsuarioDR.ToString() + "',";
                }
            }

            if (cpTodos != null)
            {
                if (cpTodos.ToString() != "")
                {
                    sqlCampos += "OPATodos, ";

                    sqlconteudo += "'" + cpTodos.ToString() + "',";
                }
            }



            sSQL = sSQL + sqlCampos.Remove(sqlCampos.Length - 2) + ")" + sqlconteudo.Remove(sqlconteudo.Length - 1) + ")";

            Conexao conexao = new Conexao(LCaminhoBanco);
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

        public void AlteraDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";
            string sqlconteudo = "";
            string sqlWhere = " WHERE OPAvisos = '" + cpID + "'";

            sSQL = "UPDATE OPAvisos SET ";

            if (cpAviso != null)
            {
                sqlconteudo += "OPAAviso = '" + cpAviso.ToString() + "',";
            }
            if(cpConfirmado != null) 
            {
                sqlconteudo += "OPAConfirmado = '" + cpConfirmado.ToString() + "',";
            }
            if (cpDataInicio != null)
            {
                sqlconteudo += "OPADataInicio = '" + cpDataInicio.ToString() + "',";
            }
            if (cpDataTermino != null)
            {
                sqlconteudo += "OPADataTremino = '" + cpDataTermino.ToString() + "',";
            }
            if (cpUsuarioDR != null)
            {
                sqlconteudo += "OPAUsuarioDR = '" + cpUsuarioDR.ToString() + "',";
            }
            if (cpTodos != null)
            {
                sqlconteudo += "OPATodos = '" + cpTodos.ToString() + "',";
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

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
        }

        public List<BDAvisos> CarregaDados(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            List<BDAvisos> lstAvisos = new List<BDAvisos>();
            string slqSelect = "SELECT * FROM OPAvisos ";
            string sqlWhere = "WHERE ";
            string ClausulaWhere = "N";


            if (cpUsuarioDR != null)
            {
                if (cpUsuarioDR != "")
                {
                    sqlWhere = "WHERE OPAUsuarioDR = '" + cpUsuarioDR + "'";
                    ClausulaWhere = "S";
                }
            }
            if(cpConfirmado != null) 
            {
                if (ClausulaWhere != "S")
                {
                    if(cpConfirmado == "S")
                    {
                        sqlWhere = "WHERE OPAConfirmado = '" + cpConfirmado + "'";
                        ClausulaWhere = "S";
                    }
                    else
                    {
                        sqlWhere = "WHERE OPAConfirmado <> 'S'";
                        ClausulaWhere = "S";

                    }
                    
                }
                else
                {
                    if(cpConfirmado == "S")
                    {
                        sqlWhere += " AND OPAConfirmado = '" + cpConfirmado + "'";
                    }
                    else
                    {
                        sqlWhere += " AND OPAConfirmado <> 'S' OR OPAConfirmado is null";
                    }
                    

                }

            }

            if (ClausulaWhere == "S")
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
                    BDAvisos bDParametros = new BDAvisos();
                    bDParametros.cpID = dr["OPAvisos"].ToString();
                    bDParametros.cpAviso = dr["OPAAviso"].ToString();
                    bDParametros.cpConfirmado = dr["OPAConfirmado"].ToString();
                    bDParametros.cpDataInicio = dr["OPADataInicio"].ToString();
                    bDParametros.cpDataTermino = dr["OPADataTermino"].ToString();
                    bDParametros.cpUsuarioDR = dr["OPAusuarioDR"].ToString();
                    bDParametros.cpTodos = dr["OPATodos"].ToString();

                    lstAvisos.Add(bDParametros);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstAvisos;
        }

        public List<BDAvisos> CarregaDadosGeral(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            List<BDAvisos> lstAvisos = new List<BDAvisos>();
            string slqSelect = "SELECT * FROM OPAvisos ";
            string sqlWhere = "WHERE ";
            char ClausulaWhere = 'N';


            if (cpTodos != null)
            {
                if (cpTodos != "")
                {
                    sqlWhere = "WHERE OPATodos = '" + cpTodos + "'";
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
                    BDAvisos bDParametros = new BDAvisos();
                    bDParametros.cpID = dr["OPAvisos"].ToString();
                    bDParametros.cpAviso = dr["OPAAviso"].ToString();
                    bDParametros.cpDataInicio = dr["OPADataInicio"].ToString();
                    bDParametros.cpDataTermino = dr["OPADataTermino"].ToString();
                    bDParametros.cpUsuarioDR = dr["OPAusuarioDR"].ToString();
                    bDParametros.cpTodos = dr["OPATodos"].ToString();


                    lstAvisos.Add(bDParametros);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {
                cpMsgErro = e.Message.ToString();
            }
            cmd.Dispose();
            return lstAvisos;
        }

        public void Excluir(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;

            string sSQL = "";

            sSQL = "DELETE FROM OPAvisos WHERE OPAvisos = '" + cpID + "'";

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

