﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Banco_de_Dados
{

       // Classe que permite acesso ao SQL Server (Obrigatorio)
    public class ConectaBanco
    {
        #region Declaracao de Variaveis globais
        private bool _State;                // Indica ULTIMO Status da conexão
        private string _ErrorMessage;       // Indica ULTIMO Mensagem de Erro da conexao
        private int _ErrorNumber;           // Indica ULTIMO Numero de Erro da conexao
        private bool _CompleteCommand;      // Indica ULTIMO comando foi executado com sucesso
        private SqlDataReader _rsData;      // Usado para retornar colecao de registros
        private SqlConnection myConnection; // Representa a conexão com banco de dados
        #endregion

        #region Definicao de Metodos
        public void ExecuteCommand(List<String> LParametros, string myConnectionName, string myQueryString)
        {
            // Metodo responsavel por executar uma instrução SQL
            // Recebe a instrução SQL a ser executada pode ser um SELECT ou uma procedure (preferencialmente)
            // Utililizo Tray..Catch para tratamento de erro
            try
            {
                // Definir valores padrões das variaveis
                _ErrorMessage = "";
                _State = false;

                // Se nao for passado nenhuma chave de conexão do arquivo web.config
                // vou setar uma chave padrao de conexão do arquivo Web.Config
                if (myConnectionName.Length == 0)
                { // Aqui estou indicando o nome da chave que contem a string de conexão no arquivo web.config
                    myConnectionName = "Connection_Developer";
                }

                

                // Se não for informado comando T-SQL retorno error
                if (myQueryString.Length > 0) // Se realmente foi passado um comando a ser executado
                {
                    // Inicio uma conexão com o banco de dados
                    SqlConnection myConnection = new SqlConnection(LParametros[0]);
                    // Abro a conexão
                    myConnection.Open();

                    // Inicio um comando
                    SqlCommand myCommand = new SqlCommand(myQueryString, myConnection);

                    // Executo um comando com ExecuteReader, pois este retorna dados a um SqlDataReader
                    _rsData = myCommand.ExecuteReader(); // Executo do comando
                    _State = true;                      // Indico o status da operação 
                    _CompleteCommand = true;
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro seto as variaveis abaixo
                _ErrorMessage = ex.Message.ToString();
                _State = false;
                _ErrorNumber = ex.GetHashCode();
            }
        }
        public SqlDataReader RecordSet
        {
            // Metodo para ler os registros
            get { return _rsData; }
        }
        public int ErrorNumber
        {
            // Metodo para ler ultimo código de error
            get { return _ErrorNumber; }
        }
        public string ErrorDescription
        {
            // Metodo para ler ultima descrição de error
            get { return _ErrorMessage; }
        }
        public bool ConnectionState
        {
            // Metodo para ler ultimo status da conexao
            get { return _State; }
        }
        public bool CompleteCommand
        {
            // Metodo para ler status do ultimo comando executado.
            get { return _CompleteCommand; }
        }
        #endregion
    }
}