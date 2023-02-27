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
    public partial class frmEntrada : Form
    {
        private string Lusuario;
        private string LSenha;
        List<string> LParametros;
        public frmEntrada()
        {
            InitializeComponent();
        }

        public void frmEntrada_Load(object sender, EventArgs e)
        {
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

            if (chkOperacional.Checked)
            {
                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Usuario e / ou Senha não informados", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                SEGUsuario objUsuario = new SEGUsuario();
                lstUsuario = objUsuario.CarregaDados("", txtUsuario.Text.ToUpper(), "", txtSenha.Text.ToUpper());

                if (lstUsuario.Count == 0)
                {
                    MessageBox.Show("Usuario ou senha invalidos", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lstUsuario[0].Operacional == 'S')
                {
                    frmCRMInicial objTela = new frmCRMInicial();
                    this.Hide();
                    objTela.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario sem permissão para este modulo.", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (chkSeguranca.Checked)
            {
                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Usuario e / ou Senha não informados", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                SEGUsuario objUsuario = new SEGUsuario();
                lstUsuario = objUsuario.CarregaDados("", txtUsuario.Text.ToUpper(), "", txtSenha.Text.ToUpper());
                if (lstUsuario.Count == 0)
                {
                    MessageBox.Show("Usuario ou senha invalidos", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lstUsuario[0].Seguranca == 'S')
                {
                    frmSEGUsuarios objTela = new frmSEGUsuarios();
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
    }
}
