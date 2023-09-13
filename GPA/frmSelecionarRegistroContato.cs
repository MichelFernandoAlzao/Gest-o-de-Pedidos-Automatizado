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
    public partial class frmSelecionarRegistroContato : Form
    {
        string LCaminhoBanco;
        public string LID;
        Form LChamador;

        public frmSelecionarRegistroContato(string inCaminhobanco, Form frmChamador, string inID)
        {
            LCaminhoBanco = inCaminhobanco;
            InitializeComponent();
            LChamador = frmChamador;
            LID = inID;

        }

        private void frmSelecionarRegistroContato_Load(object sender, EventArgs e)
        {
            CarregaRegistro(LID);
        }

        private void CarregaRegistro(string inID)
        {
            BDRegistroContato objCadastro = new BDRegistroContato();
            if (LID != "")
            {
                objCadastro.cpID = LID;
            }
            List<BDRegistroContato> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco);
            if (lstCadastro.Count > 0)
            {
                foreach (BDRegistroContato item in lstCadastro)
                {
                    string RazaoSocial;
                    BDCadastroGeral objEmpresa = new BDCadastroGeral();
                    List<BDCadastroGeral> lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, item.cpEmpresaDR, "", "", "", "", "", "", "", "", "", "", "");
                    string[] Row = new string[]
                    {
                            item.cpID.ToString(),
                            lstEmpresa[0].RazaoSocial.ToString(),
                            item.cpDataContato.ToString().Substring(0, 10)
                    };
                    grdRegContatos.Rows.Add(Row);
                }
            }
        }

        private void grdCadastroGeral_SelectionChanged(object sender, EventArgs e)
        {
            if (grdRegContatos.SelectedRows.Count > 0)
            {
                LID = grdRegContatos.SelectedRows[0].Cells[0].Value.ToString();
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
            if (grdRegContatos.SelectedRows.Count > 0)
            {
                var TipoChamador = LChamador.GetType();
                FieldInfo NumeroIDCadastro = TipoChamador.GetField("LIDRegistro");
                NumeroIDCadastro.SetValue(LChamador, grdRegContatos.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdRegContatos_DoubleClick(object sender, EventArgs e)
        {
            CmdSelecionar_Click(sender, e);
        }
    }
}

