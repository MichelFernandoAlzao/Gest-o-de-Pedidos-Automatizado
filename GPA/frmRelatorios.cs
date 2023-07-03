using Camada_Relatorios;
using CarregaRelatorios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formularios
{
    public partial class frmRelatorios : Form
    {
        string LCaminhoBanco = "";
        string[] ParametrosRel;
        DataTable objDatTableRel = new DataTable();
        public frmRelatorios(string inCaminhoBanco, string[] inParametrosRel)
        {
            LCaminhoBanco = inCaminhoBanco;

            InitializeComponent();


            string pRelatorio = inParametrosRel[0];

            ParametrosRel = inParametrosRel;
            if (pRelatorio == "Formularios.Relatorios.Pedido.rdlc")
            {
                List<RelatorioPedido> lstPedido = new List<RelatorioPedido>();
                CarregaRelatorio objRelPedido = new CarregaRelatorio();
                lstPedido = objRelPedido.CarregaRelatorioRDLC(LCaminhoBanco, ParametrosRel[1]);

                //var fonteDeDados = new Microsoft.Reporting.WinForms.ReportDataSource();
                ReportDataSource fonteDeDados = new ReportDataSource();
                fonteDeDados.Name = "Pedido";
                fonteDeDados.Value = lstPedido;
                this.ReportViewer.LocalReport.DataSources.Clear();
                this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                this.Controls.Add(this.ReportViewer);
            }
            if (pRelatorio == "Formularios.Relatorios.VendasPorCliente.rdlc")
            {
                List<VendasPorCliente> lstVendas = new List<VendasPorCliente>();
                RelVendasPorCliente objRelVendas = new RelVendasPorCliente();
                lstVendas = objRelVendas.CarregaRelatorioRDLC(LCaminhoBanco, ParametrosRel);

                ReportDataSource fonteDeDados = new ReportDataSource();
                fonteDeDados.Name = "VendasPorCliente";
                fonteDeDados.Value = lstVendas;
                this.ReportViewer.LocalReport.DataSources.Clear();
                this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                this.Controls.Add(this.ReportViewer);
            }
            ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            ReportViewer.RefreshReport();

        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {

        }
    }
}
