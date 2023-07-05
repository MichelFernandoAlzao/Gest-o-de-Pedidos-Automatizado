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
        public string LIDProduto = "";
        public string LIDRegistro = "";
        string LDataContato = "";
        string LSugestoes = "";
        string LReclamacoes = "";
        string LVendedor = "";
        string LIDPRodContato = "";
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
            LID = "";
            LIDRegistro = "";
            LDataContato = "";
            LSugestoes = "";
            LReclamacoes = "";
            txtEmpresa.Text = "";
            txtDataContato.Text = "";
            txtSugestoes.Text = "";
            txtReclamacoes.Text = "";
            grdProdSugeridos.Rows.Clear();
            TxtContato2.Text = "";
            labCtt2.Visible = false;
            TxtContato2.Visible = false;
            TxtContato1.Text = "";
            labCtt1.Visible = false;
            TxtContato1.Visible = false;


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
            if (txtSugestoes.Text != "")
            {
                objContato.cpSugestao = txtSugestoes.Text;
            }
            if (txtReclamacoes.Text != "")
            {
                objContato.cpReclamacao = txtReclamacoes.Text;
            }
            objContato.cpUsuarioDR = LUsuario;

            if(txtSugestoes.Text.ToString().Replace(" ","") == "" && txtReclamacoes.Text.ToString().Replace(" ", "") == "")
            {
                MessageBox.Show("Nenhuma reclamação ou Sugestão informada, impossivel gravar!", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                LIDRegistro = objContato.cpID;
                txtRegistro.Text = LIDRegistro;
            }

            MostraDados();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDRegistroContato objRegContato = new BDRegistroContato();
            objRegContato.cpID = LIDRegistro;
            objRegContato.Excluir(LCaminhoBanco);
            LID = "";
            LIDRegistro = "";
            LDataContato = "";
            LSugestoes = "";
            LReclamacoes = "";
            txtEmpresa.Text = "";
            txtDataContato.Text = "";
            txtSugestoes.Text = "";
            txtReclamacoes.Text = "";
            txtRegistro.Text = "";
            grdProdSugeridos.Rows.Clear();
        }

        public void MostraDados()
        {
            BDRegistroContato objRegContato = new BDRegistroContato();
            objRegContato.cpID = LIDRegistro;
            List<BDRegistroContato> lstRegContato = objRegContato.CarregaDados(LCaminhoBanco);
            if (lstRegContato.Count > 0)
            {
                LID = lstRegContato[0].cpEmpresaDR;
                if (LID != "")
                {
                    BDCadastroGeral objEmpresa = new BDCadastroGeral();
                    List<BDCadastroGeral> lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, LID, "", "", "", "", "", "", "", "", "");
                    txtEmpresa.Text = lstEmpresa[0].RazaoSocial.ToString();
                }
            }
            txtRegistro.Text = lstRegContato[0].cpID.ToString();
            txtDataContato.Text = lstRegContato[0].cpDataContato.ToString().Substring(0, 10);
            txtSugestoes.Text = lstRegContato[0].cpSugestao.ToString();
            txtReclamacoes.Text = lstRegContato[0].cpReclamacao.ToString();

            CarregaGridProdutos();


        }

        private void cmdRemover_Click(object sender, EventArgs e)
        {
            if (LIDPRodContato == "")
            {
                MessageBox.Show("Nenhum Produto selecionado", "GPA");
                return;
            }
            BDProdutosContato objProdutoContato = new BDProdutosContato();
            objProdutoContato.cpID = LIDPRodContato;
            objProdutoContato.Excluir(LCaminhoBanco);
            if (objProdutoContato.cpMsgErro != "")
            {
                MessageBox.Show(objProdutoContato.cpMsgErro, "GPA");
                return;
            }
            else
            {
                MessageBox.Show("Exclusão Realizada");
            }

            CarregaGridProdutos();
        }

        public void CarregaGridProdutos()
        {
            grdProdSugeridos.Rows.Clear();
            BDProdutosContato objProdContato = new BDProdutosContato();
            objProdContato.cpRegContatoDR = LIDRegistro;
            List<BDProdutosContato> lstProdContato = objProdContato.CarregaDados(LCaminhoBanco);

            if (lstProdContato.Count > 0)
            {
                foreach (BDProdutosContato item in lstProdContato)
                {
                    string DescProduto;
                    BDCadProdutos objProduto = new BDCadProdutos();
                    objProduto.cpID = item.cpProdutoDR;
                    List<BDCadProdutos> lstProduto = objProduto.CarregaDados(LCaminhoBanco);
                    string[] Row = new string[]
                    {
                            item.cpID.ToString(),
                            lstProduto[0].cpDescricao.ToString(),
                            item.cpValorOfertado.ToString(),
                            item.cpQuantidade.ToString()
                    };
                    grdProdSugeridos.Rows.Add(Row);
                }
            }
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            if (LIDRegistro == "")
            {
                MessageBox.Show("Nenhum registro selecionado!", "GPA");
                return;
            }

            if (LIDProduto == "")
            {
                MessageBox.Show("Nenhum Produto selecionado!", "GPA");
                return;
            }
            BDProdutosContato objProdContato = new BDProdutosContato();
            objProdContato.cpProdutoDR = LIDProduto;
            objProdContato.cpRegContatoDR = LIDRegistro;
            objProdContato.cpValorOfertado = txtValorOfertado.Text;
            objProdContato.cpQuantidade = txtQuantidade.Text;

            objProdContato.InsereDados(LCaminhoBanco);

            txtDescProduto.Text = "";
            txtValorOfertado.Text = "";
            txtQuantidade.Text = "";

            CarregaGridProdutos();
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaProduto objSelecProduto = new frmSelecionaProduto(LCaminhoBanco, this, "", txtDescProduto.Text, "", "");
                objSelecProduto.ShowDialog();
                if (LIDProduto != "")
                {
                    BDCadProdutos objProduto = new BDCadProdutos();
                    objProduto.cpID = LIDProduto;
                    List<BDCadProdutos> lstProduto = objProduto.CarregaDados(LCaminhoBanco);
                    txtDescProduto.Text = lstProduto[0].cpDescricao.ToString();
                }
            }
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtEmpresa.Text.ToString(), "", "", LUsuario,"","","");
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

        private void frmContatosEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void grdProdSugeridos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdProdSugeridos.SelectedRows.Count == 0)
            {
                return;
            }
            LIDPRodContato = grdProdSugeridos.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void txtRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarRegistroContato frmSelecionarRegistroContato = new frmSelecionarRegistroContato(LCaminhoBanco, this, txtRegistro.Text);
                frmSelecionarRegistroContato.ShowDialog();
                if (LIDRegistro != "")
                {
                    MostraDados();
                }
            }

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
