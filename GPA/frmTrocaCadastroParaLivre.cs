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
    public partial class frmTrocaCadastroParaLivre : Form
    {
        string LCaminhoBanco = "";
        public string LIDUsuario = "";
        public string LUsuario = "";
        public string LTipo = "";
        public string LIDCarteira = "";


        public frmTrocaCadastroParaLivre(string inCaminhoBanco, string inUsuario)
        {
            InitializeComponent();
            LCaminhoBanco = inCaminhoBanco;
            rchkVendedor.Checked = true;
            txtCarteira.Enabled = false;
            rchkLivre.Checked = true;
            LTipo = "S";
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmSelecionarUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, "", "");
                frmSelecionarUsuario.ShowDialog();
                if (LIDUsuario != "")
                {
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    if (lstUsuario.Count > 0)
                    {
                        txtVendedor.Text = lstUsuario[0].Usuario.ToString();
                    }
                }
                CarregaGridVendedor();
            }

        }

        private void rchkVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rchkVendedor.Checked)
            {
                txtCarteira.Text = "";
                txtVendedor.Text = "";
                LIDUsuario = "";
                LIDCarteira = "";
                txtVendedor.Enabled = true;
                txtCarteira.Enabled = false;
                grdEmpresasafetadas.Rows.Clear();
            }
            else
            {
                txtCarteira.Text = "";
                txtVendedor.Text = "";
                LIDUsuario = "";
                LIDCarteira = "";
                txtVendedor.Enabled = false;
                txtCarteira.Enabled = true;
                grdEmpresasafetadas.Rows.Clear();
            }
        }

        private void rchkLivre_CheckedChanged(object sender, EventArgs e)
        {
            if (rchkLivre.Checked)
            {
                LTipo = "S";
            }
            else
            {
                LTipo = "N";
            }
        }

        private void txtCarteira_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
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
                CarregaGridCarteira();
            }
        }
        public void CarregaGridVendedor()
        {
            grdEmpresasafetadas.Rows.Clear();

            if (LIDUsuario != "")
            {
                BDCadastroGeral objCadastro = new BDCadastroGeral();
                List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, "", "", "", "", "", LIDUsuario, "", "", "", "", "", "");


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
        public void CarregaGridCarteira()
        {
            grdEmpresasafetadas.Rows.Clear();

            if (LIDCarteira != "")
            {
                BDCadastroGeral objCadastro = new BDCadastroGeral();
                List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, "", "", "", "", "", "", "", "", "", "", "", LIDCarteira);


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

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            int QtdRegistros = 0;
            string Estado = "";
            if (LIDCarteira == "" && LIDUsuario == "")
            {
                MessageBox.Show("Nenhum Vendedor ou Carteira selecionado", "GPA - Aviso");
                return;
            }
            if (grdEmpresasafetadas.RowCount == 0)
            {
                MessageBox.Show("Nenhuma empresa passivel de alteração!", "GPA - Aviso");
                return;
            }
            QtdRegistros = grdEmpresasafetadas.RowCount;
            if (LTipo == "S")
            {
                Estado = "Livre";
            }
            else
            {
                Estado = "individual";
            }
            if (MessageBox.Show("Um total de " + QtdRegistros.ToString() + " serão passados para " + Estado + "\nDeseja prosseguir ?", "GPA - Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            BDCadastroGeral objCadastroGeral = new BDCadastroGeral();
            objCadastroGeral.PassaParaLivreIndividual(LCaminhoBanco, LTipo, LIDCarteira, LIDUsuario);    
            if (objCadastroGeral.MsgErro != "")
            {
                MessageBox.Show("Erro ao tentar alterar cadastros, contate o suporte!");
                return;
            }
            else
            {
                MessageBox.Show("Alteração realizada com sucesso!", "GPA - Aviso");
            }
            

        }
    }
}
