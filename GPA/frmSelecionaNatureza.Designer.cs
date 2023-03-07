namespace Formularios
{
    partial class frmSelecionaNatureza
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
            this.lbSelectNatOperacao = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Button();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.grdNatureza = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNatureza)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelectNatOperacao
            // 
            this.lbSelectNatOperacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSelectNatOperacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbSelectNatOperacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelectNatOperacao.ForeColor = System.Drawing.Color.Black;
            this.lbSelectNatOperacao.Location = new System.Drawing.Point(13, 4);
            this.lbSelectNatOperacao.Name = "lbSelectNatOperacao";
            this.lbSelectNatOperacao.Size = new System.Drawing.Size(286, 29);
            this.lbSelectNatOperacao.TabIndex = 14;
            this.lbSelectNatOperacao.Text = "Seleciona Natureza";
            this.lbSelectNatOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(386, 7);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 13;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.Location = new System.Drawing.Point(305, 7);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(75, 23);
            this.CmdSelecionar.TabIndex = 12;
            this.CmdSelecionar.Text = "Selecionar";
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            this.CmdSelecionar.Click += new System.EventHandler(this.CmdSelecionar_Click);
            // 
            // grdNatureza
            // 
            this.grdNatureza.AllowUserToAddRows = false;
            this.grdNatureza.AllowUserToDeleteRows = false;
            this.grdNatureza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNatureza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdDescricao,
            this.grdCodigo,
            this.grdAtivo});
            this.grdNatureza.Location = new System.Drawing.Point(12, 36);
            this.grdNatureza.MultiSelect = false;
            this.grdNatureza.Name = "grdNatureza";
            this.grdNatureza.ReadOnly = true;
            this.grdNatureza.RowTemplate.Height = 25;
            this.grdNatureza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNatureza.Size = new System.Drawing.Size(457, 402);
            this.grdNatureza.TabIndex = 11;
            this.grdNatureza.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmpresas_CellDoubleClick);
            this.grdNatureza.SelectionChanged += new System.EventHandler(this.grdNatureza_SelectionChanged);
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
            // frmSelecionaNatureza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbSelectNatOperacao);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.grdNatureza);
            this.Name = "frmSelecionaNatureza";
            this.Text = "frmSelecionaNatureza";
            this.Load += new System.EventHandler(this.frmSelecionaNatureza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNatureza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbSelectNatOperacao;
        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdNatureza;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
        private DataGridViewTextBoxColumn grdAtivo;
    }
}