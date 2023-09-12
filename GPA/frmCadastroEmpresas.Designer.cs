namespace Formularios
{
    partial class frmCadastroEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmpresas));
            labVendedor = new Label();
            labCarteira = new Label();
            txtVendedor = new TextBox();
            txtCarteira = new TextBox();
            cmdSair = new Button();
            chkAtivo = new CheckBox();
            labCadEmpresas = new Label();
            cmdImprimir = new Button();
            SuspendLayout();
            // 
            // labVendedor
            // 
            labVendedor.AutoSize = true;
            labVendedor.BackColor = Color.Transparent;
            labVendedor.Location = new Point(12, 48);
            labVendedor.Name = "labVendedor";
            labVendedor.Size = new Size(80, 15);
            labVendedor.TabIndex = 0;
            labVendedor.Text = "Vendedor - F1";
            // 
            // labCarteira
            // 
            labCarteira.AutoSize = true;
            labCarteira.BackColor = Color.Transparent;
            labCarteira.Location = new Point(172, 48);
            labCarteira.Name = "labCarteira";
            labCarteira.Size = new Size(71, 15);
            labCarteira.TabIndex = 1;
            labCarteira.Text = "Carteira - F1";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(12, 66);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(154, 23);
            txtVendedor.TabIndex = 2;
            txtVendedor.KeyDown += txtVendedor_KeyDown;
            // 
            // txtCarteira
            // 
            txtCarteira.Location = new Point(172, 66);
            txtCarteira.Name = "txtCarteira";
            txtCarteira.Size = new Size(148, 23);
            txtCarteira.TabIndex = 3;
            txtCarteira.KeyDown += txtCarteira_KeyDown;
            // 
            // cmdSair
            // 
            cmdSair.AccessibleDescription = "Sair";
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(291, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 26;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.BackColor = Color.Transparent;
            chkAtivo.Location = new Point(12, 103);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 27;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = false;
            chkAtivo.CheckedChanged += chkAtivo_CheckedChanged;
            // 
            // labCadEmpresas
            // 
            labCadEmpresas.BackColor = Color.Transparent;
            labCadEmpresas.BorderStyle = BorderStyle.Fixed3D;
            labCadEmpresas.Location = new Point(12, 9);
            labCadEmpresas.Name = "labCadEmpresas";
            labCadEmpresas.Size = new Size(237, 29);
            labCadEmpresas.TabIndex = 28;
            labCadEmpresas.Text = "Cadastros de Empresas";
            labCadEmpresas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdImprimir
            // 
            cmdImprimir.BackgroundImage = (Image)resources.GetObject("cmdImprimir.BackgroundImage");
            cmdImprimir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdImprimir.Location = new Point(255, 12);
            cmdImprimir.Name = "cmdImprimir";
            cmdImprimir.Size = new Size(30, 30);
            cmdImprimir.TabIndex = 29;
            cmdImprimir.UseVisualStyleBackColor = true;
            cmdImprimir.Click += cmdImprimir_Click;
            // 
            // frmCadastroEmpresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround_600x400;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(332, 134);
            ControlBox = false;
            Controls.Add(cmdImprimir);
            Controls.Add(labCadEmpresas);
            Controls.Add(chkAtivo);
            Controls.Add(cmdSair);
            Controls.Add(txtCarteira);
            Controls.Add(txtVendedor);
            Controls.Add(labCarteira);
            Controls.Add(labVendedor);
            Name = "frmCadastroEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastros de Empresas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labVendedor;
        private Label labCarteira;
        private TextBox txtVendedor;
        private TextBox txtCarteira;
        private Button cmdSair;
        private CheckBox chkAtivo;
        private Label labCadEmpresas;
        private Button cmdImprimir;
    }
}