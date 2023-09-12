using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Relatorios
{
    public class VendasPorCliente
    {
        public string cpIDPedido { get; set; }
        public string cpRazaoSocial { get; set; }
        public string cpDataPedido { get; set; }
        public string cpDataConfirmacao { get; set; }
        public string cpVlrItensFaturando { get; set; }
        public string cpNatOperacao { get; set; }
        public string cpVendedor { get; set; }
        public string cpITPedidoDR { get; set; }
        public string cpProdDescricao { get; set; }
        public string cpITVlrUnitario { get; set; }
        public string cpQtdProduto { get; set; }
    }
}
