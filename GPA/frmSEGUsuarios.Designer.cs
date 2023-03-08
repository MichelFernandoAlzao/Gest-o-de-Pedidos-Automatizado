namespace Formularios
{
    partial class frmSEGUsuarios
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
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.chkGerenCadastros = new System.Windows.Forms.CheckBox();
            this.chkSeguranca = new System.Windows.Forms.CheckBox();
            this.chkOperacional = new System.Windows.Forms.CheckBox();
            this.grdUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdUserSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAltCadastros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdOperacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSeguranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdUserID,
            this.grdNomeUsuario,
            this.grdUsuario,
            this.grdUserSenha,
            this.grdAdmin,
            this.grdAltCadastros,
            this.grdOperacional,
            this.grdSeguranca});
            this.grdUsuarios.Location = new System.Drawing.Point(12, 12);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.RowTemplate.Height = 25;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(544, 426);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.SelectionChanged += new System.EventHandler(this.grdUsuarios_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(562, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(562, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(562, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(226, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(562, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 23);
            this.txtNome.TabIndex = 4;
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(727, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(60, 25);
            this.cmdSair.TabIndex = 5;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(646, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(60, 25);
            this.cmdGravar.TabIndex = 6;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(562, 12);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(60, 25);
            this.cmdNovo.TabIndex = 7;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Location = new System.Drawing.Point(562, 149);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(102, 19);
            this.chkAdministrador.TabIndex = 8;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // chkGerenCadastros
            // 
            this.chkGerenCadastros.AutoSize = true;
            this.chkGerenCadastros.Location = new System.Drawing.Point(670, 149);
            this.chkGerenCadastros.Name = "chkGerenCadastros";
            this.chkGerenCadastros.Size = new System.Drawing.Size(127, 19);
            this.chkGerenCadastros.TabIndex = 9;
            this.chkGerenCadastros.Text = "Gerencia Cadastros";
            this.chkGerenCadastros.UseVisualStyleBackColor = true;
            // 
            // chkSeguranca
            // 
            this.chkSeguranca.AutoSize = true;
            this.chkSeguranca.Location = new System.Drawing.Point(670, 191);
            this.chkSeguranca.Name = "chkSeguranca";
            this.chkSeguranca.Size = new System.Drawing.Size(81, 19);
            this.chkSeguranca.TabIndex = 11;
            this.chkSeguranca.Text = "Segurança";
            this.chkSeguranca.UseVisualStyleBackColor = true;
            // 
            // chkOperacional
            // 
            this.chkOperacional.AutoSize = true;
            this.chkOperacional.Location = new System.Drawing.Point(562, 191);
            this.chkOperacional.Name = "chkOperacional";
            this.chkOperacional.Size = new System.Drawing.Size(90, 19);
            this.chkOperacional.TabIndex = 10;
            this.chkOperacional.Text = "Operacional";
            this.chkOperacional.UseVisualStyleBackColor = true;
            // 
            // grdUserID
            // 
            this.grdUserID.HeaderText = "ID";
            this.grdUserID.Name = "grdUserID";
            this.grdUserID.ReadOnly = true;
            this.grdUserID.Visible = false;
            // 
            // grdNomeUsuario
            // 
            this.grdNomeUsuario.HeaderText = "Nome";
            this.grdNomeUsuario.Name = "grdNomeUsuario";
            this.grdNomeUsuario.ReadOnly = true;
            this.grdNomeUsuario.Width = 350;
            // 
            // grdUsuario
            // 
            this.grdUsuario.HeaderText = "Usuário";
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.ReadOnly = true;
            this.grdUsuario.Width = 150;
            // 
            // grdUserSenha
            // 
            this.grdUserSenha.HeaderText = "Senha";
            this.grdUserSenha.Name = "grdUserSenha";
            this.grdUserSenha.ReadOnly = true;
            this.grdUserSenha.Visible = false;
            // 
            // grdAdmin
            // 
            this.grdAdmin.HeaderText = "Administrador";
            this.grdAdmin.Name = "grdAdmin";
            this.grdAdmin.ReadOnly = true;
            this.grdAdmin.Visible = false;
            // 
            // grdAltCadastros
            // 
            this.grdAltCadastros.HeaderText = "AlteraCadastros";
            this.grdAltCadastros.Name = "grdAltCadastros";
            this.grdAltCadastros.ReadOnly = true;
            this.grdAltCadastros.Visible = false;
            // 
            // grdOperacional
            // 
            this.grdOperacional.HeaderText = "Operacional";
            this.grdOperacional.Name = "grdOperacional";
            this.grdOperacional.ReadOnly = true;
            this.grdOperacional.Visible = false;
            // 
            // grdSeguranca
            // 
            this.grdSeguranca.HeaderText = "Seguranca";
            this.grdSeguranca.Name = "grdSeguranca";
            this.grdSeguranca.ReadOnly = true;
            this.grdSeguranca.Visible = false;
            // 
            // frmSEGUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.chkSeguranca);
            this.Controls.Add(this.chkOperacional);
            this.Controls.Add(this.chkGerenCadastros);
            this.Controls.Add(this.chkAdministrador);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdUsuarios);
            this.Name = "frmSEGUsuarios";
            this.Text = "Segurança";
            this.Load += new System.EventHandler(this.frmSEGUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdUsuarios;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtNome;
        private Button cmdSair;
        private Button cmdGravar;
        private Button cmdNovo;
        private CheckBox chkAdministrador;
        private CheckBox chkGerenCadastros;
        private DataGridViewTextBoxColumn grdUserID;
        private DataGridViewTextBoxColumn grdNomeUsuario;
        private DataGridViewTextBoxColumn grdUsuario;
        private DataGridViewTextBoxColumn grdUserSenha;
        private DataGridViewTextBoxColumn grdAdmin;
        private DataGridViewTextBoxColumn grdAltCadastros;
        private CheckBox chkSeguranca;
        private CheckBox chkOperacional;
        private DataGridViewTextBoxColumn grdOperacional;
        private DataGridViewTextBoxColumn grdSeguranca;
    }
}