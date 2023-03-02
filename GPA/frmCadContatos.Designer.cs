namespace Formularios
{
    partial class frmCadContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadContatos));
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdContatos = new System.Windows.Forms.DataGridView();
            this.grdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAniversario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdGerencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAnotacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.labTelefone = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.labCargo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtAniversario = new System.Windows.Forms.TextBox();
            this.labAniversario = new System.Windows.Forms.Label();
            this.chkComprador = new System.Windows.Forms.CheckBox();
            this.chkGerencia = new System.Windows.Forms.CheckBox();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.labAnotacoes = new System.Windows.Forms.Label();
            this.cmdExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.Location = new System.Drawing.Point(758, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 0;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.Location = new System.Drawing.Point(722, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 1;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.Location = new System.Drawing.Point(686, 12);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(30, 30);
            this.cmdNovo.TabIndex = 2;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contatos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdContatos
            // 
            this.grdContatos.AllowUserToAddRows = false;
            this.grdContatos.AllowUserToDeleteRows = false;
            this.grdContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdid,
            this.grdNome,
            this.grdCargo,
            this.grdNumero,
            this.grdEmail,
            this.grdAniversario,
            this.grdComprador,
            this.grdGerencia,
            this.grdAnotacoes});
            this.grdContatos.Location = new System.Drawing.Point(12, 48);
            this.grdContatos.MultiSelect = false;
            this.grdContatos.Name = "grdContatos";
            this.grdContatos.ReadOnly = true;
            this.grdContatos.RowTemplate.Height = 25;
            this.grdContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContatos.Size = new System.Drawing.Size(776, 189);
            this.grdContatos.TabIndex = 4;
            this.grdContatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContatos_Selection);
            // 
            // grdid
            // 
            this.grdid.HeaderText = "ID";
            this.grdid.Name = "grdid";
            this.grdid.ReadOnly = true;
            this.grdid.Visible = false;
            // 
            // grdNome
            // 
            this.grdNome.HeaderText = "Nome";
            this.grdNome.Name = "grdNome";
            this.grdNome.ReadOnly = true;
            this.grdNome.Width = 200;
            // 
            // grdCargo
            // 
            this.grdCargo.HeaderText = "Cargo";
            this.grdCargo.Name = "grdCargo";
            this.grdCargo.ReadOnly = true;
            this.grdCargo.Width = 150;
            // 
            // grdNumero
            // 
            this.grdNumero.HeaderText = "Telefone";
            this.grdNumero.Name = "grdNumero";
            this.grdNumero.ReadOnly = true;
            this.grdNumero.Width = 150;
            // 
            // grdEmail
            // 
            this.grdEmail.HeaderText = "E-mail";
            this.grdEmail.Name = "grdEmail";
            this.grdEmail.ReadOnly = true;
            this.grdEmail.Width = 230;
            // 
            // grdAniversario
            // 
            this.grdAniversario.HeaderText = "Aniversario";
            this.grdAniversario.Name = "grdAniversario";
            this.grdAniversario.ReadOnly = true;
            this.grdAniversario.Visible = false;
            // 
            // grdComprador
            // 
            this.grdComprador.HeaderText = "Comprador";
            this.grdComprador.Name = "grdComprador";
            this.grdComprador.ReadOnly = true;
            this.grdComprador.Visible = false;
            // 
            // grdGerencia
            // 
            this.grdGerencia.HeaderText = "Gerencia";
            this.grdGerencia.Name = "grdGerencia";
            this.grdGerencia.ReadOnly = true;
            this.grdGerencia.Visible = false;
            // 
            // grdAnotacoes
            // 
            this.grdAnotacoes.HeaderText = "Anotacoes";
            this.grdAnotacoes.Name = "grdAnotacoes";
            this.grdAnotacoes.ReadOnly = true;
            this.grdAnotacoes.Visible = false;
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(12, 240);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(40, 15);
            this.labNome.TabIndex = 5;
            this.labNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 258);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(391, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(635, 258);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PlaceholderText = "(  ) __ __ __ __ - __ __ __ __ __";
            this.txtTelefone.Size = new System.Drawing.Size(153, 23);
            this.txtTelefone.TabIndex = 8;
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(635, 240);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(51, 15);
            this.labTelefone.TabIndex = 7;
            this.labTelefone.Text = "Telefone";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(446, 258);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(153, 23);
            this.txtCargo.TabIndex = 10;
            // 
            // labCargo
            // 
            this.labCargo.AutoSize = true;
            this.labCargo.Location = new System.Drawing.Point(446, 240);
            this.labCargo.Name = "labCargo";
            this.labCargo.Size = new System.Drawing.Size(62, 15);
            this.labCargo.TabIndex = 9;
            this.labCargo.Text = "Cargo - F1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 308);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(12, 290);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(41, 15);
            this.labEmail.TabIndex = 11;
            this.labEmail.Text = "E-mail";
            // 
            // txtAniversario
            // 
            this.txtAniversario.Location = new System.Drawing.Point(446, 308);
            this.txtAniversario.Name = "txtAniversario";
            this.txtAniversario.PlaceholderText = "____  / ____  / ________";
            this.txtAniversario.Size = new System.Drawing.Size(153, 23);
            this.txtAniversario.TabIndex = 14;
            // 
            // labAniversario
            // 
            this.labAniversario.AutoSize = true;
            this.labAniversario.Location = new System.Drawing.Point(446, 290);
            this.labAniversario.Name = "labAniversario";
            this.labAniversario.Size = new System.Drawing.Size(66, 15);
            this.labAniversario.TabIndex = 13;
            this.labAniversario.Text = "Aniversario";
            // 
            // chkComprador
            // 
            this.chkComprador.AutoSize = true;
            this.chkComprador.Location = new System.Drawing.Point(623, 312);
            this.chkComprador.Name = "chkComprador";
            this.chkComprador.Size = new System.Drawing.Size(87, 19);
            this.chkComprador.TabIndex = 15;
            this.chkComprador.Text = "Comprador";
            this.chkComprador.UseVisualStyleBackColor = true;
            // 
            // chkGerencia
            // 
            this.chkGerencia.AutoSize = true;
            this.chkGerencia.Location = new System.Drawing.Point(716, 312);
            this.chkGerencia.Name = "chkGerencia";
            this.chkGerencia.Size = new System.Drawing.Size(72, 19);
            this.chkGerencia.TabIndex = 16;
            this.chkGerencia.Text = "Gerencia";
            this.chkGerencia.UseVisualStyleBackColor = true;
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Location = new System.Drawing.Point(12, 365);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(776, 73);
            this.txtAnotacoes.TabIndex = 18;
            // 
            // labAnotacoes
            // 
            this.labAnotacoes.AutoSize = true;
            this.labAnotacoes.Location = new System.Drawing.Point(12, 347);
            this.labAnotacoes.Name = "labAnotacoes";
            this.labAnotacoes.Size = new System.Drawing.Size(63, 15);
            this.labAnotacoes.TabIndex = 17;
            this.labAnotacoes.Text = "Anotações";
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.Location = new System.Drawing.Point(650, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(30, 30);
            this.cmdExcluir.TabIndex = 19;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // frmCadContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.labAnotacoes);
            this.Controls.Add(this.chkGerencia);
            this.Controls.Add(this.chkComprador);
            this.Controls.Add(this.txtAniversario);
            this.Controls.Add(this.labAniversario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.labCargo);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.labTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.grdContatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Name = "frmCadContatos";
            this.Text = "Contatos";
            ((System.ComponentModel.ISupportInitialize)(this.grdContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdSair;
        private Button cmdGravar;
        private Button cmdNovo;
        private Label label1;
        private DataGridView grdContatos;
        private Label labNome;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label labTelefone;
        private TextBox txtCargo;
        private Label labCargo;
        private TextBox txtEmail;
        private Label labEmail;
        private TextBox txtAniversario;
        private Label labAniversario;
        private CheckBox chkComprador;
        private CheckBox chkGerencia;
        private TextBox txtAnotacoes;
        private Label labAnotacoes;
        private DataGridViewTextBoxColumn grdid;
        private DataGridViewTextBoxColumn grdNome;
        private DataGridViewTextBoxColumn grdCargo;
        private DataGridViewTextBoxColumn grdNumero;
        private DataGridViewTextBoxColumn grdEmail;
        private DataGridViewTextBoxColumn grdAniversario;
        private DataGridViewTextBoxColumn grdComprador;
        private DataGridViewTextBoxColumn grdGerencia;
        private DataGridViewTextBoxColumn grdAnotacoes;
        private Button cmdExcluir;
    }
}