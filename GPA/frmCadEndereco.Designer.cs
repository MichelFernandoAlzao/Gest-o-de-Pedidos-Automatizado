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
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.txtReferncia = new System.Windows.Forms.TextBox();
            this.labReferencia = new System.Windows.Forms.Label();
            this.chkEndCobranca = new System.Windows.Forms.CheckBox();
            this.chkEndFisico = new System.Windows.Forms.CheckBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.labRua = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.labNumero = new System.Windows.Forms.Label();
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.labIdentificacao = new System.Windows.Forms.Label();
            this.grdEnderecos = new System.Windows.Forms.DataGridView();
            this.grdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdIdentificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCobranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.labEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.Location = new System.Drawing.Point(650, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(30, 30);
            this.cmdExcluir.TabIndex = 39;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // txtReferncia
            // 
            this.txtReferncia.Location = new System.Drawing.Point(12, 365);
            this.txtReferncia.Multiline = true;
            this.txtReferncia.Name = "txtReferncia";
            this.txtReferncia.Size = new System.Drawing.Size(776, 73);
            this.txtReferncia.TabIndex = 9;
            // 
            // labReferencia
            // 
            this.labReferencia.AutoSize = true;
            this.labReferencia.Location = new System.Drawing.Point(12, 347);
            this.labReferencia.Name = "labReferencia";
            this.labReferencia.Size = new System.Drawing.Size(62, 15);
            this.labReferencia.TabIndex = 37;
            this.labReferencia.Text = "Referencia";
            // 
            // chkEndCobranca
            // 
            this.chkEndCobranca.AutoSize = true;
            this.chkEndCobranca.Location = new System.Drawing.Point(711, 324);
            this.chkEndCobranca.Name = "chkEndCobranca";
            this.chkEndCobranca.Size = new System.Drawing.Size(77, 19);
            this.chkEndCobranca.TabIndex = 8;
            this.chkEndCobranca.Text = "Cobrança";
            this.chkEndCobranca.UseVisualStyleBackColor = true;
            // 
            // chkEndFisico
            // 
            this.chkEndFisico.AutoSize = true;
            this.chkEndFisico.Location = new System.Drawing.Point(711, 299);
            this.chkEndFisico.Name = "chkEndFisico";
            this.chkEndFisico.Size = new System.Drawing.Size(56, 19);
            this.chkEndFisico.TabIndex = 7;
            this.chkEndFisico.Text = "Fisico";
            this.chkEndFisico.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(424, 310);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(153, 23);
            this.txtCidade.TabIndex = 5;
            // 
            // labCidade
            // 
            this.labCidade.AutoSize = true;
            this.labCidade.Location = new System.Drawing.Point(424, 292);
            this.labCidade.Name = "labCidade";
            this.labCidade.Size = new System.Drawing.Size(44, 15);
            this.labCidade.TabIndex = 33;
            this.labCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 308);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(391, 23);
            this.txtBairro.TabIndex = 4;
            // 
            // labBairro
            // 
            this.labBairro.AutoSize = true;
            this.labBairro.Location = new System.Drawing.Point(12, 290);
            this.labBairro.Name = "labBairro";
            this.labBairro.Size = new System.Drawing.Size(38, 15);
            this.labBairro.TabIndex = 31;
            this.labBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(213, 258);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(364, 23);
            this.txtRua.TabIndex = 2;
            // 
            // labRua
            // 
            this.labRua.AutoSize = true;
            this.labRua.Location = new System.Drawing.Point(213, 240);
            this.labRua.Name = "labRua";
            this.labRua.Size = new System.Drawing.Size(27, 15);
            this.labRua.TabIndex = 29;
            this.labRua.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(599, 258);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(153, 23);
            this.txtNumero.TabIndex = 3;
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Location = new System.Drawing.Point(599, 240);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(51, 15);
            this.labNumero.TabIndex = 27;
            this.labNumero.Text = "Número";
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.Location = new System.Drawing.Point(12, 258);
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(182, 23);
            this.txtIdentificacao.TabIndex = 1;
            // 
            // labIdentificacao
            // 
            this.labIdentificacao.AutoSize = true;
            this.labIdentificacao.Location = new System.Drawing.Point(12, 240);
            this.labIdentificacao.Name = "labIdentificacao";
            this.labIdentificacao.Size = new System.Drawing.Size(75, 15);
            this.labIdentificacao.TabIndex = 25;
            this.labIdentificacao.Text = "Identificação";
            // 
            // grdEnderecos
            // 
            this.grdEnderecos.AllowUserToAddRows = false;
            this.grdEnderecos.AllowUserToDeleteRows = false;
            this.grdEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdid,
            this.grdIdentificacao,
            this.grdRua,
            this.grdNumero,
            this.grdBairro,
            this.grdCidade,
            this.grdEstado,
            this.grdReferencia,
            this.grdFisico,
            this.grdCobranca});
            this.grdEnderecos.Location = new System.Drawing.Point(12, 48);
            this.grdEnderecos.MultiSelect = false;
            this.grdEnderecos.Name = "grdEnderecos";
            this.grdEnderecos.ReadOnly = true;
            this.grdEnderecos.RowTemplate.Height = 25;
            this.grdEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEnderecos.Size = new System.Drawing.Size(776, 189);
            this.grdEnderecos.TabIndex = 24;
            this.grdEnderecos.SelectionChanged += new System.EventHandler(this.grdEnderecos_SelectionChanged);
            // 
            // grdid
            // 
            this.grdid.HeaderText = "ID";
            this.grdid.Name = "grdid";
            this.grdid.ReadOnly = true;
            this.grdid.Visible = false;
            // 
            // grdIdentificacao
            // 
            this.grdIdentificacao.HeaderText = "Identificação";
            this.grdIdentificacao.Name = "grdIdentificacao";
            this.grdIdentificacao.ReadOnly = true;
            this.grdIdentificacao.Width = 120;
            // 
            // grdRua
            // 
            this.grdRua.HeaderText = "Rua";
            this.grdRua.Name = "grdRua";
            this.grdRua.ReadOnly = true;
            this.grdRua.Width = 250;
            // 
            // grdNumero
            // 
            this.grdNumero.HeaderText = "Numero";
            this.grdNumero.Name = "grdNumero";
            this.grdNumero.ReadOnly = true;
            this.grdNumero.Width = 60;
            // 
            // grdBairro
            // 
            this.grdBairro.HeaderText = "Bairro";
            this.grdBairro.Name = "grdBairro";
            this.grdBairro.ReadOnly = true;
            this.grdBairro.Width = 150;
            // 
            // grdCidade
            // 
            this.grdCidade.HeaderText = "Cidade";
            this.grdCidade.Name = "grdCidade";
            this.grdCidade.ReadOnly = true;
            // 
            // grdEstado
            // 
            this.grdEstado.HeaderText = "Estado";
            this.grdEstado.Name = "grdEstado";
            this.grdEstado.ReadOnly = true;
            this.grdEstado.Width = 50;
            // 
            // grdReferencia
            // 
            this.grdReferencia.HeaderText = "Referencia";
            this.grdReferencia.Name = "grdReferencia";
            this.grdReferencia.ReadOnly = true;
            this.grdReferencia.Visible = false;
            // 
            // grdFisico
            // 
            this.grdFisico.HeaderText = "Fisico";
            this.grdFisico.Name = "grdFisico";
            this.grdFisico.ReadOnly = true;
            this.grdFisico.Visible = false;
            // 
            // grdCobranca
            // 
            this.grdCobranca.HeaderText = "Cobranca";
            this.grdCobranca.Name = "grdCobranca";
            this.grdCobranca.ReadOnly = true;
            this.grdCobranca.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Endereços";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.Location = new System.Drawing.Point(686, 12);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(30, 30);
            this.cmdNovo.TabIndex = 22;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.Location = new System.Drawing.Point(722, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 21;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.Location = new System.Drawing.Point(758, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 20;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(599, 310);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(81, 23);
            this.txtEstado.TabIndex = 6;
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Location = new System.Drawing.Point(599, 292);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(21, 15);
            this.labEstado.TabIndex = 40;
            this.labEstado.Text = "UF";
            // 
            // frmCadEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.labEstado);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.txtReferncia);
            this.Controls.Add(this.labReferencia);
            this.Controls.Add(this.chkEndCobranca);
            this.Controls.Add(this.chkEndFisico);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.labCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.labBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.labRua);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labNumero);
            this.Controls.Add(this.txtIdentificacao);
            this.Controls.Add(this.labIdentificacao);
            this.Controls.Add(this.grdEnderecos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Name = "frmCadEndereco";
            this.Text = "Cadastro Endereços";
            ((System.ComponentModel.ISupportInitialize)(this.grdEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdExcluir;
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
    }
}