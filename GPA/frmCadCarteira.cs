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
    public partial class frmCadCarteira : Form
    {
        public string LUsuario = "";
        public string LIDCarteira = "";
        public string LSigla = "";
        public string LDescricacao = "";
        public string LPotencial = "";
        public string LcaminhoBanco = "";

        public frmCadCarteira(string inCaminhoBanco, string inUsuario)
        {
            LcaminhoBanco = inCaminhoBanco;
            InitializeComponent();
        }

        private void txtPotencial_Leave(object sender, EventArgs e)
        {
            if (txtPotencial.Text == "") return;
            double VlrPotencial = Convert.ToDouble(txtPotencial.Text = txtPotencial.Text);
            txtPotencial.Text = VlrPotencial.ToString("N2");
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDCagCarteira objCarteira = new BDCagCarteira();
            List<BDCagCarteira> lstCarteira = objCarteira.CarregaDados(LcaminhoBanco);
            if (txtSigla.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Obrigatorio informar uma sigla!", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDescricao.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Obrigatorio informar uma descrição!", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPotencial.Text.Replace(" ", "") == "")
            {
                objCarteira.cpPotencial = "0,00";
            }
            else
            {
                objCarteira.cpPotencial = txtPotencial.Text.ToString();
            }
            objCarteira.cpSigla = txtSigla.Text.ToString();
            objCarteira.cpDescricao = txtDescricao.Text.ToString();

            if (LIDCarteira == "")
            {
                objCarteira.InsereDados(LcaminhoBanco);
            }
            else
            {
                objCarteira.AlteraDados(LcaminhoBanco);
            }

            CarregaGrid();

        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtSigla.Text = "";
            txtDescricao.Text = "";
            txtPotencial.Text = "";
            LIDCarteira = "";
            LDescricacao = "";
            LSigla = "";
            LPotencial = "";
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaGrid()
        {
            BDCagCarteira objCarteira = new BDCagCarteira();
            List<BDCagCarteira> lstCarteira = objCarteira.CarregaDados(LcaminhoBanco);

            foreach (BDCagCarteira carteira in lstCarteira)
            {
                string[] Row = new string[]
                    {
                            carteira.cpID.ToString(),
                            carteira.cpSigla.ToString(),
                            carteira.cpDescricao.ToString(),
                            carteira.cpPotencial.ToString()
                    };
                grdCarteira.Rows.Add(Row);
            }

        }
    }
}
