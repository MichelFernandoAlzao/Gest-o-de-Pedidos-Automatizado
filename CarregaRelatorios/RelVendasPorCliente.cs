using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_de_Dados;
using Camada_Relatorios;
using DAL;

namespace CarregaRelatorios
{
    public class RelVendasPorCliente
    {
        public List<VendasPorCliente> CarregaRelatorioRDLC(string inCaminhoBanco,string inVendedor)
        {
            DataTable DTVendasPorCliente = new DataTable();
            string sSQL = "";
            sSQL += "SELECT OPPPedido,CDCERazaoSocial,OPPDataContato,OPPDataConfirmacao, OPPVlritensFaturando,CDNODescricao ";
            sSQL += "FROM OPPPedido ";
            sSQL += "INNER JOIN CDCadastroEmpresas ON OPPEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN CDNatOperacao ON OPPNaturezaDR = CDNatOperacao ";
            sSQL += "WHERE OPPVendedorDR = '" + inVendedor + "' AND OPPStatus = 'Concluido'";

            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<VendasPorCliente> lstRelVendasPorCliente = new List<VendasPorCliente>();
            
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTVendasPorCliente.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTVendasPorCliente.Rows)
                {
                    VendasPorCliente bDVendasPorCliente = new VendasPorCliente();
                    bDVendasPorCliente.IDPedido = dr["OPPPedido"].ToString();
                    bDVendasPorCliente.RazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDVendasPorCliente.DataPedido = dr["OPPDataContato"].ToString();
                    bDVendasPorCliente.DataConfirmacao = dr["OPPDataConfirmacao"].ToString();
                    bDVendasPorCliente.VlrItensFaturando = dr["OPPVlritensFaturando"].ToString();
                    bDVendasPorCliente.NatOperacao = dr["CDNODescricao"].ToString();


                    lstRelVendasPorCliente.Add(bDVendasPorCliente);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {

            }
            cmd.Dispose();
            return lstRelVendasPorCliente;
        }
    }
}
