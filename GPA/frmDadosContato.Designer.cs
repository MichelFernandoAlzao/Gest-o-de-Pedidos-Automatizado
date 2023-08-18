namespace Formularios
{
    partial class frmDadosContato
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
            cmdGravar = new Button();
            cmdSair = new Button();
            labFone = new Label();
            labCadCarteira = new Label();
            txtContato = new MaskedTextBox();
            labEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(424, 9);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 14;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(459, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 15;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // labFone
            // 
            labFone.AutoSize = true;
            labFone.BackColor = Color.Transparent;
            labFone.Location = new Point(12, 47);
            labFone.Name = "labFone";
            labFone.Size = new Size(51, 15);
            labFone.TabIndex = 16;
            labFone.Text = "Telefone";
            // 
            // labCadCarteira
            // 
            labCadCarteira.BackColor = Color.Transparent;
            labCadCarteira.BorderStyle = BorderStyle.Fixed3D;
            labCadCarteira.Location = new Point(12, 9);
            labCadCarteira.Name = "labCadCarteira";
            labCadCarteira.Size = new Size(406, 29);
            labCadCarteira.TabIndex = 17;
            labCadCarteira.Text = "Dados Contato";
            labCadCarteira.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(12, 65);
            txtContato.Mask = "(99) 00000-0000";
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(126, 23);
            txtContato.TabIndex = 18;
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.BackColor = Color.Transparent;
            labEmail.Location = new Point(167, 47);
            labEmail.Name = "labEmail";
            labEmail.Size = new Size(41, 15);
            labEmail.TabIndex = 19;
            labEmail.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 23);
            txtEmail.TabIndex = 20;
            // 
            // frmDadosContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.vecteezy_pattern_with_geometric_elements_light_blue_to_dark_blue_17216459;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 102);
            ControlBox = false;
            Controls.Add(txtEmail);
            Controls.Add(labEmail);
            Controls.Add(txtContato);
            Controls.Add(labCadCarteira);
            Controls.Add(labFone);
            Controls.Add(cmdSair);
            Controls.Add(cmdGravar);
            Name = "frmDadosContato";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dados Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdGravar;
        private Button cmdSair;
        private Label labFone;
        private Label labCadCarteira;
        private MaskedTextBox txtContato;
        private Label labEmail;
        private TextBox txtEmail;
    }
}