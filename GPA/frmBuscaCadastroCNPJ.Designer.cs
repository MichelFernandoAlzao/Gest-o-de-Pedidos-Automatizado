namespace Formularios
{
    partial class frmBuscaCadastroCNPJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaCadastroCNPJ));
            txtCNPJ = new MaskedTextBox();
            cmdSair = new Button();
            cmdBuscar = new Button();
            lbCabeçallho = new Label();
            SuspendLayout();
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(22, 61);
            txtCNPJ.Mask = "00,000,000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(276, 23);
            txtCNPJ.TabIndex = 0;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(306, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 14;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdBuscar
            // 
            cmdBuscar.BackgroundImage = (Image)resources.GetObject("cmdBuscar.BackgroundImage");
            cmdBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdBuscar.Location = new Point(304, 54);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(30, 30);
            cmdBuscar.TabIndex = 13;
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
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
            lbCabeçallho.Size = new Size(288, 30);
            lbCabeçallho.TabIndex = 12;
            lbCabeçallho.Text = "Cadastros por CNPJ";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmBuscaCadastroCNPJ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(346, 115);
            ControlBox = false;
            Controls.Add(cmdSair);
            Controls.Add(cmdBuscar);
            Controls.Add(lbCabeçallho);
            Controls.Add(txtCNPJ);
            Name = "frmBuscaCadastroCNPJ";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Cadastro por CNPJ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCNPJ;
        private Button cmdSair;
        private Button cmdBuscar;
        private Label lbCabeçallho;
    }
}