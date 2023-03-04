﻿using System;
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
        string LDescricao ="";
        public string LIDProduto = "";
        string LCodigo= "";
        string LDataCadastro ="";
        string LCodigoFabricante = "";
        string LDescricaoFornecedor = "";
        string LFabricante = "";
        string LMelhorFornecedor = "";
        string LAtivo = "";
        string LOperacional = "";
        string LForaDeLinha = "";
        string LDescritivo = "";
        public string LID = "";
        public string LRazaoSocial = "";

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
            LFabricante = "";
            LMelhorFornecedor="";
            LAtivo = "";
            LOperacional = "";
            LForaDeLinha = "";
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

        public void MostraDados()
        {
            BDCadProdutos objProduto = new BDCadProdutos();
            objProduto.cpID = LIDProduto;
            List<BDCadProdutos> lstProdutos = objProduto.CarregaDados();
            LDescricao = lstProdutos[0].cpDescricao;
            LDataCadastro = lstProdutos[0].cpDataCadastro;
            LCodigoFabricante = lstProdutos[0].cpCodigoFabricante;
            LDescricaoFornecedor = lstProdutos[0].cpDescFornecedor;
            LFabricante = lstProdutos[0].cpFabricanteDR;
            LMelhorFornecedor = lstProdutos[0].cpMelhorFornecedorDR;
            LAtivo = lstProdutos[0].cpAtivo;
            LOperacional = lstProdutos[0].cpOperacional;
            LForaDeLinha = lstProdutos[0].cpForaDeLinha;
            LDescritivo = lstProdutos[0].cpDescritivo;
            txtDescricao.Text = LDescricao;
            txtCodigo.Text = LIDProduto;
            txtDataCadastro.Text = LDataCadastro;
            txtCodFabricante.Text = LCodigoFabricante;
            txtDescFornecedor.Text = LDescricaoFornecedor;
            if (LFabricante != "")
            {
                BDCadastroGeral objFabricante = new BDCadastroGeral();
                List<BDCadastroGeral> lstFabricante = new List<BDCadastroGeral>();
                lstFabricante = objFabricante.CarregaDados(Convert.ToString(LFabricante), "", "", "", "", "", "", "", "", "");
                txtFabricante.Text = lstFabricante[0].RazaoSocial.ToString();
            }
            else txtFabricante.Text = "";

            if (LMelhorFornecedor != "")
            {
                BDCadastroGeral objFornecedor = new BDCadastroGeral();
                List<BDCadastroGeral> lstFornecedor = new List<BDCadastroGeral>();
                lstFornecedor = objFornecedor.CarregaDados(Convert.ToString(LMelhorFornecedor), "", "", "", "", "", "", "", "", "");
                txtMelhorFornecedor.Text = lstFornecedor[0].RazaoSocial.ToString();
            }
            else txtMelhorFornecedor.Text = "";

            if(LAtivo == "S")
            {
                chkAtivo.Checked = true;
            }
            else chkAtivo.Checked = false;

            if(LOperacional == "S")
            {
                chkOperacional.Checked = true;
            }
            else chkOperacional.Checked = false;
            if(LForaDeLinha == "S")
            {
                chkForadeLinha.Checked = true;
            }
            else chkForadeLinha.Checked= false;
            txtDescritivo.Text = LDescritivo;

        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (txtDescricao.Text.Length < 5)
                {
                    MessageBox.Show("Digite um minimo de 5 caracteres!", "GPA");
                    return;
                }
                frmSelecionaProduto objForm = new frmSelecionaProduto(this,LIDProduto,txtDescricao.Text,LFabricante,txtCodFabricante.Text);
                objForm.ShowDialog();
                if(LIDProduto != "")
                {
                    MostraDados();
                }
                
            }
                
        }

        private void txtFabricante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (txtFabricante.Text.Length < 5)
                {
                    MessageBox.Show("Digite um minimo de 5 caracteres!", "GPA");
                }
                if (e.KeyCode == Keys.F1)
                {
                    frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this, "", txtFabricante.Text.ToString(), "", "");
                    objTela.ShowDialog();
                    LFabricante = LID;
                    txtFabricante.Text = LRazaoSocial.ToString();
                    LID = "";
                    LRazaoSocial = "";

                }
            }
                
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {

        }

        private void txtMelhorFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                if (txtMelhorFornecedor.Text.Length < 5)
                {
                    MessageBox.Show("Digite um minimo de 5 caracteres!", "GPA");
                }
                if (e.KeyCode == Keys.F1)
                {
                    frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this, "", txtMelhorFornecedor.Text.ToString(), "", "");
                    objTela.ShowDialog();
                    LMelhorFornecedor = LID;
                    txtMelhorFornecedor.Text = LRazaoSocial.ToString();
                    LID = "";
                    LRazaoSocial = "";
                }
            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDCadProdutos objProduto = new BDCadProdutos();
            objProduto.cpID = LIDProduto;
            objProduto.cpDescricao = txtDescricao.Text;
            objProduto.cpDataCadastro = DateTime.Today.ToString();
            objProduto.cpCodigoFabricante = txtCodFabricante.Text;
            objProduto.cpDescFornecedor = txtDescFornecedor.Text;
            objProduto.cpFabricanteDR = LFabricante;
            objProduto.cpMelhorFornecedorDR = LMelhorFornecedor;
            objProduto.cpDescritivo = txtDescritivo.Text;
            if(chkAtivo.Checked == true)
            {
                objProduto.cpAtivo = "S";
            }
            else
            {
                objProduto.cpAtivo = "N";
            }
            if(chkForadeLinha.Checked == true)
            {
                objProduto.cpForaDeLinha = "S";
            }
            else
            {
                objProduto.cpForaDeLinha= "N";
            }
            if(chkOperacional.Checked == true)
            {
                objProduto.cpOperacional = "S";
            }
            else
            {
                objProduto.cpOperacional= "N";
            }
            objProduto.cpDescritivo = txtDescritivo.Text;

            if(LIDProduto == "")
            {
                objProduto.InsereDados();
            }
            else
            {
                
                objProduto.AlteraDados();
            }
            
        }
    }
}
