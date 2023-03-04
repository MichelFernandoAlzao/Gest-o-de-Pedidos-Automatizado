using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados
{
    public class BDItensPedido
    {
        public string cpPedidoDR { get; set; }

        public List<BDItensPedido> CarregaDados()
        {
            List<BDItensPedido> lstItensPedido = new List<BDItensPedido>();
            BDItensPedido objItem = new BDItensPedido();
            return lstItensPedido;
        }
    }
}
