using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Camada_Relatorios;
using DAL;

namespace CarregaRelatorios
{
    public class RelCarregaRegistrosdeContatos
    {
        public List<RegistrosdeContatos> CarregaRelatorioRDLC(string inCaminhoBanco, string[]inParametros)
        {
            string inVendedor = inParametros[1];
            string inData = inParametros[2];
            DataTable DTContatoscomCliente = new DataTable();
            string sSQL = "";
            sSQL += "SELECT OPRegContatosEmpresa,CDCERazaoSocial,OPRCEDataContato,OPRCESugestao, OPRCEReclamacao ";
            sSQL += "FROM OPRegContatosEmpresa ";
            sSQL += "INNER JOIN CDCadastroEmpresas ON OPRCEEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN SEGUsuarios on OPRCEusuarioDR = SEGUsuarios ";
            if (inVendedor != "")
            {
                sSQL += "WHERE OPPVendedorDR = '" + inVendedor + "'";
            }
            sSQL += " ORDER BY OPRCEDataContato desc";



            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<RegistrosdeContatos> lstContatoscomCLientes = new List<RegistrosdeContatos>();

            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTContatoscomCliente.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTContatoscomCliente.Rows)
                {
                    RegistrosdeContatos bDContatosComClientes = new RegistrosdeContatos();
                    bDContatosComClientes.ID = dr["OPPPedido"].ToString();
                    bDContatosComClientes.RazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDContatosComClientes.Data = dr["OPPDataContato"].ToString();
                    bDContatosComClientes.Sugestoes = dr["OPPDataConfirmacao"].ToString();
                    bDContatosComClientes.Reclamacoes = dr["OPPVlritensFaturando"].ToString();



                    lstContatoscomCLientes.Add(bDContatosComClientes);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {

            }
            cmd.Dispose();
            return lstContatoscomCLientes;
        }
    }
}
