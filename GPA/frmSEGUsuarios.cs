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
    public partial class frmSEGUsuarios : Form
    {
        string LCaminhoBanco;
        string LID;
        string LUsuario;
        string LNome;
        string LAdministrador;
        string LGerenciaCadastros;
        string LOperacional = "";
        string LSeguranca = "";
        public frmSEGUsuarios(string inCaminhoBanco)
        {
            LCaminhoBanco = inCaminhoBanco;
            InitializeComponent();
            AtualizaGrid();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSEGUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void AtualizaGrid()
        {
            List<SEGUsuario> lstUsuarios = new List<SEGUsuario>();
            SEGUsuario objUsuario = new SEGUsuario();
            lstUsuarios = objUsuario.CarregaDados(LCaminhoBanco, "", "", "", "");

            if (lstUsuarios.Count > 0)
            {
                foreach (SEGUsuario item in lstUsuarios)
                {
                    string[] Row = new string[]
                        {
                            item.ID .ToString(),
                            item.Nome.ToString(),
                            item.Usuario.ToString(),
                            item.Senha.ToString(),
                            item.Administrador.ToString(),
                            item.GerenciaCadastros.ToString(),
                            item.Operacional.ToString(),
                            item.Seguranca.ToString()
                        };
                    grdUsuarios.Rows.Add(Row);
                }
            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            SEGUsuario objInsUsuario = new SEGUsuario();
            objInsUsuario.Usuario = txtUsuario.Text;
            objInsUsuario.Nome = txtNome.Text;
            if (chkAdministrador.Checked)
            {
                objInsUsuario.Administrador = "S";
            }
            else
            {
                objInsUsuario.Administrador = "N";
            }

            if (chkGerenCadastros.Checked)
            {
                objInsUsuario.GerenciaCadastros = "S";
            }
            else
            {
                objInsUsuario.GerenciaCadastros = "N";
            }

            if (chkOperacional.Checked)
            {
                objInsUsuario.Operacional = "S";
            }
            else
            {
                objInsUsuario.Operacional = "N";
            }

            if (chkSeguranca.Checked)
            {
                objInsUsuario.Seguranca = "S";
            }
            else
            {
                objInsUsuario.Seguranca = "N";
            }


            if (LID == "")
            {
                objInsUsuario.InsereDados(LCaminhoBanco);
            }
            else
            {
                objInsUsuario.ID = LID;
                objInsUsuario.AlteraDados(LCaminhoBanco);
            }


            grdUsuarios.Rows.Clear();
            AtualizaGrid();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            chkAdministrador.Checked = false;
            chkGerenCadastros.Checked = false;
            chkOperacional.Checked = false;
            chkSeguranca.Checked = false;
            LID = "";
            LNome = "";
            LAdministrador = "";
            LGerenciaCadastros = "";
            LOperacional = "";
            LSeguranca = "";
        }

        private void grdUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedRows.Count == 0) return;
            LID = grdUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            LNome = grdUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            LUsuario = grdUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            LAdministrador = grdUsuarios.SelectedRows[0].Cells[4].Value.ToString();
            LGerenciaCadastros = grdUsuarios.SelectedRows[0].Cells[5].Value.ToString();
            LOperacional = grdUsuarios.SelectedRows[0].Cells[6].Value.ToString();
            LSeguranca = grdUsuarios.SelectedRows[0].Cells[7].Value.ToString();
            MostraDados();
        }

        public void MostraDados()
        {
            txtNome.Text = LNome;
            txtUsuario.Text = LUsuario;
            if (LAdministrador == "S")
            {
                chkAdministrador.Checked = true;
            }
            else
            {
                chkAdministrador.Checked = false;
            }


            if (LGerenciaCadastros == "S")
            {
                chkGerenCadastros.Checked = true;
            }
            else
            {
                chkGerenCadastros.Checked = false;
            }


            if (LOperacional == "S")
            {
                chkOperacional.Checked = true;
            }
            else
            {
                chkOperacional.Checked = false;
            }


            if (LSeguranca == "S")
            {
                chkSeguranca.Checked = true;
            }
            else
            {
                chkSeguranca.Checked = false;
            }

        }
    }
}
