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
    public partial class frmCRMInicial : Form
    {
        List<string> LParametros;
        public frmCRMInicial(string inParametros)
        {
            InitializeComponent();
            
            if (inParametros == "Michel")
            {
                HabilitaBotoes();
            }
        }

        public void HabilitaBotoes()
        {
            cmdCadastrosEmpresas.Enabled = true;
            cmdCadastroProduto.Enabled = true;
        }
        public void FuncoesTela()
        {
            BDCarregaAcessos objAcessos = new BDCarregaAcessos();
            objAcessos.CarregaAcessos(LParametros[1]);
            if(objAcessos.CadastroEmpresa == 'S') cmdCadastrosEmpresas.Enabled = true;
            if (objAcessos.CadastroProduto == 'S') cmdCadastroProduto.Enabled = true;
            if (objAcessos.Vendedor == 'S') cmdPedidos.Enabled = true;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCRMInicial_Load(object sender, EventArgs e)
        {

        }

        private void cmdCadastrosEmpresas_Click(object sender, EventArgs e)
        {
            GPA.frmCadEmpresas frmCadEmpresas = new GPA.frmCadEmpresas();
            frmCadEmpresas.ShowDialog();

        }

        private void cmdCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new frmCadProdutos();
            frmCadProdutos.ShowDialog();
        }

        private void cmdPedidos_Click(object sender, EventArgs e)
        {
            Pedido frmPedido = new Pedido();
            frmPedido.ShowDialog();
        }
    }
}
