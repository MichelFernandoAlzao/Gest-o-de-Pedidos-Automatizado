namespace Formularios
{
    partial class frmSelecionaPedido
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
            this.lbLancPedido = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Button();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.grdPedidos = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLancPedido
            // 
            this.lbLancPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLancPedido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbLancPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLancPedido.ForeColor = System.Drawing.Color.Black;
            this.lbLancPedido.Location = new System.Drawing.Point(13, 5);
            this.lbLancPedido.Name = "lbLancPedido";
            this.lbLancPedido.Size = new System.Drawing.Size(613, 29);
            this.lbLancPedido.TabIndex = 10;
            this.lbLancPedido.Text = "Seleciona Pedido";
            this.lbLancPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(713, 8);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 9;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.Location = new System.Drawing.Point(632, 8);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(75, 23);
            this.CmdSelecionar.TabIndex = 8;
            this.CmdSelecionar.Text = "Selecionar";
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            this.CmdSelecionar.Click += new System.EventHandler(this.CmdSelecionar_Click);
            // 
            // grdPedidos
            // 
            this.grdPedidos.AllowUserToAddRows = false;
            this.grdPedidos.AllowUserToDeleteRows = false;
            this.grdPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdDescricao,
            this.grdCodigo});
            this.grdPedidos.Location = new System.Drawing.Point(12, 37);
            this.grdPedidos.MultiSelect = false;
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.ReadOnly = true;
            this.grdPedidos.RowTemplate.Height = 25;
            this.grdPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPedidos.Size = new System.Drawing.Size(776, 210);
            this.grdPedidos.TabIndex = 7;
            // 
            // grdID
            // 
            this.grdID.HeaderText = "Número";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grdDescricao
            // 
            this.grdDescricao.HeaderText = "Empresa";
            this.grdDescricao.Name = "grdDescricao";
            this.grdDescricao.ReadOnly = true;
            this.grdDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDescricao.Width = 450;
            // 
            // grdCodigo
            // 
            this.grdCodigo.HeaderText = "Data Contato";
            this.grdCodigo.Name = "grdCodigo";
            this.grdCodigo.ReadOnly = true;
            this.grdCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCodigo.Width = 200;
            // 
            // frmSelecionaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.ControlBox = false;
            this.Controls.Add(this.lbLancPedido);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.grdPedidos);
            this.Name = "frmSelecionaPedido";
            this.Text = "frmSelecionaPedido";
            this.Load += new System.EventHandler(this.frmSelecionaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbLancPedido;
        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdPedidos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
        private DataGridViewTextBoxColumn grdAtivo;
    }
}