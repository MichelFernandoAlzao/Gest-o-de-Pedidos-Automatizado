using Banco_de_Dados;
using GPA;
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
    public partial class frmMeusClientes : Form
    {
        string LCaminhoBanco = "";
        string LUsuario = "";
        string LID = "";
        public frmMeusClientes(string inCaminhoBanco, string inUsuario)
        {
            LCaminhoBanco = inCaminhoBanco;
            LUsuario = inUsuario;
            InitializeComponent();
            VerificaPermissao();
            CarregaGridClientes();
        }

        public void VerificaPermissao()
        {
            SEGUsuario objUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco,LUsuario,"","","");

            if (lstUsuario[0].GerenciaCadastros == "N")
            {
                chkGerencia.Enabled = false;
            }
        }
        public void CarregaGridClientes()
        {
            string AuxVendedor = "";
            if(chkGerencia.Checked == true)
            {
                AuxVendedor = "";
            }
            else
            {
                AuxVendedor = LUsuario;
            }
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            if (txtRazaoSocial.Text != "")
            {
                objCadastro.RazaoSocial = txtRazaoSocial.Text;

            }
            List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDadosPorVendedor(LCaminhoBanco, AuxVendedor);
            if (lstCadastro.Count > 0)
            {
                foreach (BDCadastroGeral item in lstCadastro)
                {
                    string[] Row = new string[]
                        {
                            item.Id.ToString(),
                            item.RazaoSocial.ToString(),
                            item.CNPJ.ToString(),
                        };
                    grdMeusClientes.Rows.Add(Row);
                }
            }
        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                grdMeusClientes.Rows.Clear();
                CarregaGridClientes();
            }
        }

        private void cmdSelecionar_Click(object sender, EventArgs e)
        {
            if (grdMeusClientes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma empresa carregada na grade!", "GPA");
                return;
            }

            frmCadEmpresas frmCadastroGeral = new frmCadEmpresas(LCaminhoBanco, LUsuario, grdMeusClientes.SelectedRows[0].Cells[0].Value.ToString());
            frmCadastroGeral.ShowDialog();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdMeusClientes_DoubleClick(object sender, EventArgs e)
        {
            cmdSelecionar_Click(sender, e);
        }

        private void frmMeusClientes_Load(object sender, EventArgs e)
        {

        }

        private void chkGerencia_CheckedChanged(object sender, EventArgs e)
        {
            grdMeusClientes.Rows.Clear();
            CarregaGridClientes();
        }
    }
}
