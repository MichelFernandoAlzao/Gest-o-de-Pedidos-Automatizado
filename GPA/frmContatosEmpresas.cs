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
    public partial class frmContatosEmpresas : Form
    {
        string LID = "";
        string LIDRegistro = "";
        string LDataContato = "";
        string LSugestoes = "";
        string LReclamacoes = "";
        string LVendedor = "";

        public frmContatosEmpresas()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LID = "";
            LIDRegistro = "";
            LDataContato = "";
            LSugestoes = "";
            LReclamacoes = "";
            txtEmpresa.Text = "";
            txtDataContato.Text = "";
            txtSugestoes.Text = "";
            txtReclamacoes.Text = "";
            grdProdSugeridos.Rows.Clear();
            

        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {

        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDRegistroContato objRegContato = new BDRegistroContato();
            objRegContato.cpID = LIDRegistro;
            LID = "";
            LIDRegistro = "";
            LDataContato = "";
            LSugestoes = "";
            LReclamacoes = "";
            txtEmpresa.Text = "";
            txtDataContato.Text = "";
            txtSugestoes.Text = "";
            txtReclamacoes.Text = "";
            grdProdSugeridos.Rows.Clear();
        }
    }
}
