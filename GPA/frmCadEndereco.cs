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
    public partial class frmCadEndereco : Form
    {
        string LCadEmpresa = "";
        string LID = "";
        string LIdentificacao = "";
        string LRua = "";
        string LNumero = "";
        string LBairro = "";
        string LCidade = "";
        string LEstado = "";
        string LFisico = "";
        string LCobranca = "";
        string LReferencia = "";

        public frmCadEndereco(string inIDEmpresa)
        {
            InitializeComponent();
            LCadEmpresa = inIDEmpresa;
            grdEnderecos.Rows.Clear();
            AtualizaGrid();
            LID = grdEnderecos.Rows[0].Cells[0].Value.ToString();
            LIdentificacao = grdEnderecos.Rows[0].Cells[1].Value.ToString();
            LRua = grdEnderecos.Rows[0].Cells[2].Value.ToString();
            LNumero = grdEnderecos.Rows[0].Cells[3].Value.ToString();
            LBairro = grdEnderecos.Rows[0].Cells[4].Value.ToString();
            LCidade = grdEnderecos.Rows[0].Cells[5].Value.ToString();
            LEstado = grdEnderecos.Rows[0].Cells[6].Value.ToString();
            LReferencia = grdEnderecos.Rows[0].Cells[7].Value.ToString();
            LFisico = grdEnderecos.Rows[0].Cells[8].Value.ToString();
            LCobranca = grdEnderecos.Rows[0].Cells[9].Value.ToString();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtIdentificacao.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            chkEndFisico.Checked = false;
            chkEndCobranca.Checked = false;
            txtReferncia.Text = "";
            LID = "";
            LIdentificacao = "";
            LRua = "";
            LNumero = "";
            LBairro = "";
            LCidade = "";
            LEstado = "";
            LFisico = "";
            LCobranca = "";
            LReferencia = "";
        }

        private void AtualizaGrid()
        {

            List<BDCadEnderecos> lstEnderecos = new List<BDCadEnderecos>();
            BDCadEnderecos objEndereco = new BDCadEnderecos();
            lstEnderecos = objEndereco.CarregaDados(LCadEmpresa);
            if (lstEnderecos.Count > 0)
            {
                foreach (BDCadEnderecos item in lstEnderecos)
                {
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpIdentificacao.ToString(),
                            item.cpRua.ToString(),
                            item.cpNumero.ToString(),
                            item.cpBairro.ToString(),
                            item.cpCidade.ToString(),
                            item.cpEstado.ToString(),
                            item.cpReferencia.ToString(),
                            item.cpEndFisico.ToString(),
                            item.cpEndCobranca.ToString()
                        };
                    grdEnderecos.Rows.Add(Row);
                }
            }
            if (grdEnderecos.RowCount == 0)
            {
                txtIdentificacao.Text = "";
                txtRua.Text = "";
                txtNumero.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                chkEndFisico.Checked = false;
                chkEndCobranca.Checked = false;
                txtReferncia.Text = "";
                LID = "";
                LIdentificacao = "";
                LRua = "";
                LNumero = "";
                LBairro = "";
                LCidade = "";
                LEstado = "";
                LFisico = "";
                LCobranca = "";
                LReferencia = "";
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            string data = "";
            BDCadEnderecos objEndereco = new BDCadEnderecos();
            objEndereco.cpID = LID;
            objEndereco.cpCadastroDR = LCadEmpresa;
            if (LIdentificacao != txtIdentificacao.Text) objEndereco.cpIdentificacao = txtIdentificacao.Text.ToString();
            if (LRua != txtRua.Text) objEndereco.cpRua = txtRua.Text.ToString();
            if (LNumero != txtNumero.Text) objEndereco.cpNumero = txtNumero.Text.ToString();
            if (LBairro != txtBairro.Text) objEndereco.cpBairro = txtBairro.Text.ToString();
            if (LCidade != txtCidade.Text) objEndereco.cpCidade = txtCidade.Text.ToString();
            if (LEstado != txtEstado.Text) objEndereco.cpEstado = txtEstado.Text.ToString();


            if (chkEndFisico.Checked == true)
            {
                objEndereco.cpEndFisico = "S";
            }
            else
            {
                objEndereco.cpEndFisico = "N";
            }

            if (chkEndCobranca.Checked == true)
            {
                objEndereco.cpEndCobranca = "S";
            }
            else
            {
                objEndereco.cpEndCobranca = "N";
            }

            if (LReferencia != txtReferncia.Text) objEndereco.cpReferencia = txtReferncia.Text.ToString();

            if (objEndereco.cpCadastroDR != "" && LID == "")
            {
                objEndereco.InsereDados();
            }
            else
            {
                objEndereco.AlteraDados();
            }
            grdEnderecos.Rows.Clear();
            AtualizaGrid();
            MostraDados();
        }

        private void MostraDados()
        {
            if (grdEnderecos.RowCount == 0) return;


            txtIdentificacao.Text = LIdentificacao;
            txtRua.Text = LRua;
            txtNumero.Text = LNumero;
            txtBairro.Text = LBairro;
            txtCidade.Text = LCidade;
            txtEstado.Text = LEstado;

            if (LFisico == "S")
            {
                chkEndFisico.Checked = true;
            }
            else
            {
                chkEndFisico.Checked = false;
            }

            if (LCobranca == "S")
            {
                chkEndCobranca.Checked = true;
            }
            else
            {
                chkEndCobranca.Checked = false;
            }

            txtReferncia.Text = LReferencia;
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (LID == "") return;

            if (MessageBox.Show("Deseja excluir este endereço permanentemente ?", "GPA", MessageBoxButtons.YesNo) == DialogResult.No) return;

            BDCadEnderecos objEndereco = new BDCadEnderecos();
            objEndereco.cpID = LID.ToString();
            objEndereco.Excluir();
            grdEnderecos.Rows.Clear();
            AtualizaGrid();
        }

        private void grdEnderecos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdEnderecos.SelectedRows.Count == 0) return;
            LID = grdEnderecos.SelectedRows[0].Cells[0].Value.ToString();
            LIdentificacao = grdEnderecos.SelectedRows[0].Cells[1].Value.ToString();
            LRua = grdEnderecos.SelectedRows[0].Cells[2].Value.ToString();
            LNumero = grdEnderecos.SelectedRows[0].Cells[3].Value.ToString();
            LBairro = grdEnderecos.SelectedRows[0].Cells[4].Value.ToString();
            LCidade = grdEnderecos.SelectedRows[0].Cells[5].Value.ToString();
            LEstado = grdEnderecos.SelectedRows[0].Cells[6].Value.ToString();
            LReferencia = grdEnderecos.SelectedRows[0].Cells[7].Value.ToString();
            LFisico = grdEnderecos.SelectedRows[0].Cells[8].Value.ToString();
            LCobranca = grdEnderecos.SelectedRows[0].Cells[9].Value.ToString();
            MostraDados();
        }

        private void grdEnderecos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (grdEnderecos.SelectedRows.Count == 0)
            {
                MostraDados();
            }
            else
            {
                LID = grdEnderecos.SelectedRows[0].Cells[0].Value.ToString();
                LIdentificacao = grdEnderecos.SelectedRows[0].Cells[1].Value.ToString();
                LRua = grdEnderecos.SelectedRows[0].Cells[2].Value.ToString();
                LNumero = grdEnderecos.SelectedRows[0].Cells[3].Value.ToString();
                LBairro = grdEnderecos.SelectedRows[0].Cells[4].Value.ToString();
                LCidade = grdEnderecos.SelectedRows[0].Cells[5].Value.ToString();
                LEstado = grdEnderecos.SelectedRows[0].Cells[6].Value.ToString();
                LReferencia = grdEnderecos.SelectedRows[0].Cells[7].Value.ToString();

                MostraDados();
            }
        }
    }
}