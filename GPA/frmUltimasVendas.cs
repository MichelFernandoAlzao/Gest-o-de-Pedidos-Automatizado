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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formularios
{
    public partial class frmUltimasVendas : Form
    {
        string LCaminhoBanco = "";
        string LUsuario = "";
        public frmUltimasVendas(string inCmainhoBanco, string inUsuario)
        {
            LCaminhoBanco = inCmainhoBanco;
            LUsuario = inUsuario;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            List<BDPedido> lstPedidos = objPedido.CarregaDadosData(LCaminhoBanco, txtDataInicio.Text, txtDataFim.Text, LUsuario);

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
                            lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, item.cpEmpresaDR, "", "", "", "", "", "", "", "", "");
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
                            item.cpConcluido.ToString()
                            };
                        grdListaPedido.Rows.Add(Row);
                    }
                }
            }
        }

        private void txtDataInicio_Leave(object sender, EventArgs e)
        {
            if (txtDataInicio.Text == "  /  /")
            {
                txtDataInicio.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataInicio.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data inicial em formato invalido", "GPA");
                    txtDataInicio.Text = "";
                    return;
                }

            }
        }

        private void txtDataFim_Leave(object sender, EventArgs e)
        {
            if (txtDataFim.Text == "  /  /")
            {
                txtDataFim.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataFim.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data inicial em formato invalido", "GPA");
                    txtDataFim.Text = "";
                    return;
                }

            }
        }

        private void grdListaPedido_DoubleClick(object sender, EventArgs e)
        {
            cmdSelecionar_Click(sender, e);
        }
    }
}
