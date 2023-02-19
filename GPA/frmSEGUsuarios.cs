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
        string LID;
        string LUsuario;
        string LNome;
        public frmSEGUsuarios()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSEGUsuarios_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            List<SEGUsuario> lstUsuarios = new List<SEGUsuario>();
            SEGUsuario objUsuario = new SEGUsuario();
            lstUsuarios =  objUsuario.CarregaDados(LID,LUsuario,LNome,"");

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
                            item.Administrador.ToString(),
                            item.GerenciaCadastros.ToString()
                        };
                    grdUsuarios.Rows.Add(Row);
                }
            }
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            List<SEGUsuario> lstUsuarios = new List<SEGUsuario>();
            SEGUsuario objUsuario = new SEGUsuario();
            lstUsuarios = objUsuario.CarregaDados("", txtUsuario.Text, txtNome.Text, "");
            if(lstUsuarios.Count == 0)
            {
                MessageBox.Show("Já existe um usuário com esta identificação");
            }
            else
            {
                SEGUsuario objInsUsuario = new SEGUsuario();
                objInsUsuario.InsereDados(txtNome.Text, txtUsuario.Text);
            }
            AtualizaGrid();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            chkAdministrador.Checked = false;
            chkGerenCadastros.Checked = false;
        }
    }
}
