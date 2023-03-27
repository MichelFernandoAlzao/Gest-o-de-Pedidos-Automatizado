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
    public partial class frmParametrosdoGestor : Form
    {
        string LcaminhoBanco = "";
        string LIDParametro = "";
        public string LID = "";
        public string LRazaoSocial ="";
        public frmParametrosdoGestor(string inCaminhoBanco)
        {
            LcaminhoBanco = inCaminhoBanco;
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            int PrazoContato;
            int PrazoVenda;
            BDParametros objParametros = new BDParametros();
            if(txtPrazoContato.Text != "")
            {
                if (int.TryParse(txtPrazoContato.Text, out PrazoContato))
                {
                    objParametros.cpDiasContato = Convert.ToString(PrazoContato);
                }
            }
            else
            {
                MessageBox.Show("Obrigatorio o preechimento do prazo para contato!", "GPA");
                return;
            }

            if(txtPrazoUltVenda.Text != "")
            {
                if(int.TryParse(txtPrazoUltVenda.Text,out PrazoVenda))
                {
                    objParametros.cpDiasUltVenda = Convert.ToString(PrazoVenda);
                }
            }
            else
            {
                MessageBox.Show("Obrigatorio o preechimento do prazo para ultima Venda!", "GPA");
                return;
            }
            if(LID != "")
            {
                objParametros.cpEmpresaDR = LID;
            }
            else
            {
                MessageBox.Show("Obrigatorio selecionar a propria empresa!", "GPA");
                return;
            }

            if(LIDParametro == "")
            {
                objParametros.InsereDados(LcaminhoBanco);
            }
            else
            {
                objParametros.cpID = LIDParametro;
                objParametros.AlteraDados(LcaminhoBanco);
            }

            


        }

        private void frmParametrosdoGestor_Load(object sender, EventArgs e)
        {
            BDParametros objParametros = new BDParametros();

            List<BDParametros> lstParametros = objParametros.CarregaDados(LcaminhoBanco);
            if(lstParametros.Count > 0)
            {
                LIDParametro = lstParametros[0].cpID;
                LID = lstParametros[0].cpEmpresaDR;
                txtPrazoContato.Text = lstParametros[0].cpDiasContato;
                txtPrazoUltVenda.Text = lstParametros[0].cpDiasUltVenda;

                BDCadastroGeral objCadastro = new BDCadastroGeral();
                List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LcaminhoBanco,LID, "", "", "", "", "", "", "", "", "");
                LRazaoSocial = lstCadastro[0].RazaoSocial;
                txtEmpresaPadrao.Text = lstCadastro[0].RazaoSocial;
            }
            CarregaUsuarios();
            
        }

        private void txtEmpresaPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(LcaminhoBanco,this, "", txtEmpresaPadrao.Text.ToString(), "", "");
                objTela.ShowDialog();
                if(LRazaoSocial != "")
                {
                    txtEmpresaPadrao.Text = LRazaoSocial;
                }
            }
        }

        private void CarregaUsuarios()
        {
            SEGUsuario objUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LcaminhoBanco,"", "", "", "");
            if (lstUsuario.Count > 0)
            {
                foreach (SEGUsuario item in lstUsuario)
                {
                    string[] Row = new string[]
                        {
                            item.ID.ToString(),
                            item.Nome.ToString(),
                            item.Meta.ToString(),
                        };
                    grdMetasMensais.Rows.Add(Row);
                }
            }
        }

        private void cmdGravarMetas_Click(object sender, EventArgs e)
        {
            List<SEGUsuario> lstUsuarios = new List<SEGUsuario>(); ;
            foreach (DataGridViewRow row in grdMetasMensais.Rows)
            {
                double Valor;
                SEGUsuario objusuario = new SEGUsuario();
                objusuario.ID = row.Cells[0].Value.ToString();
                if (double.TryParse(row.Cells[2].Value.ToString(), out Valor))
                {
                    objusuario.Meta = Valor.ToString();
                }
                else
                {
                    MessageBox.Show("Valor de meta informado para " + row.Cells[1].Value.ToString() + " em formato invalido","GPA");
                    return;
                }
                
                lstUsuarios.Add(objusuario);
            }

            foreach(SEGUsuario Usuario in lstUsuarios)
            {
                Usuario.AlteraDados(LcaminhoBanco);
                if(Usuario.MsgErro != null)
                {
                    MessageBox.Show("Erro ao alterar meta do usuário " + Usuario.ID.ToString(), "");
                }
            }
        }
    }
}
