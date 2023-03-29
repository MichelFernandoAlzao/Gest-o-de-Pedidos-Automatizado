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
using Camada_Negocios;

namespace Formularios
{
    public partial class frmCRMInicial : Form
    {
        string LCaminhoBanco = "";
        List<string> LParametros;
        string LUsuario = "";
        public frmCRMInicial(string inCaminhoBanco,string inUsuario)
        {
            LCaminhoBanco=inCaminhoBanco;
            InitializeComponent();

            LUsuario = inUsuario;

            SEGUsuario sEGUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = sEGUsuario.CarregaDados(LCaminhoBanco,inUsuario, "", "", "");
            labNomeUsuario.Text = lstUsuario[0].Nome;

            BDParametros objParametros = new BDParametros();
            List<BDParametros> lstParametros = objParametros.CarregaDados(LCaminhoBanco);
            if (lstParametros.Count > 0)
            {
                if (lstParametros[0].cpEmpresaDR != "")
                {
                    BDCadastroGeral objCadastroGeral = new BDCadastroGeral();
                    List<BDCadastroGeral> lstCadastroGeral = objCadastroGeral.CarregaDados(LCaminhoBanco, lstParametros[0].cpEmpresaDR, "", "", "", "", "", "", "", "", "");
                    labNomeEmpresa.Text = lstCadastroGeral[0].RazaoSocial.ToString();
                }
            }


            if (lstUsuario[0].Administrador == "S")
            {
                HabilitaBotoes();
            }
        }

        public void HabilitaBotoes()
        {
            cmdNatOperacao.Enabled = true;
            cmdCadastroProduto.Enabled = true;
        }
        public void FuncoesTela()
        {
            BDCarregaAcessos objAcessos = new BDCarregaAcessos();
            objAcessos.CarregaAcessos(LParametros[1]);
            if (objAcessos.CadastroEmpresa == 'S') cmdCadastrosEmpresas.Enabled = true;
            if (objAcessos.CadastroProduto == 'S') cmdCadastroProduto.Enabled = true;
            if (objAcessos.Vendedor == 'S') cmdPedidos.Enabled = true;

        }

        private void frmCRMInicial_Load(object sender, EventArgs e)
        {
            RealizaCargas();
        }

        private void cmdCadastrosEmpresas_Click(object sender, EventArgs e)
        {
            GPA.frmCadEmpresas frmCadEmpresas = new GPA.frmCadEmpresas(LCaminhoBanco, LUsuario);
            frmCadEmpresas.ShowDialog();
            RealizaCargas();

        }

        private void cmdCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new frmCadProdutos(LCaminhoBanco,LUsuario);
            frmCadProdutos.ShowDialog();
            RealizaCargas();
        }

        private void cmdPedidos_Click(object sender, EventArgs e)
        {

            frmPedido frmPedido = new frmPedido(LCaminhoBanco, LUsuario, "");
            frmPedido.ShowDialog();
            RealizaCargas();
        }

        private void cmdRegistraContatos_Click(object sender, EventArgs e)
        {
            frmContatosEmpresas frmContatosEmpresas = new frmContatosEmpresas(LCaminhoBanco,LUsuario);
            frmContatosEmpresas.ShowDialog();
            RealizaCargas();
        }

        private void cmdConsultaPedido_Click(object sender, EventArgs e)
        {
            frmConsultaPedido frmConsultaPedido = new frmConsultaPedido(LCaminhoBanco);
            frmConsultaPedido.ShowDialog();
            RealizaCargas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUltimasVendas frmUltimasVendas = new frmUltimasVendas(LCaminhoBanco,LUsuario);
            frmUltimasVendas.ShowDialog();
            RealizaCargas();
        }

        private void CalendarioContatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LButton)
            {

            }
        }

        private void cmdNatOperacao_Click(object sender, EventArgs e)
        {
            SEGUsuario objUsuario = new SEGUsuario();
            objUsuario.ID = LUsuario;
            List<SEGUsuario> lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, LUsuario, "", "", "");
            if (lstUsuario[0].GerenciaCadastros != "S")
            {
                MessageBox.Show("Usuario sem permissão para alterar/Cadastrar Naturezas", "GPA");
                return;
            }
            frmNaturezaDaOperacao frmNatOperacao = new frmNaturezaDaOperacao(LCaminhoBanco,LUsuario);
            frmNatOperacao.ShowDialog();
            RealizaCargas();
        }

        private void cmdParametros_Click(object sender, EventArgs e)
        {
            frmParametrosdoGestor frmParametros = new frmParametrosdoGestor(LCaminhoBanco);
            frmParametros.ShowDialog();
            RealizaCargas();
        }

        private void cmdCriarAviso_Click(object sender, EventArgs e)
        {
            frmAvisos frmAvisos = new frmAvisos(LCaminhoBanco);
            frmAvisos.ShowDialog();
            RealizaCargas();
        }

        private void cmdAgendarContato_Click(object sender, EventArgs e)
        {
            frmAgendarContato frmAgendarContato = new frmAgendarContato(LCaminhoBanco,"", LUsuario);
            frmAgendarContato.ShowDialog();
            RealizaCargas();

        }
        private void grdContatosAgendados_DoubleClick(object sender, EventArgs e)
        {
            frmAgendarContato frmAgendarContato = new frmAgendarContato(LCaminhoBanco,grdContatosAgendados.SelectedRows[0].Cells[0].Value.ToString(), "");
            frmAgendarContato.ShowDialog();
            RealizaCargas();
        }
        public void CarregaAvisos()
        {
            grdAvisos.Rows.Clear();
            BDAvisos objAvisos = new BDAvisos();
            objAvisos.cpUsuarioDR = LUsuario;
            List<BDAvisos> lstAvisos = objAvisos.CarregaDados(LCaminhoBanco);
            if (lstAvisos.Count > 0)
            {
                foreach (BDAvisos item in lstAvisos)
                {
                    if (item.cpDataTermino != "")
                    {
                        if (Convert.ToDateTime(item.cpDataTermino) < DateTime.Today)
                        {
                            continue;
                        }
                    }
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
                      item.cpUsuarioDR.ToString(),
                      item.cpTodos.ToString()
                     };
                    grdAvisos.Rows.Add(Row);
                }
            }


            BDAvisos objAvisosGeral = new BDAvisos();
            objAvisosGeral.cpTodos = "S";
            List<BDAvisos> lstAvisosGeral = objAvisosGeral.CarregaDadosGeral(LCaminhoBanco);
            if (lstAvisosGeral.Count > 0)
            {
                foreach (BDAvisos item in lstAvisosGeral)
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
                      "GERAL",
                      item.cpUsuarioDR.ToString(),
                      item.cpTodos.ToString()
                     };
                    grdAvisos.Rows.Add(Row);
                }
            }

        }

        public void CarregaUltContato()
        {
            BDParametros objParametros = new BDParametros();
            List<BDParametros> lstParametros = objParametros.CarregaDados(LCaminhoBanco);
            if (lstParametros.Count > 0)
            {
                grdUltContato.Rows.Clear();
                BDRegistroContato objRegContato = new BDRegistroContato();
                objRegContato.cpUsuarioDR = LUsuario;
                List<BDRegistroContato> lstRegContato = objRegContato.CarregaDados(LCaminhoBanco);
                if (lstRegContato.Count > 0)
                {
                    foreach (BDRegistroContato item in lstRegContato)
                    {
                        if (item.cpDataContato != "")
                        {
                            if (DateTime.Today.Subtract(Convert.ToDateTime(item.cpDataContato)).TotalDays < Convert.ToInt32(lstParametros[0].cpDiasContato))
                            {
                                continue;
                            }
                        }
                        string pRazao = "";
                        List<BDCadastroGeral> lstEmpresa = new List<BDCadastroGeral>();
                        if (item.cpUsuarioDR != "" && item.cpUsuarioDR != null)
                        {
                            BDCadastroGeral objEmpresa = new BDCadastroGeral();
                            lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, item.cpEmpresaDR, "", "", "", "", "", "", "", "", "");
                            if (lstEmpresa.Count > 0)
                            {
                                pRazao = lstEmpresa[0].RazaoSocial.ToString();
                            }
                            else item.cpUsuarioDR = "";
                        }
                        string[] Row = new string[]
                         {
                            item.cpDataContato.ToString(),
                            pRazao.ToString(),
                            item.cpID.ToString(),

                         };
                        grdUltContato.Rows.Add(Row);
                    }
                }
            }

        }

        public void CarregaUltVenda()
        {
            BDParametros objParametros = new BDParametros();
            List<BDParametros> lstParametros = objParametros.CarregaDados(LCaminhoBanco);
            if (lstParametros.Count > 0)
            {
                grdUltimasVendas.Rows.Clear();
                BDPedido objPedido = new BDPedido();
                objPedido.cpVendedorDR = LUsuario;
                List<BDPedido> lstPedido = objPedido.CarregaDados(LCaminhoBanco, "", "", LUsuario);
                if (lstPedido.Count > 0)
                {
                    foreach (BDPedido item in lstPedido)
                    {
                        if (item.cpDataConfirmacao != "")
                        {
                            if (DateTime.Today.Subtract(Convert.ToDateTime(item.cpDataConfirmacao)).TotalDays < Convert.ToInt32(lstParametros[0].cpDiasUltVenda))
                            {
                                continue;
                            }
                        }
                        string pRazao = "";
                        List<BDCadastroGeral> lstEmpresa = new List<BDCadastroGeral>();
                        if (item.cpEmpresaDR != "" && item.cpEmpresaDR != null)
                        {
                            BDCadastroGeral objEmpresa = new BDCadastroGeral();
                            lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, item.cpEmpresaDR, "", "", "", "", "", "", "", "", "");
                            if (lstEmpresa.Count > 0)
                            {
                                pRazao = lstEmpresa[0].RazaoSocial.ToString();
                            }
                        }
                        string[] Row = new string[]
                         {
                             item.cpDataContato.ToString(),
                             pRazao.ToString(),
                             item.cpVlrTotalPedido.ToString()
                         };
                        grdUltimasVendas.Rows.Add(Row);
                    }
                }
            }

        }

        public void ProgressaoMeta()
        {
            claCalculaProgressaoMeta claCalculaProgressaoMeta = new claCalculaProgressaoMeta();
            string[] VlrCalcMetas = claCalculaProgressaoMeta.CarregaProgressao(LCaminhoBanco, LUsuario);
            txtObjetivoDiario.Text = VlrCalcMetas[3].ToString();
            string AuxVlr = VlrCalcMetas[1].Replace(",", ".");
            pgrsbMeta.Value = (int)Convert.ToInt32(AuxVlr);
            labVlrProgressao.Text = AuxVlr + "%";
            labVlrMeta.Text = VlrCalcMetas[0]; ToString();
            labVlrConsolidado.Text = VlrCalcMetas[2].ToString();
        }

        public void CarregaAgendaContato()
        {
            grdContatosAgendados.Rows.Clear();
            BDAgendarContato objAgendaContato = new BDAgendarContato();
            objAgendaContato.cpIDUsuarioDR = LUsuario;
            List<BDAgendarContato> lstAgendarContato = objAgendaContato.CarregaDados(LCaminhoBanco);
            if (lstAgendarContato.Count > 0)
            {
                foreach (BDAgendarContato item in lstAgendarContato)
                {
                    string pRazao = "";
                    List<BDCadastroGeral> lstEmpresa = new List<BDCadastroGeral>();
                    if (item.cpEmpresaDR != "" && item.cpEmpresaDR != null)
                    {
                        BDCadastroGeral objEmpresa = new BDCadastroGeral();
                        lstEmpresa = objEmpresa.CarregaDados(LCaminhoBanco, item.cpEmpresaDR, "", "", "", "", "", "", "", "", "");
                        if (lstEmpresa.Count > 0)
                        {
                            pRazao = lstEmpresa[0].RazaoSocial.ToString();
                        }
                    }
                    string[] Row = new string[]
                        {
                            item.cpID.ToString(),
                            item.cpDataContato.ToString(),
                            pRazao.ToString(),
                        };
                    grdContatosAgendados.Rows.Add(Row);
                }
            }
        }

        public void RealizaCargas()
        {
            CarregaAvisos();
            CarregaUltContato();
            CarregaUltVenda();
            ProgressaoMeta();
            CarregaAgendaContato();
        }


    }
}
