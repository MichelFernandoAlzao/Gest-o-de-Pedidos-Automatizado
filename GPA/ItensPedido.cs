using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_Dados;
using Camada_Negocios;

namespace Formularios
{
    public partial class frmItensPedido : Form
    {
        string LCaminhoBanco = "";
        public string LID = "";
        public string LRazaoSocial = "";
        string LIDITPedido = "";
        public string LIDProduto = "";
        string LIDPedido = "";
        string LValor = "";
        string LValorTotalItem = "";
        string LValorFornecedor = "";
        string LQuantidade = "";
        string LLote = "";
        string LFornecedor = "";
        string LUsuario = "";





        public frmItensPedido(string inCaminhoBanco, string inIDPedido, string inConsulta)
        {
            LCaminhoBanco = inCaminhoBanco;
            LIDPedido = inIDPedido;

            InitializeComponent();
            if (inConsulta == "S")
            {
                DesabilitaBotoes();
            }
        }

        public void DesabilitaBotoes()
        {
            cmdNovo.Enabled = false;
            cmdExcluir.Enabled = false;
            cmdGravar.Enabled = false;
        }

        private void frmItensPedido_Load(object sender, EventArgs e)
        {
            //Verifica se tela foi chamada com pedido carregado -- Precaução para falahas de carregamento
            if (LIDPedido == "")
            {
                MessageBox.Show("Nenhuma pedido selecionado", "GPA");
                this.Close();
            }

            //Se houverem itens já inseridos no pedido os carrega no grid
            BDItensPedido objItensPedido = new BDItensPedido();
            objItensPedido.cpPedidoDR = LIDPedido;
            List<BDItensPedido> lstItenspedido = objItensPedido.CarregaDados(LCaminhoBanco);
            if (lstItenspedido.Count > 0)
            {
                CarregaGrid();
            }
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDItensPedido OBjGravarItem = new BDItensPedido();

            if (LIDProduto == "")
            {
                MessageBox.Show("Produto não Selelcionado! \n Impossivel Gravar", "GPA");
                return;
            }
            OBjGravarItem.cpProdutoID = LIDProduto;
            OBjGravarItem.cpPedidoDR = LIDPedido;
            if (txtValor.Text == "")
            {
                MessageBox.Show("Valor unitario não informado", "GPA");
                return;
            }
            OBjGravarItem.cpValorUnit = txtValor.Text.Replace(",", ".");

            if (txtValorFornecedor.Text != "")
            {
                OBjGravarItem.cpValorFornecedor = txtValorFornecedor.Text.Replace(",", ".");
            }
            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Quantidade não informada", "GPA");
            }

            OBjGravarItem.cpQuantidade = txtQuantidade.Text;
            OBjGravarItem.cpLote = txtLote.Text;
            if (LFornecedor == "")
            {
                if (MessageBox.Show("Nenhuma Fornecedor seleiconado, deseja prosseguir assim mesmo ?", "GPA", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                OBjGravarItem.cpFornecedor = LFornecedor;
            }

            OBjGravarItem.cpValorFornecedor = txtValorFornecedor.Text.Replace(",", ".");

            if (chkFatura.Checked)
            {
                OBjGravarItem.cpFatura = "S";
            }
            else
            {
                OBjGravarItem.cpFatura = "N";
            }

            claNCalculaProduto ClaCalculaProduto = new claNCalculaProduto();
            OBjGravarItem.cpValorTotalItem = ClaCalculaProduto.CalculaProduto(txtValor.Text, txtQuantidade.Text, "").Replace(",", ".");
            if (LIDITPedido == "")
            {
                OBjGravarItem.InsereDados(LCaminhoBanco);
            }
            else
            {
                OBjGravarItem.cpID = LIDITPedido;
                OBjGravarItem.AlteraDados(LCaminhoBanco);
            }


            //Se houverem itens já inseridos no pedido os carrega no grid
            BDItensPedido objItensPedido = new BDItensPedido();
            objItensPedido.cpPedidoDR = LIDPedido;
            List<BDItensPedido> lstItenspedido = objItensPedido.CarregaDados(LCaminhoBanco);
            if (lstItenspedido.Count > 0)
            {
                BDPedido objPedido = new BDPedido();
                claNCalculaProduto claCalcula = new claNCalculaProduto();
                claCalcula.CalculaTotalItens(LIDPedido,LCaminhoBanco);
                claCalcula.CalculaTotalFaturando(LIDPedido,LCaminhoBanco);

                CarregaGrid();
            }
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        public void Novo()
        {
            txtDescProduto.Text = "";
            txtQuantidade.Text = "";
            txtLote.Text = "";
            txtValor.Text = "";
            txtValorFornecedor.Text = "";
            txtFornecedor.Text = "";
            lbTotalItem.Text = "XXXX,XX";
            lbVlrPraticado1.Text = "XXXX,XX";
            lbVlrPraticado2.Text = "XXXX,XX";
            lbVlrPraticado3.Text = "XXXX,XX";
            LabVlrPraticado4.Text = "XXXX,XX";
            LIDITPedido = "";
            LIDProduto = "";
            LValor = "";
            LValorTotalItem = "";
            LValorFornecedor = "";
            LQuantidade = "";
            LLote = "";
            LFornecedor = "";
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDItensPedido objExcluirItem = new BDItensPedido();
            objExcluirItem.cpID = LIDITPedido;
            objExcluirItem.Excluir(LCaminhoBanco);
            BDPedido objPedido = new BDPedido();
            claNCalculaProduto claCalcula = new claNCalculaProduto();
            claCalcula.CalculaTotalItens(LIDPedido,LCaminhoBanco);
            Novo();
            CarregaGrid();
        }

        private void grdItensPedido_SelectionChanged(object sender, EventArgs e)
        {

            if (grdItensPedido.SelectedRows.Count == 0)
            {
                return;
            }

            LIDITPedido = grdItensPedido.Rows[0].Cells[0].Value.ToString();
            LIDProduto = grdItensPedido.Rows[0].Cells[1].Value.ToString();
            LQuantidade = grdItensPedido.Rows[0].Cells[3].Value.ToString();
            LValor = grdItensPedido.Rows[0].Cells[5].Value.ToString();
            LValorTotalItem = grdItensPedido.Rows[0].Cells[6].Value.ToString();
            LValorFornecedor = grdItensPedido.Rows[0].Cells[7].Value.ToString();
            LLote = grdItensPedido.Rows[0].Cells[8].Value.ToString();
            lbTotalItem.Text = LValorTotalItem = grdItensPedido.Rows[0].Cells[6].Value.ToString();

            MostraDados();
        }

        public void CarregaGrid()
        {
            grdItensPedido.Rows.Clear();

            BDItensPedido objItensPedido = new BDItensPedido();
            objItensPedido.cpPedidoDR = LIDPedido;
            List<BDItensPedido> lstITPedido = objItensPedido.CarregaDados(LCaminhoBanco);
            if (lstITPedido.Count > 0)
            {
                foreach (BDItensPedido item in lstITPedido)
                {
                    BDCadProdutos objProduto = new BDCadProdutos();
                    objProduto.cpID = item.cpProdutoID;
                    List<BDCadProdutos> lstProduto = objProduto.CarregaDados(LCaminhoBanco);
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpProdutoID.ToString(),
                            lstProduto[0].cpDescricao.ToString(),
                            item.cpQuantidade.ToString(),
                            lstProduto[0].cpCodigoFabricante.ToString(),
                            item.cpValorUnit.ToString(),
                            item.cpValorTotalItem.ToString(),
                            item.cpValorFornecedor.ToString(),
                            item.cpLote.ToString()

                        };
                    grdItensPedido.Rows.Add(Row);
                }
            }
        }

        private void txtDescProduto_KeyDown(object sender, KeyEventArgs e)
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

        private void txtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa frmSelecionarFornecedor = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtFornecedor.Text, "", "","");
                frmSelecionarFornecedor.ShowDialog();
                if (LID != "")
                {
                    LFornecedor = LID;
                    txtFornecedor.Text = LRazaoSocial;

                    LID = "";
                    LRazaoSocial = "";
                }
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Quantidade invalida", "GPA");
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            //if (txtValor.Text.Length < 4)
            //{
            //    MessageBox.Show("Valor em formato invalido", "GPA");
            //    return;
            //}
            //double Valor;
            //if (Double.TryParse(txtValor.Text, out Valor))
            //{
            //    txtValor.Text = Valor.ToString();
            //}


            if (txtValor.Text == "") return;
            double VlrFatMinimo = Convert.ToDouble(txtValor.Text = txtValor.Text);
            txtValor.Text = VlrFatMinimo.ToString("N2");
        }

        private void txtValorFornecedor_Leave(object sender, EventArgs e)
        {
            //if (txtValorFornecedor.Text.Length < 4)
            //{
            //    MessageBox.Show("Valor em formato invalido", "GPA");
            //    return;
            //}
            //double Valor;
            //if (Double.TryParse(txtValorFornecedor.Text, out Valor))
            //{
            //    txtValorFornecedor.Text = Valor.ToString();
            //}

            if (txtValorFornecedor.Text == "") return;
            double VlrFatMinimo = Convert.ToDouble(txtValorFornecedor.Text = txtValorFornecedor.Text);
            txtValorFornecedor.Text = VlrFatMinimo.ToString("N2");
        }


        public void MostraDados()
        {
            BDItensPedido objITPedido = new BDItensPedido();
            objITPedido.cpID = LIDITPedido;
            List<BDItensPedido> lstITPedido = objITPedido.CarregaDados(LCaminhoBanco);
            if (lstITPedido.Count == 0)
            {
                MessageBox.Show("Não foi possivel carregar os itens do pedido!\n Abra a tela de itens para carregar novmanete", "GPA");
                this.Close();
                return;
            }
            //Pega Totaldo pedido para preecher o label
            BDPedido objPedido = new BDPedido();
            List<BDPedido> lstPedido = objPedido.CarregaDados(LCaminhoBanco, LIDPedido, "", "");
            labTotalPedido.Text = lstPedido[0].cpVlrTotalPedido;

            BDCadProdutos objProduto = new BDCadProdutos();
            objProduto.cpID = lstITPedido[0].cpProdutoID;
            List<BDCadProdutos> lstProduto = objProduto.CarregaDados(LCaminhoBanco);
            txtDescProduto.Text = lstProduto[0].cpDescricao.ToString();
            txtQuantidade.Text = lstITPedido[0].cpQuantidade.ToString();
            txtLote.Text = lstITPedido[0].cpLote.ToString();
            txtValor.Text = lstITPedido[0].cpValorUnit.ToString();
            txtValorFornecedor.Text = lstITPedido[0].cpValorFornecedor.ToString();
            if (lstITPedido[0].cpFatura == "S")
            {
                chkFatura.Checked = true;
            }
            else
            {
                chkFatura.Checked = false;
            }
            if (lstITPedido[0].cpFornecedor != "")
            {
                BDCadastroGeral objFornecedor = new BDCadastroGeral();
                List<BDCadastroGeral> lstFornecedor = objFornecedor.CarregaDados(LCaminhoBanco, lstITPedido[0].cpFornecedor, "", "", "", "", "", "", "", "", "");
                LFornecedor = lstFornecedor[0].Id;
                txtFornecedor.Text = lstFornecedor[0].RazaoSocial.ToString();
            }

        }

        private void cmdCadProduto_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new frmCadProdutos(LCaminhoBanco, LUsuario);
            frmCadProdutos.ShowDialog();
        }
    }
}
