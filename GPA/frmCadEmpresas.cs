using Banco_de_Dados;
using Formularios;

namespace GPA

{
    public partial class frmCadEmpresas : Form
    {
        string LCaminhoBanco = "";
        public string LID = "";
        public string LRazaoSocial = "";
        public string LIDCarteira = "";
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
            txtCNPJ.FormatProvider = new System.Globalization.CultureInfo("en-US");
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
            chkLivre.Checked = false;
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
            if (txtFantasia.Text == "")
            {
                MessageBox.Show("Nome Fantasia não preechido");
                return;
            }
            objCadastro.InscricaoEstadual = txtInscricaoEstadual.Text;
            if (txtInscricaoEstadual.Text == "")
            {
                MessageBox.Show("Inscrição Estadual não preechida");
                return;
            }

            if (txtCNPJ.Text.ToString().Replace(" ", "").Replace(".", "").Replace("/", "").Replace("-", "") == "")
            {
                MessageBox.Show("CNPJ não preechido");
                return;
            }
            if (txtCNPJ.Text.ToString().Replace(" ", "").Replace(".", "").Replace("/", "").Replace("-", "").Length < 14)
            {
                MessageBox.Show("Comprimento do CNPJ invalido", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            objCadastro.CNPJ = txtCNPJ.Text;
            objCadastro.Aviso = txtAviso.Text;
            if (chkAtivo.Checked)
            {
                objCadastro.Ativo = "S";
            }
            else
            {
                objCadastro.Ativo = "N";
            }

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
            if (chkLivre.Checked)
            {
                objCadastro.cpLivre = "S";
            }
            else
            {
                objCadastro.cpLivre = "N";
            }
            if (Convert.ToString(txtVendedor.Text) == "")
            {
                objCadastro.Vendedor = "";
            }
            if (LIDCarteira != "")
            {
                objCadastro.Carteira = LIDCarteira;
            }


            if (LIDUsuario != "")
            {
                if (LID != "")
                {
                    BDCadastroGeral objVerifCadastro = new BDCadastroGeral();
                    List<BDCadastroGeral> lstVerfCadastro = objVerifCadastro.CarregaDados(LCaminhoBanco, LID, "", "", "", "", "", "", "", "", "", "", "");
                    SEGUsuario objUsuario = new SEGUsuario();
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LUsuario, "", "", "");
                    if (lstVerfCadastro[0].Vendedor != LIDUsuario && lstUsuario[0].GerenciaCadastros == "N")
                    {
                        MessageBox.Show("Você não é o vendedor deste cadastro e não possui permissão para alterar!\nImpossivel Gravar!", "GPA");
                        return;
                    }

                }

                objCadastro.Vendedor = LIDUsuario;
            }
            else
            {
                MessageBox.Show("Selecione um vendedor responsavel!", "GPA");
                return;
            }



            if (chkFabricante.Checked == false && chkFornecedor.Checked == false && chkCliente.Checked == false && chkDistribuidor.Checked == false)
            {
                MessageBox.Show("Ao menos uma identificação deve ser selecionada para a empresa");
                return;
            }

            if (txtAviso.Text != "")
            {
                objCadastro.Aviso = txtAviso.Text;
            }
            if (LID == "")
            {
                BDCadastroGeral objVerificaCNPJ = new BDCadastroGeral();
                List<BDCadastroGeral> lstVerificaCNPJ = objVerificaCNPJ.CarregaDados(LCaminhoBanco, "", "", "", txtCNPJ.Text, "", "", "", "", "", "", "", "");
                if (lstVerificaCNPJ.Count > 0)
                {
                    MessageBox.Show("CNPJ já cadastrado, não é permitido o cadastro em duplicidade", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaEmpresa objTela = new frmSelecionaEmpresa(LCaminhoBanco, this, "", txtRazaoSocial.Text.ToString(), "", "", LUsuario, "", "", "", "");
                objTela.ShowDialog();

                if (LID != "")
                {
                    BDCadastroGeral objCadastro = new BDCadastroGeral();
                    List<BDCadastroGeral> lstCadastros = objCadastro.CarregaDados(LCaminhoBanco, LID, "", "", "", "", "", "", "", "", "", "", "");

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
            List<BDCadastroGeral> lstCadastro = ObjCadastro.CarregaDados(LCaminhoBanco, LID, LRazaoSocial, LRazaoFantasia, LCNPJ, "", "", "", "", "", "", "", "");
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
            if (lstCadastro[0].Ativo == "S")
            {
                chkAtivo.Checked = true;
            }
            else chkAtivo.Checked = false;
            if (lstCadastro[0].cpLivre == "S")
            {
                chkLivre.Checked = true;
            }
            else chkLivre.Checked = false;

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
                    if (lstUsuarios.Count > 0)
                    {
                        LIDUsuario = lstUsuarios[0].ID;
                        txtVendedor.Text = lstUsuarios[0].Usuario;
                    }
                }
            }
            if (lstCadastro[0].Carteira != "")
            {
                BDCagCarteira objCarteira = new BDCagCarteira();
                objCarteira.cpID = lstCadastro[0].Carteira.ToString();
                List<BDCagCarteira> lstCarteira = objCarteira.CarregaDados(LCaminhoBanco);
                if (lstCarteira.Count > 0)
                {
                    LIDCarteira = lstCadastro[0].Carteira.ToString();
                    txtCarteira.Text = lstCarteira[0].cpDescricao.ToString();
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
                    List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LIDUsuario, "", "", "");
                    txtVendedor.Text = lstUsuario[0].Usuario;
                }
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.Text.ToString().Replace(" ", "").Replace(".", "").Replace("/", "").Replace("-", "") != "")
            {
                if (txtCNPJ.Text.ToString().Replace(" ", "").Replace(".", "").Replace("/", "").Replace("-", "").Length < 14)
                {
                    MessageBox.Show("Comprimento de CNPJ invalido", "GPA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void txtCarteira_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmSelecionaCarteira frmSelecionaCarteira = new frmSelecionaCarteira(LCaminhoBanco, this, LUsuario);
                frmSelecionaCarteira.ShowDialog();
                if (LIDCarteira != "")
                {
                    BDCagCarteira objCarteira = new BDCagCarteira();
                    objCarteira.cpID = LIDCarteira;
                    List<BDCagCarteira> lstCarteira = objCarteira.CarregaDados(LCaminhoBanco);
                    if (lstCarteira.Count > 0)
                    {
                        txtCarteira.Text = lstCarteira[0].cpDescricao.ToString();
                    }
                }
            }

        }
    }
}