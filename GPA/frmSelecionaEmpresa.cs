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
        public string LIDCadastro;
        private string Razao;
        string Fantasia;
        string CNPJ;
        Form LChamador;
        
        string[] LParametros;
        public frmSelecionaEmpresa(Form frmChamador,string razao, string inFantasia, string inCNPJ)
        {

            InitializeComponent();
            Razao = razao;
            Fantasia = inFantasia;
            CNPJ = inCNPJ;
            LChamador = frmChamador;
        }

        private void SelecionaEmpresa_Load(object sender, EventArgs e)
        {
            CarregaEmpresa(Razao,Fantasia,CNPJ);
        }

        private void CarregaEmpresa(string inRazao, string inRazaoFantasia,string inCNPJ)
        {
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados("", inRazao, inRazaoFantasia, inCNPJ, "", "", "", "", "", "");
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
