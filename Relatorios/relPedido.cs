﻿using Banco_de_Dados;
using System.Data;
using System.Globalization;
using Banco_de_Dados;
using DAL;
using System.Reflection.Metadata.Ecma335;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class relPedido
    {
        public string fdOPPPedido { get; set; }
        public string fdOPPObservacao { get; set; }
        public string fdOPPVlritensFaturando { get; set; }
        public string fdCDCERazaoSocial { get; set; }
        public string fdCDCECNPJ { get; set; }
        public string fdOPPDataContato { get; set; }
        public string fdCDPDescricao { get; set; }
        public string fdOPITPValorUnitario { get; set; }
        public string fdOPITPValorTotalItem { get; set; }
        public string fdOPITPQuantidade { get; set; }




    }
}