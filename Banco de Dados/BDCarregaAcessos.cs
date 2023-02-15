using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_Dados
{
    public class BDCarregaAcessos
    {   
        public char CadastroEmpresa { get; set; }
        public char CadastroProduto { get; set; }
        public char Vendedor { get; set; }
        List<string> LParametros;

        public void CarregaAcessos(string inParametros)
        {
            LParametros[1] = inParametros;
            string cmdSQL;
            cmdSQL = "SELECT * FROM SEGAcessos";
            cmdSQL += "WHER ";

        }
    }

}
