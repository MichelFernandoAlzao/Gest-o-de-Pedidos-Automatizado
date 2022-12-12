using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_Dados;

namespace Formularios
{
    public partial class SelecionaEmpresa : Form
    {
        private string Razao;
        public SelecionaEmpresa(string razao)
        {
            InitializeComponent();
            Razao = razao;
        }

        private void SelecionaEmpresa_Load(object sender, EventArgs e)
        {
            CarregaEmpresa(Razao);
        }

        private void CarregaEmpresa(string razao)
        {
            BDCadastroGeral bDCadastro = new BDCadastroGeral();
            bDCadastro.CarregaDados("", Razao, "","","","",' ',' ',' ',"","");
        }
    }
}
