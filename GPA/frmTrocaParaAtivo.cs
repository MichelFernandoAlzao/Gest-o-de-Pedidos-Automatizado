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
    public partial class frmTrocaParaAtivo : Form
    {
        string LCaminhoBanco = "";
        string LUsuario = "";
        public string LIDUsuario = "";
        string LVendedorAnterior = "";
        string LNovoVendedor = "";
        public frmTrocaParaAtivo(string inCaminhoBanco, string inUsuario)
        {
            LCaminhoBanco = inCaminhoBanco;
            LUsuario = inUsuario;
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            int Linhas = 0;
            if (LVendedorAnterior == "")
            {
                MessageBox.Show("Vendedor anterior não selecionado!");
                return;
            }
            if (LNovoVendedor == "")
            {
                MessageBox.Show("Novo vendedor não selecionado!");
                return;
            }

            Linhas = grdEmpresasafetadas.Rows.Count;

            if (Linhas == 0)
            {
                MessageBox.Show("Nenhuma empresa localizada para alterar!");
                return;
            }
            else
            {
                if (MessageBox.Show("Um total de " + Linhas + " cadastros serão afetados, deseja continuar ?", "GPA - Altera Vendedor!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            BDCadastroGeral objCadastro = new BDCadastroGeral();
            objCadastro.AlteraVendedor(LCaminhoBanco, LVendedorAnterior, LNovoVendedor);
            if (objCadastro.MsgErro != "")
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os cadastros, verifique!");
                return;
            }
            else
            {
                MessageBox.Show("Alteração realizada com suscesso, verifique os cadastros!");
            }
        }

        private void txtVendedorAnterior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmSelecionarUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, "", "");
                frmSelecionarUsuario.ShowDialog();
                if (LIDUsuario != "")
                {
                    LVendedorAnterior = LIDUsuario;
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    if (lstUsuario.Count > 0)
                    {
                        txtVendedorAnterior.Text = lstUsuario[0].Usuario.ToString();
                    }
                }
                LIDUsuario = "";
            }
        }

        private void txtNovoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmSelecionarUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, "", "");
                frmSelecionarUsuario.ShowDialog();
                if (LIDUsuario != "")
                {
                    LNovoVendedor = LIDUsuario;
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    if (lstUsuario.Count > 0)
                    {
                        txtNovoVendedor.Text = lstUsuario[0].Usuario.ToString();
                    }
                }
                CarregaGrid();
                LIDUsuario = "";
            }
        }
        public void CarregaGrid()
        {
            grdEmpresasafetadas.Rows.Clear();

            if (LVendedorAnterior != "")
            {
                BDCadastroGeral objCadastro = new BDCadastroGeral();
                List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, "", "", "", "", "", LVendedorAnterior, "", "", "", "", "","");


                foreach (BDCadastroGeral Cadastro in lstCadastro)
                {
                    string[] Row = new string[]
                        {
                            Cadastro.Id,
                            Cadastro.RazaoSocial

                        };
                    grdEmpresasafetadas.Rows.Add(Row);
                }
            }
        }
    }
}
