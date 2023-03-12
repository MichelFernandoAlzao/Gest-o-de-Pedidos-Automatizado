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
        string LUsuario = "";
        public frmCRMInicial(string inUsuario)
        {
            InitializeComponent();

            LUsuario = inUsuario;

            SEGUsuario sEGUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = sEGUsuario.CarregaDados(inUsuario, "", "", "");
            labNomeUsuario.Text = lstUsuario[0].Nome;

            if (lstUsuario[0].Administrador == "S")
            {
                HabilitaBotoes();
            }
        }

        public void HabilitaBotoes()
        {
            cmdNatOperacao.Enabled = true;
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
            
            Pedido frmPedido = new Pedido(LUsuario,"");
            frmPedido.ShowDialog();
        }

        private void cmdRegistraContatos_Click(object sender, EventArgs e)
        {
            frmContatosEmpresas frmContatosEmpresas = new frmContatosEmpresas();
            frmContatosEmpresas.ShowDialog();
        }

        private void cmdConsultaPedido_Click(object sender, EventArgs e)
        {
            frmConsultaPedido frmConsultaPedido = new frmConsultaPedido();
            frmConsultaPedido.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUltimasVendas frmUltimasVendas = new frmUltimasVendas();
            frmUltimasVendas.ShowDialog();
        }

        private void CalendarioContatos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.LButton)
            {

            }
        }

        private void cmdNatOperacao_Click(object sender, EventArgs e)
        {
            frmNaturezaDaOperacao frmNatOperacao = new frmNaturezaDaOperacao(LUsuario);
            frmNatOperacao.ShowDialog();
        }
    }
}
