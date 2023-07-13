﻿using Banco_de_Dados;
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
    public partial class frmMostraContatosAgendados : Form
    {
        string LUsuario = "";
        string LCaminhoBanco = "";
        public frmMostraContatosAgendados(string inCaminhoBanco, string inUsuario)
        {
            LUsuario = inUsuario;
            LCaminhoBanco = inCaminhoBanco;
            InitializeComponent();
            CarregaAvisos();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaAvisos()
        {
            grdAgendaContatos.Rows.Clear();
            string RazaoSocial = "";
            BDAgendarContato objContatosAgendados = new BDAgendarContato();
            objContatosAgendados.cpIDUsuarioDR = LUsuario;
            objContatosAgendados.cpAtendido = "N";
            List<BDAgendarContato> lstContatosAgendados = objContatosAgendados.CarregaDados(LCaminhoBanco);
            if (lstContatosAgendados.Count > 0)
            {
                foreach (BDAgendarContato Cttagenda in lstContatosAgendados)
                {
                    string usuario = "";
                    List<SEGUsuario> lstUsuario = new List<SEGUsuario>();
                    if (Cttagenda.cpIDUsuarioDR != "" && Cttagenda.cpIDUsuarioDR != null)
                    {
                        SEGUsuario objUsuario = new SEGUsuario();
                        lstUsuario = objUsuario.CarregaDados(LCaminhoBanco, Cttagenda.cpIDUsuarioDR, "", "", "");
                        if (lstUsuario.Count > 0)
                        {
                            Cttagenda.cpIDUsuarioDR = lstUsuario[0].ID;
                            usuario = lstUsuario[0].Nome.ToString();
                        }
                        else Cttagenda.cpIDUsuarioDR = "";
                    }
                    if(Cttagenda.cpEmpresaDR != "")
                    {
                        BDCadastroGeral objCadastro = new BDCadastroGeral();
                        List<BDCadastroGeral> lstCadastro = objCadastro.CarregaDados(LCaminhoBanco,Cttagenda.cpEmpresaDR,"","","","","","","","","");
                        RazaoSocial = lstCadastro[0].RazaoSocial.ToString();
                    }
                    string[] Row = new string[]
                     {
                         Cttagenda.cpID.ToString(),
                         RazaoSocial.ToString(),
                         Cttagenda.cpNome.ToString(),
                         Cttagenda.cpDataContato.ToString(),
                         Cttagenda.cpFone.ToString(),
                         usuario.ToString(),
                     };
                    grdAgendaContatos.Rows.Add(Row);
                    RazaoSocial = "";
                }
            }
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            if (grdAgendaContatos.RowCount > 0)
            {
                BDAgendarContato objContatoAgendado = new BDAgendarContato();
                objContatoAgendado.cpID = grdAgendaContatos.SelectedRows[0].Cells[0].Value.ToString();
                objContatoAgendado.cpAtendido = "S";
                objContatoAgendado.AlteraDados(LCaminhoBanco);
            }
            CarregaAvisos();
        }
    }
}
