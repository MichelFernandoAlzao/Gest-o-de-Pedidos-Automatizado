using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados
{
    internal class BDConexao
    {
        string ConnectionString;

        //Construtor
         private SqlConnection CriaConexao()
        {
            return new SqlConnection(ConnectionString);
        }

        //Parametros que vão para o banco

        private SqlParameterCollection SqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            SqlParameterCollection.Clear();
        }

        public void AdicionarParametos(string nomeParametros, object valorParametro)
        {
            SqlParameterCollection.Add(new SqlParameter(nomeParametros, valorParametro));
        }
        //Metodo Conectar
        //Persistencia - Inserir, Alterar, Excluir
        //ComandType = Se é Texto ou nome da StoredProcedure
        public object ExecutaManipulacao(string pConnectionString, CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            ConnectionString = pConnectionString;
            try
            {
                //Criar Conexão
                SqlConnection sqlConnection = CriaConexao();
                //Abrir Conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (Dentro da caixa que vai entregar a conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; // Em Segundos

                //Adicionar os parametros no comando
                foreach (SqlParameter parameter in SqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(parameter.ParameterName, parameter.Value));
                }
                //Executar o comando, ou seja, mandar o coando ir até o banco de dados
                return sqlCommand.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

           
        }
        public DataTable ExecutarConsulta(string pConnectionString, CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            ConnectionString = pConnectionString;

            try
            {
                //Criar Conexão
                SqlConnection sqlConnection = CriaConexao();
                //Abrir Conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (Dentro da caixa que vai entregar a conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; // Em Segundos

                //Adicionar os parametros no comando
                foreach (SqlParameter parameter in SqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(parameter.ParameterName, parameter.Value));
                }
                //Cria um adaptador para receber os dados
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTabble = Tabela de Dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();
                //Mandar o comando ir até o banco buscar os dados e o adaptador preecher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //Metodo Desconectar
    }
}
