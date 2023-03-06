using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_Dados;

namespace Formularios
{
    public partial class frmSelecionaPedido : Form
    {
        public string LID;
        private string Lvendedor;
        Form LChamador;

        public frmSelecionaPedido(Form frmChamador, string inID, string inVendedor)
        {
            InitializeComponent();
            LID = inID;
            Lvendedor = inVendedor;
        }

        private void frmSelecionaPedido_Load(object sender, EventArgs e)
        {
            CarregaProduto(LID, Lvendedor);
        }

        private void CarregaProduto(string inID, string inVendedor)
        {
            BDPedido objCadastro = new BDPedido();
            List<BDPedido> lstCadastro = objCadastro.CarregaDados(inID,"",inVendedor);
            if (lstCadastro.Count > 0)
            {
                foreach (BDPedido item in lstCadastro)
                {
                    string RazaoSocial;
                    BDCadastroGeral objEmpresa = new BDCadastroGeral();
                    List<BDCadastroGeral> lstEmpresa = objEmpresa.CarregaDados(item.cpEmpresaDR,"","","","","","","","","");
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            lstEmpresa[0].RazaoSocial.ToString(),
                            item.cpDataContato.ToString(),
                        };
                    grdPedidos.Rows.Add(Row);
                }
            }
        }

        private void grdCadastroGeral_SelectionChanged(object sender, EventArgs e)
        {
            if (grdPedidos.SelectedRows.Count > 0)
            {
                LID = grdPedidos.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        private void CmdSelecionar_Click(object sender, EventArgs e)
        {
            RetornaResultado();
        }

        private void grdEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RetornaResultado();
        }

        private void RetornaResultado()
        {
            if (grdPedidos.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LIDPedido");
                NumeroIDCadastro.SetValue(LChamador, grdPedidos.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
