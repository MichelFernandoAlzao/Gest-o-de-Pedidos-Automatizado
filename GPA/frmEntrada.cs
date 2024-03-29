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
    public partial class frmEntrada : Form
    {
        string LCaminhoBanco;
        private string Lusuario;
        private string LSenha;
        List<string> LParametros;
        public frmEntrada()
        {
            InitializeComponent();
        }

        public void frmEntrada_Load(object sender, EventArgs e)
        {
            string[] Servidor = File.ReadAllLines("C:\\GPA\\Conexoes.ini");
            cboServidor.Items.Clear();
            foreach (string ServidorSerie in Servidor)
            {
                cboServidor.Items.Add(ServidorSerie);
                int posicao = ServidorSerie.IndexOf("|");
                int posicaodois = ServidorSerie.IndexOf("=");
                int Tamanhonome = posicao - posicaodois;
                cboNomeServer.Items.Add(ServidorSerie.Substring(8,Tamanhonome - 1));
            }
            if (cboServidor.Items.Count > 0)
            {
                cboServidor.SelectedIndex = 0;
                cboNomeServer.SelectedIndex = 0;
            }
            chkOperacional.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }
        private void Entrar()
        {
            if (cboServidor.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum servidor selecionado", "GPA");
                return;
            }
            int index = cboNomeServer.SelectedIndex;
            int i = cboServidor.Items[index].ToString().IndexOf("|");
            LCaminhoBanco = cboServidor.Items[index].ToString().Remove(0, i + 1);
            if (chkOperacional.Checked == true)
            {

                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Usuario e / ou Senha não informados", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                SEGUsuario objUsuario = new SEGUsuario();
                lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, "", txtUsuario.Text.ToUpper(), "", txtSenha.Text.ToUpper());
                if (objUsuario.MsgErro != "")
                {
                    MessageBox.Show(objUsuario.MsgErro.ToString(), "GPA");
                    return;
                }
                if (lstUsuario.Count == 0)
                {
                    MessageBox.Show("Usuario ou senha invalidos", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lstUsuario[0].Operacional == "S")
                {
                    frmCRMInicial objTela = new frmCRMInicial(LCaminhoBanco, lstUsuario[0].ID);
                    this.Hide();
                    objTela.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario sem permissão para este modulo.", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (chkSeguranca.Checked == true)
            {
                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Usuario e / ou Senha não informados", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                SEGUsuario objUsuario = new SEGUsuario();
                lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, "", txtUsuario.Text.ToUpper(), "", txtSenha.Text.ToUpper());
                if (lstUsuario.Count == 0)
                {
                    MessageBox.Show("Usuario ou senha invalidos", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lstUsuario[0].Seguranca == "S")
                {
                    frmSEGUsuarios objTela = new frmSEGUsuarios(LCaminhoBanco);
                    this.Hide();
                    objTela.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario sem permissão para este modulo.", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void chkOperacional_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkOperacional.Checked == true)
            {
                chkSeguranca.Checked = false;
                chkFinanceiro.Checked = false;
            }
        }

        private void chkFinanceiro_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkFinanceiro.Checked == true)
            {
                chkOperacional.Checked = false;
                chkSeguranca.Checked = false;
            }

        }

        private void chkSeguranca_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkSeguranca.Checked == true)
            {
                chkOperacional.Checked = false;
                chkFinanceiro.Checked = false;
            }
        }
    }
}
