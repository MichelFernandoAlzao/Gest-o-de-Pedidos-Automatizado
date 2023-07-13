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
using System.Reflection;

namespace Formularios
{
    public partial class frmSelecionaEmpresa : Form
    {
        string LCaminhoBanco;
        public string LIDCadastro;
        private string Razao;
        string Fantasia;
        string CNPJ;
        string LUsuario;
        string LFabricante;
        string LFornecedor;
        string LCliente;
        Form LChamador;

        string[] LParametros;
        public frmSelecionaEmpresa(string inCaminhoBanco, Form frmChamador, string inID, string inrazao, string inFantasia, string inCNPJ, string inUsuario, string inFabricante, string inFornecedor, string inCLiente)
        {

            InitializeComponent();
            LCaminhoBanco = inCaminhoBanco;
            LIDCadastro = inID;
            Razao = inrazao;
            Fantasia = inFantasia;
            CNPJ = inCNPJ;
            LChamador = frmChamador;
            LUsuario = inUsuario;
            LFornecedor = inFornecedor;
            LFabricante = inFabricante;
            LCliente = inCLiente;
        }

        private void SelecionaEmpresa_Load(object sender, EventArgs e)
        {
            CarregaEmpresa(Razao, Fantasia, CNPJ);
        }

        private void CarregaEmpresa(string inRazao, string inRazaoFantasia, string inCNPJ)
        {
            string IDVendedor = "";

            if (LUsuario != "")
            {
                SEGUsuario objUsuario = new SEGUsuario();
                List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LUsuario, "", "", "");
                if (lstUsuario[0].GerenciaCadastros != "S")
                {
                    IDVendedor = LUsuario;
                }
            }

            BDCadastroGeral objCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = new List<BDCadastroGeral>();
            if (LFabricante != "")
            {
                lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, LIDCadastro, inRazao, inRazaoFantasia, inCNPJ, "", IDVendedor, "", "", "S", "");
            }
            if (LFornecedor != "")
            {
                lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, LIDCadastro, inRazao, inRazaoFantasia, inCNPJ, "", IDVendedor, "", "", "", "S");
            }
            if (LCliente != "")
            {
                lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, LIDCadastro, inRazao, inRazaoFantasia, inCNPJ, "", IDVendedor, "S", "", "", "");
            }
            if (LFabricante == "" && LFornecedor == "" && LCliente == "")
            {
                lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, LIDCadastro, inRazao, inRazaoFantasia, inCNPJ, "", IDVendedor, "", "", "", "");
            }

            if (lstCadastro.Count > 0)
            {
                foreach (BDCadastroGeral item in lstCadastro)
                {
                    string[] Row = new string[]
                        {
                            item.Id.ToString(),
                            item.RazaoSocial.ToString(),
                            item.RazaoFantasia.ToString(),
                            item.CNPJ.ToString()
                        };
                    grdEmpresas.Rows.Add(Row);
                }
            }
        }

        private void grdCadastroGeral_SelectionChanged(object sender, EventArgs e)
        {
            if (grdEmpresas.SelectedRows.Count > 0)
            {
                LIDCadastro = grdEmpresas.SelectedRows[0].Cells[0].Value.ToString();
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
            if (grdEmpresas.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LID");
                NumeroIDCadastro.SetValue(LChamador, grdEmpresas.SelectedRows[0].Cells[0].Value.ToString());

                FieldInfo RazaoSocial = TipoChamador.GetField("LRazaoSocial");
                RazaoSocial.SetValue(LChamador, grdEmpresas.SelectedRows[0].Cells[1].Value.ToString());


            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
