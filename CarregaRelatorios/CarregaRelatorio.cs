using Banco_de_Dados;
using Camada_Relatorios;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace CarregaRelatorios
{
    public class CarregaRelatorio
    {
        public List<RelatorioPedido> CarregaRelatorioRDLC(string inCaminhoBanco, string inPedido)
        {
            DataTable DTPedido = new DataTable();
            string sSQL = "";

            sSQL += "SELECT OPPPedido,OPPObservacao,OPPVlritensFaturando,CDCERazaoSocial,CDCECNPJ,OPPDataContato,CDPDescricao,OPITPValorUnitario,OPITPValorTotalItem,OPITPQuantidade,OPPValidadeProposta,OPPVlrFatMinimo,OPPPrazoEntrega,OPPPrazoPagamento,OPPVlrImpostos,OPPImpostosInclusos,USContato,USEmail ";
            sSQL += "FROM OPItensPedido ";
            sSQL += "INNER JOIN OPPPedido ON OPITPPedidoDR = OPPPedido ";
            sSQL += "INNER JOIN CDCadastroEmpresas ON OPPEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN CDProdutos ON OPITPProdutoDR = CDProdutos ";
            sSQL += "INNER JOIN SEGUsuarios ON OPPVendedorDR = SEGUsuarios ";
            sSQL += "WHERE OPPPedido = " + inPedido;

            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<RelatorioPedido> lstrelPedido = new List<RelatorioPedido>();
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTPedido.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTPedido.Rows)
                {
                    RelatorioPedido bDPedidoItens = new RelatorioPedido();
                    bDPedidoItens.fdOPPPedido = dr["OPPPedido"].ToString();
                    bDPedidoItens.fdOPPObservacao = dr["OPPObservacao"].ToString();
                    bDPedidoItens.fdOPPVlrItensFaturando = dr["OPPVlritensFaturando"].ToString();
                    bDPedidoItens.fdCDCERazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDPedidoItens.fdCDCECNPJ = dr["CDCECNPJ"].ToString();
                    bDPedidoItens.fdOPPDataContato = dr["OPPDataContato"].ToString();
                    bDPedidoItens.fdCDPDescricao = dr["CDPDescricao"].ToString();
                    bDPedidoItens.fdOPITPValorUnitario = dr["OPITPValorUnitario"].ToString();
                    bDPedidoItens.fdFatMinimo = dr["OPPVlrFatMinimo"].ToString();
                    bDPedidoItens.fdValidadeProposta = dr["OPPValidadeProposta"].ToString();
                    bDPedidoItens.fdOPITPValorTotalItem = dr["OPITPValorTotalItem"].ToString();
                    bDPedidoItens.fdOPITPQuantidade = dr["OPITPQuantidade"].ToString();
                    bDPedidoItens.fdImpInclu = dr["OPPImpostosInclusos"].ToString();
                    bDPedidoItens.fdEmail = dr["USEmail"].ToString();
                    bDPedidoItens.fdContato = dr["USContato"].ToString();
                    bDPedidoItens.fdPrazoEntrega = dr["OPPPrazoEntrega"].ToString();
                    bDPedidoItens.fdPrazoPagamento = dr["OPPPrazoPagamento"].ToString();


                    lstrelPedido.Add(bDPedidoItens);

                }

                //Desconectar
                conexao.desconectar();

            }
            catch (SqlException e)
            {

            }
            cmd.Dispose();

            return lstrelPedido;
        }
    }
}