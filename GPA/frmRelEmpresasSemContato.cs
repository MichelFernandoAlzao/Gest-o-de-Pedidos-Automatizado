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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formularios
{
    public partial class frmRelEmpresasSemContato : Form
    {
        string LCaminhoBanco = "";
        string LUsuario = "";
        public string LIDUsuario = "";
        public string LPeriodo = "";
        string Ativo = "";
        string SContato = "N";
        public frmRelEmpresasSemContato(string inCaminhoBanco, string inUsuario)
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

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            string[] Proprelatorio =
                    {
                        "Formularios.Relatorios.EmpresassemContato.rdlc",
                        LIDUsuario.ToString(),
                        LPeriodo,
                        Ativo,
                        SContato
                    };
            frmRelatorios frmrelatorio = new frmRelatorios(LCaminhoBanco, Proprelatorio);
            frmrelatorio.ShowDialog();
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

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                Ativo = "S";
            }
            else
            {
                Ativo = "";
            }
        }

        private void txtDias_Leave(object sender, EventArgs e)
        {
            if (txtDias.Text == "")
            {
                txtDias.Text = "";
                LPeriodo = txtDias.Text;
            }
            else
            {
                LPeriodo = txtDias.Text.ToString();
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDias.Text, "  ^ [0-9]"))
            {
                txtDias.Text = "";
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkSemContato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemContato.Checked)
            {
                SContato = "S";
            }
            else
            {
                SContato = "N";
            }
        }

        private void txtVendedor_Leave(object sender, EventArgs e)
        {
            if (txtVendedor.Text == "")
            {
                LIDUsuario = "";
            }
        }
    }
}
