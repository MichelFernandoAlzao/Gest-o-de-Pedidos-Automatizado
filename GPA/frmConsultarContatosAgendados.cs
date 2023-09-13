using Banco_de_Dados;
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
    public partial class frmConsultarContatosAgendados : Form
    {
        string LUsuario = "";
        string LCaminhoBanco = "";
        public frmConsultarContatosAgendados(string inCaminhoBanco, string inUsuario)
        {
            LUsuario = inUsuario;
            LCaminhoBanco = inCaminhoBanco;
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaAvisos()
        {
            if (txtDataInicial.Text == "  /  /")
            {
                txtDataInicial.Text = DateTime.Today.ToShortDateString();
            }
            if (txtDataFinal.Text == "  /  /")
            {
                txtDataFinal.Text = DateTime.Today.ToShortDateString();
            }


            string DataInicial = txtDataInicial.Text;
            string DataFinal = txtDataFinal.Text;

            grdAgendaContatos.Rows.Clear();
            string RazaoSocial = "";
            BDAgendarContato objContatosAgendados = new BDAgendarContato();
            objContatosAgendados.cpIDUsuarioDR = LUsuario;
            if (chkAtendido.Checked == true)
            {
                objContatosAgendados.cpAtendido = "S";
            }
            else
            {
                objContatosAgendados.cpAtendido = "N";
            }

            List<BDAgendarContato> lstContatosAgendados = objContatosAgendados.CarregaDadosPorData(LCaminhoBanco, DataInicial, DataFinal);
            if (lstContatosAgendados.Count > 0)
            {
                foreach (BDAgendarContato Cttagenda in lstContatosAgendados)
                {
                    string usuario = "";
                    List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                    if (Cttagenda.cpIDUsuarioDR != "" && Cttagenda.cpIDUsuarioDR != null)
                    {
                        SEGUsuario objUsuario = new SEGUsuario();
                        lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, Cttagenda.cpIDUsuarioDR, "", "", "");
                        if (lstUsuario.Count > 0)
                        {
                            Cttagenda.cpIDUsuarioDR = lstUsuario[0].ID;
                            usuario = lstUsuario[0].Nome.ToString();
                        }
                        else Cttagenda.cpIDUsuarioDR = "";
                    }
                    if (Cttagenda.cpEmpresaDR != "")
                    {
                        BDCadastroGeral objCadastro = new BDCadastroGeral();
                        List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco, Cttagenda.cpEmpresaDR, "", "", "", "", "", "", "", "", "", "", "");
                        RazaoSocial = lstCadastro[0].RazaoSocial.ToString();
                    }
                    string[] Row = new string[]
                     {
                         Cttagenda.cpID.ToString(),
                         RazaoSocial.ToString(),
                         Cttagenda.cpNome.ToString(),
                         Cttagenda.cpDataContato.ToString(),
                         Cttagenda.cpFone.ToString(),
                         Cttagenda.cpAtendido.ToString()
                     };
                    grdAgendaContatos.Rows.Add(Row);
                    RazaoSocial = "";
                }
            }
        }


        private void txtDataInicial_Leave(object sender, EventArgs e)
        {
            if (txtDataInicial.Text == "  /  /")
            {
                txtDataInicial.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataInicial.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    txtDataInicial.Text = "";
                    return;
                }
            }
        }

        private void txtDataFinal_Leave(object sender, EventArgs e)
        {
            if (txtDataFinal.Text == "  /  /")
            {
                txtDataFinal.Text = DateTime.Today.ToShortDateString();
            }
            else
            {
                if (DateTime.TryParse(txtDataFinal.Text, out DateTime result) == false)
                {
                    MessageBox.Show("Data em formato invalido", "GPA");
                    txtDataFinal.Text = "";
                    return;
                }
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            CarregaAvisos();
        }
    }
}
