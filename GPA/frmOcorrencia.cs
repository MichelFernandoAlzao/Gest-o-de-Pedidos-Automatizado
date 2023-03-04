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
    public partial class frmOcorrencia : Form
    {
        string LID = "";
        string LEmpresaDR = "";
        string LData = "";
        string LDescricao = "";
        string LPedidoDR = "";


        public frmOcorrencia()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
