﻿namespace Formularios
{
    partial class frmMeusClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeusClientes));
            grdMeusClientes = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdRazaoSocial = new DataGridViewTextBoxColumn();
            grdCNPJ = new DataGridViewTextBoxColumn();
            txtRazaoSocial = new TextBox();
            labEmpresa = new Label();
            lbCabeçallho = new Label();
            cmdSair = new Button();
            cmdSelecionar = new Button();
            chkGerencia = new CheckBox();
            txtCNPJ = new MaskedTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdMeusClientes).BeginInit();
            SuspendLayout();
            // 
            // grdMeusClientes
            // 
            grdMeusClientes.AllowUserToAddRows = false;
            grdMeusClientes.AllowUserToDeleteRows = false;
            grdMeusClientes.BackgroundColor = SystemColors.GradientActiveCaption;
            grdMeusClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMeusClientes.Columns.AddRange(new DataGridViewColumn[] { grdID, grdRazaoSocial, grdCNPJ });
            grdMeusClientes.Location = new Point(12, 81);
            grdMeusClientes.Name = "grdMeusClientes";
            grdMeusClientes.ReadOnly = true;
            grdMeusClientes.RowTemplate.Height = 25;
            grdMeusClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMeusClientes.Size = new Size(688, 242);
            grdMeusClientes.TabIndex = 3;
            grdMeusClientes.DoubleClick += grdMeusClientes_DoubleClick;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Visible = false;
            // 
            // grdRazaoSocial
            // 
            grdRazaoSocial.HeaderText = "Razão Social";
            grdRazaoSocial.Name = "grdRazaoSocial";
            grdRazaoSocial.ReadOnly = true;
            grdRazaoSocial.Width = 500;
            // 
            // grdCNPJ
            // 
            grdCNPJ.HeaderText = "CNPJ";
            grdCNPJ.Name = "grdCNPJ";
            grdCNPJ.ReadOnly = true;
            grdCNPJ.Width = 150;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(12, 52);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(415, 23);
            txtRazaoSocial.TabIndex = 0;
            txtRazaoSocial.KeyDown += txtRazaoSocial_KeyDown;
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.BackColor = Color.Transparent;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(12, 34);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 2;
            labEmpresa.Text = "Empresa - F1";
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BackColor = Color.Transparent;
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 4);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(610, 30);
            lbCabeçallho.TabIndex = 5;
            lbCabeçallho.Text = "Meus Clientes";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(670, 4);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 5;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdSelecionar
            // 
            cmdSelecionar.BackgroundImage = (Image)resources.GetObject("cmdSelecionar.BackgroundImage");
            cmdSelecionar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSelecionar.Location = new Point(634, 4);
            cmdSelecionar.Name = "cmdSelecionar";
            cmdSelecionar.Size = new Size(30, 30);
            cmdSelecionar.TabIndex = 4;
            cmdSelecionar.UseVisualStyleBackColor = true;
            cmdSelecionar.Click += cmdSelecionar_Click;
            // 
            // chkGerencia
            // 
            chkGerencia.AutoSize = true;
            chkGerencia.BackColor = Color.Transparent;
            chkGerencia.Location = new Point(643, 54);
            chkGerencia.Name = "chkGerencia";
            chkGerencia.Size = new Size(57, 19);
            chkGerencia.TabIndex = 2;
            chkGerencia.Text = "Todos";
            chkGerencia.UseVisualStyleBackColor = false;
            chkGerencia.CheckedChanged += chkGerencia_CheckedChanged;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(449, 52);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(173, 23);
            txtCNPJ.TabIndex = 1;
            txtCNPJ.KeyDown += txtCNPJ_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(449, 34);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 14;
            label1.Text = "CNPJ - F1";
            // 
            // frmMeusClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(712, 335);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(txtCNPJ);
            Controls.Add(chkGerencia);
            Controls.Add(cmdSair);
            Controls.Add(cmdSelecionar);
            Controls.Add(lbCabeçallho);
            Controls.Add(labEmpresa);
            Controls.Add(txtRazaoSocial);
            Controls.Add(grdMeusClientes);
            Name = "frmMeusClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meus Clientes";
            Load += frmMeusClientes_Load;
            ((System.ComponentModel.ISupportInitialize)grdMeusClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdMeusClientes;
        private TextBox txtRazaoSocial;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdRazaoSocial;
        private DataGridViewTextBoxColumn grdCNPJ;
        private Label labEmpresa;
        private Label lbCabeçallho;
        private Button cmdSair;
        private Button cmdSelecionar;
        private CheckBox chkGerencia;
        private MaskedTextBox txtCNPJ;
        private Label label1;
    }
}