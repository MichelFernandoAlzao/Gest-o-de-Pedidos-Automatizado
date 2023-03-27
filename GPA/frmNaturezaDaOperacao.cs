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
    public partial class frmNaturezaDaOperacao : Form
    {
        string LCaminhoBanco = "";
        public string LID = "";
        public string LDescricao = "";
        public string LVenda = "";
        public string LBonificacao = "";
        public string LBrinde = "";
        public string LInterno = "";
        public string LRestrito = "";
        string LUsuario = "";
        public frmNaturezaDaOperacao(string inCmainhoBanco,string inUsuario)
        {
            LCaminhoBanco=inCmainhoBanco;
            InitializeComponent();
            LUsuario = inUsuario;
            TestaUsuario();
            CarregaGrid();
            if (grdNatOperacao.SelectedRows.Count != 0)
            {
                LID = grdNatOperacao.SelectedRows[0].Cells[0].Value.ToString();
                LDescricao = grdNatOperacao.SelectedRows[0].Cells[1].Value.ToString();
                LVenda = grdNatOperacao.SelectedRows[0].Cells[2].Value.ToString();
                LBonificacao = grdNatOperacao.SelectedRows[0].Cells[3].Value.ToString();
                LBrinde = grdNatOperacao.SelectedRows[0].Cells[4].Value.ToString();
                LInterno = grdNatOperacao.SelectedRows[0].Cells[5].Value.ToString();
                LRestrito = grdNatOperacao.SelectedRows[0].Cells[6].Value.ToString();
            }
            

        }

        public void TestaUsuario()
        {
            SEGUsuario objUsuario = new SEGUsuario();
            objUsuario.ID = LUsuario;
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LUsuario,"","","");
            if (lstUsuario[0].GerenciaCadastros != "S")
            {
                MessageBox.Show("Usuario sem permissão para alterar/Cadastrar Naturezas", "GPA");
                this.Close();
            }
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            chkVenda.Checked = false;
            chkBonificacao.Checked = false;
            chkBrinde.Checked = false;
            chkInterno.Checked = false;
            chkRestrito.Checked = false;
            LID = "";
            LDescricao = "";
            LVenda = "";
            LBonificacao = "";
            LBrinde = "";
            LInterno = "";
            LRestrito = "";
        
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            BDNatOperacao objNatOperacao = new BDNatOperacao();
            objNatOperacao.cpID = LID;
            objNatOperacao.Excluir(LCaminhoBanco);
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            BDNatOperacao objNatureza = new BDNatOperacao();
            objNatureza.cpDescricao = txtDescricao.Text;
            if(chkVenda.Checked == true)
            {
                objNatureza.cpVenda = "S";
            }
            else
            {
                objNatureza.cpVenda="N";
            }
            if(chkBonificacao.Checked == true)
            {
                objNatureza.cpBonificacao = "S";
            }
            else
            {
                objNatureza.cpBonificacao="N";
            }
            if(chkBrinde.Checked == true)
            {
                objNatureza.cpBrinde = "S";
            }
            else
            {
                objNatureza.cpBrinde ="N";
            }
            if(chkInterno.Checked == true)
            {
                objNatureza.cpInterno="S";
            }
            else
            {
                objNatureza.cpInterno = "N";
            }
            if (chkRestrito.Checked == true)
            {
                objNatureza.cpRestrito = "S";
            }
            else
            {
                objNatureza.cpRestrito = "N";
            }

            if(LID == "")
            {
                objNatureza.InsereDados(LCaminhoBanco);
            }
            else
            {
                objNatureza.cpID = LID;
                objNatureza.AlteraDados(LCaminhoBanco);
            }

            grdNatOperacao.Rows.Clear();
            CarregaGrid();
            if (grdNatOperacao.SelectedRows.Count != 0)
            {
                LID = grdNatOperacao.SelectedRows[0].Cells[0].Value.ToString();
                LDescricao = grdNatOperacao.SelectedRows[0].Cells[1].Value.ToString();
                LVenda = grdNatOperacao.SelectedRows[0].Cells[2].Value.ToString();
                LBonificacao = grdNatOperacao.SelectedRows[0].Cells[3].Value.ToString();
                LBrinde = grdNatOperacao.SelectedRows[0].Cells[4].Value.ToString();
                LInterno = grdNatOperacao.SelectedRows[0].Cells[5].Value.ToString();
                LRestrito = grdNatOperacao.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void CarregaGrid()
        {
            
            BDNatOperacao objCadastro = new BDNatOperacao();
            List<BDNatOperacao> lstCadastro = objCadastro.CarregaDadosTotal(LCaminhoBanco);
            if (lstCadastro.Count > 0)
            {
                foreach (BDNatOperacao item in lstCadastro)
                {
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpDescricao.ToString(),
                            item.cpVenda.ToString(),
                            item.cpBonificacao.ToString(),
                            item.cpBrinde.ToString(),
                            item.cpInterno.ToString(),
                            item.cpRestrito.ToString(),
                        };
                    grdNatOperacao.Rows.Add(Row);
                }
            }
        }

        private void grdNatOperacao_SelectionChanged(object sender, EventArgs e)
        {
            if (grdNatOperacao.SelectedRows.Count == 0) return;
            LID = grdNatOperacao.SelectedRows[0].Cells[0].Value.ToString();
            LDescricao = grdNatOperacao.SelectedRows[0].Cells[1].Value.ToString();
            LVenda = grdNatOperacao.SelectedRows[0].Cells[2].Value.ToString();
            LBonificacao = grdNatOperacao.SelectedRows[0].Cells[3].Value.ToString();
            LBrinde = grdNatOperacao.SelectedRows[0].Cells[4].Value.ToString();
            LInterno = grdNatOperacao.SelectedRows[0].Cells[5].Value.ToString();
            LRestrito = grdNatOperacao.SelectedRows[0].Cells[6].Value.ToString();
            
            MostraDados();
        }

        public void MostraDados()
        {
            txtDescricao.Text = LDescricao;

            if(LVenda == "S")
            {
                chkVenda.Checked = true;
            }
            else
            {
                chkVenda.Checked = false;
            }

            if(LBonificacao == "S")
            {
                chkBonificacao.Checked = true;
            }
            else
            {
                chkBonificacao.Checked= false;
            }
            if(LBrinde == "S")
            {
                chkBrinde.Checked = true;
            }
            if(LInterno == "S")
            {
                chkInterno.Checked = true;
            }
            else
            {
                chkInterno.Checked = false;
            }
            
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
