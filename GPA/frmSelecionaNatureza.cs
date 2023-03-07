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
    public partial class frmSelecionaNatureza : Form
    {
        public string LID;
        private string LUsuario;
        Form LChamador;

        public frmSelecionaNatureza(Form frmChamador,string inUsuario)
        {
            InitializeComponent();
            LUsuario = inUsuario;
            LChamador = frmChamador;
        }

        private void frmSelecionaNatureza_Load(object sender, EventArgs e)
        {
            CarregaNatureza(LID, LUsuario);
        }

        private void CarregaNatureza(string inID, string inUsuario)
        {
            BDNatOperacao objNatureza = new BDNatOperacao();
            List<BDNatOperacao> lstNatureza = new List<BDNatOperacao>(); 
            SEGUsuario objUsuario = new SEGUsuario();
            objUsuario.ID = inUsuario;
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(inUsuario, "", "", "");
            if (lstUsuario[0].Administrador == "S")
            {
                lstNatureza = objNatureza.CarregaDadosTotal();
            }
            else
            {
                lstNatureza = objNatureza.CarregaRestritas();
            }
            
            
            if (lstNatureza.Count > 0)
            {
                foreach (BDNatOperacao item in lstNatureza)
                {
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpDescricao.ToString()
                        };
                    grdNatureza.Rows.Add(Row);
                }
            }
        }

        private void grdNatureza_SelectionChanged(object sender, EventArgs e)
        {
            if (grdNatureza.SelectedRows.Count > 0)
            {
                LID = grdNatureza.SelectedRows[0].Cells[0].Value.ToString();
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
            if (grdNatureza.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LIDNaturezaOperacao");
                NumeroIDCadastro.SetValue(LChamador, grdNatureza.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
