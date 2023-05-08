using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco_de_Dados;

namespace Camada_Negocios
{
    public class claNCalculaProduto
    {
        string LCaminhoBanco;
        public string ValorUnit { get; set; }
        public string Quantidade { get; set; }
        public string ValroFornecedor { get; set; }
        public string TipoCalculo { get; set; }



        public string CalculaProduto(string inValorUnit,string inQuantidade, string inValorForencedor)
        {
            string ValorTotal;
            ValorTotal = Convert.ToString((Convert.ToDouble(inValorUnit) * Convert.ToInt32(inQuantidade)));
            return ValorTotal;
        }

        public void CalculaTotalItens(string inPedidoDR,string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            double pTotalPedido = 0;
            BDItensPedido objItens = new BDItensPedido();
            objItens.cpPedidoDR = inPedidoDR;
            List<BDItensPedido> lstItens = objItens.CarregaDados(LCaminhoBanco);
            if(lstItens.Count > 0)
            {
                foreach(BDItensPedido obj in lstItens)
                {
                    pTotalPedido = pTotalPedido + Convert.ToDouble(obj.cpValorTotalItem);
                }
                BDPedido objPedido = new BDPedido();
                objPedido.cpID = inPedidoDR;
                objPedido.cpVlrTotalPedido = Convert.ToString(pTotalPedido).Replace(",",".");
                objPedido.AlteraDados(LCaminhoBanco);

            }
        }

        public void CalculaTotalFaturando(string inPedidoDR,string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            double pTotalFaturando = 0;
            BDItensPedido objItens = new BDItensPedido();
            objItens.cpPedidoDR = inPedidoDR;
            List<BDItensPedido> lstItens = objItens.CarregaDados(LCaminhoBanco);
            if (lstItens.Count > 0)
            {
                foreach (BDItensPedido obj in lstItens)
                {
                    if(obj.cpFatura != "S")
                    {
                        continue;
                    }
                    pTotalFaturando = pTotalFaturando + Convert.ToDouble(obj.cpValorTotalItem);
                }
                BDPedido objPedido = new BDPedido();
                objPedido.cpID = inPedidoDR;
                objPedido.cpVlrItensFaturando = Convert.ToString(pTotalFaturando).Replace(",", ".");
                objPedido.AlteraDados(LCaminhoBanco);

            }


        }
    }
}
