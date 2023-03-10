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
    public partial class frmItensPedido : Form
    {
        string LIDITPedido = "";
        public string LIDProduto = "";
        string LValor = "";
        string LQuantidade = "";
        string LLote = "";
        string Lornecedor = "";

        public frmItensPedido(string inIDPedido)
        {
            InitializeComponent();
        }

        private void frmItensPedido_Load(object sender, EventArgs e)
        {

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {

        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtDescProduto.Text = "";
            txtQuantidade.Text = "";
            txtLote.Text = "";
            txtValor.Text = "";
            txtFornecedor.Text = "";
            lbTotalItem.Text = "XXXX,XX";
            lbVlrPraticado1.Text = "XXXX,XX";
            lbVlrPraticado2.Text = "XXXX,XX";
            lbVlrPraticado3.Text = "XXXX,XX";
            lbVlrPraticado4.Text = "XXXX,XX";
            LIDProduto = "";
            LQuantidade = "";
            LLote = "";
            LValor = "";
            Lornecedor = "";
            
        }

        private void txtDescProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                frmSelecionaProduto objSelecProduto = new frmSelecionaProduto(this, "", txtDescProduto.Text, "", "");
                objSelecProduto.ShowDialog();
                if(LIDProduto != "")
                {
                    BDCadProdutos objProduto = new BDCadProdutos();
                    objProduto.cpID = LIDProduto;
                    List<BDCadProdutos> lstProduto = objProduto.CarregaDados();
                    txtDescProduto.Text = lstProduto[0].cpDescricao.ToString();
                }
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if(txtQuantidade.Text == "")
            {
                MessageBox.Show("Quantidade invalida", "GPA");
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text.Length < 4)
            {
                MessageBox.Show("Valor em formato invalido", "GPA");
                return;
            }
            double Valor;
            if (Double.TryParse(txtValor.Text, out Valor))
            {
                txtValor.Text = Valor.ToString();
            }
            
        }

        public void MostraDados()
        {
            BDItensPedido objITPedido = new BDItensPedido();
            //objITPedido
            List<BDItensPedido> lstITPedido = objITPedido.CarregaDados();
            
            BDCadProdutos objProduto = new BDCadProdutos();
            objProduto.cpID = LIDProduto.ToString();
            List<BDCadProdutos> lstProduto = objProduto.CarregaDados();
            txtDescProduto.Text = lstProduto[0].cpDescricao.ToString();

        }
    }
}
