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
    public partial class frmSelecionaCarteira : Form
    {
        string LCaminhoBanco;
        public string LIDCarteira;
        private string LSigla;
        string Ldescricao;
        Form LChamador;

        public frmSelecionaCarteira(string inCaminhoBanco, Form frmChamador, string inUsuario)
        {
            InitializeComponent();
            LCaminhoBanco = inCaminhoBanco;
            LChamador = frmChamador;
        }

        private void frmSelecionaProduto_Load(object sender, EventArgs e)
        {
            CarregaCarteira();
        }

        private void CarregaCarteira()
        {
            BDCagCarteira objCarteira = new BDCagCarteira();
            List<BDCagCarteira> lstCarteira = objCarteira.CarregaDados(LCaminhoBanco);
            if (lstCarteira.Count > 0)
            {
                foreach (BDCagCarteira Carteira in lstCarteira)
                {
                    string[] Row = new string[]
                        {
                            Carteira.cpID.ToString(),
                            Carteira.cpSigla.ToString(),
                            Carteira.cpDescricao.ToString()
                        };
                    grdCarteira.Rows.Add(Row);
                }
            }
        }

        private void grdCarteira_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCarteira.SelectedRows.Count > 0)
            {
                LIDCarteira = grdCarteira.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        private void CmdSelecionar_Click(object sender, EventArgs e)
        {
            RetornaResultado();
        }

        private void grdCarteira_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RetornaResultado();
        }

        private void RetornaResultado()
        {
            if (grdCarteira.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LIDCarteira");
                NumeroIDCadastro.SetValue(LChamador, grdCarteira.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
