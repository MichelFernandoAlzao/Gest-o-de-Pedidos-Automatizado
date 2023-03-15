﻿using System;
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
    public partial class frmCRMInicial : Form
    {
        List<string> LParametros;
        string LUsuario = "";
        public frmCRMInicial(string inUsuario)
        {
            InitializeComponent();

            LUsuario = inUsuario;

            SEGUsuario sEGUsuario = new SEGUsuario();
            List<SEGUsuario> lstUsuario = sEGUsuario.CarregaDados(inUsuario, "", "", "");
            labNomeUsuario.Text = lstUsuario[0].Nome;

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
            if(objAcessos.CadastroEmpresa == 'S') cmdCadastrosEmpresas.Enabled = true;
            if (objAcessos.CadastroProduto == 'S') cmdCadastroProduto.Enabled = true;
            if (objAcessos.Vendedor == 'S') cmdPedidos.Enabled = true;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCRMInicial_Load(object sender, EventArgs e)
        {
            CarregaAvisos();
            CarregaUltContato();
            CarregaUltVenda();
        }

        private void cmdCadastrosEmpresas_Click(object sender, EventArgs e)
        {
            GPA.frmCadEmpresas frmCadEmpresas = new GPA.frmCadEmpresas();
            frmCadEmpresas.ShowDialog();

        }

        private void cmdCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new frmCadProdutos();
            frmCadProdutos.ShowDialog();
        }

        private void cmdPedidos_Click(object sender, EventArgs e)
        {
            
            frmPedido frmPedido = new frmPedido(LUsuario,"");
            frmPedido.ShowDialog();
        }

        private void cmdRegistraContatos_Click(object sender, EventArgs e)
        {
            frmContatosEmpresas frmContatosEmpresas = new frmContatosEmpresas();
            frmContatosEmpresas.ShowDialog();
        }

        private void cmdConsultaPedido_Click(object sender, EventArgs e)
        {
            frmConsultaPedido frmConsultaPedido = new frmConsultaPedido();
            frmConsultaPedido.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUltimasVendas frmUltimasVendas = new frmUltimasVendas();
            frmUltimasVendas.ShowDialog();
        }

        private void CalendarioContatos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.LButton)
            {

            }
        }

        private void cmdNatOperacao_Click(object sender, EventArgs e)
        {
            frmNaturezaDaOperacao frmNatOperacao = new frmNaturezaDaOperacao(LUsuario);
            frmNatOperacao.ShowDialog();
        }

        private void cmdParametros_Click(object sender, EventArgs e)
        {
            frmParametrosdoGestor frmParametros = new frmParametrosdoGestor();
            frmParametros.ShowDialog();
        }

        private void cmdCriarAviso_Click(object sender, EventArgs e)
        {
            frmAvisos frmAvisos = new frmAvisos();
            frmAvisos.ShowDialog();
        }

        public void CarregaAvisos()
        {
             grdAvisos.Rows.Clear();
             BDAvisos objAvisos = new BDAvisos();
            objAvisos.cpUsuarioDR = LUsuario;
             List<BDAvisos> lstAvisos = objAvisos.CarregaDados();
             if (lstAvisos.Count > 0)
             {
                 foreach (BDAvisos item in lstAvisos)
                 {
                    if(item.cpDataTermino != "")
                    {
                        if(Convert.ToDateTime(item.cpDataTermino) < DateTime.Today)
                        {
                            continue;
                        }
                    }
                     string usuario = "";
                     List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                     if (item.cpUsuarioDR != "" && item.cpUsuarioDR != null)
                     {
                         SEGUsuario objUsuario = new SEGUsuario();
                         lstUsuario = objUsuario.CarregaDados(item.cpUsuarioDR, "", "", "");
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
            List<BDAvisos> lstAvisosGeral = objAvisosGeral.CarregaDadosGeral();
            if (lstAvisosGeral.Count > 0)
            {
                foreach (BDAvisos item in lstAvisosGeral)
                {
                    string usuario = "";
                    List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                    if (item.cpUsuarioDR != "" && item.cpUsuarioDR != null)
                    {
                        SEGUsuario objUsuario = new SEGUsuario();
                        lstUsuario = objUsuario.CarregaDados(item.cpUsuarioDR, "", "", "");
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
            List<BDParametros> lstParametros = objParametros.CarregaDados();
            if(lstParametros.Count > 0)
            {
                grdUltContato.Rows.Clear();
                BDRegistroContato objRegContato = new BDRegistroContato();
                objRegContato.cpUsuarioDR = LUsuario;
                List<BDRegistroContato> lstRegContato = objRegContato.CarregaDados();
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
                            lstEmpresa = objEmpresa.CarregaDados(item.cpEmpresaDR, "", "", "","","","","","","");
                            if (lstEmpresa.Count > 0)
                            {
                                pRazao = lstEmpresa[0].RazaoSocial.ToString();
                            }
                            else item.cpUsuarioDR = "";
                        }
                        string[] Row = new string[]
                         {
                            item.cpID.ToString(),
                            item.cpDataContato.ToString(),
                            pRazao.ToString(),
                         };
                        grdUltContato.Rows.Add(Row);
                    }
                }
            }
            
        }

        public void CarregaUltVenda()
        {
            BDParametros objParametros = new BDParametros();
            List<BDParametros> lstParametros = objParametros.CarregaDados();
            if (lstParametros.Count > 0)
            {
                grdUltimasVendas.Rows.Clear();
                BDPedido objPedido = new BDPedido();
                objPedido.cpVendedorDR = LUsuario;
                List<BDPedido> lstPedido = objPedido.CarregaDados("","",LUsuario);
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
                            lstEmpresa = objEmpresa.CarregaDados(item.cpEmpresaDR, "", "", "", "", "", "", "", "", "");
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
                            item.cpVlrTotalPedido.ToString()
                         };
                        grdUltimasVendas.Rows.Add(Row);
                    }
                }
            }

        }
    }
}
