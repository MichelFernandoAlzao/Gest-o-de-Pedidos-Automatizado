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
        string LCadEmpresa;
        string LID;
        string LCargo;
        string LTelefone;
        string LEmail;
        string LNome;
        DateTime LAniversario;
        string LComprador;
        string Lgerencia;
        string LAnotacoes;

        public frmCadContatos(string inIDEmpresa,string inCargo)
        {
            InitializeComponent();
            LCadEmpresa = inIDEmpresa;
            LID = inCargo;
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
            LCargo = "";
            LTelefone = "";
            LEmail = "";
            LComprador = "";
            Lgerencia = "";
            LAnotacoes = "";
        }

        private void AtualizaGrid()
        {
            List<BDCadContatos> lstContatos = new List<BDCadContatos>();
            BDCadContatos objContato = new BDCadContatos();
            lstContatos =  objContato.CarregaDados(LCadEmpresa);
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
            BDCadContatos objContato = new BDCadContatos();
            objContato.cpID = LID;
            objContato.cpNome = txtNome.Text.ToString();
            objContato.cpCargo = LCargo;
            objContato.cpTelefone = txtTelefone.Text.ToString();
            objContato.cpEmpresaDR = LCadEmpresa;
            objContato.cpEmail = txtEmail.Text.ToString();
            string data = txtAniversario.Text.Substring(0, 2) + "/" + txtAniversario.Text.Substring(2, 2) + "/" + txtAniversario.Text.Substring(4, 4);
            if (Convert.ToDateTime(data) is DateTime)
            {

                objContato.cpAniversario = Convert.ToDateTime(data);
            }
            else
            {
                MessageBox.Show("Data em formato invalido", "GPA");
                return;
            }
            
            if(chkComprador.Checked == true)
            {
                objContato.cpComprador = "S";
            }
            else
            {
                objContato.cpComprador = "N";
            }
            
            if(chkGerencia.Checked == true)
            {
                objContato.cpGerencia = "S";
            }
            else
            {
                objContato.cpGerencia = "N";
            }
            
            objContato.cpAnotacoes = LAnotacoes;

            if(objContato.cpEmpresaDR != "" && LID == "")
            {
                objContato.InsereDados();
            }
            else
            {
                objContato.AlteraDados(objContato);
            }
            AtualizaGrid();
        }

        private void grdContatos_SelectionChanged(object sender, EventArgs e)
        {
            LNome = grdContatos.SelectedRows[0].Cells[1].Value.ToString();
            LCargo = grdContatos.SelectedRows[0].Cells[2].Value.ToString();
            LTelefone = grdContatos.SelectedRows[0].Cells[3].Value.ToString();
            LEmail = grdContatos.SelectedRows[0].Cells[4].Value.ToString();
            LAniversario = Convert.ToDateTime(grdContatos.SelectedRows[0].Cells[5].Value);
            LComprador = grdContatos.SelectedRows[0].Cells[6].Value.ToString();
            Lgerencia = grdContatos.SelectedRows[0].Cells[6].Value.ToString();
            LAnotacoes = grdContatos.SelectedRows[0].Cells[7].Value.ToString();

            MostraDados();
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
    }
}
