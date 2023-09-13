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
    public partial class frmConsultaPedidoGeral : Form
    {
        string LCaminhoBanco = "";
        string LUsuario = "";
        public string LIDUsuario = "";
        public frmConsultaPedidoGeral(string inCmainhoBanco, string inUsuario)
        {
            LCaminhoBanco = inCmainhoBanco;
            InitializeComponent();
            SEGUsuario objUsuario = new SEGUsuario();
            List<SEGUsuario> lstCarregaUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
            if (lstCarregaUsuario.Count > 0)
            {
                if (lstCarregaUsuario[0].GerenciaCadastros == "S")
                {
                    txtVendedor.Enabled = true;
                }
                else
                {
                    txtVendedor.Enabled = false;
                    txtVendedor.Text = lstCarregaUsuario[0].Usuario.ToString();
                    LUsuario = LIDUsuario;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            List<BDPedido> lstPedidos = objPedido.CarregaDadosData(LCaminhoBanco, txtDataInicial.Text.ToString(), txtDataFinal.Text.ToString(), LIDUsuario, "", "", "");
            grdListaPedido.Rows.Clear();
            if (lstPedidos.Count > 0)
            {
                if (lstPedidos.Count > 0)
                {
                    foreach (BDPedido item in lstPedidos)
                    {
                        string pRazao = "";
                        List<BDCadastroGeral> lstEmpresa = new List<BDCadastroGeral>();
                        if (item.cpEmpresaDR != "" && item.cpEmpresaDR != null)
                        {
                            BDCadastroGeral objEmpresa = new BDCadastroGeral();
                            lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, item.cpEmpresaDR, "", "", "", "", "", "", "", "", "", "", "");
                            if (lstEmpresa.Count > 0)
                            {
                                pRazao = lstEmpresa[0].RazaoSocial.ToString();
                            }
                        }
                        string[] Row = new string[]
                            {
                            item.cpID.ToString(),
                            pRazao.ToString(),
                            item.cpDataContato.ToString(),
                            item.cpStatus.ToString()
                            };
                        grdListaPedido.Rows.Add(Row);
                    }
                }
            }
        }

        private void cmdSelecionar_Click(object sender, EventArgs e)
        {
            if (grdListaPedido.Rows.Count == 0)
            {
                return;
            }

            frmPedido frmPedido = new frmPedido(LCaminhoBanco, "", grdListaPedido.SelectedRows[0].Cells[0].Value.ToString());
            frmPedido.ShowDialog();
        }

        private void grdListaPedido_DoubleClick(object sender, EventArgs e)
        {
            cmdSelecionar_Click(sender, e);
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdBuscar_Click(sender, e);
            }
        }

        private void txtDataInicial_Leave(object sender, EventArgs e)
        {
            if (txtDataInicial.Text == "  /  /")
            {
                txtDataInicial.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataInicial.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    txtDataInicial.Text = "";
                    return;

                }
            }
        }

        private void txtDataFinal_Leave(object sender, EventArgs e)
        {
            if (txtDataFinal.Text == "  /  /")
            {
                txtDataFinal.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataFinal.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    txtDataFinal.Text = "";
                    return;

                }
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, "", txtVendedor.Text.ToString());
                frmUsuario.ShowDialog();

                if (LIDUsuario != "")
                {
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    txtVendedor.Text = lstUsuario[0].Usuario;
                }
            }
        }
    }
}
