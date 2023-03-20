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
        public frmConsultaPedido()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BDPedido objPedido = new BDPedido();
            List<BDPedido> lstPedidos = objPedido.CarregaDados(txtNumero.Text, "", "");

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
                            lstEmpresa = objEmpresa.CarregaDados(item.cpEmpresaDR, "", "", "", "", "", "", "", "", "");
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

        private void cmdSelecionar_Click(object sender, EventArgs e)
        {
            if (grdListaPedido.Rows.Count == 0)
            {
                return;
            }

            frmPedido frmPedido = new frmPedido("", grdListaPedido.SelectedRows[0].Cells[0].Value.ToString());
            frmPedido.ShowDialog();
        }
    }
}
