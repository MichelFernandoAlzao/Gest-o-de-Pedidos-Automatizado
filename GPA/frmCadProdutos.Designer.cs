namespace Formularios
{
    partial class frmCadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCadProdutos = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodFabricante = new System.Windows.Forms.TextBox();
            this.txtDescritivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.chkOperacional = new System.Windows.Forms.CheckBox();
            this.chkForadeLinha = new System.Windows.Forms.CheckBox();
            this.labMelFornecedor = new System.Windows.Forms.Label();
            this.txtMelhorFornecedor = new System.Windows.Forms.TextBox();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCadProdutos
            // 
            this.lbCadProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCadProdutos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbCadProdutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCadProdutos.ForeColor = System.Drawing.Color.Black;
            this.lbCadProdutos.Location = new System.Drawing.Point(12, 9);
            this.lbCadProdutos.Name = "lbCadProdutos";
            this.lbCadProdutos.Size = new System.Drawing.Size(755, 23);
            this.lbCadProdutos.TabIndex = 1;
            this.lbCadProdutos.Text = "Cadastro de Produtos";
            this.lbCadProdutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 77);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(472, 23);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(503, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(127, 23);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(652, 77);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(115, 23);
            this.txtDataCadastro.TabIndex = 4;
            this.txtDataCadastro.Text = "____/____/________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição - F1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(503, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo - F1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(652, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Cadastro";
            // 
            // txtDescFornecedor
            // 
            this.txtDescFornecedor.Location = new System.Drawing.Point(12, 137);
            this.txtDescFornecedor.Name = "txtDescFornecedor";
            this.txtDescFornecedor.Size = new System.Drawing.Size(472, 23);
            this.txtDescFornecedor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fabricante - F1";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(12, 197);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(472, 23);
            this.txtFabricante.TabIndex = 10;
            this.txtFabricante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFabricante_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(789, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo Fabricante - F1";
            // 
            // txtCodFabricante
            // 
            this.txtCodFabricante.Location = new System.Drawing.Point(789, 77);
            this.txtCodFabricante.Name = "txtCodFabricante";
            this.txtCodFabricante.Size = new System.Drawing.Size(130, 23);
            this.txtCodFabricante.TabIndex = 12;
            // 
            // txtDescritivo
            // 
            this.txtDescritivo.Location = new System.Drawing.Point(12, 344);
            this.txtDescritivo.Multiline = true;
            this.txtDescritivo.Name = "txtDescritivo";
            this.txtDescritivo.Size = new System.Drawing.Size(755, 180);
            this.txtDescritivo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descritivo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ultima Venda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(789, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ocorrencias";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Anexos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(12, 244);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(54, 19);
            this.chkAtivo.TabIndex = 19;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkOperacional
            // 
            this.chkOperacional.AutoSize = true;
            this.chkOperacional.Location = new System.Drawing.Point(86, 244);
            this.chkOperacional.Name = "chkOperacional";
            this.chkOperacional.Size = new System.Drawing.Size(90, 19);
            this.chkOperacional.TabIndex = 20;
            this.chkOperacional.Text = "Operacional";
            this.chkOperacional.UseVisualStyleBackColor = true;
            // 
            // chkForadeLinha
            // 
            this.chkForadeLinha.AutoSize = true;
            this.chkForadeLinha.Location = new System.Drawing.Point(204, 244);
            this.chkForadeLinha.Name = "chkForadeLinha";
            this.chkForadeLinha.Size = new System.Drawing.Size(94, 19);
            this.chkForadeLinha.TabIndex = 21;
            this.chkForadeLinha.Text = "Fora de linha";
            this.chkForadeLinha.UseVisualStyleBackColor = true;
            // 
            // labMelFornecedor
            // 
            this.labMelFornecedor.AutoSize = true;
            this.labMelFornecedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMelFornecedor.Location = new System.Drawing.Point(490, 179);
            this.labMelFornecedor.Name = "labMelFornecedor";
            this.labMelFornecedor.Size = new System.Drawing.Size(138, 15);
            this.labMelFornecedor.TabIndex = 23;
            this.labMelFornecedor.Text = "Melhor Fornecedor - F1";
            // 
            // txtMelhorFornecedor
            // 
            this.txtMelhorFornecedor.Location = new System.Drawing.Point(490, 197);
            this.txtMelhorFornecedor.Name = "txtMelhorFornecedor";
            this.txtMelhorFornecedor.Size = new System.Drawing.Size(429, 23);
            this.txtMelhorFornecedor.TabIndex = 22;
            this.txtMelhorFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMelhorFornecedor_KeyDown);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.CausesValidation = false;
            this.cmdNovo.Location = new System.Drawing.Point(787, 9);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(40, 25);
            this.cmdNovo.TabIndex = 24;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.CausesValidation = false;
            this.cmdGravar.Location = new System.Drawing.Point(833, 9);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(40, 25);
            this.cmdGravar.TabIndex = 25;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.CausesValidation = false;
            this.cmdSair.Location = new System.Drawing.Point(879, 9);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(40, 25);
            this.cmdSair.TabIndex = 26;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 536);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.labMelFornecedor);
            this.Controls.Add(this.txtMelhorFornecedor);
            this.Controls.Add(this.chkForadeLinha);
            this.Controls.Add(this.chkOperacional);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescritivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodFabricante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lbCadProdutos);
            this.Name = "frmCadProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCadProdutos;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private TextBox txtDataCadastro;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescFornecedor;
        private Label label4;
        private Label label5;
        private TextBox txtFabricante;
        private Label label6;
        private TextBox txtCodFabricante;
        private TextBox txtDescritivo;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox chkAtivo;
        private CheckBox chkOperacional;
        private CheckBox chkForadeLinha;
        private Label labMelFornecedor;
        private TextBox txtMelhorFornecedor;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
    }
}