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
            lbLancPedido = new Label();
            cmdSair = new Button();
            CmdSelecionar = new Button();
            grdPedidos = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            grdCodigo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdPedidos).BeginInit();
            SuspendLayout();
            // 
            // lbLancPedido
            // 
            lbLancPedido.BorderStyle = BorderStyle.Fixed3D;
            lbLancPedido.Cursor = Cursors.IBeam;
            lbLancPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbLancPedido.ForeColor = Color.Black;
            lbLancPedido.Location = new Point(13, 5);
            lbLancPedido.Name = "lbLancPedido";
            lbLancPedido.Size = new Size(613, 29);
            lbLancPedido.TabIndex = 10;
            lbLancPedido.Text = "Seleciona Pedido";
            lbLancPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(713, 8);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(75, 23);
            cmdSair.TabIndex = 9;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // CmdSelecionar
            // 
            CmdSelecionar.Location = new Point(632, 8);
            CmdSelecionar.Name = "CmdSelecionar";
            CmdSelecionar.Size = new Size(75, 23);
            CmdSelecionar.TabIndex = 8;
            CmdSelecionar.Text = "Selecionar";
            CmdSelecionar.UseVisualStyleBackColor = true;
            CmdSelecionar.Click += CmdSelecionar_Click;
            // 
            // grdPedidos
            // 
            grdPedidos.AllowUserToAddRows = false;
            grdPedidos.AllowUserToDeleteRows = false;
            grdPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPedidos.Columns.AddRange(new DataGridViewColumn[] { grdID, grdDescricao, grdCodigo });
            grdPedidos.Location = new Point(12, 37);
            grdPedidos.MultiSelect = false;
            grdPedidos.Name = "grdPedidos";
            grdPedidos.ReadOnly = true;
            grdPedidos.RowTemplate.Height = 25;
            grdPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPedidos.Size = new Size(776, 210);
            grdPedidos.TabIndex = 7;
            grdPedidos.DoubleClick += grdPedidos_DoubleClick;
            // 
            // grdID
            // 
            grdID.HeaderText = "Número";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Resizable = DataGridViewTriState.True;
            // 
            // grdDescricao
            // 
            grdDescricao.HeaderText = "Empresa";
            grdDescricao.Name = "grdDescricao";
            grdDescricao.ReadOnly = true;
            grdDescricao.Resizable = DataGridViewTriState.True;
            grdDescricao.Width = 450;
            // 
            // grdCodigo
            // 
            grdCodigo.HeaderText = "Data Contato";
            grdCodigo.Name = "grdCodigo";
            grdCodigo.ReadOnly = true;
            grdCodigo.Resizable = DataGridViewTriState.True;
            grdCodigo.Width = 200;
            // 
            // frmSelecionaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 251);
            ControlBox = false;
            Controls.Add(lbLancPedido);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdPedidos);
            Name = "frmSelecionaPedido";
            Text = "frmSelecionaPedido";
            Load += frmSelecionaPedido_Load;
            ((System.ComponentModel.ISupportInitialize)grdPedidos).EndInit();
            ResumeLayout(false);
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