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
    public partial class frmContatosEmpresas : Form
    {
        string LCaminhoBanco;
        public string LID = "";
        public string LRazaoSocial = "";
        public string LIDRegistro = "";
        public string LIDRegistroSelecionado = "";
        string LDataContato = "";
        string LRegistro = "";
        string LVendedor = "";
        string LUsuario = "";

        public frmContatosEmpresas(string inCaminhoBanco, string inUsuario)
        {
            LCaminhoBanco = inCaminhoBanco;
            LUsuario = inUsuario;
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LIDRegistro = "";
            LDataContato = "";
            txtRegistro.Text = "";
            txtDataContato.Text = "";
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDRegistroContato objContato = new BDRegistroContato();
            if (LID == "")
            {
                MessageBox.Show("Nenhumna Empresa selcionada!", "GPA");
                return;
            }
            objContato.cpEmpresaDR = LID;

            DateTime DataContato;
            if (DateTime.TryParse(txtDataContato.Text.ToString(), out DataContato))
            {
                objContato.cpDataContato = DataContato.ToString();
            }
            else
            {
                MessageBox.Show("Data em formato invalido", "GPA");
                return;
            }
            if (txtRegistro.Text != "")
            {
                objContato.cpRegistro = txtRegistro.Text;
            }
            objContato.cpUsuarioDR = LUsuario;

            if (txtRegistro.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nenhum texto inserido no registro, impossivel gravar!", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (txtRegistro.Text.Length > 1000)
            {
                MessageBox.Show("Registro com mais de 1000 caracteres, impossivel gravar!", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            if (LIDRegistro == "")
            {
                objContato.InsereDados(LCaminhoBanco);
                if (objContato.cpMsgErro != "" && objContato.cpMsgErro != null)
                {
                    MessageBox.Show(objContato.cpMsgErro, "GPA");
                    return;
                }
            }
            else
            {
                objContato.cpID = LIDRegistro;
                objContato.AlteraDados(LCaminhoBanco);
                if (objContato.cpMsgErro != "" && objContato.cpMsgErro != null)
                {
                    MessageBox.Show(objContato.cpMsgErro, "GPA");
                    return;
                }
            }

            if (objContato.cpID != "")
            {
                MessageBox.Show("Registro Gravado com Sucesso!", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CarregaGridRegistros();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (grdRegistros.RowCount == 0) return;
            BDRegistroContato objRegContato = new BDRegistroContato();
            objRegContato.cpID = grdRegistros.SelectedRows[0].Cells[0].Value.ToString();
            objRegContato.Excluir(LCaminhoBanco);
            LIDRegistro = "";
            LDataContato = "";
            LRegistro = "";
            txtDataContato.Text = "";
            txtRegistro.Text = "";
            CarregaGridRegistros();
        }

        public void CarregaGridRegistros()
        {
            grdRegistros.Rows.Clear();
            BDRegistroContato objregistroContato = new BDRegistroContato();
            objregistroContato.cpEmpresaDR = LID;
            List<BDRegistroContato> lstRegistrosporEmpresa = objregistroContato.CarregaDados(LCaminhoBanco);

            if (lstRegistrosporEmpresa.Count > 0)
            {
                foreach (BDRegistroContato registro in lstRegistrosporEmpresa)
                {
                    string[] Row = new string[]
                    {
                            registro.cpID.ToString(),
                            registro.cpDataContato.ToString(),
                            registro.cpRegistro.ToString()
                    };
                    grdRegistros.Rows.Add(Row);
                }
            }
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                TxtContato2.Text = "";
                labCtt2.Visible = false;
                TxtContato2.Visible = false;
                TxtContato1.Text = "";
                labCtt1.Visible = false;
                TxtContato1.Visible = false;
                txtRegistro.Text = "";
                grdRegistros.Rows.Clear();
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtEmpresa.Text.ToString(), "", "", LUsuario, "", "", "");
                objTela.ShowDialog();
                if (LRazaoSocial != "")
                {
                    txtEmpresa.Text = LRazaoSocial;

                    BDCadContatos objContato = new BDCadContatos();
                    List<BDCadContatos> lstContatos = objContato.CarregaDados(LCaminhoBanco, LID);
                    if (lstContatos.Count > 0)
                    {
                        TxtContato1.Text = lstContatos[0].cpTelefone.ToString();
                        labCtt1.Visible = true;
                        TxtContato1.Visible = true;
                    }
                    if (lstContatos.Count > 1)
                    {
                        TxtContato2.Text = lstContatos[1].cpTelefone.ToString();
                        labCtt2.Visible = true;
                        TxtContato2.Visible = true;
                    }
                    CarregaGridRegistros();
                }
            }
        }

        private void frmContatosEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void grdRegistros_SelectionChanged(object sender, EventArgs e)
        {
            if (grdRegistros.SelectedRows.Count == 0)
            {
                return;
            }
            LIDRegistroSelecionado = grdRegistros.SelectedRows[0].Cells[0].Value.ToString();
            BDRegistroContato objRegistro = new BDRegistroContato();
            objRegistro.cpID = LIDRegistroSelecionado;
            List<BDRegistroContato> lstRegistro = objRegistro.CarregaDados(LCaminhoBanco);
            txtTranscricao.Text = lstRegistro[0].cpRegistro.ToString();
        }


        private void txtDataContato_Leave(object sender, EventArgs e)
        {
            if (txtDataContato.Text == "  /  /")
            {
                txtDataContato.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataContato.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    txtDataContato.Text = "";
                    return;
                }
            }
        }

        private void cmdContatos_Click(object sender, EventArgs e)
        {
            if (LID == "")
            {
                MessageBox.Show("Nenhuma empresa selecionada!", "GPA");
                return;
            }
            frmCadContatos objTela = new frmCadContatos(LCaminhoBanco, LID, "");
            objTela.ShowDialog();

            if (LRazaoSocial != "")
            {
                txtEmpresa.Text = LRazaoSocial;

                BDCadContatos objContato = new BDCadContatos();
                List<BDCadContatos> lstContatos = objContato.CarregaDados(LCaminhoBanco, LID);
                if (lstContatos.Count > 0)
                {
                    TxtContato1.Text = lstContatos[0].cpTelefone.ToString();
                    labCtt1.Visible = true;
                    TxtContato1.Visible = true;
                }
                if (lstContatos.Count > 1)
                {
                    TxtContato2.Text = lstContatos[1].cpTelefone.ToString();
                    labCtt2.Visible = true;
                    TxtContato2.Visible = true;
                }
            }
        }
    }
}
