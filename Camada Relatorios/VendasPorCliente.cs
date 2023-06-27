using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Relatorios
{
    public class VendasPorCliente
    {
        public string IDPedido { get; set; }
        public string RazaoSocial { get; set; }
        public string DataPedido { get; set; }
        public string DataConfirmacao { get; set; }
        public string VlrItensFaturando { get; set; }
        public string NatOperacao { get; set; }
        public string Vendedor { get; set; }
    }
}
