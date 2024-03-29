﻿namespace Formularios
{
    partial class frmAvisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvisos));
            cmdExcluir = new Button();
            cmdNovo = new Button();
            cmdSair = new Button();
            cmdGravar = new Button();
            lbPedidos = new Label();
            txtAviso = new TextBox();
            labAvisos = new Label();
            labInicio = new Label();
            labTermino = new Label();
            txtUsuarioDestino = new TextBox();
            labUsuario = new Label();
            grdAvisos = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdAviso = new DataGridViewTextBoxColumn();
            grdInicio = new DataGridViewTextBoxColumn();
            grdTermino = new DataGridViewTextBoxColumn();
            grdUsuario = new DataGridViewTextBoxColumn();
            grdIDusuario = new DataGridViewTextBoxColumn();
            grdTodos = new DataGridViewTextBoxColumn();
            chkTodos = new CheckBox();
            txtDataInicio = new MaskedTextBox();
            txtDataTermino = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grdAvisos).BeginInit();
            SuspendLayout();
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            cmdExcluir.Location = new Point(654, 12);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(29, 29);
            cmdExcluir.TabIndex = 11;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdNovo.Location = new Point(689, 12);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(29, 29);
            cmdNovo.TabIndex = 12;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(759, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 14;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(724, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 13;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // lbPedidos
            // 
            lbPedidos.BackColor = Color.Transparent;
            lbPedidos.BorderStyle = BorderStyle.Fixed3D;
            lbPedidos.Cursor = Cursors.IBeam;
            lbPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPedidos.ForeColor = Color.Black;
            lbPedidos.Location = new Point(12, 12);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(632, 30);
            lbPedidos.TabIndex = 15;
            lbPedidos.Text = "Cadastro Avisos";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAviso
            // 
            txtAviso.Location = new Point(12, 60);
            txtAviso.Multiline = true;
            txtAviso.Name = "txtAviso";
            txtAviso.Size = new Size(632, 70);
            txtAviso.TabIndex = 16;
            // 
            // labAvisos
            // 
            labAvisos.AutoSize = true;
            labAvisos.BackColor = Color.Transparent;
            labAvisos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labAvisos.Location = new Point(12, 42);
            labAvisos.Name = "labAvisos";
            labAvisos.Size = new Size(37, 15);
            labAvisos.TabIndex = 17;
            labAvisos.Text = "Aviso";
            // 
            // labInicio
            // 
            labInicio.AutoSize = true;
            labInicio.BackColor = Color.Transparent;
            labInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labInicio.Location = new Point(669, 44);
            labInicio.Name = "labInicio";
            labInicio.Size = new Size(37, 15);
            labInicio.TabIndex = 19;
            labInicio.Text = "Inicio";
            // 
            // labTermino
            // 
            labTermino.AutoSize = true;
            labTermino.BackColor = Color.Transparent;
            labTermino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labTermino.Location = new Point(668, 89);
            labTermino.Name = "labTermino";
            labTermino.Size = new Size(53, 15);
            labTermino.TabIndex = 21;
            labTermino.Text = "Termino";
            // 
            // txtUsuarioDestino
            // 
            txtUsuarioDestino.Location = new Point(647, 156);
            txtUsuarioDestino.Name = "txtUsuarioDestino";
            txtUsuarioDestino.Size = new Size(141, 23);
            txtUsuarioDestino.TabIndex = 24;
            txtUsuarioDestino.KeyDown += txtUsuarioDestino_KeyDown;
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.BackColor = Color.Transparent;
            labUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labUsuario.Location = new Point(647, 138);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(73, 15);
            labUsuario.TabIndex = 23;
            labUsuario.Text = "Usuario - F1";
            // 
            // grdAvisos
            // 
            grdAvisos.AllowUserToAddRows = false;
            grdAvisos.AllowUserToDeleteRows = false;
            grdAvisos.BackgroundColor = Color.Gainsboro;
            grdAvisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAvisos.Columns.AddRange(new DataGridViewColumn[] { grdID, grdAviso, grdInicio, grdTermino, grdUsuario, grdIDusuario, grdTodos });
            grdAvisos.Location = new Point(12, 185);
            grdAvisos.Name = "grdAvisos";
            grdAvisos.ReadOnly = true;
            grdAvisos.RowTemplate.Height = 25;
            grdAvisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAvisos.Size = new Size(776, 150);
            grdAvisos.TabIndex = 25;
            grdAvisos.RowEnter += grdAvisos_RowEnter;
            grdAvisos.SelectionChanged += grdAvisos_SelectionChanged;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Visible = false;
            // 
            // grdAviso
            // 
            grdAviso.HeaderText = "Aviso";
            grdAviso.Name = "grdAviso";
            grdAviso.ReadOnly = true;
            grdAviso.Width = 400;
            // 
            // grdInicio
            // 
            grdInicio.HeaderText = "Inicio";
            grdInicio.Name = "grdInicio";
            grdInicio.ReadOnly = true;
            // 
            // grdTermino
            // 
            grdTermino.HeaderText = "Termino";
            grdTermino.Name = "grdTermino";
            grdTermino.ReadOnly = true;
            // 
            // grdUsuario
            // 
            grdUsuario.HeaderText = "Usuario";
            grdUsuario.Name = "grdUsuario";
            grdUsuario.ReadOnly = true;
            // 
            // grdIDusuario
            // 
            grdIDusuario.HeaderText = "IDUsuario";
            grdIDusuario.Name = "grdIDusuario";
            grdIDusuario.ReadOnly = true;
            grdIDusuario.Visible = false;
            // 
            // grdTodos
            // 
            grdTodos.HeaderText = "Todos";
            grdTodos.Name = "grdTodos";
            grdTodos.ReadOnly = true;
            grdTodos.Width = 50;
            // 
            // chkTodos
            // 
            chkTodos.AutoSize = true;
            chkTodos.BackColor = Color.Transparent;
            chkTodos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkTodos.Location = new Point(12, 160);
            chkTodos.Name = "chkTodos";
            chkTodos.Size = new Size(58, 19);
            chkTodos.TabIndex = 26;
            chkTodos.Text = "Todos";
            chkTodos.UseVisualStyleBackColor = false;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Location = new Point(669, 60);
            txtDataInicio.Mask = "00/00/0000";
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(100, 23);
            txtDataInicio.TabIndex = 27;
            txtDataInicio.ValidatingType = typeof(DateTime);
            txtDataInicio.Leave += txtDataInicio_Leave;
            // 
            // txtDataTermino
            // 
            txtDataTermino.Location = new Point(669, 107);
            txtDataTermino.Mask = "00/00/0000";
            txtDataTermino.Name = "txtDataTermino";
            txtDataTermino.Size = new Size(100, 23);
            txtDataTermino.TabIndex = 28;
            txtDataTermino.ValidatingType = typeof(DateTime);
            txtDataTermino.Leave += txtDataTermino_Leave;
            // 
            // frmAvisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 349);
            ControlBox = false;
            Controls.Add(txtDataTermino);
            Controls.Add(txtDataInicio);
            Controls.Add(chkTodos);
            Controls.Add(grdAvisos);
            Controls.Add(txtUsuarioDestino);
            Controls.Add(labUsuario);
            Controls.Add(labTermino);
            Controls.Add(labInicio);
            Controls.Add(labAvisos);
            Controls.Add(txtAviso);
            Controls.Add(lbPedidos);
            Controls.Add(cmdExcluir);
            Controls.Add(cmdNovo);
            Controls.Add(cmdSair);
            Controls.Add(cmdGravar);
            Name = "frmAvisos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Avisos";
            Load += frmAvisos_Load;
            ((System.ComponentModel.ISupportInitialize)grdAvisos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdSair;
        private Button cmdGravar;
        private Label lbPedidos;
        private TextBox txtAviso;
        private Label labAvisos;
        private Label labInicio;
        private Label labTermino;
        private TextBox txtUsuarioDestino;
        private Label labUsuario;
        private DataGridView grdAvisos;
        private CheckBox chkTodos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdAviso;
        private DataGridViewTextBoxColumn grdInicio;
        private DataGridViewTextBoxColumn grdTermino;
        private DataGridViewTextBoxColumn grdUsuario;
        private DataGridViewTextBoxColumn grdIDusuario;
        private DataGridViewTextBoxColumn grdTodos;
        private MaskedTextBox txtDataInicio;
        private MaskedTextBox txtDataTermino;
    }
}