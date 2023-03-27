using Banco_de_Dados;
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
        public frmAgendarContato(string inCaminhoBanco,string inAgendaContato, string inID)
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
                frmSelecionaEmpresa frmSelecionaEmpresa = new frmSelecionaEmpresa(LCaminhoBanco,this, "", txtEmpresa.Text, "", "");
                frmSelecionaEmpresa.ShowDialog();
                if (LRazaoSocial != "")
                {
                    txtEmpresa.Text = LRazaoSocial;
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
                List<BDCadastroGeral> lstCadastroGeral = objCadastroGeral.CarregaDados(LCaminhoBanco,lstAgendarContato[0].cpEmpresaDR, "", "", "", "", "", "", "", "", "");
                txtEmpresa.Text = lstCadastroGeral[0].RazaoSocial.ToString();

                SEGUsuario objUsuario = new SEGUsuario();
                List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, lstAgendarContato[0].cpIDUsuarioDR, "", "", "");
                txtUsuario.Text = lstUsuario[0].Usuario.ToString();
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
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            if (LID == "")
            {
                MessageBox.Show("Nenhuma empresa selecionada", "GPA");
                return;
            }
            if (LIDUsuario == "")
            {
                MessageBox.Show("Nenhum usuário selecionado", "GPA");
                return;
            }
            if (txtDataContato.Text == "  /  /")
            {
                MessageBox.Show("Data não informada!", "GPA");
                return;
            }

            BDAgendarContato objAgendaContato = new BDAgendarContato();
            objAgendaContato.cpEmpresaDR = LID;
            objAgendaContato.cpDataContato = txtDataContato.Text;
            objAgendaContato.cpIDUsuarioDR = LIDUsuario;

            objAgendaContato.InsereDados(LCaminhoBanco);
            if (objAgendaContato.cpMsgErro != null)
            {
                if(objAgendaContato.cpMsgErro != "")
                {
                    MessageBox.Show(objAgendaContato.cpMsgErro, "GPA");
                    return;
                }
                
            }
        }

        private void txtDataContato_Leave(object sender, EventArgs e)
        {
            if(txtDataContato.Text.Replace("/","") == "    ")
            {
                txtDataContato.Text = DateTime.Today.ToString().Substring(0, 10);
            }

            if(txtDataContato.Text.Replace(" ","").Replace("/","").Length != 8)
            {
                MessageBox.Show("Data em formato invalido!", "GPA");
                return;
            }
        }
    }
}
