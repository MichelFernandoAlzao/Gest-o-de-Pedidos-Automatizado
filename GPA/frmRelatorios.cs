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
    public partial class frmRelatorios : Form
    {
        string[] ParametrosRel;
        public frmRelatorios(string[] inParametrosRel)
        {
            ParametrosRel = inParametrosRel;
            InitializeComponent();

            ReportViewer.LocalReport.ReportEmbeddedResource = "Formularios.Relatorios.Pedido.rdlc";

            ReportViewer.RefreshReport();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {

        }
    }
}
