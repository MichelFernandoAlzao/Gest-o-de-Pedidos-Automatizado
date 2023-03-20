namespace Formularios
{
    partial class frmAgendarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendarContato));
            txtEmpresa = new TextBox();
            labEmpresa = new Label();
            labData = new Label();
            txtDataContato = new TextBox();
            labUsuario = new Label();
            txtUsuario = new TextBox();
            cmdExcluir = new Button();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            lbPedidos = new Label();
            SuspendLayout();
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(12, 62);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(430, 23);
            txtEmpresa.TabIndex = 0;
            txtEmpresa.KeyDown += txtEmpresa_KeyDown;
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(12, 44);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 1;
            labEmpresa.Text = "Empresa - F1";
            // 
            // labData
            // 
            labData.AutoSize = true;
            labData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labData.Location = new Point(463, 44);
            labData.Name = "labData";
            labData.Size = new Size(33, 15);
            labData.TabIndex = 3;
            labData.Text = "Data";
            // 
            // txtDataContato
            // 
            txtDataContato.Location = new Point(463, 62);
            txtDataContato.Name = "txtDataContato";
            txtDataContato.Size = new Size(78, 23);
            txtDataContato.TabIndex = 2;
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labUsuario.Location = new Point(558, 44);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(73, 15);
            labUsuario.TabIndex = 5;
            labUsuario.Text = "Usuario - F1";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(558, 62);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(119, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdExcluir.Location = new Point(547, 9);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(30, 30);
            cmdExcluir.TabIndex = 50;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(583, 9);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 49;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(619, 9);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 48;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(655, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 47;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // lbPedidos
            // 
            lbPedidos.BorderStyle = BorderStyle.Fixed3D;
            lbPedidos.Cursor = Cursors.IBeam;
            lbPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPedidos.ForeColor = Color.Black;
            lbPedidos.Location = new Point(12, 9);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(529, 30);
            lbPedidos.TabIndex = 46;
            lbPedidos.Text = "Agendar Contato";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAgendarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 96);
            ControlBox = false;
            Controls.Add(cmdExcluir);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(lbPedidos);
            Controls.Add(labUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(labData);
            Controls.Add(txtDataContato);
            Controls.Add(labEmpresa);
            Controls.Add(txtEmpresa);
            Name = "frmAgendarContato";
            Text = "Agendar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpresa;
        private Label labEmpresa;
        private Label labData;
        private TextBox txtDataContato;
        private Label labUsuario;
        private TextBox txtUsuario;
        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private Label lbPedidos;
    }
}