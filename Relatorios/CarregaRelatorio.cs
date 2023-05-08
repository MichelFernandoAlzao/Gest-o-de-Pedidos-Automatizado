using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class CarregaRelatorio
    {
        public List<relPedido> CarregaRelatorioRDLC(string inCaminhoBanco, string inPedido)
        {
            DataTable DTPedido = new DataTable();
            string sSQL = "";

            sSQL += "SELECT OPPPedido,OPPObservacao,OPPVlritensFaturando,CDCERazaoSocial,CDCECNPJ,OPPDataContato,CDPDescricao,OPITPValorUnitario,OPITPValorTotalItem,OPITPQuantidade ";
            sSQL += "FROM OPItensPedido ";
            sSQL += "INNER JOIN OPPPedido ON OPITPPedidoDR = OPPPedido ";
            sSQL += "INNER JOIN CDCadastroEmpresas ON OPPEmpresaDR = CDCadastroEmpresas ";
            sSQL += "INNER JOIN CDProdutos ON OPITPProdutoDR = CDProdutos ";
            sSQL += "WHERE OPPPedido = " + inPedido;

            Conexao conexao = new Conexao(inCaminhoBanco);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sSQL;

            List<relPedido> lstrelPedido = new List<relPedido>();
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar o comando
                SqlDataReader reader = cmd.ExecuteReader();
                DTPedido.Load(reader);
                reader.Close();


                foreach (DataRow dr in DTPedido.Rows)
                {
                    relPedido bDPedidoItens = new relPedido();
                    bDPedidoItens.fdOPPPedido = dr["OPPPedido"].ToString();
                    bDPedidoItens.fdOPPObservacao = dr["OPPObservacao"].ToString();
                    bDPedidoItens.fdOPPVlritensFaturando = dr["OPPVlritensFaturando"].ToString();
                    bDPedidoItens.fdCDCERazaoSocial = dr["CDCERazaoSocial"].ToString();
                    bDPedidoItens.fdCDCECNPJ = dr["CDCECNPJ"].ToString();
                    bDPedidoItens.fdOPPDataContato = dr["OPPDataContato"].ToString();
                    bDPedidoItens.fdCDPDescricao = dr["CDPDescricao"].ToString();
                    bDPedidoItens.fdOPITPValorUnitario = dr["OPITPValorUnitario"].ToString();
                    bDPedidoItens.fdOPITPValorTotalItem = dr["OPITPValorTotalItem"].ToString();
                    bDPedidoItens.fdOPITPQuantidade = dr["OPITPQuantidade"].ToString();


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
