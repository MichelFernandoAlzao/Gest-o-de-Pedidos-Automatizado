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
    public partial class frmSelecionaEmpresa : Form
    {
        public string ID;
        private string Razao;
        string Fantasia;
        string CNPJ;
        
        string[] LParametros;
        public frmSelecionaEmpresa(string razao, string inFantasia, string inCNPJ)
        {

            InitializeComponent();
            Razao = razao;
            Fantasia = inFantasia;
            CNPJ = inCNPJ;
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

                var data = from BDCadastroGeral in lstCadastro
                           orderby Razao
                           select new
                           {
                               ID = BDCadastroGeral.Id.ToString(),
                               Razao = BDCadastroGeral.RazaoSocial.ToString(),
                               Fantasia = BDCadastroGeral.RazaoFantasia.ToString(),
                               CNPJ = BDCadastroGeral.CNPJ.ToString()
                           };
                grdEmpresas.Rows.Add(data.ToList());
                //foreach (BDCadastroGeral item in lstCadastro)
                //{
                //    //string[] Cadastros;

                //    //Cadastros[0] = item.Id.ToString();
                //    //Cadastros[1] = item.RazaoSocial;
                //    //Cadastros[2] = item.RazaoFantasia;
                //    //Cadastros[3] = item.CNPJ;
                //    //grdEmpresas.Rows.Add(Cadastros);

                //}


            }
              
            
            
        }

        private void grdEmpresas_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSelecionar_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
