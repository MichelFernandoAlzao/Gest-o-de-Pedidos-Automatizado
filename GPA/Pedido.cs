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
    public partial class Pedido : Form
    {
        public string LID = "";
        public string LIDPedido = "";
        public string LRazaoSocial = "";
        string LUsuario = "";
        string LDataSolcitacao = "";
        string LDataConfirmacao = "";
        public string LIDNaturezaOperacao = "";
        string LObservacao = "";
        string LPedidoExterno = "";
        string LTotalItens = "";
        string LTotaFaturando = "";
        string LImpostos = "";
        string LComissao = "";

        public Pedido(string inUsuario)
        {
            InitializeComponent();
            LUsuario = inUsuario;
            SEGUsuario objUsuario = new SEGUsuario();
            List<SEGUsuario> lstusuario = objUsuario.CarregaDados(LUsuario,"","","");
            txtVendedor.Text = lstusuario[0].Nome;
            if (lstusuario[0].Administrador == "S")
            {
                txtVendedor.Enabled = true;
            }
            else
            {
                txtVendedor.Enabled = false;
            }
            
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }

        private void MostraDados()
        {   
            BDCadastroGeral ObjCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = ObjCadastro.CarregaDados(LID, LRazaoSocial, "", "", "", LUsuario, "", "", "", "");
            txtEmpresa.Text = lstCadastro[0].RazaoSocial.ToString();
            BDCadEnderecos objEndereco = new BDCadEnderecos();
            List<BDCadEnderecos> lstEndereco = new List<BDCadEnderecos>();
            lstEndereco = objEndereco.CarregaDados(lstCadastro[0].Id);
            labDescCNPJ.Text = lstCadastro[0].CNPJ.ToString();
            string pPossuiEndereco = "";
            foreach (BDCadEnderecos endereco in lstEndereco)
            {
                if(endereco.cpEndFisico == "S")
                {
                    labDescEndereco.Text = endereco.cpRua.ToString();
                    labDescNumero.Text = endereco.cpNumero.ToString();
                    pPossuiEndereco = "S";
                }
            }
            if(pPossuiEndereco != "S")
            {
                MessageBox.Show("Empresa não possui endereço fisico cadastrado", "GPA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            txtNumeroPedido.Enabled = false;
            if(LIDNaturezaOperacao != "")
            {
                BDNatOperacao objNatOperacao = new BDNatOperacao();
                List<BDNatOperacao> lstNatureza = objNatOperacao.CarregaDados(LIDNaturezaOperacao);
                txtxNatOperacao.Text = lstNatureza[0].cpDescricao.ToString();
            }

        }
        private void cmdItensPedido_Click(object sender, EventArgs e)
        {
            if(LIDPedido == "") { return; }

            frmItensPedido objItensPedido = new frmItensPedido();
            objItensPedido.ShowDialog();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            objPedido.cpID = LIDPedido;
            objPedido.Excluir();
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this, "", txtEmpresa.Text.ToString(), "", "");
                objTela.ShowDialog();
                txtEmpresa.Text = LRazaoSocial;

                BDCadEnderecos objEndereco =  new BDCadEnderecos();
                List<BDCadEnderecos> lstEndereco = objEndereco.CarregaDados(LID);
                labDescEndereco.Text = lstEndereco[0].cpRua.ToString();
                labDescNumero.Text = lstEndereco[0].cpNumero.ToString();

                BDPedido objPedido = new BDPedido();
                List<BDPedido> lstPedido = objPedido.CarregaDados("", LID, LUsuario);
                if(lstPedido.Count > 0)
                {
                    string MaiorData = "";
                    foreach (BDPedido item in lstPedido)
                    {
                        if(MaiorData == "")
                        {
                            MaiorData = item.cpDataConfirmacao;
                        }
                        else
                        {
                            if(Convert.ToDateTime(item.cpDataConfirmacao) > Convert.ToDateTime(MaiorData))
                            {
                                MaiorData = item.cpDataConfirmacao;
                            }
                        }
                        
                    }
                    labDescUltCompra.Text = MaiorData.ToString();
                }
                

                BDCadastroGeral objEmpresa = new BDCadastroGeral();
                List<BDCadastroGeral> lstEmpresa = objEmpresa.CarregaDados(LID,LRazaoSocial,"","","",LUsuario,"","","","");
                labDescCNPJ.Text = lstEmpresa[0].CNPJ.ToString();

            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            if(LIDPedido != "")
            {
                objPedido.cpID = LIDPedido;
            }
            if(LID == "")
            {
                MessageBox.Show("Empresa não selecionada", "GPA");
                return;
            }
            objPedido.cpEmpresaDR = LID;
            objPedido.cpPedidoExterno = txtNumPedExterno.Text;

            DateTime Datatratada;

            if(txtDataSolicitacao.Text != "")
            {
                //if (txtDataSolicitacao.Text.Replace("/","").Length == 8)
                //{
                //    LDataSolcitacao = txtDataSolicitacao.Text.Substring(0, 2) + "/" + txtDataSolicitacao.Text.Substring(2, 2) + "/" + txtDataSolicitacao.Text.Substring(4, 4);
                //}
                //else
                //{
                //    MessageBox.Show("Tamanho de data de solcitação invalido", "GPA");
                //    return;
                //}

                if (DateTime.TryParse(txtDataSolicitacao.Text, out Datatratada))
                {
                    objPedido.cpDataContato = txtDataSolicitacao.Text.ToString();

                }
                else
                {
                    MessageBox.Show("Data de solcitação em formato invalido", "GPA");
                    return;
                }
            }
            if(txtDataSolicitacao.Text == "")
            {
                MessageBox.Show("Data solcitação não informada", "GPA");
                return;
            }

            if(txtDataConfirmacao.Text != "")
            {
                //if (txtDataConfirmacao.Text.Length == 8)
                //{
                //    LDataConfirmacao = txtDataConfirmacao.Text.Substring(0, 2) + "/" + txtDataConfirmacao.Text.Substring(2, 2) + "/" + txtDataConfirmacao.Text.Substring(4, 4);
                //}
                //else
                //{
                //    MessageBox.Show("Tamanho de data de solcitação invalido", "GPA");
                //    return;
                //}

                if (DateTime.TryParse(txtDataConfirmacao.Text, out Datatratada))
                {
                    objPedido.cpDataConfirmacao = txtDataConfirmacao.Text.ToString();

                }
                else
                {
                    MessageBox.Show("Data de confirmação em formato invalido", "GPA");
                    return;
                }
            }
            if(LIDNaturezaOperacao == "")
            {
                MessageBox.Show("Natureza não selcionada", "GPA");
                return;
            }
            objPedido.cpNatureOperacaoDR = LIDNaturezaOperacao.ToString();
            objPedido.cpVendedorDR = LUsuario;
            if(txtObservacao.Text != "")
            {
                objPedido.cpObservacoes = txtObservacao.Text;
            }

            if(LIDPedido == "")
            {
                objPedido.InsereDados();
            }
            else
            {
                objPedido.AlteraDados();
            }

            LIDPedido = objPedido.cpID;

            if (LIDPedido != "")
            {
                BDPedido objCarregaPedido = new BDPedido();
                List<BDPedido> lstPedido = objCarregaPedido.CarregaDados(LIDPedido, "", LUsuario);
                LID = lstPedido[0].cpEmpresaDR;
                LDataSolcitacao = lstPedido[0].cpDataContato.Substring(0, 10);
                if (lstPedido[0].cpDataConfirmacao != "")
                {
                    LDataConfirmacao = lstPedido[0].cpDataConfirmacao.Substring(0, 10);
                }
                LIDNaturezaOperacao = lstPedido[0].cpNatureOperacaoDR;
                LObservacao = lstPedido[0].cpObservacoes;
                txtxNatOperacao.Enabled = false;
                MostraDados();
            }


        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtNumeroPedido.Text = "";
            txtEmpresa.Text = "";
            labDescEndereco.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            labDescCNPJ.Text = "xxxxxxxxxxxx";
            labDescUltCompra.Text = "xxxxxx";
            labDescVlrUltCompra.Text = "xxxxxx";
            labDescCEP.Text = "xxxxxx";
            labDescNumero.Text = "xxxxxx";
            txtDataSolicitacao.Text = "____/____/________";
            txtDataConfirmacao.Text = "____/____/________";
            txtxNatOperacao.Text = "";
            txtObservacao.Text = "";
            LID = "";
            LIDPedido = "";
            LRazaoSocial = "";
            LDataSolcitacao = "";
            LDataConfirmacao = "";
            LIDNaturezaOperacao = "";
            LObservacao = "";
            LPedidoExterno = "";
            LTotalItens = "";
            LTotaFaturando = "";
            LImpostos = "";
            LComissao = "";
            txtNumeroPedido.Enabled = true;
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaPedido objTela = new frmSelecionaPedido(this, txtNumeroPedido.Text, LUsuario);
                objTela.ShowDialog();
                if(LIDPedido != "")
                {
                    BDPedido objPedido = new BDPedido();
                    List<BDPedido> lstPedido = objPedido.CarregaDados(LIDPedido,"",LUsuario);
                    LID = lstPedido[0].cpEmpresaDR;
                    LDataSolcitacao = lstPedido[0].cpDataContato.Substring(0,10);
                    if (lstPedido[0].cpDataConfirmacao != "")
                    {
                        LDataConfirmacao = lstPedido[0].cpDataConfirmacao.Substring(0, 10);
                    }
                    LIDNaturezaOperacao = lstPedido[0].cpNatureOperacaoDR;
                    LObservacao = lstPedido[0].cpObservacoes;
                    MostraDados();
                }
            }
        }

        private void txtxNatOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                frmSelecionaNatureza objTela = new frmSelecionaNatureza(this,LUsuario);
                objTela.ShowDialog();

                if(LIDNaturezaOperacao != "")
                {
                    BDNatOperacao objNatOperacao = new BDNatOperacao();
                    List<BDNatOperacao> lstNatureza = objNatOperacao.CarregaDados(LIDNaturezaOperacao);
                    txtxNatOperacao.Text = lstNatureza[0].cpDescricao.ToString();

                    MessageBox.Show("Natureza não podera ser alterado após gravar o pedido", "GPA");
                }
            }
        }

        private void txtDataSolicitacao_Leave(object sender, EventArgs e)
        {
            if(txtDataSolicitacao.Text == "")
            {
                txtDataSolicitacao.Text = DateTime.Today.ToString().Substring(0,10);
            }
            else
            {
                if(txtDataSolicitacao.Text.Length != 8)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    return;
                }
                txtDataSolicitacao.Text = txtDataSolicitacao.Text.Insert(2, "/").Insert(5,"/");
            }
        }

        private void txtDataConfirmacao_Leave(object sender, EventArgs e)
        {
            if (txtDataConfirmacao.Text == "")
            {
                txtDataConfirmacao.Text = DateTime.Today.ToString().Substring(0, 10);
            }
            else
            {
                if (txtDataConfirmacao.Text.Length != 8)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    return;
                }
                txtDataConfirmacao.Text = txtDataConfirmacao.Text.Insert(2, "/").Insert(5, "/");
            }
        }
    }
}
