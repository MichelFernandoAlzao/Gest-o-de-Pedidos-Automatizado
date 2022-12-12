using Banco_de_Dados;

namespace GPA
    
{
    public partial class frmCadEmpresas : Form
    {
        string RazaoSocial = "";
        string RazaoFantasia = "";
        string CNPJ = "";
        string InscricaoEstadual = "";
        string Vendedor = "";
        char Cliente;
        char Distribuidor;
        char Fabricante;
        char FOrnecedor;
        int Enderecos;
        int Contatos;
        List<string> LParametros;
        string MsgErro;

        public frmCadEmpresas(List<string> lParametros)
        {
            InitializeComponent();
            LParametros = lParametros;
        }

        private void frmCadEmpresas_Load(object sender, EventArgs e)
        {

        }

        


        private void cmdNovo_Click(object sender, EventArgs e)
        {
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
            BDCadastroGeral objCadastro = new BDCadastroGeral();
            objCadastro.RazaoSocial = txtRazaoSocial.Text;
            objCadastro.RazaoFantasia = txtFantasia.Text;
            objCadastro.InscricaoEstadual = txtInscricaoEstadual.Text;
            objCadastro.CNPJ = txtCNPJ.Text;
            if (chkFabricante.Checked) objCadastro.Fabricante = 'S';
            if (chkCliente.Checked) objCadastro.Cliente = 'S';
            if (chkFornecedor.Checked) objCadastro.Fornecedor = 'S';
            if (chkDistribuidor.Checked) objCadastro.Distribuidor = 'S';

            objCadastro.InsereDados(LParametros);
            MsgErro = objCadastro.MsgErro;
            if (MsgErro != null)
            {
                MessageBox.Show(MsgErro);
            }
            else MostraDados();
        }

        private void CarregaCampos(BDCadastroGeral CadastroGeral)
        {
            txtRazaoSocial.Text =  RazaoSocial;
            txtFantasia.Text =  RazaoFantasia;
            txtCNPJ.Text = CNPJ;
            txtInscricaoEstadual.Text =  InscricaoEstadual;
            txtVendedor.Text = Vendedor;
            if (Cliente == 'S') chkCliente.Checked = true;
            if (Distribuidor == 'S') chkDistribuidor.Checked = true;
            if (Fabricante == 'S') chkFabricante.Checked = true;
            if (FOrnecedor == 'S') chkFornecedor.Checked = true;

        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                BDCadastroGeral objCadastro = new BDCadastroGeral();
                objCadastro.CarregaDados(LParametros[0], txtRazaoSocial.Text);
            }
        }

        public void MostraDados()
        {
            txtRazaoSocial.Text = RazaoSocial;
            txtFantasia.Text = RazaoFantasia;
            txtCNPJ.Text = CNPJ;
            txtInscricaoEstadual.Text = InscricaoEstadual;
            if (Cliente == 'S') chkCliente.Checked = true;
            if (Distribuidor == 'S') chkDistribuidor.Checked = true;
            if (Fabricante == 'S') chkFabricante.Checked = true;
            if (FOrnecedor == 'S') chkFornecedor.Checked = true;
            if (Vendedor != null)
            {
                Vendedores objvendedor = new Vendedores();
                objvendedor.CarregaDados(LParametros, Convert.ToInt32(Vendedor));
                txtVendedor.Text = objvendedor.Nome;
            }
        }
    }
}