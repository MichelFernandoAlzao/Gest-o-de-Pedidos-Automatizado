namespace Formularios
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
            ((System.ComponentModel.ISupportInitialize)grdMeusClientes).BeginInit();
            SuspendLayout();
            // 
            // grdMeusClientes
            // 
            grdMeusClientes.AllowUserToAddRows = false;
            grdMeusClientes.AllowUserToDeleteRows = false;
            grdMeusClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMeusClientes.Columns.AddRange(new DataGridViewColumn[] { grdID, grdRazaoSocial, grdCNPJ });
            grdMeusClientes.Location = new Point(12, 81);
            grdMeusClientes.Name = "grdMeusClientes";
            grdMeusClientes.ReadOnly = true;
            grdMeusClientes.RowTemplate.Height = 25;
            grdMeusClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdMeusClientes.Size = new Size(688, 242);
            grdMeusClientes.TabIndex = 0;
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
            txtRazaoSocial.Size = new Size(688, 23);
            txtRazaoSocial.TabIndex = 1;
            txtRazaoSocial.KeyDown += txtRazaoSocial_KeyDown;
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(12, 34);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 2;
            labEmpresa.Text = "Empresa - F1";
            // 
            // lbCabeçallho
            // 
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
            cmdSair.TabIndex = 11;
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
            cmdSelecionar.TabIndex = 10;
            cmdSelecionar.UseVisualStyleBackColor = true;
            cmdSelecionar.Click += cmdSelecionar_Click;
            // 
            // frmMeusClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 335);
            ControlBox = false;
            Controls.Add(cmdSair);
            Controls.Add(cmdSelecionar);
            Controls.Add(lbCabeçallho);
            Controls.Add(labEmpresa);
            Controls.Add(txtRazaoSocial);
            Controls.Add(grdMeusClientes);
            Name = "frmMeusClientes";
            Text = "Meus Clientes";
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
    }
}