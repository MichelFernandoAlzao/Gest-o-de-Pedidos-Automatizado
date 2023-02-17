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
        char LCliente;
        char LDistribuidor;
        char LFabricante;
        char LFOrnecedor;
        int LEnderecos;
        int LContatos;
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
            chkCliente.Checked = false;
            chkDistribuidor.Checked = false;
            chkFabricante.Checked = false;
            chkFornecedor.Checked = false;
            MostraDados();
        }

        private void Gravar(object sender, EventArgs e)
        {
            BDCadastroGeral objEmpresaAnterior = new BDCadastroGeral();
            

            
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            objCadastro.RazaoSocial = txtRazaoSocial.Text;
            if (txtRazaoSocial.Text == "") 
            {
                MessageBox.Show("RazaoSocial não preechida");
            }
            objCadastro.RazaoFantasia = txtFantasia.Text;
            if(txtFantasia.Text == "")
            {
                MessageBox.Show("Nome Fantasia não preechido");
            }
            objCadastro.InscricaoEstadual = txtInscricaoEstadual.Text;
            if(txtInscricaoEstadual.Text == "")
            {
                MessageBox.Show("Inscrição Estadual não preechida");
            }
            objCadastro.CNPJ = txtCNPJ.Text;
            if(txtCNPJ.Text == "")
            {
                MessageBox.Show("CNPJ não preechido");
            }
            if (chkFabricante.Checked)
            {
                objCadastro.Fabricante = 'S';
            }
            else
            {
                objCadastro.Fabricante = 'N';
            }
            if (chkCliente.Checked)
            {
                objCadastro.Cliente = 'S';
            }
            else
            {
                objCadastro.Cliente = 'N';
            }
            if (chkFornecedor.Checked)
            {
                objCadastro.Fornecedor = 'S';
            }
            else
            {
                objCadastro.Fornecedor = 'N';
            }
            if (chkDistribuidor.Checked)
            {
                objCadastro.Distribuidor = 'S';
            }
            else
            {
                objCadastro.Distribuidor = 'N';
            }
            if(Convert.ToString(txtVendedor.Text) == "")
            {
                objCadastro.Vendedor = "";
            }
            
            if(chkFabricante.Checked == false && chkFornecedor.Checked == false && chkCliente.Checked == false && chkDistribuidor.Checked == false)
            {
                MessageBox.Show("Ao menos uma identificação deve ser selecionada para a empresa");
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
                BDCadastroGeral objAtualiza = new BDCadastroGeral();
                List<BDCadastroGeral> lstEmpresaAnterior = objEmpresaAnterior.CarregaDados(LID, LRazaoSocial, LRazaoFantasia, LCNPJ, "", "", "", "", "", "");
                if (lstEmpresaAnterior[0].RazaoSocial != objCadastro.RazaoSocial)
                {
                    objAtualiza.RazaoSocial = objCadastro.RazaoSocial;
                }
                if (lstEmpresaAnterior[0].RazaoFantasia != objCadastro.RazaoFantasia)
                {
                    objAtualiza.RazaoFantasia = objCadastro.RazaoFantasia;
                }
                if (lstEmpresaAnterior[0].InscricaoEstadual != objCadastro.InscricaoEstadual)
                {
                    objAtualiza.InscricaoEstadual = objCadastro.InscricaoEstadual;
                }
                if (lstEmpresaAnterior[0].CNPJ != objCadastro.CNPJ)
                {
                    objAtualiza.CNPJ = objCadastro.CNPJ;
                }
                if (lstEmpresaAnterior[0].Cliente != objCadastro.Cliente)
                {
                    objAtualiza.Cliente = objCadastro.Cliente;
                }
                if (lstEmpresaAnterior[0].Distribuidor != objCadastro.Distribuidor)
                {
                    objAtualiza.Distribuidor = objCadastro.Distribuidor;
                }
                if (lstEmpresaAnterior[0].Fabricante != objCadastro.Fabricante)
                {
                    objAtualiza.Fabricante = objCadastro.Fabricante;
                }
                if (lstEmpresaAnterior[0].Fornecedor != objCadastro.Fornecedor)
                {
                    objAtualiza.Fornecedor = objCadastro.Fornecedor;
                }
                if (lstEmpresaAnterior[0].Aviso != objCadastro.Aviso)
                {
                    objAtualiza.Aviso = objCadastro.Aviso;
                }
                if (lstEmpresaAnterior[0].RegiaodeVenda != objCadastro.RegiaodeVenda)
                {
                    objAtualiza.RegiaodeVenda = objCadastro.RegiaodeVenda;
                }
                if (lstEmpresaAnterior[0].Qualificacao != objCadastro.Qualificacao)
                {
                    objAtualiza.Qualificacao = objCadastro.Qualificacao;
                }
                if (lstEmpresaAnterior[0].RegCobranca != objCadastro.RegCobranca)
                {
                    objAtualiza.RegCobranca = objCadastro.RegCobranca;
                }
                objAtualiza.AlteraDados(LParametros,objAtualiza);
                if (objAtualiza.MsgErro != "")
                {
                    MsgErro = objAtualiza.MsgErro;
                }
            }
            if(MsgErro != "")
            {
                MessageBox.Show(MsgErro.ToString());
                return;
            }
            else 
            {
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
            if (LCliente == 'S') chkCliente.Checked = true;
            if (LDistribuidor == 'S') chkDistribuidor.Checked = true;
            if (LFabricante == 'S') chkFabricante.Checked = true;
            if (LFOrnecedor == 'S') chkFornecedor.Checked = true;

        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(this,txtRazaoSocial.Text.ToString(),"","");
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
            if (lstCadastro[0].Cliente == 'S') 
            {
                chkCliente.Checked = true; 
            }
            else chkCliente.Checked = false;

            if (lstCadastro[0].Distribuidor == 'S')
            {
                chkDistribuidor.Checked = true;
            }
            else chkDistribuidor.Checked= false;

            if (lstCadastro[0].Fabricante == 'S')
            {
                chkFabricante.Checked = true;
            }
            else chkFabricante.Checked = false;

            if (lstCadastro[0].Fornecedor == 'S')
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
    }
}