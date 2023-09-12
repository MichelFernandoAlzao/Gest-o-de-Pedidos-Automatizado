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
        public List<VendasPorCliente> CarregaRelatorioRDLC(string inCaminhoBanco,string[]inParametrosRel)
        {
            string inVendedor = inParametrosRel[1];
            string inDataInicial = inParametrosRel[2];
            string inDataFinal = inParametrosRel[3];
            DataTable DTVendasPorCliente = new DataTable();
            string sSQL = "";
            sSQL += "SELECT OPPPedido,CDCERazaoSocial,OPPDataContato,OPPDataConfirmacao, OPPVlritensFaturando,CDNODescricao, USUsuario, OPITPPedidoDR, CDPDescricao, OPITPValorUnitario, OPITPQuantidade ";
            sSQL += "FROM OPPPedido ";
            sSQL += "INNER JOIN CDCadastroEmpresas ON OPPEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN CDNatOperacao ON OPPNaturezaDR = CDNatOperacao ";
            sSQL += "INNER JOIN SEGUsuarios on OPPVendedorDR = SEGUsuarios ";
            sSQL += "INNER JOIN OPItensPedido ON OPITPPedidoDR = OPPPedido ";
            sSQL += "INNER JOIN CDProdutos ON OPITPProdutoDR = CDProdutos ";
            sSQL += "WHERE OPPStatus = 'Concluido'";
            sSQL += " AND (OPPDataConfirmacao >= '" + inDataInicial + "' AND OPPDataConfirmacao <= '" + inDataFinal + "')";
            if (inVendedor != "")
            {
                sSQL += " AND OPPVendedorDR = '" + inVendedor + "'";
            }
            sSQL += " ORDER BY OPPVlritensFaturando desc,OPPDataConfirmacao";



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
                    bDVendasPorCliente.cpIDPedido = dr["OPPPedido"].ToString();
                    bDVendasPorCliente.cpRazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDVendasPorCliente.cpDataPedido = dr["OPPDataContato"].ToString();
                    bDVendasPorCliente.cpDataConfirmacao = dr["OPPDataConfirmacao"].ToString();
                    bDVendasPorCliente.cpVlrItensFaturando = dr["OPPVlritensFaturando"].ToString();
                    bDVendasPorCliente.cpNatOperacao = dr["CDNODescricao"].ToString();
                    bDVendasPorCliente.cpVendedor = dr["USUsuario"].ToString();
                    bDVendasPorCliente.cpITPedidoDR = dr["OPITPPedidoDR"].ToString();
                    bDVendasPorCliente.cpProdDescricao = dr["CDPDescricao"].ToString();
                    bDVendasPorCliente.cpITVlrUnitario = dr["OPITPValorUnitario"].ToString();
                    bDVendasPorCliente.cpQtdProduto = dr["OPITPQuantidade"].ToString();


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
