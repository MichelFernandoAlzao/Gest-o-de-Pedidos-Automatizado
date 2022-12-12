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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEmpresas));
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
            this.SuspendLayout();
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(12, 75);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(504, 23);
            this.txtRazaoSocial.TabIndex = 0;
            this.txtRazaoSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazaoSocial_KeyDown);
            // 
            // labRazaoSocial
            // 
            this.labRazaoSocial.AutoSize = true;
            this.labRazaoSocial.Location = new System.Drawing.Point(12, 57);
            this.labRazaoSocial.Name = "labRazaoSocial";
            this.labRazaoSocial.Size = new System.Drawing.Size(95, 15);
            this.labRazaoSocial.TabIndex = 1;
            this.labRazaoSocial.Text = "Razão Social - F1";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(566, 75);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.PlaceholderText = "____._____._____/_____-____";
            this.txtCNPJ.Size = new System.Drawing.Size(144, 23);
            this.txtCNPJ.TabIndex = 2;
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(566, 57);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(57, 15);
            this.labCNPJ.TabIndex = 3;
            this.labCNPJ.Text = "CNPJ - F1";
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(566, 128);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(144, 23);
            this.txtInscricaoEstadual.TabIndex = 4;
            // 
            // labInscricaoEstadual
            // 
            this.labInscricaoEstadual.AutoSize = true;
            this.labInscricaoEstadual.Location = new System.Drawing.Point(566, 110);
            this.labInscricaoEstadual.Name = "labInscricaoEstadual";
            this.labInscricaoEstadual.Size = new System.Drawing.Size(101, 15);
            this.labInscricaoEstadual.TabIndex = 5;
            this.labInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // labFantasia
            // 
            this.labFantasia.AutoSize = true;
            this.labFantasia.Location = new System.Drawing.Point(12, 110);
            this.labFantasia.Name = "labFantasia";
            this.labFantasia.Size = new System.Drawing.Size(86, 15);
            this.labFantasia.TabIndex = 6;
            this.labFantasia.Text = "Nome Fantasia";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(12, 128);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(504, 23);
            this.txtFantasia.TabIndex = 7;
            // 
            // labVendedor
            // 
            this.labVendedor.AutoSize = true;
            this.labVendedor.Location = new System.Drawing.Point(566, 163);
            this.labVendedor.Name = "labVendedor";
            this.labVendedor.Size = new System.Drawing.Size(80, 15);
            this.labVendedor.TabIndex = 8;
            this.labVendedor.Text = "Vendedor - F1";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(566, 181);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(144, 23);
            this.txtVendedor.TabIndex = 9;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(12, 181);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(63, 19);
            this.chkCliente.TabIndex = 10;
            this.chkCliente.Text = "Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // chkDistribuidor
            // 
            this.chkDistribuidor.AutoSize = true;
            this.chkDistribuidor.Location = new System.Drawing.Point(138, 181);
            this.chkDistribuidor.Name = "chkDistribuidor";
            this.chkDistribuidor.Size = new System.Drawing.Size(88, 19);
            this.chkDistribuidor.TabIndex = 11;
            this.chkDistribuidor.Text = "Distribuidor";
            this.chkDistribuidor.UseVisualStyleBackColor = true;
            // 
            // chkFabricante
            // 
            this.chkFabricante.AutoSize = true;
            this.chkFabricante.Location = new System.Drawing.Point(286, 181);
            this.chkFabricante.Name = "chkFabricante";
            this.chkFabricante.Size = new System.Drawing.Size(81, 19);
            this.chkFabricante.TabIndex = 12;
            this.chkFabricante.Text = "Fabricante";
            this.chkFabricante.UseVisualStyleBackColor = true;
            // 
            // chkFornecedor
            // 
            this.chkFornecedor.AutoSize = true;
            this.chkFornecedor.Location = new System.Drawing.Point(430, 181);
            this.chkFornecedor.Name = "chkFornecedor";
            this.chkFornecedor.Size = new System.Drawing.Size(86, 19);
            this.chkFornecedor.TabIndex = 13;
            this.chkFornecedor.Text = "Fornecedor";
            this.chkFornecedor.UseVisualStyleBackColor = true;
            // 
            // cmdSair
            // 
            this.cmdSair.Image = ((System.Drawing.Image)(resources.GetObject("cmdSair.Image")));
            this.cmdSair.Location = new System.Drawing.Point(680, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 14;
            this.cmdSair.UseVisualStyleBackColor = true;
            // 
            // cmdGravar
            // 
            this.cmdGravar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGravar.Image")));
            this.cmdGravar.Location = new System.Drawing.Point(636, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 15;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.Gravar);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNovo.Image")));
            this.cmdNovo.Location = new System.Drawing.Point(601, 13);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(29, 29);
            this.cmdNovo.TabIndex = 16;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // labCadastroGeral
            // 
            this.labCadastroGeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCadastroGeral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCadastroGeral.Location = new System.Drawing.Point(12, 9);
            this.labCadastroGeral.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labCadastroGeral.Name = "labCadastroGeral";
            this.labCadastroGeral.Size = new System.Drawing.Size(580, 32);
            this.labCadastroGeral.TabIndex = 17;
            this.labCadastroGeral.Text = "Cadastro Geral";
            this.labCadastroGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdEndereco
            // 
            this.cmdEndereco.Location = new System.Drawing.Point(12, 403);
            this.cmdEndereco.Name = "cmdEndereco";
            this.cmdEndereco.Size = new System.Drawing.Size(80, 30);
            this.cmdEndereco.TabIndex = 20;
            this.cmdEndereco.Text = "Endereços";
            this.cmdEndereco.UseVisualStyleBackColor = true;
            // 
            // cmdContatos
            // 
            this.cmdContatos.Location = new System.Drawing.Point(98, 403);
            this.cmdContatos.Name = "cmdContatos";
            this.cmdContatos.Size = new System.Drawing.Size(80, 30);
            this.cmdContatos.TabIndex = 21;
            this.cmdContatos.Text = "Contatos";
            this.cmdContatos.UseVisualStyleBackColor = true;
            // 
            // CmdRegOcorrencias
            // 
            this.CmdRegOcorrencias.Location = new System.Drawing.Point(184, 403);
            this.CmdRegOcorrencias.Name = "CmdRegOcorrencias";
            this.CmdRegOcorrencias.Size = new System.Drawing.Size(80, 30);
            this.CmdRegOcorrencias.TabIndex = 22;
            this.CmdRegOcorrencias.Text = "Ocorrencias";
            this.CmdRegOcorrencias.UseVisualStyleBackColor = true;
            // 
            // frmCadEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.ControlBox = false;
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
    }
}