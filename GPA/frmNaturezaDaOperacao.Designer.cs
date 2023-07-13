namespace Formularios
{
    partial class frmNaturezaDaOperacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNaturezaDaOperacao));
            grdNatOperacao = new DataGridView();
            grdNatID = new DataGridViewTextBoxColumn();
            grdNatDescricao = new DataGridViewTextBoxColumn();
            grdvenda = new DataGridViewTextBoxColumn();
            grdBonificacao = new DataGridViewTextBoxColumn();
            grdBrinde = new DataGridViewTextBoxColumn();
            grdInterno = new DataGridViewTextBoxColumn();
            grdRestrito = new DataGridViewTextBoxColumn();
            lbPedidos = new Label();
            chkVenda = new CheckBox();
            chkBonificacao = new CheckBox();
            chkBrinde = new CheckBox();
            chkInterno = new CheckBox();
            chkRestrito = new CheckBox();
            txtDescricao = new TextBox();
            labDescricao = new Label();
            cmdExcluir = new Button();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            ((System.ComponentModel.ISupportInitialize)grdNatOperacao).BeginInit();
            SuspendLayout();
            // 
            // grdNatOperacao
            // 
            grdNatOperacao.AllowUserToAddRows = false;
            grdNatOperacao.AllowUserToDeleteRows = false;
            grdNatOperacao.BackgroundColor = SystemColors.GradientActiveCaption;
            grdNatOperacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdNatOperacao.Columns.AddRange(new DataGridViewColumn[] { grdNatID, grdNatDescricao, grdvenda, grdBonificacao, grdBrinde, grdInterno, grdRestrito });
            grdNatOperacao.Location = new Point(12, 64);
            grdNatOperacao.Name = "grdNatOperacao";
            grdNatOperacao.ReadOnly = true;
            grdNatOperacao.RowTemplate.Height = 25;
            grdNatOperacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdNatOperacao.Size = new Size(335, 374);
            grdNatOperacao.TabIndex = 10;
            grdNatOperacao.SelectionChanged += grdNatOperacao_SelectionChanged;
            // 
            // grdNatID
            // 
            grdNatID.HeaderText = "ID";
            grdNatID.Name = "grdNatID";
            grdNatID.ReadOnly = true;
            grdNatID.Width = 50;
            // 
            // grdNatDescricao
            // 
            grdNatDescricao.HeaderText = "Descrição";
            grdNatDescricao.Name = "grdNatDescricao";
            grdNatDescricao.ReadOnly = true;
            grdNatDescricao.Width = 250;
            // 
            // grdvenda
            // 
            grdvenda.HeaderText = "Venda";
            grdvenda.Name = "grdvenda";
            grdvenda.ReadOnly = true;
            grdvenda.Visible = false;
            // 
            // grdBonificacao
            // 
            grdBonificacao.HeaderText = "Bonificacao";
            grdBonificacao.Name = "grdBonificacao";
            grdBonificacao.ReadOnly = true;
            grdBonificacao.Visible = false;
            // 
            // grdBrinde
            // 
            grdBrinde.HeaderText = "Brinde";
            grdBrinde.Name = "grdBrinde";
            grdBrinde.ReadOnly = true;
            grdBrinde.Visible = false;
            // 
            // grdInterno
            // 
            grdInterno.HeaderText = "Interno";
            grdInterno.Name = "grdInterno";
            grdInterno.ReadOnly = true;
            grdInterno.Visible = false;
            // 
            // grdRestrito
            // 
            grdRestrito.HeaderText = "Restrito";
            grdRestrito.Name = "grdRestrito";
            grdRestrito.ReadOnly = true;
            grdRestrito.Visible = false;
            // 
            // lbPedidos
            // 
            lbPedidos.BackColor = Color.Transparent;
            lbPedidos.BorderStyle = BorderStyle.Fixed3D;
            lbPedidos.Cursor = Cursors.IBeam;
            lbPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPedidos.ForeColor = Color.Black;
            lbPedidos.Location = new Point(12, 16);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(632, 30);
            lbPedidos.TabIndex = 3;
            lbPedidos.Text = "Natureza da Operação";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkVenda
            // 
            chkVenda.AutoSize = true;
            chkVenda.BackColor = Color.Transparent;
            chkVenda.Location = new Point(353, 124);
            chkVenda.Name = "chkVenda";
            chkVenda.Size = new Size(58, 19);
            chkVenda.TabIndex = 1;
            chkVenda.Text = "Venda";
            chkVenda.UseVisualStyleBackColor = false;
            // 
            // chkBonificacao
            // 
            chkBonificacao.AutoSize = true;
            chkBonificacao.BackColor = Color.Transparent;
            chkBonificacao.Location = new Point(353, 149);
            chkBonificacao.Name = "chkBonificacao";
            chkBonificacao.Size = new Size(88, 19);
            chkBonificacao.TabIndex = 2;
            chkBonificacao.Text = "Bonificação";
            chkBonificacao.UseVisualStyleBackColor = false;
            // 
            // chkBrinde
            // 
            chkBrinde.AutoSize = true;
            chkBrinde.BackColor = Color.Transparent;
            chkBrinde.Location = new Point(353, 174);
            chkBrinde.Name = "chkBrinde";
            chkBrinde.Size = new Size(60, 19);
            chkBrinde.TabIndex = 3;
            chkBrinde.Text = "Brinde";
            chkBrinde.UseVisualStyleBackColor = false;
            // 
            // chkInterno
            // 
            chkInterno.AutoSize = true;
            chkInterno.BackColor = Color.Transparent;
            chkInterno.Location = new Point(353, 199);
            chkInterno.Name = "chkInterno";
            chkInterno.Size = new Size(64, 19);
            chkInterno.TabIndex = 4;
            chkInterno.Text = "Interno";
            chkInterno.UseVisualStyleBackColor = false;
            // 
            // chkRestrito
            // 
            chkRestrito.AutoSize = true;
            chkRestrito.BackColor = Color.Transparent;
            chkRestrito.Location = new Point(353, 224);
            chkRestrito.Name = "chkRestrito";
            chkRestrito.Size = new Size(66, 19);
            chkRestrito.TabIndex = 5;
            chkRestrito.Text = "Restrito";
            chkRestrito.UseVisualStyleBackColor = false;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(353, 82);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(435, 23);
            txtDescricao.TabIndex = 0;
            // 
            // labDescricao
            // 
            labDescricao.AutoSize = true;
            labDescricao.BackColor = Color.Transparent;
            labDescricao.Location = new Point(353, 64);
            labDescricao.Name = "labDescricao";
            labDescricao.Size = new Size(58, 15);
            labDescricao.TabIndex = 10;
            labDescricao.Text = "Descrição";
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdExcluir.Location = new Point(650, 12);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(30, 30);
            cmdExcluir.TabIndex = 6;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(686, 12);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 7;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(722, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 8;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(758, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 9;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // frmNaturezaDaOperacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(cmdExcluir);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(labDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(chkRestrito);
            Controls.Add(chkInterno);
            Controls.Add(chkBrinde);
            Controls.Add(chkBonificacao);
            Controls.Add(chkVenda);
            Controls.Add(lbPedidos);
            Controls.Add(grdNatOperacao);
            Name = "frmNaturezaDaOperacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Natureza da Operação";
            ((System.ComponentModel.ISupportInitialize)grdNatOperacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdNatOperacao;
        private Label lbPedidos;
        private CheckBox chkVenda;
        private CheckBox chkBonificacao;
        private CheckBox chkBrinde;
        private CheckBox chkInterno;
        private CheckBox chkRestrito;
        private TextBox txtDescricao;
        private Label labDescricao;
        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private DataGridViewTextBoxColumn grdNatID;
        private DataGridViewTextBoxColumn grdNatDescricao;
        private DataGridViewTextBoxColumn grdvenda;
        private DataGridViewTextBoxColumn grdBonificacao;
        private DataGridViewTextBoxColumn grdBrinde;
        private DataGridViewTextBoxColumn grdInterno;
        private DataGridViewTextBoxColumn grdRestrito;
    }
}