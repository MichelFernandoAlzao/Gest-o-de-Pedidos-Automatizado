namespace Formularios
{
    partial class frmCadCarteira
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
            grdCarteira = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdSigla = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            grdPotencial = new DataGridViewTextBoxColumn();
            labCadCarteira = new Label();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            txtSigla = new TextBox();
            txtDescricao = new TextBox();
            labSigla = new Label();
            labDescricao = new Label();
            txtPotencial = new TextBox();
            labPotencial = new Label();
            ((System.ComponentModel.ISupportInitialize)grdCarteira).BeginInit();
            SuspendLayout();
            // 
            // grdCarteira
            // 
            grdCarteira.AllowUserToAddRows = false;
            grdCarteira.AllowUserToDeleteRows = false;
            grdCarteira.BackgroundColor = SystemColors.GradientActiveCaption;
            grdCarteira.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCarteira.Columns.AddRange(new DataGridViewColumn[] { grdID, grdSigla, grdDescricao, grdPotencial });
            grdCarteira.Location = new Point(12, 55);
            grdCarteira.MultiSelect = false;
            grdCarteira.Name = "grdCarteira";
            grdCarteira.ReadOnly = true;
            grdCarteira.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdCarteira.RowHeadersVisible = false;
            grdCarteira.RowTemplate.Height = 25;
            grdCarteira.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCarteira.Size = new Size(302, 285);
            grdCarteira.TabIndex = 0;
            grdCarteira.SelectionChanged += grdCarteira_SelectionChanged;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Visible = false;
            // 
            // grdSigla
            // 
            grdSigla.HeaderText = "Sigla";
            grdSigla.Name = "grdSigla";
            grdSigla.ReadOnly = true;
            grdSigla.Width = 50;
            // 
            // grdDescricao
            // 
            grdDescricao.HeaderText = "Descrição";
            grdDescricao.Name = "grdDescricao";
            grdDescricao.ReadOnly = true;
            grdDescricao.Width = 150;
            // 
            // grdPotencial
            // 
            grdPotencial.HeaderText = "Potencial";
            grdPotencial.Name = "grdPotencial";
            grdPotencial.ReadOnly = true;
            // 
            // labCadCarteira
            // 
            labCadCarteira.BackColor = Color.Transparent;
            labCadCarteira.BorderStyle = BorderStyle.Fixed3D;
            labCadCarteira.Location = new Point(12, 12);
            labCadCarteira.Name = "labCadCarteira";
            labCadCarteira.Size = new Size(197, 29);
            labCadCarteira.TabIndex = 1;
            labCadCarteira.Text = "Cadastro Carteira";
            labCadCarteira.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdNovo
            // 
            cmdNovo.AccessibleDescription = "Novo";
            cmdNovo.AccessibleName = "Novo";
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdNovo.Location = new Point(215, 12);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(29, 29);
            cmdNovo.TabIndex = 23;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.AccessibleDescription = "Gravar";
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(250, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 24;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.AccessibleDescription = "Sair";
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(285, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 25;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(12, 361);
            txtSigla.MaxLength = 5;
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(53, 23);
            txtSigla.TabIndex = 26;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(71, 361);
            txtDescricao.MaxLength = 20;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(243, 23);
            txtDescricao.TabIndex = 27;
            // 
            // labSigla
            // 
            labSigla.AutoSize = true;
            labSigla.BackColor = Color.Transparent;
            labSigla.Location = new Point(12, 343);
            labSigla.Name = "labSigla";
            labSigla.Size = new Size(32, 15);
            labSigla.TabIndex = 28;
            labSigla.Text = "Sigla";
            // 
            // labDescricao
            // 
            labDescricao.AutoSize = true;
            labDescricao.BackColor = Color.Transparent;
            labDescricao.Location = new Point(71, 343);
            labDescricao.Name = "labDescricao";
            labDescricao.Size = new Size(58, 15);
            labDescricao.TabIndex = 29;
            labDescricao.Text = "Descrição";
            // 
            // txtPotencial
            // 
            txtPotencial.Location = new Point(12, 405);
            txtPotencial.MaxLength = 18;
            txtPotencial.Name = "txtPotencial";
            txtPotencial.Size = new Size(100, 23);
            txtPotencial.TabIndex = 30;
            txtPotencial.Leave += txtPotencial_Leave;
            // 
            // labPotencial
            // 
            labPotencial.AutoSize = true;
            labPotencial.BackColor = Color.Transparent;
            labPotencial.Location = new Point(12, 387);
            labPotencial.Name = "labPotencial";
            labPotencial.Size = new Size(56, 15);
            labPotencial.TabIndex = 31;
            labPotencial.Text = "Potencial";
            // 
            // frmCadCarteira
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vecteezy_pattern_with_geometric_elements_light_blue_to_dark_blue_17216459;
            ClientSize = new Size(326, 450);
            ControlBox = false;
            Controls.Add(labPotencial);
            Controls.Add(txtPotencial);
            Controls.Add(labDescricao);
            Controls.Add(labSigla);
            Controls.Add(txtDescricao);
            Controls.Add(txtSigla);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(labCadCarteira);
            Controls.Add(grdCarteira);
            Name = "frmCadCarteira";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cad. Carteira";
            ((System.ComponentModel.ISupportInitialize)grdCarteira).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdCarteira;
        private Label labCadCarteira;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private TextBox txtSigla;
        private TextBox txtDescricao;
        private Label labSigla;
        private Label labDescricao;
        private TextBox txtPotencial;
        private Label labPotencial;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdSigla;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdPotencial;
    }
}