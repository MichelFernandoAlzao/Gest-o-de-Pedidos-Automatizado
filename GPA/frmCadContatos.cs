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
    public partial class frmCadContatos : Form
    {
        string LCaminhoBanco = "";
        string LCadEmpresa = "";
        string LID = "";
        string LCargo = "";
        string LTelefone = "";
        string LEmail = "";
        string LNome = "";
        DateTime LAniversario;
        string LComprador = "";
        string Lgerencia = "";
        string LAnotacoes = "";

        public frmCadContatos(string inCaminhoBanco, string inIDEmpresa, string inCargo)
        {
            InitializeComponent();
            LCaminhoBanco = inCaminhoBanco;
            LCadEmpresa = inIDEmpresa;
            AtualizaGrid();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCargo.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtAniversario.Text = "";
            chkComprador.Checked = false;
            chkGerencia.Checked = false;
            LID = "";
            LCargo = null;
            LTelefone = "";
            LEmail = "";
            LComprador = "";
            Lgerencia = "";
            LAnotacoes = "";
        }

        private void AtualizaGrid()
        {
            grdContatos.Rows.Clear();
            List<BDCadContatos> lstContatos = new List<BDCadContatos>();
            BDCadContatos objContato = new BDCadContatos();
            lstContatos = objContato.CarregaDados(LCaminhoBanco, LCadEmpresa);
            if (lstContatos.Count > 0)
            {
                foreach (BDCadContatos item in lstContatos)
                {
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpNome.ToString(),
                            item.cpCargo.ToString(),
                            item.cpTelefone.ToString(),
                            item.cpEmail.ToString(),
                            item.cpAniversario.ToString(),
                            item.cpComprador.ToString(),
                            item.cpGerencia.ToString(),
                            item.cpAnotacoes.ToString()
                        };
                    grdContatos.Rows.Add(Row);
                }
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            string data = "";
            BDCadContatos objContato = new BDCadContatos();
            objContato.cpID = LID;
            if (LNome != txtNome.Text) objContato.cpNome = txtNome.Text.ToString();
            if (LCargo != txtCargo.Text) objContato.cpCargo = LCargo;
            if (LTelefone != txtTelefone.Text) objContato.cpTelefone = txtTelefone.Text.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            objContato.cpEmpresaDR = LCadEmpresa;
            if (LEmail != txtEmail.Text) objContato.cpEmail = txtEmail.Text.ToString();

            DateTime Data;
            if (DateTime.TryParse(txtAniversario.Text, out Data))
            {

                objContato.cpAniversario = txtAniversario.Text;
            }
            else
            {
                MessageBox.Show("Data em formato invalido", "GPA");
                return;
            }

            if (chkComprador.Checked == true)
            {
                objContato.cpComprador = "S";
            }
            else
            {
                objContato.cpComprador = "N";
            }

            if (chkGerencia.Checked == true)
            {
                objContato.cpGerencia = "S";
            }
            else
            {
                objContato.cpGerencia = "N";
            }

            objContato.cpAnotacoes = txtAnotacoes.Text;

            if (objContato.cpEmpresaDR != "" && LID == "")
            {
                objContato.InsereDados(LCaminhoBanco);
            }
            else
            {
                objContato.AlteraDados(LCaminhoBanco);
            }
            AtualizaGrid();
        }

        private void grdContatos_Selection(object sender, EventArgs e)
        {
            if (grdContatos.SelectedRows.Count == 0)
            {
                MostraDados();
            }
            else
            {
                LID = grdContatos.SelectedRows[0].Cells[0].Value.ToString();
                LNome = grdContatos.SelectedRows[0].Cells[1].Value.ToString();
                LCargo = grdContatos.SelectedRows[0].Cells[2].Value.ToString();
                LTelefone = grdContatos.SelectedRows[0].Cells[3].Value.ToString();
                LEmail = grdContatos.SelectedRows[0].Cells[4].Value.ToString();
                LAniversario = Convert.ToDateTime(grdContatos.SelectedRows[0].Cells[5].Value);
                LComprador = grdContatos.SelectedRows[0].Cells[6].Value.ToString();
                Lgerencia = grdContatos.SelectedRows[0].Cells[7].Value.ToString();
                LAnotacoes = grdContatos.SelectedRows[0].Cells[8].Value.ToString();
                MostraDados();
            }



        }

        private void MostraDados()
        {
            txtNome.Text = LNome;
            txtCargo.Text = LCargo;
            txtTelefone.Text = LTelefone;
            txtEmail.Text = LEmail;
            txtAniversario.Text = Convert.ToString(LAniversario);

            if (LComprador == "S")
            {
                chkComprador.Checked = true;
            }
            else
            {
                chkComprador.Checked = false;
            }

            if (Lgerencia == "S")
            {
                chkGerencia.Checked = true;
            }
            else
            {
                chkGerencia.Checked = false;
            }

            txtAnotacoes.Text = LAnotacoes;
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (LID == "") return;

            if (MessageBox.Show("Deseja excluir este contato permanentemente ?", "GPA", MessageBoxButtons.YesNo) == DialogResult.No) return;

            BDCadContatos objContato = new BDCadContatos();
            objContato.cpID = LID.ToString();
            objContato.Excluir(LCaminhoBanco);
            AtualizaGrid();
        }

        private void txtAniversario_Leave(object sender, EventArgs e)
        {
            if (txtAniversario.Text != "")
            {
                DateTime Datainicio;
                if (DateTime.TryParse(txtAniversario.Text, out Datainicio) == false)
                {
                    MessageBox.Show("Data Inicio em formato invalido", "GPA");
                    return;
                }
            }
        }
    }
}
