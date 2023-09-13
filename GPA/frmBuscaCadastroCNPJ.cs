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
using GPA;

namespace Formularios
{
    public partial class frmBuscaCadastroCNPJ : Form
    {
        string LUsusario = "";
        string LCaminhoBanco = "";
        public frmBuscaCadastroCNPJ(string inCmainhoBanco, string inUsuario)
        {
            LUsusario = inUsuario;
            LCaminhoBanco = inCmainhoBanco;
            InitializeComponent();
        }

        private void Buscar()
        {
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, "", txtRazaoSocial.Text.ToString(), "", txtCNPJ.Text.ToString(), "", "", "", "", "", "","","");
            if (lstCadastro.Count > 0)
            {
                if (lstCadastro[0].Vendedor == LUsusario)
                {
                    frmCadEmpresas frmMostraCadastro = new frmCadEmpresas(LCaminhoBanco, LUsusario, lstCadastro[0].Id.ToString());
                    frmMostraCadastro.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Empresa ja cadastrada por outro vendedor", "GPA");
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Empresa não possui cadastro ainda, deseja cadastrar ?", "GPA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmCadEmpresas objCadastraEmpresa = new frmCadEmpresas(LCaminhoBanco, LUsusario, "");
                    objCadastraEmpresa.ShowDialog();
                }
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtRazaoSocial.Text = "";
                Buscar();
            }

        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtCNPJ.Text = "";
                Buscar();
            }

        }
    }
}
