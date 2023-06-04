namespace GPA
{
    partial class frmCadEmpresas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRazaoSocial = new TextBox();
            labRazaoSocial = new Label();
            labCNPJ = new Label();
            txtInscricaoEstadual = new TextBox();
            labInscricaoEstadual = new Label();
            labFantasia = new Label();
            txtFantasia = new TextBox();
            labVendedor = new Label();
            txtVendedor = new TextBox();
            chkCliente = new CheckBox();
            chkDistribuidor = new CheckBox();
            chkFabricante = new CheckBox();
            chkFornecedor = new CheckBox();
            cmdSair = new Button();
            cmdGravar = new Button();
            cmdNovo = new Button();
            labCadastroGeral = new Label();
            cmdEndereco = new Button();
            cmdContatos = new Button();
            CmdRegOcorrencias = new Button();
            txtQualificacao = new TextBox();
            label1 = new Label();
            txtAviso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDiasAtraso = new TextBox();
            label4 = new Label();
            txtRegCobranca = new TextBox();
            cmdUltVenda = new Button();
            button2 = new Button();
            label5 = new Label();
            txtRegVenda = new TextBox();
            txtCNPJ = new MaskedTextBox();
            chkAtivo = new CheckBox();
            SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(12, 75);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(681, 23);
            txtRazaoSocial.TabIndex = 0;
            txtRazaoSocial.KeyDown += txtRazaoSocial_KeyDown;
            // 
            // labRazaoSocial
            // 
            labRazaoSocial.AutoSize = true;
            labRazaoSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labRazaoSocial.Location = new Point(12, 57);
            labRazaoSocial.Name = "labRazaoSocial";
            labRazaoSocial.Size = new Size(99, 15);
            labRazaoSocial.TabIndex = 1;
            labRazaoSocial.Text = "Razão Social - F1";
            // 
            // labCNPJ
            // 
            labCNPJ.AutoSize = true;
            labCNPJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labCNPJ.Location = new Point(841, 57);
            labCNPJ.Name = "labCNPJ";
            labCNPJ.Size = new Size(58, 15);
            labCNPJ.TabIndex = 3;
            labCNPJ.Text = "CNPJ - F1";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(842, 128);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(155, 23);
            txtInscricaoEstadual.TabIndex = 3;
            // 
            // labInscricaoEstadual
            // 
            labInscricaoEstadual.AutoSize = true;
            labInscricaoEstadual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labInscricaoEstadual.Location = new Point(842, 110);
            labInscricaoEstadual.Name = "labInscricaoEstadual";
            labInscricaoEstadual.Size = new Size(104, 15);
            labInscricaoEstadual.TabIndex = 5;
            labInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // labFantasia
            // 
            labFantasia.AutoSize = true;
            labFantasia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labFantasia.Location = new Point(12, 110);
            labFantasia.Name = "labFantasia";
            labFantasia.Size = new Size(88, 15);
            labFantasia.TabIndex = 6;
            labFantasia.Text = "Nome Fantasia";
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(12, 128);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(681, 23);
            txtFantasia.TabIndex = 2;
            // 
            // labVendedor
            // 
            labVendedor.AutoSize = true;
            labVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labVendedor.Location = new Point(842, 163);
            labVendedor.Name = "labVendedor";
            labVendedor.Size = new Size(85, 15);
            labVendedor.TabIndex = 8;
            labVendedor.Text = "Vendedor - F1";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(842, 181);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(155, 23);
            txtVendedor.TabIndex = 5;
            txtVendedor.KeyDown += txtVendedor_KeyDown;
            // 
            // chkCliente
            // 
            chkCliente.AutoSize = true;
            chkCliente.Location = new Point(12, 279);
            chkCliente.Name = "chkCliente";
            chkCliente.Size = new Size(63, 19);
            chkCliente.TabIndex = 7;
            chkCliente.Text = "Cliente";
            chkCliente.UseVisualStyleBackColor = true;
            // 
            // chkDistribuidor
            // 
            chkDistribuidor.AutoSize = true;
            chkDistribuidor.Location = new Point(138, 279);
            chkDistribuidor.Name = "chkDistribuidor";
            chkDistribuidor.Size = new Size(88, 19);
            chkDistribuidor.TabIndex = 8;
            chkDistribuidor.Text = "Distribuidor";
            chkDistribuidor.UseVisualStyleBackColor = true;
            // 
            // chkFabricante
            // 
            chkFabricante.AutoSize = true;
            chkFabricante.Location = new Point(286, 279);
            chkFabricante.Name = "chkFabricante";
            chkFabricante.Size = new Size(81, 19);
            chkFabricante.TabIndex = 9;
            chkFabricante.Text = "Fabricante";
            chkFabricante.UseVisualStyleBackColor = true;
            // 
            // chkFornecedor
            // 
            chkFornecedor.AutoSize = true;
            chkFornecedor.Location = new Point(430, 279);
            chkFornecedor.Name = "chkFornecedor";
            chkFornecedor.Size = new Size(86, 19);
            chkFornecedor.TabIndex = 10;
            chkFornecedor.Text = "Fornecedor";
            chkFornecedor.UseVisualStyleBackColor = true;
            // 
            // cmdSair
            // 
            cmdSair.AccessibleDescription = "Sair";
            cmdSair.BackgroundImage = Formularios.Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(967, 11);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 16;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.AccessibleDescription = "Gravar";
            cmdGravar.BackgroundImage = Formularios.Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(931, 11);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 15;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += Gravar;
            // 
            // cmdNovo
            // 
            cmdNovo.AccessibleDescription = "Novo";
            cmdNovo.AccessibleName = "Novo";
            cmdNovo.BackgroundImage = Formularios.Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdNovo.Location = new Point(896, 11);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(29, 29);
            cmdNovo.TabIndex = 14;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // labCadastroGeral
            // 
            labCadastroGeral.BorderStyle = BorderStyle.Fixed3D;
            labCadastroGeral.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labCadastroGeral.Location = new Point(12, 11);
            labCadastroGeral.Margin = new Padding(5, 0, 3, 0);
            labCadastroGeral.Name = "labCadastroGeral";
            labCadastroGeral.Size = new Size(878, 30);
            labCadastroGeral.TabIndex = 17;
            labCadastroGeral.Text = "Cadastro Geral";
            labCadastroGeral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdEndereco
            // 
            cmdEndereco.Location = new Point(12, 403);
            cmdEndereco.Name = "cmdEndereco";
            cmdEndereco.Size = new Size(80, 30);
            cmdEndereco.TabIndex = 19;
            cmdEndereco.Text = "Endereços";
            cmdEndereco.UseVisualStyleBackColor = true;
            cmdEndereco.Click += cmdEndereco_Click;
            // 
            // cmdContatos
            // 
            cmdContatos.Location = new Point(98, 403);
            cmdContatos.Name = "cmdContatos";
            cmdContatos.Size = new Size(80, 30);
            cmdContatos.TabIndex = 20;
            cmdContatos.Text = "Contatos";
            cmdContatos.UseVisualStyleBackColor = true;
            cmdContatos.Click += cmdContatos_Click;
            // 
            // CmdRegOcorrencias
            // 
            CmdRegOcorrencias.Location = new Point(184, 403);
            CmdRegOcorrencias.Name = "CmdRegOcorrencias";
            CmdRegOcorrencias.Size = new Size(80, 30);
            CmdRegOcorrencias.TabIndex = 21;
            CmdRegOcorrencias.Text = "Ocorrencias";
            CmdRegOcorrencias.UseVisualStyleBackColor = true;
            CmdRegOcorrencias.Click += CmdRegOcorrencias_Click;
            // 
            // txtQualificacao
            // 
            txtQualificacao.Location = new Point(12, 337);
            txtQualificacao.Name = "txtQualificacao";
            txtQualificacao.Size = new Size(134, 23);
            txtQualificacao.TabIndex = 11;
            txtQualificacao.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 319);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 24;
            label1.Text = "Qualificação - F1";
            label1.Visible = false;
            // 
            // txtAviso
            // 
            txtAviso.Location = new Point(12, 181);
            txtAviso.Name = "txtAviso";
            txtAviso.Size = new Size(681, 23);
            txtAviso.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 163);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 25;
            label2.Text = "Aviso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(152, 319);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 28;
            label3.Text = "Dias Atraso";
            label3.Visible = false;
            // 
            // txtDiasAtraso
            // 
            txtDiasAtraso.Location = new Point(152, 337);
            txtDiasAtraso.Name = "txtDiasAtraso";
            txtDiasAtraso.Size = new Size(69, 23);
            txtDiasAtraso.TabIndex = 12;
            txtDiasAtraso.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(233, 319);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 30;
            label4.Text = "Região de Cobrança - F1";
            label4.Visible = false;
            // 
            // txtRegCobranca
            // 
            txtRegCobranca.Location = new Point(233, 337);
            txtRegCobranca.Name = "txtRegCobranca";
            txtRegCobranca.Size = new Size(283, 23);
            txtRegCobranca.TabIndex = 13;
            txtRegCobranca.Visible = false;
            // 
            // cmdUltVenda
            // 
            cmdUltVenda.Location = new Point(842, 275);
            cmdUltVenda.Name = "cmdUltVenda";
            cmdUltVenda.Size = new Size(156, 23);
            cmdUltVenda.TabIndex = 17;
            cmdUltVenda.Text = "Ultima Venda";
            cmdUltVenda.UseVisualStyleBackColor = true;
            cmdUltVenda.Click += cmdUltVenda_Click;
            // 
            // button2
            // 
            button2.Location = new Point(842, 319);
            button2.Name = "button2";
            button2.Size = new Size(156, 23);
            button2.TabIndex = 18;
            button2.Text = "Produtos Preferidos";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 218);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 34;
            label5.Text = "Região de Venda - F1";
            // 
            // txtRegVenda
            // 
            txtRegVenda.Enabled = false;
            txtRegVenda.Location = new Point(12, 236);
            txtRegVenda.Name = "txtRegVenda";
            txtRegVenda.Size = new Size(283, 23);
            txtRegVenda.TabIndex = 6;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(842, 75);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(155, 23);
            txtCNPJ.TabIndex = 35;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(708, 79);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 36;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // frmCadEmpresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 449);
            ControlBox = false;
            Controls.Add(chkAtivo);
            Controls.Add(txtCNPJ);
            Controls.Add(label5);
            Controls.Add(txtRegVenda);
            Controls.Add(button2);
            Controls.Add(cmdUltVenda);
            Controls.Add(label4);
            Controls.Add(txtRegCobranca);
            Controls.Add(label3);
            Controls.Add(txtDiasAtraso);
            Controls.Add(txtAviso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQualificacao);
            Controls.Add(CmdRegOcorrencias);
            Controls.Add(cmdContatos);
            Controls.Add(cmdEndereco);
            Controls.Add(labCadastroGeral);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(chkFornecedor);
            Controls.Add(chkFabricante);
            Controls.Add(chkDistribuidor);
            Controls.Add(chkCliente);
            Controls.Add(txtVendedor);
            Controls.Add(labVendedor);
            Controls.Add(txtFantasia);
            Controls.Add(labFantasia);
            Controls.Add(labInscricaoEstadual);
            Controls.Add(txtInscricaoEstadual);
            Controls.Add(labCNPJ);
            Controls.Add(labRazaoSocial);
            Controls.Add(txtRazaoSocial);
            Name = "frmCadEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Geral";
            Load += frmCadEmpresas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRazaoSocial;
        private Label labRazaoSocial;
        private Label labCNPJ;
        private TextBox txtInscricaoEstadual;
        private Label labInscricaoEstadual;
        private Label labFantasia;
        private TextBox txtFantasia;
        private Label labVendedor;
        private TextBox txtVendedor;
        private CheckBox chkCliente;
        private CheckBox chkDistribuidor;
        private CheckBox chkFabricante;
        private CheckBox chkFornecedor;
        private Button cmdSair;
        private Button cmdGravar;
        private Button cmdNovo;
        private Label labCadastroGeral;
        private Button cmdEndereco;
        private Button cmdContatos;
        private Button CmdRegOcorrencias;
        private TextBox txtQualificacao;
        private Label label1;
        private TextBox txtAviso;
        private Label label2;
        private Label label3;
        private TextBox txtDiasAtraso;
        private Label label4;
        private TextBox txtRegCobranca;
        private Button cmdUltVenda;
        private Button button2;
        private Label label5;
        private TextBox txtRegVenda;
        private MaskedTextBox txtCNPJ;
        private CheckBox chkAtivo;
    }
}