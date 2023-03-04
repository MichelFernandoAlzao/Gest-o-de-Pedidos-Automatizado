namespace Formularios
{
    partial class frmSelecionaProduto
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
            this.cmdSair = new System.Windows.Forms.Button();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCadProdutos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(712, 7);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 5;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.Location = new System.Drawing.Point(631, 7);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(75, 23);
            this.CmdSelecionar.TabIndex = 4;
            this.CmdSelecionar.Text = "Selecionar";
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            this.CmdSelecionar.Click += new System.EventHandler(this.CmdSelecionar_Click);
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdDescricao,
            this.grdCodigo,
            this.grdAtivo});
            this.grdProdutos.Location = new System.Drawing.Point(11, 36);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowTemplate.Height = 25;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(776, 210);
            this.grdProdutos.TabIndex = 3;
            // 
            // grdID
            // 
            this.grdID.HeaderText = "ID";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdID.Visible = false;
            // 
            // grdDescricao
            // 
            this.grdDescricao.HeaderText = "Descrição";
            this.grdDescricao.Name = "grdDescricao";
            this.grdDescricao.ReadOnly = true;
            this.grdDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDescricao.Width = 450;
            // 
            // grdCodigo
            // 
            this.grdCodigo.HeaderText = "Codigo";
            this.grdCodigo.Name = "grdCodigo";
            this.grdCodigo.ReadOnly = true;
            this.grdCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCodigo.Width = 200;
            // 
            // grdAtivo
            // 
            this.grdAtivo.HeaderText = "Ativo";
            this.grdAtivo.Name = "grdAtivo";
            this.grdAtivo.ReadOnly = true;
            this.grdAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lbCadProdutos
            // 
            this.lbCadProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCadProdutos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbCadProdutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCadProdutos.ForeColor = System.Drawing.Color.Black;
            this.lbCadProdutos.Location = new System.Drawing.Point(12, 4);
            this.lbCadProdutos.Name = "lbCadProdutos";
            this.lbCadProdutos.Size = new System.Drawing.Size(613, 29);
            this.lbCadProdutos.TabIndex = 6;
            this.lbCadProdutos.Text = "Seleciona Produtos";
            this.lbCadProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSelecionaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.ControlBox = false;
            this.Controls.Add(this.lbCadProdutos);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.grdProdutos);
            this.Name = "frmSelecionaProduto";
            this.Text = "frmSelecionaProduto";
            this.Load += new System.EventHandler(this.frmSelecionaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdProdutos;
        private Label lbCadProdutos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
        private DataGridViewTextBoxColumn grdAtivo;
    }
}