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
    public partial class frmCadProdutos : Form
    {
        string LDescricao;
        string LCodigo;
        string LDataCadastro;
        string LCodigoFabricante;
        string LDescricaoFornecedor;
        int LFabricante;
        int LMelhorFornecedor;
        bool LAtivo;
        bool LOperacional;
        bool LForaDeLinha;
        string LDescritivo;
        string LID;
        string LRazaoSocial;

        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LDescricao = "";
            LCodigo = "";
            LDataCadastro = "";
            LCodigoFabricante = "";
            LDescricaoFornecedor = "";
            LFabricante = 0;
            LMelhorFornecedor=0;
            LAtivo = false;
            LOperacional = false;
            LForaDeLinha = false;
            LDescritivo = "";
            txtDescricao.Text = "";
            txtCodigo.Text = "";
            txtDataCadastro.Text = "";
            txtCodFabricante.Text = "";
            txtDescFornecedor.Text = "";
            txtFabricante.Text = "";
            txtMelhorFornecedor.Text = "";
            chkAtivo.Checked = false;
            chkOperacional.Checked = false;
            chkForadeLinha.Checked = false;
            txtDescritivo.Text = "";

        }

        public void AtualizaCampos()
        {
            txtDescricao.Text = LDescricao;
            txtCodigo.Text = LCodigo;
            txtDataCadastro.Text = LDataCadastro;
            txtCodFabricante.Text = LCodigoFabricante;
            txtDescFornecedor.Text = LDescricaoFornecedor;
            txtDescFornecedor.Text = LDescricaoFornecedor;
            if (LFabricante != 0)
            {
                BDCadastroGeral objFabricante = new BDCadastroGeral();
                List<BDCadastroGeral> lstFabricante = new List<BDCadastroGeral>();
                lstFabricante = objFabricante.CarregaDados(Convert.ToString(LFabricante), "", "", "", "", "", "", "", "", "");
                txtFabricante.Text = lstFabricante[0].RazaoSocial.ToString();
            }
            else txtFabricante.Text = "";

            if (LFabricante != 0)
            {
                BDCadastroGeral objFornecedor = new BDCadastroGeral();
                List<BDCadastroGeral> lstFornecedor = new List<BDCadastroGeral>();
                lstFornecedor = objFornecedor.CarregaDados(Convert.ToString(LFabricante), "", "", "", "", "", "", "", "", "");
                txtMelhorFornecedor.Text = lstFornecedor[0].RazaoSocial.ToString();
            }
            else txtMelhorFornecedor.Text = "";

        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDescricao.Text.Length < 5)
            {
                MessageBox.Show("Digite um minimo de 5 caracteres!", "GPA");
            }
            if (e.KeyCode == Keys.F1)
            {

            }
        }

        private void txtFabricante_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFabricante.Text.Length < 5)
            {
                MessageBox.Show("Digite um minimo de 5 caracteres!", "GPA");
            }
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this,"",txtFabricante.Text.ToString(), "", "");
                objTela.ShowDialog();
                LFabricante = Convert.ToInt32(LID);
                txtFabricante.Text = LRazaoSocial.ToString();
            }
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {

        }

        private void txtMelhorFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtMelhorFornecedor.Text.Length < 5)
            {
                MessageBox.Show("Digite um minimo de 5 caracteres!","GPA");
            }
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this, "", txtMelhorFornecedor.Text.ToString(), "", "");
                objTela.ShowDialog();
                LFabricante = Convert.ToInt32(LID);
                txtFabricante.Text = LRazaoSocial.ToString();
            }
        }
    }
}
