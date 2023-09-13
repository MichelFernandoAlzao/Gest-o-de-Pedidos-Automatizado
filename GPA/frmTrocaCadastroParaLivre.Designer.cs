namespace Formularios
{
    partial class frmTrocaCadastroParaLivre
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
            txtVendedor = new TextBox();
            cmdGravar = new Button();
            cmdSair = new Button();
            lbCabeçallho = new Label();
            labVend = new Label();
            grdEmpresasafetadas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Razao = new DataGridViewTextBoxColumn();
            txtCarteira = new TextBox();
            labCarteira = new Label();
            rchkVendedor = new RadioButton();
            rchkCarteira = new RadioButton();
            grpVendCart = new GroupBox();
            groupBox1 = new GroupBox();
            rchkIndividual = new RadioButton();
            rchkLivre = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)grdEmpresasafetadas).BeginInit();
            grpVendCart.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(12, 57);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(300, 23);
            txtVendedor.TabIndex = 0;
            txtVendedor.KeyDown += txtVendedor_KeyDown;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(248, 10);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 6;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(283, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 7;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
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
            lbCabeçallho.Size = new Size(230, 30);
            lbCabeçallho.TabIndex = 19;
            lbCabeçallho.Text = "Passa para Livre";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labVend
            // 
            labVend.AutoSize = true;
            labVend.BackColor = Color.Transparent;
            labVend.Location = new Point(12, 39);
            labVend.Name = "labVend";
            labVend.Size = new Size(80, 15);
            labVend.TabIndex = 18;
            labVend.Text = "Vendedor - F1";
            // 
            // grdEmpresasafetadas
            // 
            grdEmpresasafetadas.AllowUserToAddRows = false;
            grdEmpresasafetadas.AllowUserToDeleteRows = false;
            grdEmpresasafetadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEmpresasafetadas.Columns.AddRange(new DataGridViewColumn[] { ID, Razao });
            grdEmpresasafetadas.Location = new Point(12, 188);
            grdEmpresasafetadas.Name = "grdEmpresasafetadas";
            grdEmpresasafetadas.ReadOnly = true;
            grdEmpresasafetadas.RowHeadersVisible = false;
            grdEmpresasafetadas.RowTemplate.Height = 25;
            grdEmpresasafetadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEmpresasafetadas.Size = new Size(300, 305);
            grdEmpresasafetadas.TabIndex = 23;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Razao
            // 
            Razao.HeaderText = "Razao Social";
            Razao.Name = "Razao";
            Razao.ReadOnly = true;
            Razao.Width = 270;
            // 
            // txtCarteira
            // 
            txtCarteira.Location = new Point(12, 118);
            txtCarteira.Name = "txtCarteira";
            txtCarteira.Size = new Size(300, 23);
            txtCarteira.TabIndex = 1;
            txtCarteira.KeyDown += txtCarteira_KeyDown;
            // 
            // labCarteira
            // 
            labCarteira.AutoSize = true;
            labCarteira.BackColor = Color.Transparent;
            labCarteira.Location = new Point(12, 100);
            labCarteira.Name = "labCarteira";
            labCarteira.Size = new Size(71, 15);
            labCarteira.TabIndex = 24;
            labCarteira.Text = "Carteira - F1";
            // 
            // rchkVendedor
            // 
            rchkVendedor.AutoSize = true;
            rchkVendedor.BackColor = Color.Transparent;
            rchkVendedor.Location = new Point(5, 10);
            rchkVendedor.Name = "rchkVendedor";
            rchkVendedor.Size = new Size(75, 19);
            rchkVendedor.TabIndex = 2;
            rchkVendedor.TabStop = true;
            rchkVendedor.Text = "Vendedor";
            rchkVendedor.UseVisualStyleBackColor = false;
            rchkVendedor.CheckedChanged += rchkVendedor_CheckedChanged;
            // 
            // rchkCarteira
            // 
            rchkCarteira.AutoSize = true;
            rchkCarteira.BackColor = Color.Transparent;
            rchkCarteira.Location = new Point(86, 12);
            rchkCarteira.Name = "rchkCarteira";
            rchkCarteira.Size = new Size(66, 19);
            rchkCarteira.TabIndex = 3;
            rchkCarteira.TabStop = true;
            rchkCarteira.Text = "Carteira";
            rchkCarteira.UseVisualStyleBackColor = false;
            // 
            // grpVendCart
            // 
            grpVendCart.BackColor = Color.Transparent;
            grpVendCart.Controls.Add(rchkCarteira);
            grpVendCart.Controls.Add(rchkVendedor);
            grpVendCart.Location = new Point(12, 147);
            grpVendCart.Name = "grpVendCart";
            grpVendCart.Size = new Size(154, 35);
            grpVendCart.TabIndex = 28;
            grpVendCart.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rchkIndividual);
            groupBox1.Controls.Add(rchkLivre);
            groupBox1.Location = new Point(170, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 35);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // rchkIndividual
            // 
            rchkIndividual.AutoSize = true;
            rchkIndividual.BackColor = Color.Transparent;
            rchkIndividual.Location = new Point(61, 12);
            rchkIndividual.Name = "rchkIndividual";
            rchkIndividual.Size = new Size(77, 19);
            rchkIndividual.TabIndex = 5;
            rchkIndividual.TabStop = true;
            rchkIndividual.Text = "Individual";
            rchkIndividual.UseVisualStyleBackColor = false;
            // 
            // rchkLivre
            // 
            rchkLivre.AutoSize = true;
            rchkLivre.BackColor = Color.Transparent;
            rchkLivre.Location = new Point(5, 10);
            rchkLivre.Name = "rchkLivre";
            rchkLivre.Size = new Size(50, 19);
            rchkLivre.TabIndex = 4;
            rchkLivre.TabStop = true;
            rchkLivre.Text = "Livre";
            rchkLivre.UseVisualStyleBackColor = false;
            rchkLivre.CheckedChanged += rchkLivre_CheckedChanged;
            // 
            // frmTrocaCadastroParaLivre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround_600x400;
            ClientSize = new Size(325, 505);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(grpVendCart);
            Controls.Add(txtCarteira);
            Controls.Add(labCarteira);
            Controls.Add(grdEmpresasafetadas);
            Controls.Add(txtVendedor);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(lbCabeçallho);
            Controls.Add(labVend);
            Name = "frmTrocaCadastroParaLivre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Altera Cadastro para Livre";
            ((System.ComponentModel.ISupportInitialize)grdEmpresasafetadas).EndInit();
            grpVendCart.ResumeLayout(false);
            grpVendCart.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVendedor;
        private Button cmdGravar;
        private Button cmdSair;
        private Label lbCabeçallho;
        private Label labVend;
        private DataGridView grdEmpresasafetadas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Razao;
        private TextBox txtCarteira;
        private Label labCarteira;
        private RadioButton rchkVendedor;
        private RadioButton rchkCarteira;
        private GroupBox grpVendCart;
        private GroupBox groupBox1;
        private RadioButton rchkIndividual;
        private RadioButton rchkLivre;
    }
}