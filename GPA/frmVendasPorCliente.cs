using Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmVendasPorCliente : Form
    {
        string LCaminhoBanco = "";
        public string LID = "";
        public string LRazaoSocial = "";
        string LUsuario = "";
        string LDataInicial = "";
        string LDataFinal = "";
        public string LIDUsuario = "";
        public frmVendasPorCliente(string inCaminhoBanco, string inUsuario)
        {
            InitializeComponent();
            LCaminhoBanco = inCaminhoBanco;
            LUsuario = inUsuario;

            SEGUsuario objUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LUsuario, "", "", "");
            if (lstUsuario[0].GerenciaCadastros != "S")
            {
                txtVendedor.Enabled = false;
                LIDUsuario = LUsuario;
                txtVendedor.Text = lstUsuario[0].Usuario;

            }
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtEmpresa.Text.ToString(), "", "", LUsuario);
                objTela.ShowDialog();
            }
            if(LID != "")
            {
                txtEmpresa.Text = LRazaoSocial;
            }
        }

        private void txtDataInicial_Leave(object sender, EventArgs e)
        {
            if (txtDataInicial.Text == "  /  /")
            {
                txtDataInicial.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataInicial.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data inicial em formato invalido", "GPA");
                    txtDataInicial.Text = "";
                    return;
                }
            }
        }

        private void txtDataFinal_Leave(object sender, EventArgs e)
        {
            if (txtDataFinal.Text == "  /  /")
            {
                txtDataFinal.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataFinal.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data final em formato invalido", "GPA");
                    txtDataFinal.Text = "";
                    return;
                }
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, "", txtVendedor.Text.ToString());
                frmUsuario.ShowDialog();

                if (LIDUsuario != "")
                {
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    txtVendedor.Text = lstUsuario[0].Usuario;
                }
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
