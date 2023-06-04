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
    public partial class frmConsultaPedido : Form
    {
        string LCaminhoBanco;
        public frmConsultaPedido(string inCmainhoBanco)
        {
            LCaminhoBanco = inCmainhoBanco;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            List<BDPedido> lstPedidos = objPedido.CarregaDados(LCaminhoBanco, txtNumero.Text, "", "");

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
    }
}
