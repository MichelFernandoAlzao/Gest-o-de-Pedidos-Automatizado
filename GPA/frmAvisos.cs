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
    public partial class frmAvisos : Form
    {
        string LIDAviso = "";
        public string LIDUsuario = "";
        string LAviso = "";
        string LDataInicio = "";
        string LDataTermino = "";
        public frmAvisos()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtAviso.Text = "";
            txtDataInicio.Text = "";
            txtDataTermino.Text = "";
            txtUsuarioDestino.Text = "";
            LIDAviso = "";
            LIDUsuario = "";
            LAviso = "";
            LDataInicio = "";
            LDataTermino = "";
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDAvisos objAviso = new BDAvisos();

            objAviso.cpID = LIDAviso;

            if(MessageBox.Show("Deseja Excluir este aviso ?","GPA",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                objAviso.Excluir();
            }
            else
            {
                return;
            }
            
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDAvisos objAviso = new BDAvisos();

            if(txtAviso.Text != "")
            {
                objAviso.cpAviso = txtAviso.Text;
            }
            else
            {
                MessageBox.Show("Nenhuma mensagem informada", "GPA");
                return;
            }

            if(txtDataInicio.Text != "")
            {
                DateTime Datainicio;
                if(DateTime.TryParse(txtDataInicio.Text, out Datainicio))
                {
                    objAviso.cpDataInicio = Convert.ToString(Datainicio);
                }
                else
                {
                    MessageBox.Show("Data Inicio em formato invalido", "GPA");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Data Inciio não informada", "GPA");
                return;
            }

            if (txtDataTermino.Text != "")
            {
                DateTime DataTermino;
                if (DateTime.TryParse(txtDataTermino.Text, out DataTermino))
                {
                    objAviso.cpDataTermino = Convert.ToString(DataTermino);
                }
                else
                {
                    MessageBox.Show("Data termino em formato invalido", "GPA");
                    return;
                }
            }

            if(LIDUsuario != "")
            {
                objAviso.cpUsuarioDR = LIDUsuario;
            }

            if(LIDAviso == "")
            {
                objAviso.InsereDados();
            }
            else
            {
                objAviso.cpID = LIDAviso;
                objAviso.AlteraDados();
            }
        }
        private void CarregaAvisos()
        {
            BDAvisos objAvisos = new BDAvisos();
            List<BDAvisos> lstAvisos = objAvisos.CarregaDados();
            if (lstAvisos.Count > 0)
            {
                foreach (BDAvisos item in lstAvisos)
                {
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpAviso.ToString(),
                            item.cpDataInicio.ToString(),
                            item.cpDataTermino.ToString(),
                        };
                    grdAvisos.Rows.Add(Row);
                }
            }
        }
    }
}
