using System;
using System.Globalization;

namespace Camada_de_tratamento_de_Valores
{
    public class FormataValores
    {
        public string FormataVlrBRL(string inValor)
        {
            if (decimal.TryParse(inValor, out decimal ValorDecimal))
            {
                CultureInfo culture = new CultureInfo("pt-BR");
                return ValorDecimal.ToString("C", culture);
            }

            return "Valor inválido";
        }
    }
}
