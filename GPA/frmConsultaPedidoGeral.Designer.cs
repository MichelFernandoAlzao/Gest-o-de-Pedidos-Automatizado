namespace Formularios
{
    partial class frmConsultaPedidoGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPedidoGeral));
            lbCabeçallho = new Label();
            cmdBuscar = new Button();
            cmdSelecionar = new Button();
            grdListaPedido = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdRazao = new DataGridViewTextBoxColumn();
            grdData = new DataGridViewTextBoxColumn();
            cmdSair = new Button();
            txtVendedor = new TextBox();
            labVendedor = new Label();
            label1 = new Label();
            labDataInicial = new Label();
            txtDataFinal = new MaskedTextBox();
            txtDataInicial = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grdListaPedido).BeginInit();
            SuspendLayout();
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BackColor = Color.Transparent;
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 9);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(704, 30);
            lbCabeçallho.TabIndex = 4;
            lbCabeçallho.Text = "Consulta Pedidos";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdBuscar
            // 
            cmdBuscar.BackgroundImage = (Image)resources.GetObject("cmdBuscar.BackgroundImage");
            cmdBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdBuscar.Location = new Point(758, 75);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(30, 30);
            cmdBuscar.TabIndex = 5;
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // cmdSelecionar
            // 
            cmdSelecionar.BackgroundImage = (Image)resources.GetObject("cmdSelecionar.BackgroundImage");
            cmdSelecionar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSelecionar.Location = new Point(722, 9);
            cmdSelecionar.Name = "cmdSelecionar";
            cmdSelecionar.Size = new Size(30, 30);
            cmdSelecionar.TabIndex = 1;
            cmdSelecionar.UseVisualStyleBackColor = true;
            cmdSelecionar.Click += cmdSelecionar_Click;
            // 
            // grdListaPedido
            // 
            grdListaPedido.AllowUserToAddRows = false;
            grdListaPedido.AllowUserToDeleteRows = false;
            grdListaPedido.BackgroundColor = SystemColors.GradientActiveCaption;
            grdListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdListaPedido.Columns.AddRange(new DataGridViewColumn[] { grdID, grdRazao, grdData });
            grdListaPedido.Location = new Point(12, 107);
            grdListaPedido.Name = "grdListaPedido";
            grdListaPedido.ReadOnly = true;
            grdListaPedido.RowTemplate.Height = 25;
            grdListaPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdListaPedido.Size = new Size(776, 300);
            grdListaPedido.TabIndex = 3;
            grdListaPedido.DoubleClick += grdListaPedido_DoubleClick;
            // 
            // grdID
            // 
            grdID.HeaderText = "Numero";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            // 
            // grdRazao
            // 
            grdRazao.HeaderText = "Razão Social";
            grdRazao.Name = "grdRazao";
            grdRazao.ReadOnly = true;
            grdRazao.Width = 500;
            // 
            // grdData
            // 
            grdData.HeaderText = "Data";
            grdData.Name = "grdData";
            grdData.ReadOnly = true;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(758, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 2;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += button3_Click;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(272, 80);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(130, 23);
            txtVendedor.TabIndex = 9;
            txtVendedor.KeyDown += txtVendedor_KeyDown;
            // 
            // labVendedor
            // 
            labVendedor.AutoSize = true;
            labVendedor.BackColor = Color.Transparent;
            labVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labVendedor.Location = new Point(272, 62);
            labVendedor.Name = "labVendedor";
            labVendedor.Size = new Size(85, 15);
            labVendedor.TabIndex = 10;
            labVendedor.Text = "Vendedor - F1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(148, 62);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 26;
            label1.Text = "Data Final";
            // 
            // labDataInicial
            // 
            labDataInicial.AutoSize = true;
            labDataInicial.BackColor = Color.Transparent;
            labDataInicial.Location = new Point(12, 62);
            labDataInicial.Name = "labDataInicial";
            labDataInicial.Size = new Size(65, 15);
            labDataInicial.TabIndex = 25;
            labDataInicial.Text = "Data Inicial";
            // 
            // txtDataFinal
            // 
            txtDataFinal.Location = new Point(148, 80);
            txtDataFinal.Mask = "00/00/0000";
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(100, 23);
            txtDataFinal.TabIndex = 24;
            txtDataFinal.ValidatingType = typeof(DateTime);
            txtDataFinal.Leave += txtDataFinal_Leave;
            // 
            // txtDataInicial
            // 
            txtDataInicial.Location = new Point(12, 80);
            txtDataInicial.Mask = "00/00/0000";
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(100, 23);
            txtDataInicial.TabIndex = 23;
            txtDataInicial.ValidatingType = typeof(DateTime);
            txtDataInicial.Leave += txtDataInicial_Leave;
            // 
            // frmConsultaPedidoGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 419);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(labDataInicial);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicial);
            Controls.Add(txtVendedor);
            Controls.Add(labVendedor);
            Controls.Add(cmdSair);
            Controls.Add(grdListaPedido);
            Controls.Add(cmdSelecionar);
            Controls.Add(cmdBuscar);
            Controls.Add(lbCabeçallho);
            Name = "frmConsultaPedidoGeral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Pedido";
            ((System.ComponentModel.ISupportInitialize)grdListaPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCabeçallho;
        private Button cmdBuscar;
        private Button cmdSelecionar;
        private DataGridView grdListaPedido;
        private Button cmdSair;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdRazao;
        private DataGridViewTextBoxColumn grdData;
        private TextBox txtVendedor;
        private Label labVendedor;
        private Label label1;
        private Label labDataInicial;
        private MaskedTextBox txtDataFinal;
        private MaskedTextBox txtDataInicial;
    }
}