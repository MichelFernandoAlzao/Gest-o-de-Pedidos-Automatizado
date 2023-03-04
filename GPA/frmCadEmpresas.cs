using Banco_de_Dados;
using Formularios;

namespace GPA
    
{
    public partial class frmCadEmpresas : Form
    {
        public string LID = "";
        public string LRazaoSocial = "";
        string LRazaoFantasia = "";
        string LCNPJ = "";
        string LInscricaoEstadual = "";
        string LVendedor = "";
        string LCliente;
        string LDistribuidor;
        string LFabricante;
        string LFOrnecedor;
        string LRegVenda;
        string LRegCobranca;
        string LQualificacao;
        string LDiasAtraso;
        string LAviso;
        string[] LParametros;
        string MsgErro;

        public frmCadEmpresas()
        {
            InitializeComponent();
            
        }

        private void frmCadEmpresas_Load(object sender, EventArgs e)
        {

        }

        


        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LID = "";
            txtRazaoSocial.Text = "";
            txtFantasia.Text = "";
            txtCNPJ.Text = "";
            txtVendedor.Text = "";
            txtAviso.Text = "";
            txtRegVenda.Text = "";
            txtInscricaoEstadual.Text = "";
            txtQualificacao.Text = "";
            txtDiasAtraso.Text = "";
            txtRegCobranca.Text = "";
            chkCliente.Checked = false;
            chkDistribuidor.Checked = false;
            chkFabricante.Checked = false;
            chkFornecedor.Checked = false;
            LID = "";
            LRazaoSocial = "";
            LRazaoFantasia = "";
            LCNPJ = "";
            LInscricaoEstadual = "";
            LVendedor = "";
            LCliente = "";
            LDistribuidor = "";
            LFabricante = "";
            LFOrnecedor = "";
            LRegVenda = "";
            LRegCobranca = "";
            LAviso = "";
            MsgErro = "";
    }

        private void Gravar(object sender, EventArgs e)
        {

            BDCadastroGeral objEmpresaAnterior = new BDCadastroGeral();

            BDCadastroGeral objCadastro = new BDCadastroGeral();
            objCadastro.RazaoSocial = txtRazaoSocial.Text;
            if (txtRazaoSocial.Text == "") 
            {
                MessageBox.Show("RazaoSocial não preechida");
                return;
            }
            objCadastro.RazaoFantasia = txtFantasia.Text;
            if(txtFantasia.Text == "")
            {
                MessageBox.Show("Nome Fantasia não preechido");
                return;
            }
            objCadastro.InscricaoEstadual = txtInscricaoEstadual.Text;
            if(txtInscricaoEstadual.Text == "")
            {
                MessageBox.Show("Inscrição Estadual não preechida");
                return;
            }
            objCadastro.CNPJ = txtCNPJ.Text;
            if(txtCNPJ.Text == "")
            {
                MessageBox.Show("CNPJ não preechido");
                return;
            }
            objCadastro.Aviso = txtAviso.Text;

            objCadastro.RegiaodeVenda = LRegVenda;

            objCadastro.Qualificacao = LQualificacao;

            objCadastro.DiasAtraso = txtDiasAtraso.Text;

            objCadastro.RegCobranca = LRegCobranca;

            objCadastro.RegiaodeVenda = LRegVenda;
            if (chkFabricante.Checked)
            {
                objCadastro.Fabricante = "S";
            }
            else
            {
                objCadastro.Fabricante = "N";
            }
            if (chkCliente.Checked)
            {
                objCadastro.Cliente = "S";
            }
            else
            {
                objCadastro.Cliente = "N";
            }
            if (chkFornecedor.Checked)
            {
                objCadastro.Fornecedor = "S";
            }
            else
            {
                objCadastro.Fornecedor = "N";
            }
            if (chkDistribuidor.Checked)
            {
                objCadastro.Distribuidor = "S";
            }
            else
            {
                objCadastro.Distribuidor = "N";
            }
            if(Convert.ToString(txtVendedor.Text) == "")
            {
                objCadastro.Vendedor = "";
            }
            
            if(chkFabricante.Checked == false && chkFornecedor.Checked == false && chkCliente.Checked == false && chkDistribuidor.Checked == false)
            {
                MessageBox.Show("Ao menos uma identificação deve ser selecionada para a empresa");
                return;
            }

            if(LID == "")
            {
                objCadastro.InsereDados(LParametros);
                MsgErro = objCadastro.MsgErro;
                if (MsgErro != null)
                {
                    MessageBox.Show(MsgErro);
                }
            }
            else
            {
                string Alterar = "";
                BDCadastroGeral objAtualiza = new BDCadastroGeral();
                List<BDCadastroGeral> lstEmpresaAnterior = objEmpresaAnterior.CarregaDados(LID, LRazaoSocial, LRazaoFantasia, LCNPJ, "", "", "", "", "", "");
                objAtualiza.Id = LID;
                if (lstEmpresaAnterior[0].RazaoSocial != objCadastro.RazaoSocial)
                {
                    objAtualiza.RazaoSocial = objCadastro.RazaoSocial;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].RazaoFantasia != objCadastro.RazaoFantasia)
                {
                    objAtualiza.RazaoFantasia = objCadastro.RazaoFantasia;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].InscricaoEstadual != objCadastro.InscricaoEstadual)
                {
                    objAtualiza.InscricaoEstadual = objCadastro.InscricaoEstadual;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].CNPJ != objCadastro.CNPJ)
                {
                    objAtualiza.CNPJ = objCadastro.CNPJ;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].Cliente != objCadastro.Cliente)
                {
                    objAtualiza.Cliente = objCadastro.Cliente;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].Distribuidor != objCadastro.Distribuidor)
                {
                    objAtualiza.Distribuidor = objCadastro.Distribuidor;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].Fabricante != objCadastro.Fabricante)
                {
                    objAtualiza.Fabricante = objCadastro.Fabricante;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].Fornecedor != objCadastro.Fornecedor)
                {
                    objAtualiza.Fornecedor = objCadastro.Fornecedor;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].Aviso != objCadastro.Aviso)
                {
                    objAtualiza.Aviso = objCadastro.Aviso;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].RegiaodeVenda != objCadastro.RegiaodeVenda)
                {
                    objAtualiza.RegiaodeVenda = objCadastro.RegiaodeVenda;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].Qualificacao != objCadastro.Qualificacao)
                {
                    objAtualiza.Qualificacao = objCadastro.Qualificacao;
                    Alterar = "S";
                }
                if (lstEmpresaAnterior[0].RegCobranca != objCadastro.RegCobranca)
                {
                    objAtualiza.RegCobranca = objCadastro.RegCobranca;
                    Alterar = "S";
                }
                if(Alterar == "S")
                {
                    objAtualiza.AlteraDados();
                }
                
                if (objAtualiza.MsgErro != "")
                {
                    MsgErro = objAtualiza.MsgErro;
                }
            }
            if(MsgErro != null)
            {
                MessageBox.Show(MsgErro.ToString());
                return;
            }
            else 
            {
                MessageBox.Show("Dados Gravados!","GPA");
                MostraDados();
            }
            
        }

        private void CarregaCampos(BDCadastroGeral CadastroGeral)
        {
            txtRazaoSocial.Text =  LRazaoSocial;
            txtFantasia.Text =  LRazaoFantasia;
            txtCNPJ.Text = LCNPJ;
            txtInscricaoEstadual.Text =  LInscricaoEstadual;
            txtVendedor.Text = LVendedor;
            if (LCliente == "S") chkCliente.Checked = true;
            if (LDistribuidor == "S") chkDistribuidor.Checked = true;
            if (LFabricante == "S") chkFabricante.Checked = true;
            if (LFOrnecedor == "S") chkFornecedor.Checked = true;

        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this,"",txtRazaoSocial.Text.ToString(),"","");
                objTela.ShowDialog();
                MostraDados();
            }
            
        }

        public void MostraDados()
        {
            BDCadastroGeral ObjCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = ObjCadastro.CarregaDados(LID,LRazaoSocial,LRazaoFantasia,LCNPJ,"","","","","","");
            txtRazaoSocial.Text = lstCadastro[0].RazaoSocial.ToString();
            txtFantasia.Text = lstCadastro[0].RazaoFantasia.ToString();
            txtCNPJ.Text = lstCadastro[0].CNPJ.ToString();
            txtInscricaoEstadual.Text = lstCadastro[0].InscricaoEstadual.ToString();
            if (lstCadastro[0].Cliente == "S") 
            {
                chkCliente.Checked = true; 
            }
            else chkCliente.Checked = false;

            if (lstCadastro[0].Distribuidor == "S")
            {
                chkDistribuidor.Checked = true;
            }
            else chkDistribuidor.Checked= false;

            if (lstCadastro[0].Fabricante == "S")
            {
                chkFabricante.Checked = true;
            }
            else chkFabricante.Checked = false;

            if (lstCadastro[0].Fornecedor == "S")
            {
                chkFornecedor.Checked = true;
            }
            else chkFornecedor.Checked= false;
            //if (lstCadastro[0].Vendedor != "")
            //{
            //    Vendedores objvendedor = new Vendedores();
            //    objvendedor.CarregaDados(LParametros, Convert.ToInt32(LVendedor));
            //    txtVendedor.Text = objvendedor.Nome;
            //}
        }

        private void labCNPJ_Click(object sender, EventArgs e)
        {

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdContatos_Click(object sender, EventArgs e)
        {
            if (LID == "") return;

            frmCadContatos objTela = new frmCadContatos(LID,"");
            objTela.ShowDialog();
        }

        private void cmdEndereco_Click(object sender, EventArgs e)
        {
            if (LID == "") return;

            frmCadEndereco objTela = new frmCadEndereco(LID);
            objTela.ShowDialog();
        }

        private void CmdRegOcorrencias_Click(object sender, EventArgs e)
        {
            frmOcorrencia objTela = new frmOcorrencia();
            objTela.ShowDialog();
        }
    }
}