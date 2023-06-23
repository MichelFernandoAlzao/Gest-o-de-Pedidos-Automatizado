namespace Formularios
{
    partial class frmSelecionaRelatorio
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
            cmdSair = new Button();
            lbPedidos = new Label();
            cdmAcompDeVendas = new Button();
            SuspendLayout();
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(329, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 43;
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
            lbPedidos.Size = new Size(311, 30);
            lbPedidos.TabIndex = 44;
            lbPedidos.Text = "Relatórios";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cdmAcompDeVendas
            // 
            cdmAcompDeVendas.Location = new Point(12, 42);
            cdmAcompDeVendas.Name = "cdmAcompDeVendas";
            cdmAcompDeVendas.Size = new Size(347, 23);
            cdmAcompDeVendas.TabIndex = 45;
            cdmAcompDeVendas.Text = "Acompanhamento de Vendas";
            cdmAcompDeVendas.UseVisualStyleBackColor = true;
            // 
            // frmSelecionaRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 450);
            ControlBox = false;
            Controls.Add(cdmAcompDeVendas);
            Controls.Add(lbPedidos);
            Controls.Add(cmdSair);
            Name = "frmSelecionaRelatorio";
            Text = "Relatórios";
            ResumeLayout(false);
        }

        #endregion
        private Button cmdSair;
        private Label lbPedidos;
        private Button cdmAcompDeVendas;
    }
}