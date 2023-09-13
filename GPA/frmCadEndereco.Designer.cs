namespace Formularios
{
    partial class frmCadEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEndereco));
            txtReferncia = new TextBox();
            labReferencia = new Label();
            chkEndCobranca = new CheckBox();
            chkEndFisico = new CheckBox();
            txtCidade = new TextBox();
            labCidade = new Label();
            txtBairro = new TextBox();
            labBairro = new Label();
            txtRua = new TextBox();
            labRua = new Label();
            txtNumero = new TextBox();
            labNumero = new Label();
            txtIdentificacao = new TextBox();
            labIdentificacao = new Label();
            grdEnderecos = new DataGridView();
            grdid = new DataGridViewTextBoxColumn();
            grdIdentificacao = new DataGridViewTextBoxColumn();
            grdRua = new DataGridViewTextBoxColumn();
            grdNumero = new DataGridViewTextBoxColumn();
            grdBairro = new DataGridViewTextBoxColumn();
            grdCidade = new DataGridViewTextBoxColumn();
            grdEstado = new DataGridViewTextBoxColumn();
            grdReferencia = new DataGridViewTextBoxColumn();
            grdCEP = new DataGridViewTextBoxColumn();
            grdFisico = new DataGridViewTextBoxColumn();
            grdCobranca = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            txtEstado = new TextBox();
            labEstado = new Label();
            labCEP = new Label();
            txtCEP = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grdEnderecos).BeginInit();
            SuspendLayout();
            // 
            // txtReferncia
            // 
            txtReferncia.Location = new Point(12, 365);
            txtReferncia.MaxLength = 50;
            txtReferncia.Multiline = true;
            txtReferncia.Name = "txtReferncia";
            txtReferncia.Size = new Size(776, 73);
            txtReferncia.TabIndex = 10;
            // 
            // labReferencia
            // 
            labReferencia.AutoSize = true;
            labReferencia.BackColor = Color.Transparent;
            labReferencia.Location = new Point(12, 347);
            labReferencia.Name = "labReferencia";
            labReferencia.Size = new Size(62, 15);
            labReferencia.TabIndex = 37;
            labReferencia.Text = "Referencia";
            // 
            // chkEndCobranca
            // 
            chkEndCobranca.AutoSize = true;
            chkEndCobranca.BackColor = Color.Transparent;
            chkEndCobranca.Location = new Point(711, 324);
            chkEndCobranca.Name = "chkEndCobranca";
            chkEndCobranca.Size = new Size(77, 19);
            chkEndCobranca.TabIndex = 9;
            chkEndCobranca.Text = "Cobrança";
            chkEndCobranca.UseVisualStyleBackColor = false;
            // 
            // chkEndFisico
            // 
            chkEndFisico.AutoSize = true;
            chkEndFisico.BackColor = Color.Transparent;
            chkEndFisico.Location = new Point(711, 299);
            chkEndFisico.Name = "chkEndFisico";
            chkEndFisico.Size = new Size(56, 19);
            chkEndFisico.TabIndex = 8;
            chkEndFisico.Text = "Fisico";
            chkEndFisico.UseVisualStyleBackColor = false;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(345, 308);
            txtCidade.MaxLength = 30;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(153, 23);
            txtCidade.TabIndex = 5;
            // 
            // labCidade
            // 
            labCidade.AutoSize = true;
            labCidade.BackColor = Color.Transparent;
            labCidade.Location = new Point(345, 290);
            labCidade.Name = "labCidade";
            labCidade.Size = new Size(44, 15);
            labCidade.TabIndex = 33;
            labCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(12, 308);
            txtBairro.MaxLength = 30;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(315, 23);
            txtBairro.TabIndex = 4;
            // 
            // labBairro
            // 
            labBairro.AutoSize = true;
            labBairro.BackColor = Color.Transparent;
            labBairro.Location = new Point(12, 290);
            labBairro.Name = "labBairro";
            labBairro.Size = new Size(38, 15);
            labBairro.TabIndex = 31;
            labBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(213, 258);
            txtRua.MaxLength = 40;
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(364, 23);
            txtRua.TabIndex = 2;
            // 
            // labRua
            // 
            labRua.AutoSize = true;
            labRua.BackColor = Color.Transparent;
            labRua.Location = new Point(213, 240);
            labRua.Name = "labRua";
            labRua.Size = new Size(27, 15);
            labRua.TabIndex = 29;
            labRua.Text = "Rua";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(599, 258);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(153, 23);
            txtNumero.TabIndex = 3;
            // 
            // labNumero
            // 
            labNumero.AutoSize = true;
            labNumero.BackColor = Color.Transparent;
            labNumero.Location = new Point(599, 240);
            labNumero.Name = "labNumero";
            labNumero.Size = new Size(51, 15);
            labNumero.TabIndex = 27;
            labNumero.Text = "Número";
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.Location = new Point(12, 258);
            txtIdentificacao.MaxLength = 30;
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.Size = new Size(182, 23);
            txtIdentificacao.TabIndex = 1;
            // 
            // labIdentificacao
            // 
            labIdentificacao.AutoSize = true;
            labIdentificacao.BackColor = Color.Transparent;
            labIdentificacao.Location = new Point(12, 240);
            labIdentificacao.Name = "labIdentificacao";
            labIdentificacao.Size = new Size(75, 15);
            labIdentificacao.TabIndex = 25;
            labIdentificacao.Text = "Identificação";
            // 
            // grdEnderecos
            // 
            grdEnderecos.AllowUserToAddRows = false;
            grdEnderecos.AllowUserToDeleteRows = false;
            grdEnderecos.BackgroundColor = SystemColors.GradientActiveCaption;
            grdEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEnderecos.Columns.AddRange(new DataGridViewColumn[] { grdid, grdIdentificacao, grdRua, grdNumero, grdBairro, grdCidade, grdEstado, grdReferencia, grdCEP, grdFisico, grdCobranca });
            grdEnderecos.Location = new Point(12, 48);
            grdEnderecos.MultiSelect = false;
            grdEnderecos.Name = "grdEnderecos";
            grdEnderecos.ReadOnly = true;
            grdEnderecos.RowTemplate.Height = 25;
            grdEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEnderecos.Size = new Size(776, 189);
            grdEnderecos.TabIndex = 14;
            grdEnderecos.SelectionChanged += grdEnderecos_SelectionChanged;
            // 
            // grdid
            // 
            grdid.HeaderText = "ID";
            grdid.Name = "grdid";
            grdid.ReadOnly = true;
            grdid.Visible = false;
            // 
            // grdIdentificacao
            // 
            grdIdentificacao.HeaderText = "Identificação";
            grdIdentificacao.Name = "grdIdentificacao";
            grdIdentificacao.ReadOnly = true;
            grdIdentificacao.Width = 120;
            // 
            // grdRua
            // 
            grdRua.HeaderText = "Rua";
            grdRua.Name = "grdRua";
            grdRua.ReadOnly = true;
            grdRua.Width = 250;
            // 
            // grdNumero
            // 
            grdNumero.HeaderText = "Numero";
            grdNumero.Name = "grdNumero";
            grdNumero.ReadOnly = true;
            grdNumero.Width = 60;
            // 
            // grdBairro
            // 
            grdBairro.HeaderText = "Bairro";
            grdBairro.Name = "grdBairro";
            grdBairro.ReadOnly = true;
            grdBairro.Width = 150;
            // 
            // grdCidade
            // 
            grdCidade.HeaderText = "Cidade";
            grdCidade.Name = "grdCidade";
            grdCidade.ReadOnly = true;
            // 
            // grdEstado
            // 
            grdEstado.HeaderText = "Estado";
            grdEstado.Name = "grdEstado";
            grdEstado.ReadOnly = true;
            grdEstado.Width = 50;
            // 
            // grdReferencia
            // 
            grdReferencia.HeaderText = "Referencia";
            grdReferencia.Name = "grdReferencia";
            grdReferencia.ReadOnly = true;
            grdReferencia.Visible = false;
            // 
            // grdCEP
            // 
            grdCEP.HeaderText = "CEP";
            grdCEP.Name = "grdCEP";
            grdCEP.ReadOnly = true;
            grdCEP.Visible = false;
            // 
            // grdFisico
            // 
            grdFisico.HeaderText = "Fisico";
            grdFisico.Name = "grdFisico";
            grdFisico.ReadOnly = true;
            grdFisico.Visible = false;
            // 
            // grdCobranca
            // 
            grdCobranca.HeaderText = "Cobranca";
            grdCobranca.Name = "grdCobranca";
            grdCobranca.ReadOnly = true;
            grdCobranca.Visible = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(620, 30);
            label1.TabIndex = 23;
            label1.Text = "Endereços";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(686, 12);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 11;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(722, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 12;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(758, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 13;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(520, 308);
            txtEstado.MaxLength = 2;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(81, 23);
            txtEstado.TabIndex = 6;
            // 
            // labEstado
            // 
            labEstado.AutoSize = true;
            labEstado.BackColor = Color.Transparent;
            labEstado.Location = new Point(520, 290);
            labEstado.Name = "labEstado";
            labEstado.Size = new Size(21, 15);
            labEstado.TabIndex = 40;
            labEstado.Text = "UF";
            // 
            // labCEP
            // 
            labCEP.AutoSize = true;
            labCEP.BackColor = Color.Transparent;
            labCEP.Location = new Point(612, 290);
            labCEP.Name = "labCEP";
            labCEP.Size = new Size(28, 15);
            labCEP.TabIndex = 41;
            labCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(612, 308);
            txtCEP.Mask = "00,000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(93, 23);
            txtCEP.TabIndex = 7;
            // 
            // frmCadEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtCEP);
            Controls.Add(labCEP);
            Controls.Add(txtEstado);
            Controls.Add(labEstado);
            Controls.Add(txtReferncia);
            Controls.Add(labReferencia);
            Controls.Add(chkEndCobranca);
            Controls.Add(chkEndFisico);
            Controls.Add(txtCidade);
            Controls.Add(labCidade);
            Controls.Add(txtBairro);
            Controls.Add(labBairro);
            Controls.Add(txtRua);
            Controls.Add(labRua);
            Controls.Add(txtNumero);
            Controls.Add(labNumero);
            Controls.Add(txtIdentificacao);
            Controls.Add(labIdentificacao);
            Controls.Add(grdEnderecos);
            Controls.Add(label1);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Name = "frmCadEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Endereços";
            ((System.ComponentModel.ISupportInitialize)grdEnderecos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtReferncia;
        private Label labReferencia;
        private CheckBox chkEndCobranca;
        private CheckBox chkEndFisico;
        private TextBox txtCidade;
        private Label labCidade;
        private TextBox txtBairro;
        private Label labBairro;
        private TextBox txtRua;
        private Label labRua;
        private TextBox txtNumero;
        private Label labNumero;
        private TextBox txtIdentificacao;
        private Label labIdentificacao;
        private DataGridView grdEnderecos;
        private Label label1;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private TextBox txtEstado;
        private Label labEstado;
        private DataGridViewTextBoxColumn grdid;
        private DataGridViewTextBoxColumn grdIdentificacao;
        private DataGridViewTextBoxColumn grdRua;
        private DataGridViewTextBoxColumn grdNumero;
        private DataGridViewTextBoxColumn grdBairro;
        private DataGridViewTextBoxColumn grdCidade;
        private DataGridViewTextBoxColumn grdEstado;
        private DataGridViewTextBoxColumn grdReferencia;
        private DataGridViewTextBoxColumn grdFisico;
        private DataGridViewTextBoxColumn grdCobranca;
        private Label labCEP;
        private MaskedTextBox txtCEP;
        private DataGridViewTextBoxColumn grdCEP;
    }
}