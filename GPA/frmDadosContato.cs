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
    public partial class frmDadosContato : Form
    {
        string LUsuario;
        string LCaminhoBanco;
        public frmDadosContato(string inCaminhoBanco, string inUsuario)
        {
            InitializeComponent();
            LUsuario = inUsuario;
            LCaminhoBanco = inCaminhoBanco;
            SEGUsuario objDadosUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = objDadosUsuario.CarregaDados(LCaminhoBanco, LUsuario, "", "", "");
            if(lstUsuario.Count > 0)
            {
                txtContato.Text = lstUsuario[0].Contato.ToString();
                txtEmail.Text = lstUsuario[0].Email.ToString();
            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            SEGUsuario objUsuario = new SEGUsuario();
            objUsuario.ID = LUsuario;
            objUsuario.Contato = txtContato.Text.ToString();
            objUsuario.Email = txtEmail.Text.ToString();

            objUsuario.AlteraDados(LCaminhoBanco);
            if(objUsuario.MsgErro != "")
            {
                MessageBox.Show("Erro ao gravar contato, verifique os dados digitados!", "GPA - Dados Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
