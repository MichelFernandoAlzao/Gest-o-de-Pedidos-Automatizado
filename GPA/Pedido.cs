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
    public partial class Pedido : Form
    {
        string LID = "";
        string LRazaoSocial = "";
        string LUsuario = "";
        public Pedido(string inUsuario)
        {
            LUsuario = inUsuario;
            InitializeComponent();
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
            foreach (BDCadEnderecos endereco in lstEndereco)
            {
                if(endereco.cpEndFisico == "S")
                {
                    labDescEndereco.Text = endereco.cpRua.ToString();
                    labDescNumero.Text = endereco.cpNumero.ToString();
                }
            }
            

        }
        private void cmdItensPedido_Click(object sender, EventArgs e)
        {
            frmItensPedido objItensPedido = new frmItensPedido();
            objItensPedido.ShowDialog();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this, "", txtEmpresa.Text.ToString(), "", "");
                objTela.ShowDialog();
                MostraDados();
            }
        }
    }
}
