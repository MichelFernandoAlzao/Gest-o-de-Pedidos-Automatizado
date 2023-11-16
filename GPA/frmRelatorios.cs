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
        public frmRelatorios(string inCaminhoBanco, string[] inParametrosRel)
        {
            LCaminhoBanco = inCaminhoBanco;

            InitializeComponent();


            string pRelatorio = inParametrosRel[0];

            ParametrosRel = inParametrosRel;
            ReportDataSource fonteDeDados = new ReportDataSource();
            switch (pRelatorio)
            {
                case "Formularios.Relatorios.Pedido.rdlc":
                    List<RelatorioPedido> lstPedido = new List<RelatorioPedido>();
                    CarregaRelatorio objRelPedido = new CarregaRelatorio();
                    lstPedido = objRelPedido.CarregaRelatorioRDLC(LCaminhoBanco, ParametrosRel[1]);
                    fonteDeDados.Name = "Pedido";
                    fonteDeDados.Value = lstPedido;
                    this.ReportViewer.LocalReport.DataSources.Clear();
                    this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                    ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                    this.Controls.Add(this.ReportViewer);
                break;

                case "Formularios.Relatorios.VendasPorCliente.rdlc":
                    List<VendasPorCliente> lstVendas = new List<VendasPorCliente>();
                    RelVendasPorCliente objRelVendas = new RelVendasPorCliente();
                    lstVendas = objRelVendas.CarregaRelatorioRDLC(LCaminhoBanco, ParametrosRel);
                    fonteDeDados.Name = "VendasPorCliente";
                    fonteDeDados.Value = lstVendas;
                    this.ReportViewer.LocalReport.DataSources.Clear();
                    this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                    ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                    this.Controls.Add(this.ReportViewer);
                break;

                case "Formularios.Relatorios.RegistroContatos.rdlc":
                    List<RegistrodeContato> lstregistros = new List<RegistrodeContato>();
                    RelRegistroContatos objRelRegistros = new RelRegistroContatos();
                    lstregistros = objRelRegistros.CarregaRelatorioRDLC(LCaminhoBanco, ParametrosRel);
                    fonteDeDados.Name = "RegistroDeContatos";
                    fonteDeDados.Value = lstregistros;
                    this.ReportViewer.LocalReport.DataSources.Clear();
                    this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                    ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                    this.Controls.Add(this.ReportViewer);
                break;

                case "Formularios.Relatorios.CadastrosDeEmpresas.rdlc":
                    List<CadastrosDeEmpresas> lstCadastros = new List<CadastrosDeEmpresas>();
                    RelCadastroDeEmpresas objRelCadastros = new RelCadastroDeEmpresas();
                    lstCadastros = objRelCadastros.CarregaRelatorioRDLC(LCaminhoBanco, ParametrosRel);
                    fonteDeDados.Name = "CadastrosDeEmpresas";
                    fonteDeDados.Value = lstCadastros;
                    this.ReportViewer.LocalReport.DataSources.Clear();
                    this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                    ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                    this.Controls.Add(this.ReportViewer);
                    break;

                case "Formularios.Relatorios.EmpresassemContato.rdlc":
                    List<CadastrosDeEmpresas> lstCadastrosSemContato = new List<CadastrosDeEmpresas>();
                    RelCadastroDeEmpresas objRelCadastrosSemContato = new RelCadastroDeEmpresas();
                    lstCadastrosSemContato = objRelCadastrosSemContato.CarregaRelatorioSemContatoRDLC(LCaminhoBanco, ParametrosRel);
                    fonteDeDados.Name = "CadastrosDeEmpresas";
                    fonteDeDados.Value = lstCadastrosSemContato;
                    this.ReportViewer.LocalReport.DataSources.Clear();
                    this.ReportViewer.LocalReport.DataSources.Add(fonteDeDados);
                    ReportParameter Prazo = new ReportParameter( "Prazo",ParametrosRel[2]);
                    ReportViewer.LocalReport.ReportEmbeddedResource = pRelatorio;
                    ReportViewer.LocalReport.SetParameters(Prazo);
                    this.Controls.Add(this.ReportViewer);
                    break;
            }
            ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            ReportViewer.RefreshReport();

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
