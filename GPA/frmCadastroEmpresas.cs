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
    public partial class frmCadastroEmpresas : Form
    {
        string LCaminhoBanco = "";
        string LUsuario = "";
        public string LIDUsuario = "";
        public string LIDCarteira = "";
        string Ativo = "";
        public frmCadastroEmpresas(string inCaminhoBanco, string inUsuario)
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
                        "Formularios.Relatorios.CadastrosDeEmpresas.rdlc",
                        LIDUsuario.ToString(),
                        LIDCarteira,
                        Ativo

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

        private void txtCarteira_KeyDown(object sender, KeyEventArgs e)
        {
            frmSelecionaCarteira frmSelecionaCarteira = new frmSelecionaCarteira(LCaminhoBanco, this, LUsuario);
            frmSelecionaCarteira.ShowDialog();
            if (LIDCarteira != "")
            {
                BDCagCarteira objCarteira = new BDCagCarteira();
                objCarteira.cpID = LIDCarteira;
                List<BDCagCarteira> lstCarteira = objCarteira.CarregaDados(LCaminhoBanco);
                if (lstCarteira.Count > 0)
                {
                    txtCarteira.Text = lstCarteira[0].cpDescricao.ToString();
                }
            }
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
    }
}
