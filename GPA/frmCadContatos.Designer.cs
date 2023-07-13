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
            cmdSair = new Button();
            cmdGravar = new Button();
            cmdNovo = new Button();
            label1 = new Label();
            grdContatos = new DataGridView();
            grdid = new DataGridViewTextBoxColumn();
            grdNome = new DataGridViewTextBoxColumn();
            grdCargo = new DataGridViewTextBoxColumn();
            grdNumero = new DataGridViewTextBoxColumn();
            grdEmail = new DataGridViewTextBoxColumn();
            grdAniversario = new DataGridViewTextBoxColumn();
            grdComprador = new DataGridViewTextBoxColumn();
            grdGerencia = new DataGridViewTextBoxColumn();
            grdAnotacoes = new DataGridViewTextBoxColumn();
            labNome = new Label();
            txtNome = new TextBox();
            labTelefone = new Label();
            txtCargo = new TextBox();
            labCargo = new Label();
            txtEmail = new TextBox();
            labEmail = new Label();
            labAniversario = new Label();
            chkComprador = new CheckBox();
            chkGerencia = new CheckBox();
            txtAnotacoes = new TextBox();
            labAnotacoes = new Label();
            cmdExcluir = new Button();
            txtTelefone = new MaskedTextBox();
            txtAniversario = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grdContatos).BeginInit();
            SuspendLayout();
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(758, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 12;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(722, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 11;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(686, 12);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 10;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(620, 30);
            label1.TabIndex = 3;
            label1.Text = "Contatos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grdContatos
            // 
            grdContatos.AllowUserToAddRows = false;
            grdContatos.AllowUserToDeleteRows = false;
            grdContatos.BackgroundColor = SystemColors.GradientActiveCaption;
            grdContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContatos.Columns.AddRange(new DataGridViewColumn[] { grdid, grdNome, grdCargo, grdNumero, grdEmail, grdAniversario, grdComprador, grdGerencia, grdAnotacoes });
            grdContatos.Location = new Point(12, 48);
            grdContatos.MultiSelect = false;
            grdContatos.Name = "grdContatos";
            grdContatos.ReadOnly = true;
            grdContatos.RowTemplate.Height = 25;
            grdContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContatos.Size = new Size(776, 189);
            grdContatos.TabIndex = 13;
            grdContatos.CellEnter += grdContatos_Selection;
            grdContatos.SelectionChanged += grdContatos_SelectionChanged;
            // 
            // grdid
            // 
            grdid.HeaderText = "ID";
            grdid.Name = "grdid";
            grdid.ReadOnly = true;
            grdid.Visible = false;
            // 
            // grdNome
            // 
            grdNome.HeaderText = "Nome";
            grdNome.Name = "grdNome";
            grdNome.ReadOnly = true;
            grdNome.Width = 200;
            // 
            // grdCargo
            // 
            grdCargo.HeaderText = "Cargo";
            grdCargo.Name = "grdCargo";
            grdCargo.ReadOnly = true;
            grdCargo.Width = 150;
            // 
            // grdNumero
            // 
            grdNumero.HeaderText = "Telefone";
            grdNumero.Name = "grdNumero";
            grdNumero.ReadOnly = true;
            grdNumero.Width = 150;
            // 
            // grdEmail
            // 
            grdEmail.HeaderText = "E-mail";
            grdEmail.Name = "grdEmail";
            grdEmail.ReadOnly = true;
            grdEmail.Width = 230;
            // 
            // grdAniversario
            // 
            grdAniversario.HeaderText = "Aniversario";
            grdAniversario.Name = "grdAniversario";
            grdAniversario.ReadOnly = true;
            grdAniversario.Visible = false;
            // 
            // grdComprador
            // 
            grdComprador.HeaderText = "Comprador";
            grdComprador.Name = "grdComprador";
            grdComprador.ReadOnly = true;
            grdComprador.Visible = false;
            // 
            // grdGerencia
            // 
            grdGerencia.HeaderText = "Gerencia";
            grdGerencia.Name = "grdGerencia";
            grdGerencia.ReadOnly = true;
            grdGerencia.Visible = false;
            // 
            // grdAnotacoes
            // 
            grdAnotacoes.HeaderText = "Anotacoes";
            grdAnotacoes.Name = "grdAnotacoes";
            grdAnotacoes.ReadOnly = true;
            grdAnotacoes.Visible = false;
            // 
            // labNome
            // 
            labNome.AutoSize = true;
            labNome.BackColor = Color.Transparent;
            labNome.Location = new Point(12, 240);
            labNome.Name = "labNome";
            labNome.Size = new Size(40, 15);
            labNome.TabIndex = 5;
            labNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 258);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(391, 23);
            txtNome.TabIndex = 1;
            // 
            // labTelefone
            // 
            labTelefone.AutoSize = true;
            labTelefone.BackColor = Color.Transparent;
            labTelefone.Location = new Point(635, 240);
            labTelefone.Name = "labTelefone";
            labTelefone.Size = new Size(51, 15);
            labTelefone.TabIndex = 7;
            labTelefone.Text = "Telefone";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(446, 258);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(153, 23);
            txtCargo.TabIndex = 2;
            // 
            // labCargo
            // 
            labCargo.AutoSize = true;
            labCargo.BackColor = Color.Transparent;
            labCargo.Location = new Point(446, 240);
            labCargo.Name = "labCargo";
            labCargo.Size = new Size(62, 15);
            labCargo.TabIndex = 9;
            labCargo.Text = "Cargo - F1";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 308);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(391, 23);
            txtEmail.TabIndex = 4;
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.BackColor = Color.Transparent;
            labEmail.Location = new Point(12, 290);
            labEmail.Name = "labEmail";
            labEmail.Size = new Size(41, 15);
            labEmail.TabIndex = 11;
            labEmail.Text = "E-mail";
            // 
            // labAniversario
            // 
            labAniversario.AutoSize = true;
            labAniversario.BackColor = Color.Transparent;
            labAniversario.Location = new Point(446, 290);
            labAniversario.Name = "labAniversario";
            labAniversario.Size = new Size(66, 15);
            labAniversario.TabIndex = 13;
            labAniversario.Text = "Aniversario";
            // 
            // chkComprador
            // 
            chkComprador.AutoSize = true;
            chkComprador.BackColor = Color.Transparent;
            chkComprador.Location = new Point(623, 312);
            chkComprador.Name = "chkComprador";
            chkComprador.Size = new Size(87, 19);
            chkComprador.TabIndex = 6;
            chkComprador.Text = "Comprador";
            chkComprador.UseVisualStyleBackColor = false;
            // 
            // chkGerencia
            // 
            chkGerencia.AutoSize = true;
            chkGerencia.BackColor = Color.Transparent;
            chkGerencia.Location = new Point(716, 312);
            chkGerencia.Name = "chkGerencia";
            chkGerencia.Size = new Size(72, 19);
            chkGerencia.TabIndex = 7;
            chkGerencia.Text = "Gerencia";
            chkGerencia.UseVisualStyleBackColor = false;
            // 
            // txtAnotacoes
            // 
            txtAnotacoes.Location = new Point(12, 365);
            txtAnotacoes.Multiline = true;
            txtAnotacoes.Name = "txtAnotacoes";
            txtAnotacoes.Size = new Size(776, 73);
            txtAnotacoes.TabIndex = 8;
            // 
            // labAnotacoes
            // 
            labAnotacoes.AutoSize = true;
            labAnotacoes.BackColor = Color.Transparent;
            labAnotacoes.Location = new Point(12, 347);
            labAnotacoes.Name = "labAnotacoes";
            labAnotacoes.Size = new Size(63, 15);
            labAnotacoes.TabIndex = 17;
            labAnotacoes.Text = "Anotações";
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdExcluir.Location = new Point(650, 12);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(30, 30);
            cmdExcluir.TabIndex = 9;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(635, 258);
            txtTelefone.Mask = "( 00 ) 00000 - 0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(153, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtAniversario
            // 
            txtAniversario.Location = new Point(446, 308);
            txtAniversario.Mask = "00/00/0000";
            txtAniversario.Name = "txtAniversario";
            txtAniversario.Size = new Size(153, 23);
            txtAniversario.TabIndex = 5;
            txtAniversario.ValidatingType = typeof(DateTime);
            txtAniversario.Leave += txtAniversario_Leave;
            // 
            // frmCadContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtAniversario);
            Controls.Add(txtTelefone);
            Controls.Add(cmdExcluir);
            Controls.Add(txtAnotacoes);
            Controls.Add(labAnotacoes);
            Controls.Add(chkGerencia);
            Controls.Add(chkComprador);
            Controls.Add(labAniversario);
            Controls.Add(txtEmail);
            Controls.Add(labEmail);
            Controls.Add(txtCargo);
            Controls.Add(labCargo);
            Controls.Add(labTelefone);
            Controls.Add(txtNome);
            Controls.Add(labNome);
            Controls.Add(grdContatos);
            Controls.Add(label1);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Name = "frmCadContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contatos";
            ((System.ComponentModel.ISupportInitialize)grdContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdSair;
        private Button cmdGravar;
        private Button cmdNovo;
        private Label label1;
        private DataGridView grdContatos;
        private Label labNome;
        private TextBox txtNome;
        private Label labTelefone;
        private TextBox txtCargo;
        private Label labCargo;
        private TextBox txtEmail;
        private Label labEmail;
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
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtAniversario;
    }
}