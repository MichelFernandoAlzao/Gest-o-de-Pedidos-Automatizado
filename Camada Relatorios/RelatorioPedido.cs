using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Camada_Relatorios
{
    public class RelatorioPedido
    {
        public string fdOPPPedido { get; set; }
        public string fdOPPObservacao { get; set; }
        public string fdOPPVlrItensFaturando { get; set; }
        public string fdCDCERazaoSocial { get; set; }
        public string fdCDCECNPJ { get; set; }
        public string fdOPPDataContato { get; set; }
        public string fdCDPDescricao { get; set; }
        public string fdOPITPValorUnitario { get; set; }
        public string fdOPITPValorTotalItem { get; set; }
        public string fdOPITPQuantidade { get; set; }
        public string fdValidadeProposta { get; set; }
        public string fdFatMinimo { get; set; }
        public string fdPrazoPagamento { get; set; }
        public string fdPrazoEntrega { get; set; }
        public string fdImpostos { get;set; }
        public string fdImpInclu { get; set; }

        
    }
}
