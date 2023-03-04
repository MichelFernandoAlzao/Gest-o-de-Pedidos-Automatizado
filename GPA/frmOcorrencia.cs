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
    public partial class frmOcorrencia : Form
    {
        string LIDOcorrencia = "";
        public string LID = "";
        public string LRazaoSocial = "";
        string LEmpresaDR = "";
        string LDataOcorrencia;
        string LDataresolucao;
        string LPedidoDR = "";


        public frmOcorrencia(string inEmpresa)
        {
            LEmpresaDR = inEmpresa;
            InitializeComponent();
            List<BDCadastroGeral> lstEmpresa = new List<BDCadastroGeral>();
            BDCadastroGeral objEmpresa = new BDCadastroGeral();
            lstEmpresa = objEmpresa.CarregaDados(LEmpresaDR, "", "", "", "", "", "", "", "", "");
            txtEmpresa.Text = lstEmpresa[0].RazaoSocial.ToString();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            if (LEmpresaDR != "")
            {
                BDRegOcorrencias objReOcorencia = new BDRegOcorrencias();
                objReOcorencia.cpEmpresaDR = LEmpresaDR;
                DateTime Datatratada;
                if (txtDataOcorrencia.Text.Length == 8)
                {
                    LDataOcorrencia = txtDataOcorrencia.Text.Substring(0, 2) + "/" + txtDataOcorrencia.Text.Substring(2, 2) + "/" + txtDataOcorrencia.Text.Substring(4, 4);
                }
                else
                {
                    MessageBox.Show("Tamanho de data de ocorrencia invalido", "GPA");
                    return;
                }
                 
                if (DateTime.TryParse(LDataOcorrencia, out Datatratada))
                {
                    objReOcorencia.cpDataOcorrencia = LDataOcorrencia.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Data de Ocorrencia em formato invalido", "GPA");
                    return;
                }
                if(txtDataReolucao.Text != "")
                {
                    if (txtDataReolucao.Text.Length == 8)
                    {
                        LDataresolucao = txtDataReolucao.Text.Substring(0, 2) + "/" + txtDataReolucao.Text.Substring(2, 2) + "/" + txtDataReolucao.Text.Substring(4, 4);
                    }
                    else
                    {
                        MessageBox.Show("Tamanho de data de resolução invalido", "GPA");
                        return;
                    }
                    if (MessageBox.Show("Data de resolução preenchida, deseja encerrar esta ocorrencia ?","GPA",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    if (DateTime.TryParse(LDataresolucao, out Datatratada))
                    {
                        objReOcorencia.cpDataResolucao = LDataresolucao.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data de Resolução em formato invalido", "GPA");
                        return;
                    }
                }
                if(LID != "")
                {
                    objReOcorencia.cpFornecedorDR = LID;
                }
                objReOcorencia.cpDescricao = txtxDescricao.Text;

                if(LPedidoDR != "")
                {
                    objReOcorencia.cpPedidoDR = LPedidoDR;
                }
                
                if(LIDOcorrencia == "")
                {
                    objReOcorencia.InsereDados();
                }
                else
                {
                    objReOcorencia.AlteraDados();
                }
                


            }

        }
        public void MostraDados()
        {
            txtFornecedor.Text = LRazaoSocial;
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LIDOcorrencia = "";
            LID = "";
            LRazaoSocial = "";
            LDataOcorrencia = "";
            LDataresolucao = "";
            LPedidoDR = "";
            txtFornecedor.Text = "";
            txtDataOcorrencia.Text = "";
            txtDataReolucao.Text = "";
            txtxDescricao.Text = "";
            txtProduto.Text = "";
            txtPedido.Text = "";
            grdProdutos.Rows.Clear();
        }

        private void txtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this, "", txtFornecedor.Text.ToString(), "", "");
                objTela.ShowDialog();
                MostraDados();
            }
        }

        private void cmdSelecionar_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            objPedido.CarregaDados(txtPedido.Text, LEmpresaDR, "");
            LPedidoDR = objPedido.cpID;
            if(LPedidoDR != "") 
            { 
                AtualizaGrid(); 
            }
            
        }
        public void AtualizaGrid()
        {
            List<BDItensPedido> lstItensPedido = new List<BDItensPedido>();
            BDItensPedido objItensPedido = new BDItensPedido();
            objItensPedido.cpPedidoDR = LPedidoDR;
            lstItensPedido = objItensPedido.CarregaDados();
            if (lstItensPedido.Count > 0)
            {
                foreach (BDItensPedido item in lstItensPedido)
                {
                    string[] Row = new string[]
                        {
                            item.cpPedidoDR.ToString(),
                        };
                    grdProdutos.Rows.Add(Row);
                }
            }
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if(LIDOcorrencia == "")
            {
                MessageBox.Show("Nenhuma ocorrencia selecionada", "GPA");
                return;
            }
            BDRegOcorrencias objOcorrencia = new BDRegOcorrencias();
            objOcorrencia.cpID = LIDOcorrencia;
            objOcorrencia.Excluir();
        }
    }
}
