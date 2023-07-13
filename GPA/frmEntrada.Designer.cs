namespace Formularios
{
    partial class frmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            chkOperacional = new CheckBox();
            chkSeguranca = new CheckBox();
            chkFinanceiro = new CheckBox();
            cboServidor = new ComboBox();
            cboNomeServer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Location = new Point(40, 203);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(40, 250);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(300, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyDown += txtUsuario_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 185);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 232);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(91, 355);
            button1.Name = "button1";
            button1.Size = new Size(209, 38);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Entrar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(92, 400);
            button2.Name = "button2";
            button2.Size = new Size(209, 38);
            button2.TabIndex = 4;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // chkOperacional
            // 
            chkOperacional.AutoSize = true;
            chkOperacional.Location = new Point(40, 281);
            chkOperacional.Name = "chkOperacional";
            chkOperacional.Size = new Size(90, 19);
            chkOperacional.TabIndex = 5;
            chkOperacional.Text = "Operacional";
            chkOperacional.UseVisualStyleBackColor = true;
            chkOperacional.MouseClick += chkOperacional_MouseClick;
            // 
            // chkSeguranca
            // 
            chkSeguranca.AutoSize = true;
            chkSeguranca.Location = new Point(259, 281);
            chkSeguranca.Name = "chkSeguranca";
            chkSeguranca.Size = new Size(81, 19);
            chkSeguranca.TabIndex = 7;
            chkSeguranca.Text = "Segurança";
            chkSeguranca.UseVisualStyleBackColor = true;
            chkSeguranca.MouseClick += chkSeguranca_MouseClick;
            // 
            // chkFinanceiro
            // 
            chkFinanceiro.AutoSize = true;
            chkFinanceiro.Location = new Point(154, 281);
            chkFinanceiro.Name = "chkFinanceiro";
            chkFinanceiro.Size = new Size(81, 19);
            chkFinanceiro.TabIndex = 6;
            chkFinanceiro.Text = "Financeiro";
            chkFinanceiro.UseVisualStyleBackColor = true;
            chkFinanceiro.MouseClick += chkFinanceiro_MouseClick;
            // 
            // cboServidor
            // 
            cboServidor.FormattingEnabled = true;
            cboServidor.Location = new Point(130, 326);
            cboServidor.Name = "cboServidor";
            cboServidor.Size = new Size(144, 23);
            cboServidor.TabIndex = 2;
            // 
            // cboNomeServer
            // 
            cboNomeServer.FormattingEnabled = true;
            cboNomeServer.Location = new Point(130, 326);
            cboNomeServer.Name = "cboNomeServer";
            cboNomeServer.Size = new Size(144, 23);
            cboNomeServer.TabIndex = 8;
            // 
            // frmEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 450);
            ControlBox = false;
            Controls.Add(cboNomeServer);
            Controls.Add(cboServidor);
            Controls.Add(chkFinanceiro);
            Controls.Add(chkSeguranca);
            Controls.Add(chkOperacional);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "frmEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GPA -Entrada";
            Load += frmEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private CheckBox chkOperacional;
        private CheckBox chkSeguranca;
        private CheckBox chkFinanceiro;
        private ComboBox cboServidor;
        private ComboBox cboNomeServer;
    }
}