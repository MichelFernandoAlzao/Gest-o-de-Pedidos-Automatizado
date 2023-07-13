namespace Formularios
{
    partial class frmRelRegistroContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelRegistroContatos));
            labEmpresa = new Label();
            txtEmpresa = new TextBox();
            txtVendedor = new TextBox();
            labVendedor = new Label();
            txtDataInicial = new MaskedTextBox();
            txtDataFinal = new MaskedTextBox();
            labDataFinal = new Label();
            lbDataInicial = new Label();
            labVendasPorCliente = new Label();
            cmdSair = new Button();
            cmdImprimir = new Button();
            SuspendLayout();
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.BackColor = Color.Transparent;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(12, 53);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 9;
            labEmpresa.Text = "Empresa - F1";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(12, 71);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(411, 23);
            txtEmpresa.TabIndex = 1;
            txtEmpresa.KeyDown += txtEmpresa_KeyDown;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(268, 134);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(155, 23);
            txtVendedor.TabIndex = 4;
            txtVendedor.KeyDown += txtVendedor_KeyDown;
            // 
            // labVendedor
            // 
            labVendedor.AutoSize = true;
            labVendedor.BackColor = Color.Transparent;
            labVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labVendedor.Location = new Point(268, 116);
            labVendedor.Name = "labVendedor";
            labVendedor.Size = new Size(85, 15);
            labVendedor.TabIndex = 11;
            labVendedor.Text = "Vendedor - F1";
            // 
            // txtDataInicial
            // 
            txtDataInicial.Location = new Point(12, 134);
            txtDataInicial.Mask = "00/00/0000";
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(100, 23);
            txtDataInicial.TabIndex = 2;
            txtDataInicial.ValidatingType = typeof(DateTime);
            txtDataInicial.Leave += txtDataInicial_Leave;
            // 
            // txtDataFinal
            // 
            txtDataFinal.Location = new Point(118, 134);
            txtDataFinal.Mask = "00/00/0000";
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(100, 23);
            txtDataFinal.TabIndex = 3;
            txtDataFinal.ValidatingType = typeof(DateTime);
            txtDataFinal.Leave += txtDataFinal_Leave;
            // 
            // labDataFinal
            // 
            labDataFinal.AutoSize = true;
            labDataFinal.BackColor = Color.Transparent;
            labDataFinal.Location = new Point(115, 114);
            labDataFinal.Name = "labDataFinal";
            labDataFinal.Size = new Size(59, 15);
            labDataFinal.TabIndex = 52;
            labDataFinal.Text = "Data Final";
            // 
            // lbDataInicial
            // 
            lbDataInicial.AutoSize = true;
            lbDataInicial.BackColor = Color.Transparent;
            lbDataInicial.Location = new Point(12, 115);
            lbDataInicial.Name = "lbDataInicial";
            lbDataInicial.Size = new Size(65, 15);
            lbDataInicial.TabIndex = 51;
            lbDataInicial.Text = "Data Inicial";
            // 
            // labVendasPorCliente
            // 
            labVendasPorCliente.BackColor = Color.Transparent;
            labVendasPorCliente.BorderStyle = BorderStyle.Fixed3D;
            labVendasPorCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labVendasPorCliente.Location = new Point(14, 12);
            labVendasPorCliente.Margin = new Padding(5, 0, 3, 0);
            labVendasPorCliente.Name = "labVendasPorCliente";
            labVendasPorCliente.Size = new Size(337, 30);
            labVendasPorCliente.TabIndex = 58;
            labVendasPorCliente.Text = "Registros de Contatos";
            labVendasPorCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.AccessibleDescription = "Sair";
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(393, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 6;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdImprimir
            // 
            cmdImprimir.BackgroundImage = (Image)resources.GetObject("cmdImprimir.BackgroundImage");
            cmdImprimir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdImprimir.Location = new Point(357, 12);
            cmdImprimir.Name = "cmdImprimir";
            cmdImprimir.Size = new Size(30, 30);
            cmdImprimir.TabIndex = 5;
            cmdImprimir.UseVisualStyleBackColor = true;
            cmdImprimir.Click += cmdImprimir_Click;
            // 
            // frmRelRegistroContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(436, 184);
            ControlBox = false;
            Controls.Add(cmdImprimir);
            Controls.Add(labVendasPorCliente);
            Controls.Add(cmdSair);
            Controls.Add(txtDataInicial);
            Controls.Add(txtDataFinal);
            Controls.Add(labDataFinal);
            Controls.Add(lbDataInicial);
            Controls.Add(txtVendedor);
            Controls.Add(labVendedor);
            Controls.Add(labEmpresa);
            Controls.Add(txtEmpresa);
            Name = "frmRelRegistroContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas por Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labEmpresa;
        private TextBox txtEmpresa;
        private TextBox txtVendedor;
        private Label labVendedor;
        private MaskedTextBox txtDataInicial;
        private MaskedTextBox txtDataFinal;
        private Label labDataFinal;
        private Label lbDataInicial;
        private Label labVendasPorCliente;
        private Button cmdSair;
        private Button cmdImprimir;
    }
}