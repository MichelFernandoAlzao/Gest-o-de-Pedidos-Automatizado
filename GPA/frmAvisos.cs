﻿using System;
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


        private void frmAvisos_Load(object sender, EventArgs e)
        {
            CarregaAvisos();
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
                txtAviso.Text = "";
                txtDataInicio.Text = "";
                txtDataTermino.Text = "";
                txtUsuarioDestino.Text = "";
            }
            else
            {
                return;
            }

            CarregaAvisos();
            
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

            if (chkTodos.Checked)
            {
                objAviso.cpTodos = "S";
            }
            else
            {
                objAviso.cpTodos = "N";
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

            CarregaAvisos();
        }
        private void CarregaAvisos()
        {
            grdAvisos.Rows.Clear();
            BDAvisos objAvisos = new BDAvisos();
            List<BDAvisos> lstAvisos = objAvisos.CarregaDados();
            if (lstAvisos.Count > 0)
            {
                foreach (BDAvisos item in lstAvisos)
                {
                    string usuario = "";
                    List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                    if (item.cpUsuarioDR != "" && item.cpUsuarioDR != null)
                    {
                        SEGUsuario objUsuario = new SEGUsuario();
                        lstUsuario = objUsuario.CarregaDados(item.cpUsuarioDR,"","","");
                        if (lstUsuario.Count > 0)
                        {
                            item.cpUsuarioDR = lstUsuario[0].ID;
                            usuario = lstUsuario[0].Nome.ToString();
                        }
                        else item.cpUsuarioDR = "";
                    }
                    string[] Row = new string[]
                     {
                         item.cpID.ToString(),
                         item.cpAviso.ToString(),
                         item.cpDataInicio.ToString(),
                         item.cpDataTermino.ToString(),
                         usuario.ToString(),
                         item.cpUsuarioDR.ToString(),
                         item.cpTodos.ToString()
                     };
                    grdAvisos.Rows.Add(Row);
                }
            }
        }

        private void grdAvisos_SelectionChanged(object sender, EventArgs e)
        {
            if(grdAvisos.SelectedRows.Count == 0)
            {

                return;
            }

            txtAviso.Text = grdAvisos.SelectedRows[0].Cells[1].Value.ToString();
            txtDataInicio.Text = grdAvisos.SelectedRows[0].Cells[2].Value.ToString();
            txtDataTermino.Text = grdAvisos.SelectedRows[0].Cells[3].Value.ToString();
            txtUsuarioDestino.Text = grdAvisos.SelectedRows[0].Cells[4].Value.ToString();
            LIDAviso = grdAvisos.SelectedRows[0].Cells[0].Value.ToString();
            LIDUsuario = grdAvisos.SelectedRows[0].Cells[5].Value.ToString();
            LAviso = grdAvisos.SelectedRows[0].Cells[2].Value.ToString();
            LDataInicio = grdAvisos.SelectedRows[0].Cells[2].Value.ToString();
            LDataTermino = grdAvisos.SelectedRows[0].Cells[3].Value.ToString();
            if(grdAvisos.SelectedRows[0].Cells[6].Value.ToString() == "S")
            {
                chkTodos.Checked = true;
            }
            else
            {
                chkTodos.Checked = false;
            }

        }

        private void txtUsuarioDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmUsuario = new frmSelecionarUsuario(this,"",txtUsuarioDestino.Text.ToString());
                frmUsuario.ShowDialog();
                
                if(LIDUsuario != "")
                {
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LIDUsuario, "", "", "");
                    txtUsuarioDestino.Text = lstUsuario[0].Usuario;
                }
            }
        }
    }
}