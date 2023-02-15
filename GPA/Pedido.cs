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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }

        private void cmdItensPedido_Click(object sender, EventArgs e)
        {
            frmItensPedido objItensPedido = new frmItensPedido();
            objItensPedido.ShowDialog();
        }
    }
}
