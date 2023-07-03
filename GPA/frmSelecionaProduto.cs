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
    public partial class frmSelecionaProduto : Form
    {
        string LCaminhoBanco;
        public string LID;
        private string LDescProduto;
        string LFabricanteDR;
        string LCodFabricante;
        Form LChamador;

        public frmSelecionaProduto(string inCaminhoBanco, Form frmChamador, string inID, string inDescProduto, string inFabricante, string inCodFabricante)
        {
            InitializeComponent();
            LCaminhoBanco = inCaminhoBanco;
            LID = inID;
            LDescProduto = inDescProduto;
            LFabricanteDR = inFabricante;
            LCodFabricante = inCodFabricante;
            LChamador = frmChamador;
        }

        private void frmSelecionaProduto_Load(object sender, EventArgs e)
        {
            CarregaProduto(LID, LDescProduto, LFabricanteDR, LCodFabricante);
        }

        private void CarregaProduto(string inIDProd, string inDescProduto, string inFabricanteDR, string inCodFabricante)
        {

            BDCadProdutos objCadastro = new BDCadProdutos();
            if (inIDProd != null)
            {
                if (inIDProd != "")
                {
                    objCadastro.cpID = inIDProd;
                }
            }

            if (inDescProduto != null)
            {
                if (inDescProduto != "")
                {
                    objCadastro.cpDescricao = inDescProduto;
                }
            }

            if (inFabricanteDR != null)
            {
                if (inCodFabricante != "")
                {
                    objCadastro.cpCodigoFabricante = inCodFabricante;
                }
            }

            List<BDCadProdutos> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco);
            if (lstCadastro.Count > 0)
            {
                foreach (BDCadProdutos item in lstCadastro)
                {
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpDescricao.ToString(),
                            item.cpCodigoFabricante.ToString(),
                            item.cpAtivo.ToString()
                        };
                    grdProdutos.Rows.Add(Row);
                }
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
            if (grdProdutos.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LIDProduto");
                NumeroIDCadastro.SetValue(LChamador, grdProdutos.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdProdutos_DoubleClick(object sender, EventArgs e)
        {
            CmdSelecionar_Click(sender, e);
        }
    }
}
