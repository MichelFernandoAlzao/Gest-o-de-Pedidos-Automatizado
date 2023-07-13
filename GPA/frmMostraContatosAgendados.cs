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
    public partial class frmMostraContatosAgendados : Form
    {
        string LUsuario = "";
        string LCaminhoBanco = "";
        public frmMostraContatosAgendados(string inCaminhoBanco, string inUsuario)
        {
            LUsuario = inUsuario;
            LCaminhoBanco = inCaminhoBanco;
            InitializeComponent();
            CarregaAvisos();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaAvisos()
        {
            grdAviso.Rows.Clear();
            BDAvisos objAvisos = new BDAvisos();
            objAvisos.cpUsuarioDR = LUsuario;
            objAvisos.cpConfirmado = "N";
            List<BDAvisos> lstAvisos = objAvisos.CarregaDados(LCaminhoBanco);
            if (lstAvisos.Count > 0)
            {
                foreach (BDAvisos item in lstAvisos)
                {
                    string usuario = "";
                    List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                    if (item.cpUsuarioDR != "" && item.cpUsuarioDR != null)
                    {
                        SEGUsuario objUsuario = new SEGUsuario();
                        lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, item.cpUsuarioDR, "", "", "");
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
                     };
                    grdAviso.Rows.Add(Row);
                }
            }
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            if (grdAviso.RowCount > 0)
            {
                BDAvisos objAviso = new BDAvisos();
                objAviso.cpID = grdAviso.SelectedRows[0].Cells[0].Value.ToString();
                objAviso.cpConfirmado = "S";
                objAviso.AlteraDados(LCaminhoBanco);
            }
            CarregaAvisos();
        }
    }
}
