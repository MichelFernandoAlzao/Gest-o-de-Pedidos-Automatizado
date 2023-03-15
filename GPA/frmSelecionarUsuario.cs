using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_Dados;

namespace Formularios
{
    public partial class frmSelecionarUsuario : Form
    {
        public string LID;
        private string Lusuario;
        string LFabricanteDR;
        string LCodFabricante;
        Form LChamador;

        public frmSelecionarUsuario(Form frmChamador, string inID, string inUsuario)
        {
            InitializeComponent();
            LID = inID;
            Lusuario = inUsuario;
            LChamador = frmChamador;
        }

        private void frmSelecionaProduto_Load(object sender, EventArgs e)
        {
            CarregaProduto(LID,Lusuario);
        }

        private void CarregaProduto(string inID, string inUsuario)
        {
            SEGUsuario objCadastro = new SEGUsuario();
            List<SEGUsuario> lstCadastro = objCadastro.CarregaDados(inID,inUsuario,"","");
            if (lstCadastro.Count > 0)
            {
                foreach (SEGUsuario item in lstCadastro)
                {
                    string[] Row = new string[]
                        {
                            item.ID.ToString(),
                            item.Usuario.ToString(),
                        };
                    grdUsuarios.Rows.Add(Row);
                }
            }
        }

        private void grdCadastroGeral_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedRows.Count > 0)
            {
                LID = grdUsuarios.SelectedRows[0].Cells[0].Value.ToString();
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
            if (grdUsuarios.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LIDUsuario");
                NumeroIDCadastro.SetValue(LChamador, grdUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
