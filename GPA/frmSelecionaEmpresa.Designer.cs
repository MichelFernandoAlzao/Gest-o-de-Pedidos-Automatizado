namespace Formularios
{
    partial class frmSelecionaEmpresa
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
            grdEmpresas = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdRazao = new DataGridViewTextBoxColumn();
            grdFantasia = new DataGridViewTextBoxColumn();
            grdCNPJ = new DataGridViewTextBoxColumn();
            CmdSelecionar = new Button();
            cmdSair = new Button();
            lbCadProdutos = new Label();
            ((System.ComponentModel.ISupportInitialize)grdEmpresas).BeginInit();
            SuspendLayout();
            // 
            // grdEmpresas
            // 
            grdEmpresas.AllowUserToAddRows = false;
            grdEmpresas.AllowUserToDeleteRows = false;
            grdEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEmpresas.Columns.AddRange(new DataGridViewColumn[] { grdID, grdRazao, grdFantasia, grdCNPJ });
            grdEmpresas.Location = new Point(12, 41);
            grdEmpresas.MultiSelect = false;
            grdEmpresas.Name = "grdEmpresas";
            grdEmpresas.ReadOnly = true;
            grdEmpresas.RowTemplate.Height = 25;
            grdEmpresas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEmpresas.Size = new Size(776, 210);
            grdEmpresas.TabIndex = 0;
            grdEmpresas.CellDoubleClick += grdEmpresas_CellDoubleClick;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Resizable = DataGridViewTriState.True;
            grdID.Visible = false;
            // 
            // grdRazao
            // 
            grdRazao.HeaderText = "Razao Social";
            grdRazao.Name = "grdRazao";
            grdRazao.ReadOnly = true;
            grdRazao.Resizable = DataGridViewTriState.True;
            grdRazao.Width = 300;
            // 
            // grdFantasia
            // 
            grdFantasia.HeaderText = "Razão Fantasia";
            grdFantasia.Name = "grdFantasia";
            grdFantasia.ReadOnly = true;
            grdFantasia.Resizable = DataGridViewTriState.True;
            grdFantasia.Width = 300;
            // 
            // grdCNPJ
            // 
            grdCNPJ.HeaderText = "CNPJ";
            grdCNPJ.Name = "grdCNPJ";
            grdCNPJ.ReadOnly = true;
            grdCNPJ.Resizable = DataGridViewTriState.True;
            grdCNPJ.Width = 150;
            // 
            // CmdSelecionar
            // 
            CmdSelecionar.Location = new Point(631, 12);
            CmdSelecionar.Name = "CmdSelecionar";
            CmdSelecionar.Size = new Size(75, 23);
            CmdSelecionar.TabIndex = 1;
            CmdSelecionar.Text = "Selecionar";
            CmdSelecionar.UseVisualStyleBackColor = true;
            CmdSelecionar.Click += CmdSelecionar_Click;
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(713, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(75, 23);
            cmdSair.TabIndex = 2;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // lbCadProdutos
            // 
            lbCadProdutos.BorderStyle = BorderStyle.Fixed3D;
            lbCadProdutos.Cursor = Cursors.IBeam;
            lbCadProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCadProdutos.ForeColor = Color.Black;
            lbCadProdutos.Location = new Point(12, 9);
            lbCadProdutos.Name = "lbCadProdutos";
            lbCadProdutos.Size = new Size(613, 29);
            lbCadProdutos.TabIndex = 7;
            lbCadProdutos.Text = "Seleciona Produtos";
            lbCadProdutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmSelecionaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 256);
            ControlBox = false;
            Controls.Add(lbCadProdutos);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdEmpresas);
            Name = "frmSelecionaEmpresa";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Empresa";
            Load += SelecionaEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)grdEmpresas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdEmpresas;
        private Button CmdSelecionar;
        private Button cmdSair;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdRazao;
        private DataGridViewTextBoxColumn grdFantasia;
        private DataGridViewTextBoxColumn grdCNPJ;
        private Label lbCadProdutos;
    }
}