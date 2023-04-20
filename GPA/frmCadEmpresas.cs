using Banco_de_Dados;
using Formularios;

namespace GPA

{
    public partial class frmCadEmpresas : Form
    {
        string LCaminhoBanco = "";
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
        public string LIDUsuario = "";
        string LUsuario = "";
        string MsgErro;

        public frmCadEmpresas(string inCaminhoBanco, string inUsuario, string inID)
        {

            InitializeComponent();
            LUsuario = inUsuario;
            LCaminhoBanco = inCaminhoBanco;
            if (inID != "")
            {
                LID = inID;
                MostraDados();
            }
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
                MessageBox.Show("RazaoSocial n�o preechida");
                return;
            }
            objCadastro.RazaoFantasia = txtFantasia.Text;
            if (txtFantasia.Text == "")
            {
                MessageBox.Show("Nome Fantasia n�o preechido");
                return;
            }
            objCadastro.InscricaoEstadual = txtInscricaoEstadual.Text;
            if (txtInscricaoEstadual.Text == "")
            {
                MessageBox.Show("Inscri��o Estadual n�o preechida");
                return;
            }
            objCadastro.CNPJ = txtCNPJ.Text;
            if (txtCNPJ.Text == "")
            {
                MessageBox.Show("CNPJ n�o preechido");
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
            if (Convert.ToString(txtVendedor.Text) == "")
            {
                objCadastro.Vendedor = "";
            }

            objCadastro.Vendedor = LIDUsuario;


            if (chkFabricante.Checked == false && chkFornecedor.Checked == false && chkCliente.Checked == false && chkDistribuidor.Checked == false)
            {
                MessageBox.Show("Ao menos uma identifica��o deve ser selecionada para a empresa");
                return;
            }

            if (txtAviso.Text != "")
            {
                objCadastro.Aviso = txtAviso.Text;
            }
            if (LID == "")
            {
                objCadastro.InsereDados(LCaminhoBanco);
                MsgErro = objCadastro.MsgErro;
                if (MsgErro != "")
                {
                    MessageBox.Show(MsgErro);
                }
                else
                {
                    MessageBox.Show("Cadastro Gravado!", "GPA");
                    LID = objCadastro.Id;
                    MostraDados();
                }
            }
            else
            {
                objCadastro.Id = LID;
                objCadastro.AlteraDados(LCaminhoBanco);
                //string Alterar = "";
                //BDCadastroGeral objAtualiza = new BDCadastroGeral();
                //List<BDCadastroGeral> lstEmpresaAnterior = objEmpresaAnterior.CarregaDados(LID, LRazaoSocial, LRazaoFantasia, LCNPJ, "", "", "", "", "", "");
                //objAtualiza.Id = LID;
                //if (lstEmpresaAnterior[0].RazaoSocial != objCadastro.RazaoSocial)
                //{
                //    objAtualiza.RazaoSocial = objCadastro.RazaoSocial;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].RazaoFantasia != objCadastro.RazaoFantasia)
                //{
                //    objAtualiza.RazaoFantasia = objCadastro.RazaoFantasia;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].InscricaoEstadual != objCadastro.InscricaoEstadual)
                //{
                //    objAtualiza.InscricaoEstadual = objCadastro.InscricaoEstadual;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].CNPJ != objCadastro.CNPJ)
                //{
                //    objAtualiza.CNPJ = objCadastro.CNPJ;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].Cliente != objCadastro.Cliente)
                //{
                //    objAtualiza.Cliente = objCadastro.Cliente;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].Distribuidor != objCadastro.Distribuidor)
                //{
                //    objAtualiza.Distribuidor = objCadastro.Distribuidor;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].Fabricante != objCadastro.Fabricante)
                //{
                //    objAtualiza.Fabricante = objCadastro.Fabricante;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].Fornecedor != objCadastro.Fornecedor)
                //{
                //    objAtualiza.Fornecedor = objCadastro.Fornecedor;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].Aviso != objCadastro.Aviso)
                //{
                //    objAtualiza.Aviso = objCadastro.Aviso;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].RegiaodeVenda != objCadastro.RegiaodeVenda)
                //{
                //    objAtualiza.RegiaodeVenda = objCadastro.RegiaodeVenda;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].Qualificacao != objCadastro.Qualificacao)
                //{
                //    objAtualiza.Qualificacao = objCadastro.Qualificacao;
                //    Alterar = "S";
                //}
                //if (lstEmpresaAnterior[0].RegCobranca != objCadastro.RegCobranca)
                //{
                //    objAtualiza.RegCobranca = objCadastro.RegCobranca;
                //    Alterar = "S";
                //}
                //if (Alterar == "S")
                //{
                //    objAtualiza.AlteraDados();
                //}

                //if (objAtualiza.MsgErro != "")
                //{
                //    MsgErro = objAtualiza.MsgErro;
                //}

                if (objCadastro.MsgErro != "")
                {
                    MessageBox.Show(MsgErro.ToString());
                    return;
                }
                else
                {
                    MessageBox.Show("Dados Gravados!", "GPA");
                    MostraDados();
                }
            }


        }

        private void CarregaCampos(BDCadastroGeral CadastroGeral)
        {
            txtRazaoSocial.Text = LRazaoSocial;
            txtFantasia.Text = LRazaoFantasia;
            txtCNPJ.Text = LCNPJ;
            txtInscricaoEstadual.Text = LInscricaoEstadual;
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
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtRazaoSocial.Text.ToString(), "", "");
                objTela.ShowDialog();

                if (LID != "")
                {
                    BDCadastroGeral objCadastro = new BDCadastroGeral();
                    List<BDCadastroGeral> lstCadastros = objCadastro.CarregaDados(LCaminhoBanco, LID, "", "", "", "", "", "", "", "", "");

                    if (lstCadastros.Count > 0)
                    {
                        if (lstCadastros[0].Aviso != null)
                        {
                            if (lstCadastros[0].Aviso != "")
                            {
                                MessageBox.Show(lstCadastros[0].Aviso.ToString(), "GPA");
                            }
                        }
                    }
                    MostraDados();
                }

            }

        }

        public void MostraDados()
        {
            BDCadastroGeral ObjCadastro = new BDCadastroGeral();
            List<BDCadastroGeral> lstCadastro = ObjCadastro.CarregaDados(LCaminhoBanco, LID, LRazaoSocial, LRazaoFantasia, LCNPJ, "", "", "", "", "", "");
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
            else chkDistribuidor.Checked = false;

            if (lstCadastro[0].Fabricante == "S")
            {
                chkFabricante.Checked = true;
            }
            else chkFabricante.Checked = false;

            if (lstCadastro[0].Fornecedor == "S")
            {
                chkFornecedor.Checked = true;
            }
            else chkFornecedor.Checked = false;

            if (lstCadastro[0].Vendedor != LUsuario)
            {
                SEGUsuario objUsuario = new SEGUsuario();
                List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LUsuario, "", "", "");
                if (lstUsuario.Count > 0)
                {
                    if (lstUsuario[0].GerenciaCadastros != "S")
                    {
                        cmdGravar.Enabled = false;
                    }
                }
            }
            if (lstCadastro[0].Vendedor != null)
            {
                if (lstCadastro[0].Vendedor != "")
                {
                    SEGUsuario objvendedor = new SEGUsuario();
                    List<SEGUsuario> lstUsuarios = objvendedor.CarregaDados(LCaminhoBanco, lstCadastro[0].Vendedor, "", "", "");
                    txtVendedor.Text = lstUsuarios[0].Usuario;
                }
            }
            
            if (lstCadastro[0].Aviso != null)
            {
                if (lstCadastro[0].Aviso != "")
                {
                    txtAviso.Text = lstCadastro[0].Aviso.ToString();
                }
            }
            
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
            if (LID == "")
            {
                MessageBox.Show("Nenhuma empresa selecionada!", "GPA");
                return;
            }
            frmCadContatos objTela = new frmCadContatos(LCaminhoBanco, LID, "");
            objTela.ShowDialog();
        }

        private void cmdEndereco_Click(object sender, EventArgs e)
        {
            if (LID == "")
            {
                MessageBox.Show("Nenhuma empresa selecionada!", "GPA");
                return;
            }

            frmCadEndereco objTela = new frmCadEndereco(LCaminhoBanco, LID);
            objTela.ShowDialog();
        }

        private void CmdRegOcorrencias_Click(object sender, EventArgs e)
        {
            if (LID == "")
            {
                MessageBox.Show("Nenhuma empresa selecionada!", "GPA");
                return;
            }
            frmOcorrencia objTela = new frmOcorrencia(LCaminhoBanco, LID);
            objTela.ShowDialog();
        }

        private void cmdUltVenda_Click(object sender, EventArgs e)
        {
            if (LID == "")
            {
                MessageBox.Show("Nenhuma empresa selecionada!", "GPA");
                return;
            }
            BDPedido objPedido = new BDPedido();
            objPedido.cpEmpresaDR = LID;
            List<BDPedido> lstPedido = objPedido.CarregaDadosUltVenda(LCaminhoBanco, "");

            if (lstPedido.Count > 0)
            {
                frmPedido frmPedido = new frmPedido(LCaminhoBanco, LUsuario, lstPedido[0].cpID.ToString());
                frmPedido.ShowDialog();
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionarUsuario frmUsuario = new frmSelecionarUsuario(LCaminhoBanco, this, "", txtVendedor.Text.ToString());
                frmUsuario.ShowDialog();

                if (LIDUsuario != "")
                {
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LVendedor, "", "", "");
                    txtVendedor.Text = lstUsuario[0].Usuario;
                }
            }
        }
    }
}