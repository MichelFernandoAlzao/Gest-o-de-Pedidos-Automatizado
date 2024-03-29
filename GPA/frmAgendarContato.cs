﻿using Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmAgendarContato : Form
    {
        string LCaminhoBanco = "";
        public string LID = "";
        public string LIDAContato = "";
        public string LRazaoSocial = "";
        public string LIDUsuario = "";
        public frmAgendarContato(string inCaminhoBanco, string inAgendaContato, string inID)
        {
            LCaminhoBanco = inCaminhoBanco;
            InitializeComponent();
            LIDUsuario = inID;
            if (inAgendaContato != "")
            {
                LIDAContato = inAgendaContato;
                MostraDados();
            }
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa frmSelecionaEmpresa = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtEmpresa.Text, "", "", "", "", "", "", "S");
                frmSelecionaEmpresa.ShowDialog();
                if (LRazaoSocial != "")
                {
                    txtEmpresa.Text = LRazaoSocial;
                    BDCadContatos objContato = new BDCadContatos();
                    List<BDCadContatos> lstContato = objContato.CarregaDados(LCaminhoBanco, LID);
                    if (lstContato.Count > 0)
                    {
                        foreach (BDCadContatos contato in lstContato)
                        {
                            if (contato.cpComprador == "S")
                            {
                                txtNome.Text = contato.cpNome;
                                txtFone.Text = contato.cpTelefone;
                                continue;
                            }
                        }
                    }
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmSelecionarUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, LIDUsuario, "");
                frmSelecionarUsuario.ShowDialog();
                if (LIDUsuario != "")
                {
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    txtUsuario.Text = lstUsuario[0].Usuario.ToString();
                }
            }
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDAgendarContato objAgendarContato = new BDAgendarContato();
            objAgendarContato.cpID = LIDAContato;
            objAgendarContato.Excluir(LCaminhoBanco);
        }

        public void MostraDados()
        {
            BDAgendarContato objAgendarContato = new BDAgendarContato();
            objAgendarContato.cpID = LIDAContato;
            List<BDAgendarContato> lstAgendarContato = objAgendarContato.CarregaDados(LCaminhoBanco);
            if (lstAgendarContato.Count > 0)
            {
                BDCadastroGeral objCadastroGeral = new BDCadastroGeral();
                List<BDCadastroGeral> lstCadastroGeral = objCadastroGeral.CarregaDados(LCaminhoBanco, lstAgendarContato[0].cpEmpresaDR, "", "", "", "", "", "", "", "", "", "", "");
                txtEmpresa.Text = lstCadastroGeral[0].RazaoSocial.ToString();

                SEGUsuario objUsuario = new SEGUsuario();
                List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, lstAgendarContato[0].cpIDUsuarioDR, "", "", "");
                txtUsuario.Text = lstUsuario[0].Usuario.ToString();

                txtDataContato.Text = lstAgendarContato[0].cpDataContato.ToString();
            }

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LID = "";
            LIDAContato = "";
            LRazaoSocial = "";
            LIDUsuario = "";
            txtEmpresa.Text = "";
            txtDataContato.Text = "";
            txtUsuario.Text = "";
            txtNome.Text = "";
            txtFone.Text = "";
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {

            if (LIDUsuario == "")
            {
                MessageBox.Show("Nenhum usuário selecionado", "GPA");
                return;
            }
            if (txtDataContato.Text.Replace(" ", "").Replace("/", "") == "" || txtDataContato.Text.Replace(" ", "").Replace("/", "").Length < 8)
            {
                MessageBox.Show("Data não informada ou em formato invalido!", "GPA");
                return;
            }

            BDAgendarContato objAgendaContato = new BDAgendarContato();
            if (LID == "")
            {
                if (MessageBox.Show("Deseja seguir sem uma empresa selecionada?", "GPA", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            }
            else
            {
                objAgendaContato.cpEmpresaDR = LID;
            }
            if (txtFone.Text != "")
            {
                objAgendaContato.cpFone = txtFone.Text;
            }
            if (objAgendaContato.cpNome != "")
            {
                objAgendaContato.cpNome = txtNome.Text;
            }
            objAgendaContato.cpAtendido = "N";
            objAgendaContato.cpDataContato = txtDataContato.Text;
            objAgendaContato.cpIDUsuarioDR = LIDUsuario;

            objAgendaContato.InsereDados(LCaminhoBanco);
            if (objAgendaContato.cpMsgErro != null)
            {
                if (objAgendaContato.cpMsgErro != "")
                {
                    MessageBox.Show(objAgendaContato.cpMsgErro, "GPA");
                    return;
                }
            }
            if (objAgendaContato.cpID != null)
            {
                if (objAgendaContato.cpID != "")
                {
                    MessageBox.Show("Contato Agendado com sucesso!", "GPA");
                    LID = "";
                    LIDAContato = "";
                    LRazaoSocial = "";
                    LIDUsuario = "";
                    txtEmpresa.Text = "";
                    txtDataContato.Text = "";
                    txtUsuario.Text = "";
                    txtNome.Text = "";
                    txtFone.Text = "";
                }
            }
        }

        private void txtDataContato_Leave(object sender, EventArgs e)
        {
            if (txtDataContato.Text.Replace("/", "") == "    ")
            {
                txtDataContato.Text = DateTime.Today.ToString().Substring(0, 10);
            }

            if (txtDataContato.Text.Replace(" ", "").Replace("/", "").Length != 8)
            {
                MessageBox.Show("Data em formato invalido!", "GPA");
                return;
            }
        }
    }
}
