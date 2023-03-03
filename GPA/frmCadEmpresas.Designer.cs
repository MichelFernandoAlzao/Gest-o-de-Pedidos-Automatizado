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
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.labRazaoSocial = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.labInscricaoEstadual = new System.Windows.Forms.Label();
            this.labFantasia = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.labVendedor = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkDistribuidor = new System.Windows.Forms.CheckBox();
            this.chkFabricante = new System.Windows.Forms.CheckBox();
            this.chkFornecedor = new System.Windows.Forms.CheckBox();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.labCadastroGeral = new System.Windows.Forms.Label();
            this.cmdEndereco = new System.Windows.Forms.Button();
            this.cmdContatos = new System.Windows.Forms.Button();
            this.CmdRegOcorrencias = new System.Windows.Forms.Button();
            this.txtQualificacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiasAtraso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegCobranca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegVenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(12, 75);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(681, 23);
            this.txtRazaoSocial.TabIndex = 0;
            this.txtRazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazaoSocial_KeyDown);
            // 
            // labRazaoSocial
            // 
            this.labRazaoSocial.AutoSize = true;
            this.labRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labRazaoSocial.Location = new System.Drawing.Point(12, 57);
            this.labRazaoSocial.Name = "labRazaoSocial";
            this.labRazaoSocial.Size = new System.Drawing.Size(99, 15);
            this.labRazaoSocial.TabIndex = 1;
            this.labRazaoSocial.Text = "Razão Social - F1";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(841, 75);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.PlaceholderText = "____._____._____/_____-____";
            this.txtCNPJ.Size = new System.Drawing.Size(156, 23);
            this.txtCNPJ.TabIndex = 1;
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCNPJ.Location = new System.Drawing.Point(841, 57);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(58, 15);
            this.labCNPJ.TabIndex = 3;
            this.labCNPJ.Text = "CNPJ - F1";
            this.labCNPJ.Click += new System.EventHandler(this.labCNPJ_Click);
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(842, 128);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(155, 23);
            this.txtInscricaoEstadual.TabIndex = 3;
            // 
            // labInscricaoEstadual
            // 
            this.labInscricaoEstadual.AutoSize = true;
            this.labInscricaoEstadual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labInscricaoEstadual.Location = new System.Drawing.Point(842, 110);
            this.labInscricaoEstadual.Name = "labInscricaoEstadual";
            this.labInscricaoEstadual.Size = new System.Drawing.Size(104, 15);
            this.labInscricaoEstadual.TabIndex = 5;
            this.labInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // labFantasia
            // 
            this.labFantasia.AutoSize = true;
            this.labFantasia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFantasia.Location = new System.Drawing.Point(12, 110);
            this.labFantasia.Name = "labFantasia";
            this.labFantasia.Size = new System.Drawing.Size(88, 15);
            this.labFantasia.TabIndex = 6;
            this.labFantasia.Text = "Nome Fantasia";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(12, 128);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(681, 23);
            this.txtFantasia.TabIndex = 2;
            // 
            // labVendedor
            // 
            this.labVendedor.AutoSize = true;
            this.labVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labVendedor.Location = new System.Drawing.Point(842, 163);
            this.labVendedor.Name = "labVendedor";
            this.labVendedor.Size = new System.Drawing.Size(85, 15);
            this.labVendedor.TabIndex = 8;
            this.labVendedor.Text = "Vendedor - F1";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(842, 181);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(155, 23);
            this.txtVendedor.TabIndex = 5;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(12, 279);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(63, 19);
            this.chkCliente.TabIndex = 7;
            this.chkCliente.Text = "Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // chkDistribuidor
            // 
            this.chkDistribuidor.AutoSize = true;
            this.chkDistribuidor.Location = new System.Drawing.Point(138, 279);
            this.chkDistribuidor.Name = "chkDistribuidor";
            this.chkDistribuidor.Size = new System.Drawing.Size(88, 19);
            this.chkDistribuidor.TabIndex = 8;
            this.chkDistribuidor.Text = "Distribuidor";
            this.chkDistribuidor.UseVisualStyleBackColor = true;
            // 
            // chkFabricante
            // 
            this.chkFabricante.AutoSize = true;
            this.chkFabricante.Location = new System.Drawing.Point(286, 279);
            this.chkFabricante.Name = "chkFabricante";
            this.chkFabricante.Size = new System.Drawing.Size(81, 19);
            this.chkFabricante.TabIndex = 9;
            this.chkFabricante.Text = "Fabricante";
            this.chkFabricante.UseVisualStyleBackColor = true;
            // 
            // chkFornecedor
            // 
            this.chkFornecedor.AutoSize = true;
            this.chkFornecedor.Location = new System.Drawing.Point(430, 279);
            this.chkFornecedor.Name = "chkFornecedor";
            this.chkFornecedor.Size = new System.Drawing.Size(86, 19);
            this.chkFornecedor.TabIndex = 10;
            this.chkFornecedor.Text = "Fornecedor";
            this.chkFornecedor.UseVisualStyleBackColor = true;
            // 
            // cmdSair
            // 
            this.cmdSair.AccessibleDescription = "Sair";
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Location = new System.Drawing.Point(967, 11);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 16;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.AccessibleDescription = "Gravar";
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGravar.Location = new System.Drawing.Point(931, 11);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 15;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.Gravar);
            // 
            // cmdNovo
            // 
            this.cmdNovo.AccessibleDescription = "Novo";
            this.cmdNovo.AccessibleName = "Novo";
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNovo.Location = new System.Drawing.Point(896, 11);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(29, 29);
            this.cmdNovo.TabIndex = 14;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // labCadastroGeral
            // 
            this.labCadastroGeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCadastroGeral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCadastroGeral.Location = new System.Drawing.Point(12, 11);
            this.labCadastroGeral.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labCadastroGeral.Name = "labCadastroGeral";
            this.labCadastroGeral.Size = new System.Drawing.Size(878, 30);
            this.labCadastroGeral.TabIndex = 17;
            this.labCadastroGeral.Text = "Cadastro Geral";
            this.labCadastroGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdEndereco
            // 
            this.cmdEndereco.Location = new System.Drawing.Point(12, 403);
            this.cmdEndereco.Name = "cmdEndereco";
            this.cmdEndereco.Size = new System.Drawing.Size(80, 30);
            this.cmdEndereco.TabIndex = 19;
            this.cmdEndereco.Text = "Endereços";
            this.cmdEndereco.UseVisualStyleBackColor = true;
            this.cmdEndereco.Click += new System.EventHandler(this.cmdEndereco_Click);
            // 
            // cmdContatos
            // 
            this.cmdContatos.Location = new System.Drawing.Point(98, 403);
            this.cmdContatos.Name = "cmdContatos";
            this.cmdContatos.Size = new System.Drawing.Size(80, 30);
            this.cmdContatos.TabIndex = 20;
            this.cmdContatos.Text = "Contatos";
            this.cmdContatos.UseVisualStyleBackColor = true;
            this.cmdContatos.Click += new System.EventHandler(this.cmdContatos_Click);
            // 
            // CmdRegOcorrencias
            // 
            this.CmdRegOcorrencias.Location = new System.Drawing.Point(184, 403);
            this.CmdRegOcorrencias.Name = "CmdRegOcorrencias";
            this.CmdRegOcorrencias.Size = new System.Drawing.Size(80, 30);
            this.CmdRegOcorrencias.TabIndex = 21;
            this.CmdRegOcorrencias.Text = "Ocorrencias";
            this.CmdRegOcorrencias.UseVisualStyleBackColor = true;
            // 
            // txtQualificacao
            // 
            this.txtQualificacao.Location = new System.Drawing.Point(12, 337);
            this.txtQualificacao.Name = "txtQualificacao";
            this.txtQualificacao.Size = new System.Drawing.Size(134, 23);
            this.txtQualificacao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Qualificação - F1";
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(12, 181);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(681, 23);
            this.txtAviso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Aviso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(152, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Dias Atraso";
            // 
            // txtDiasAtraso
            // 
            this.txtDiasAtraso.Location = new System.Drawing.Point(152, 337);
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.Size = new System.Drawing.Size(69, 23);
            this.txtDiasAtraso.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(233, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Região de Cobrança - F1";
            // 
            // txtRegCobranca
            // 
            this.txtRegCobranca.Location = new System.Drawing.Point(233, 337);
            this.txtRegCobranca.Name = "txtRegCobranca";
            this.txtRegCobranca.Size = new System.Drawing.Size(283, 23);
            this.txtRegCobranca.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ultima Venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Produtos Preferidos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Região de Venda - F1";
            // 
            // txtRegVenda
            // 
            this.txtRegVenda.Location = new System.Drawing.Point(12, 236);
            this.txtRegVenda.Name = "txtRegVenda";
            this.txtRegVenda.Size = new System.Drawing.Size(283, 23);
            this.txtRegVenda.TabIndex = 6;
            // 
            // frmCadEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 449);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegVenda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegCobranca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQualificacao);
            this.Controls.Add(this.CmdRegOcorrencias);
            this.Controls.Add(this.cmdContatos);
            this.Controls.Add(this.cmdEndereco);
            this.Controls.Add(this.labCadastroGeral);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.chkFornecedor);
            this.Controls.Add(this.chkFabricante);
            this.Controls.Add(this.chkDistribuidor);
            this.Controls.Add(this.chkCliente);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.labVendedor);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.labFantasia);
            this.Controls.Add(this.labInscricaoEstadual);
            this.Controls.Add(this.txtInscricaoEstadual);
            this.Controls.Add(this.labCNPJ);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.labRazaoSocial);
            this.Controls.Add(this.txtRazaoSocial);
            this.Name = "frmCadEmpresas";
            this.Text = "Cadastro Geral";
            this.Load += new System.EventHandler(this.frmCadEmpresas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRazaoSocial;
        private Label labRazaoSocial;
        private TextBox txtCNPJ;
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
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox txtRegVenda;
    }
}