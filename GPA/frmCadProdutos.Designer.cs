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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
            lbCadProdutos = new Label();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescFornecedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtFabricante = new TextBox();
            label6 = new Label();
            txtCodFabricante = new TextBox();
            txtDescritivo = new TextBox();
            label7 = new Label();
            cmdUltVenda = new Button();
            button2 = new Button();
            chkAtivo = new CheckBox();
            chkOperacional = new CheckBox();
            chkForadeLinha = new CheckBox();
            labMelFornecedor = new Label();
            txtMelhorFornecedor = new TextBox();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            txtDataCadastro = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbCadProdutos
            // 
            lbCadProdutos.BackColor = Color.Transparent;
            lbCadProdutos.BorderStyle = BorderStyle.Fixed3D;
            lbCadProdutos.Cursor = Cursors.IBeam;
            lbCadProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCadProdutos.ForeColor = Color.Black;
            lbCadProdutos.Location = new Point(12, 9);
            lbCadProdutos.Name = "lbCadProdutos";
            lbCadProdutos.Size = new Size(819, 29);
            lbCadProdutos.TabIndex = 1;
            lbCadProdutos.Text = "Cadastro de Produtos";
            lbCadProdutos.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 65);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(472, 23);
            txtDescricao.TabIndex = 0;
            txtDescricao.KeyDown += txtDescricao_KeyDown;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(503, 65);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(127, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 5;
            label1.Text = "Descrição - F1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(503, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Codigo - F1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(652, 47);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "Data Cadastro";
            // 
            // txtDescFornecedor
            // 
            txtDescFornecedor.Location = new Point(12, 113);
            txtDescFornecedor.Name = "txtDescFornecedor";
            txtDescFornecedor.Size = new Size(472, 23);
            txtDescFornecedor.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 9;
            label4.Text = "Descrição Fornecedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 11;
            label5.Text = "Fabricante - F1";
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(12, 165);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(472, 23);
            txtFabricante.TabIndex = 5;
            txtFabricante.KeyDown += txtFabricante_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(789, 47);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 13;
            label6.Text = "Codigo Fabricante - F1";
            // 
            // txtCodFabricante
            // 
            txtCodFabricante.Location = new Point(789, 65);
            txtCodFabricante.Name = "txtCodFabricante";
            txtCodFabricante.Size = new Size(130, 23);
            txtCodFabricante.TabIndex = 3;
            txtCodFabricante.KeyDown += txtCodFabricante_KeyDown;
            // 
            // txtDescritivo
            // 
            txtDescritivo.Location = new Point(12, 244);
            txtDescritivo.Multiline = true;
            txtDescritivo.Name = "txtDescritivo";
            txtDescritivo.Size = new Size(755, 180);
            txtDescritivo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 226);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 15;
            label7.Text = "Descritivo";
            // 
            // cmdUltVenda
            // 
            cmdUltVenda.Location = new Point(789, 245);
            cmdUltVenda.Name = "cmdUltVenda";
            cmdUltVenda.Size = new Size(130, 23);
            cmdUltVenda.TabIndex = 11;
            cmdUltVenda.Text = "Ultima Venda";
            cmdUltVenda.UseVisualStyleBackColor = true;
            cmdUltVenda.Click += cmdUltVenda_Click;
            // 
            // button2
            // 
            button2.Location = new Point(789, 286);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 12;
            button2.Text = "Ocorrencias";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.BackColor = Color.Transparent;
            chkAtivo.Location = new Point(12, 194);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 7;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = false;
            // 
            // chkOperacional
            // 
            chkOperacional.AutoSize = true;
            chkOperacional.BackColor = Color.Transparent;
            chkOperacional.Location = new Point(86, 194);
            chkOperacional.Name = "chkOperacional";
            chkOperacional.Size = new Size(90, 19);
            chkOperacional.TabIndex = 8;
            chkOperacional.Text = "Operacional";
            chkOperacional.UseVisualStyleBackColor = false;
            // 
            // chkForadeLinha
            // 
            chkForadeLinha.AutoSize = true;
            chkForadeLinha.BackColor = Color.Transparent;
            chkForadeLinha.Location = new Point(204, 194);
            chkForadeLinha.Name = "chkForadeLinha";
            chkForadeLinha.Size = new Size(94, 19);
            chkForadeLinha.TabIndex = 9;
            chkForadeLinha.Text = "Fora de linha";
            chkForadeLinha.UseVisualStyleBackColor = false;
            // 
            // labMelFornecedor
            // 
            labMelFornecedor.AutoSize = true;
            labMelFornecedor.BackColor = Color.Transparent;
            labMelFornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labMelFornecedor.Location = new Point(490, 147);
            labMelFornecedor.Name = "labMelFornecedor";
            labMelFornecedor.Size = new Size(138, 15);
            labMelFornecedor.TabIndex = 23;
            labMelFornecedor.Text = "Melhor Fornecedor - F1";
            // 
            // txtMelhorFornecedor
            // 
            txtMelhorFornecedor.Location = new Point(490, 165);
            txtMelhorFornecedor.Name = "txtMelhorFornecedor";
            txtMelhorFornecedor.Size = new Size(429, 23);
            txtMelhorFornecedor.TabIndex = 6;
            txtMelhorFornecedor.KeyDown += txtMelhorFornecedor_KeyDown;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.CausesValidation = false;
            cmdNovo.Location = new Point(837, 9);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(29, 29);
            cmdNovo.TabIndex = 13;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.CausesValidation = false;
            cmdGravar.Location = new Point(872, 9);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 14;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.CausesValidation = false;
            cmdSair.Location = new Point(907, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 15;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.Enabled = false;
            txtDataCadastro.Location = new Point(652, 65);
            txtDataCadastro.Mask = "00/00/0000";
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.Size = new Size(100, 23);
            txtDataCadastro.TabIndex = 2;
            txtDataCadastro.ValidatingType = typeof(DateTime);
            // 
            // frmCadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(948, 437);
            ControlBox = false;
            Controls.Add(txtDataCadastro);
            Controls.Add(cmdSair);
            Controls.Add(cmdGravar);
            Controls.Add(cmdNovo);
            Controls.Add(labMelFornecedor);
            Controls.Add(txtMelhorFornecedor);
            Controls.Add(chkForadeLinha);
            Controls.Add(chkOperacional);
            Controls.Add(chkAtivo);
            Controls.Add(button2);
            Controls.Add(cmdUltVenda);
            Controls.Add(label7);
            Controls.Add(txtDescritivo);
            Controls.Add(label6);
            Controls.Add(txtCodFabricante);
            Controls.Add(label5);
            Controls.Add(txtFabricante);
            Controls.Add(label4);
            Controls.Add(txtDescFornecedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(txtDescricao);
            Controls.Add(lbCadProdutos);
            Name = "frmCadProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            Load += frmCadProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCadProdutos;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
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
        private Button cmdUltVenda;
        private Button button2;
        private CheckBox chkAtivo;
        private CheckBox chkOperacional;
        private CheckBox chkForadeLinha;
        private Label labMelFornecedor;
        private TextBox txtMelhorFornecedor;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private MaskedTextBox txtDataCadastro;
    }
}