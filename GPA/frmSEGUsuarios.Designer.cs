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
            grdUsuarios = new DataGridView();
            grdUserID = new DataGridViewTextBoxColumn();
            grdNomeUsuario = new DataGridViewTextBoxColumn();
            grdUsuario = new DataGridViewTextBoxColumn();
            grdUserSenha = new DataGridViewTextBoxColumn();
            grdAdmin = new DataGridViewTextBoxColumn();
            grdAltCadastros = new DataGridViewTextBoxColumn();
            grdOperacional = new DataGridViewTextBoxColumn();
            grdSeguranca = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtNome = new TextBox();
            cmdSair = new Button();
            cmdGravar = new Button();
            cmdNovo = new Button();
            chkAdministrador = new CheckBox();
            chkGerenCadastros = new CheckBox();
            chkSeguranca = new CheckBox();
            chkOperacional = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
            SuspendLayout();
            // 
            // grdUsuarios
            // 
            grdUsuarios.AllowUserToAddRows = false;
            grdUsuarios.AllowUserToDeleteRows = false;
            grdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsuarios.Columns.AddRange(new DataGridViewColumn[] { grdUserID, grdNomeUsuario, grdUsuario, grdUserSenha, grdAdmin, grdAltCadastros, grdOperacional, grdSeguranca });
            grdUsuarios.Location = new Point(12, 12);
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.ReadOnly = true;
            grdUsuarios.RowTemplate.Height = 25;
            grdUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsuarios.Size = new Size(544, 426);
            grdUsuarios.TabIndex = 0;
            grdUsuarios.SelectionChanged += grdUsuarios_SelectionChanged;
            // 
            // grdUserID
            // 
            grdUserID.HeaderText = "ID";
            grdUserID.Name = "grdUserID";
            grdUserID.ReadOnly = true;
            grdUserID.Visible = false;
            // 
            // grdNomeUsuario
            // 
            grdNomeUsuario.HeaderText = "Nome";
            grdNomeUsuario.Name = "grdNomeUsuario";
            grdNomeUsuario.ReadOnly = true;
            grdNomeUsuario.Width = 350;
            // 
            // grdUsuario
            // 
            grdUsuario.HeaderText = "Usuário";
            grdUsuario.Name = "grdUsuario";
            grdUsuario.ReadOnly = true;
            grdUsuario.Width = 150;
            // 
            // grdUserSenha
            // 
            grdUserSenha.HeaderText = "Senha";
            grdUserSenha.Name = "grdUserSenha";
            grdUserSenha.ReadOnly = true;
            grdUserSenha.Visible = false;
            // 
            // grdAdmin
            // 
            grdAdmin.HeaderText = "Administrador";
            grdAdmin.Name = "grdAdmin";
            grdAdmin.ReadOnly = true;
            grdAdmin.Visible = false;
            // 
            // grdAltCadastros
            // 
            grdAltCadastros.HeaderText = "AlteraCadastros";
            grdAltCadastros.Name = "grdAltCadastros";
            grdAltCadastros.ReadOnly = true;
            grdAltCadastros.Visible = false;
            // 
            // grdOperacional
            // 
            grdOperacional.HeaderText = "Operacional";
            grdOperacional.Name = "grdOperacional";
            grdOperacional.ReadOnly = true;
            grdOperacional.Visible = false;
            // 
            // grdSeguranca
            // 
            grdSeguranca.HeaderText = "Seguranca";
            grdSeguranca.Name = "grdSeguranca";
            grdSeguranca.ReadOnly = true;
            grdSeguranca.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(562, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(562, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Location = new Point(562, 59);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(226, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(562, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 23);
            txtNome.TabIndex = 4;
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(727, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(60, 25);
            cmdSair.TabIndex = 5;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.Location = new Point(646, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(60, 25);
            cmdGravar.TabIndex = 6;
            cmdGravar.Text = "Gravar";
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.Location = new Point(562, 12);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(60, 25);
            cmdNovo.TabIndex = 7;
            cmdNovo.Text = "Novo";
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // chkAdministrador
            // 
            chkAdministrador.AutoSize = true;
            chkAdministrador.Location = new Point(562, 149);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(102, 19);
            chkAdministrador.TabIndex = 8;
            chkAdministrador.Text = "Administrador";
            chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // chkGerenCadastros
            // 
            chkGerenCadastros.AutoSize = true;
            chkGerenCadastros.Location = new Point(670, 149);
            chkGerenCadastros.Name = "chkGerenCadastros";
            chkGerenCadastros.Size = new Size(127, 19);
            chkGerenCadastros.TabIndex = 9;
            chkGerenCadastros.Text = "Gerencia Cadastros";
            chkGerenCadastros.UseVisualStyleBackColor = true;
            // 
            // chkSeguranca
            // 
            chkSeguranca.AutoSize = true;
            chkSeguranca.Location = new Point(670, 191);
            chkSeguranca.Name = "chkSeguranca";
            chkSeguranca.Size = new Size(81, 19);
            chkSeguranca.TabIndex = 11;
            chkSeguranca.Text = "Segurança";
            chkSeguranca.UseVisualStyleBackColor = true;
            // 
            // chkOperacional
            // 
            chkOperacional.AutoSize = true;
            chkOperacional.Location = new Point(562, 191);
            chkOperacional.Name = "chkOperacional";
            chkOperacional.Size = new Size(90, 19);
            chkOperacional.TabIndex = 10;
            chkOperacional.Text = "Operacional";
            chkOperacional.UseVisualStyleBackColor = true;
            // 
            // frmSEGUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(chkSeguranca);
            Controls.Add(chkOperacional);
            Controls.Add(chkGerenCadastros);
            Controls.Add(chkAdministrador);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(txtNome);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grdUsuarios);
            Name = "frmSEGUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Segurança";
            Load += frmSEGUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
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