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
            this.grdEmpresas = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEmpresas
            // 
            this.grdEmpresas.AllowUserToAddRows = false;
            this.grdEmpresas.AllowUserToDeleteRows = false;
            this.grdEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdRazao,
            this.grdFantasia,
            this.grdCNPJ});
            this.grdEmpresas.Location = new System.Drawing.Point(12, 30);
            this.grdEmpresas.MultiSelect = false;
            this.grdEmpresas.Name = "grdEmpresas";
            this.grdEmpresas.ReadOnly = true;
            this.grdEmpresas.RowTemplate.Height = 25;
            this.grdEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmpresas.Size = new System.Drawing.Size(776, 210);
            this.grdEmpresas.TabIndex = 0;
            this.grdEmpresas.DoubleClick += new System.EventHandler(this.grdEmpresas_DoubleClick);
            // 
            // grdID
            // 
            this.grdID.HeaderText = "ID";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdID.Visible = false;
            // 
            // grdRazao
            // 
            this.grdRazao.HeaderText = "Razao Social";
            this.grdRazao.Name = "grdRazao";
            this.grdRazao.ReadOnly = true;
            this.grdRazao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRazao.Width = 300;
            // 
            // grdFantasia
            // 
            this.grdFantasia.HeaderText = "Razão Fantasia";
            this.grdFantasia.Name = "grdFantasia";
            this.grdFantasia.ReadOnly = true;
            this.grdFantasia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFantasia.Width = 300;
            // 
            // grdCNPJ
            // 
            this.grdCNPJ.HeaderText = "CNPJ";
            this.grdCNPJ.Name = "grdCNPJ";
            this.grdCNPJ.ReadOnly = true;
            this.grdCNPJ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCNPJ.Width = 150;
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.Location = new System.Drawing.Point(632, 1);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(75, 23);
            this.CmdSelecionar.TabIndex = 1;
            this.CmdSelecionar.Text = "Selecionar";
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            this.CmdSelecionar.Click += new System.EventHandler(this.CmdSelecionar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(713, 1);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 2;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // frmSelecionaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.grdEmpresas);
            this.Name = "frmSelecionaEmpresa";
            this.ShowIcon = false;
            this.Text = "Selecionar Empresa";
            this.Load += new System.EventHandler(this.SelecionaEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdEmpresas;
        private Button CmdSelecionar;
        private Button cmdSair;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdRazao;
        private DataGridViewTextBoxColumn grdFantasia;
        private DataGridViewTextBoxColumn grdCNPJ;
    }
}