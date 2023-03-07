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
            this.grdNatOperacao = new System.Windows.Forms.DataGridView();
            this.grdNatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNatDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdBonificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdBrinde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdRestrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPedidos = new System.Windows.Forms.Label();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.chkBonificacao = new System.Windows.Forms.CheckBox();
            this.chkBrinde = new System.Windows.Forms.CheckBox();
            this.chkInterno = new System.Windows.Forms.CheckBox();
            this.chkRestrito = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labDescricao = new System.Windows.Forms.Label();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdNatOperacao)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNatOperacao
            // 
            this.grdNatOperacao.AllowUserToAddRows = false;
            this.grdNatOperacao.AllowUserToDeleteRows = false;
            this.grdNatOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNatOperacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNatID,
            this.grdNatDescricao,
            this.grdvenda,
            this.grdBonificacao,
            this.grdBrinde,
            this.grdInterno,
            this.grdRestrito});
            this.grdNatOperacao.Location = new System.Drawing.Point(12, 64);
            this.grdNatOperacao.Name = "grdNatOperacao";
            this.grdNatOperacao.ReadOnly = true;
            this.grdNatOperacao.RowTemplate.Height = 25;
            this.grdNatOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNatOperacao.Size = new System.Drawing.Size(335, 374);
            this.grdNatOperacao.TabIndex = 0;
            this.grdNatOperacao.SelectionChanged += new System.EventHandler(this.grdNatOperacao_SelectionChanged);
            // 
            // grdNatID
            // 
            this.grdNatID.HeaderText = "ID";
            this.grdNatID.Name = "grdNatID";
            this.grdNatID.ReadOnly = true;
            this.grdNatID.Width = 50;
            // 
            // grdNatDescricao
            // 
            this.grdNatDescricao.HeaderText = "Descrição";
            this.grdNatDescricao.Name = "grdNatDescricao";
            this.grdNatDescricao.ReadOnly = true;
            this.grdNatDescricao.Width = 250;
            // 
            // grdvenda
            // 
            this.grdvenda.HeaderText = "Venda";
            this.grdvenda.Name = "grdvenda";
            this.grdvenda.ReadOnly = true;
            this.grdvenda.Visible = false;
            // 
            // grdBonificacao
            // 
            this.grdBonificacao.HeaderText = "Bonificacao";
            this.grdBonificacao.Name = "grdBonificacao";
            this.grdBonificacao.ReadOnly = true;
            this.grdBonificacao.Visible = false;
            // 
            // grdBrinde
            // 
            this.grdBrinde.HeaderText = "Brinde";
            this.grdBrinde.Name = "grdBrinde";
            this.grdBrinde.ReadOnly = true;
            this.grdBrinde.Visible = false;
            // 
            // grdInterno
            // 
            this.grdInterno.HeaderText = "Interno";
            this.grdInterno.Name = "grdInterno";
            this.grdInterno.ReadOnly = true;
            this.grdInterno.Visible = false;
            // 
            // grdRestrito
            // 
            this.grdRestrito.HeaderText = "Restrito";
            this.grdRestrito.Name = "grdRestrito";
            this.grdRestrito.ReadOnly = true;
            this.grdRestrito.Visible = false;
            // 
            // lbPedidos
            // 
            this.lbPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPedidos.ForeColor = System.Drawing.Color.Black;
            this.lbPedidos.Location = new System.Drawing.Point(12, 16);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(632, 30);
            this.lbPedidos.TabIndex = 3;
            this.lbPedidos.Text = "Natureza da Operação";
            this.lbPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(353, 124);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(58, 19);
            this.chkVenda.TabIndex = 4;
            this.chkVenda.Text = "Venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // chkBonificacao
            // 
            this.chkBonificacao.AutoSize = true;
            this.chkBonificacao.Location = new System.Drawing.Point(353, 149);
            this.chkBonificacao.Name = "chkBonificacao";
            this.chkBonificacao.Size = new System.Drawing.Size(88, 19);
            this.chkBonificacao.TabIndex = 5;
            this.chkBonificacao.Text = "Bonificação";
            this.chkBonificacao.UseVisualStyleBackColor = true;
            // 
            // chkBrinde
            // 
            this.chkBrinde.AutoSize = true;
            this.chkBrinde.Location = new System.Drawing.Point(353, 174);
            this.chkBrinde.Name = "chkBrinde";
            this.chkBrinde.Size = new System.Drawing.Size(60, 19);
            this.chkBrinde.TabIndex = 6;
            this.chkBrinde.Text = "Brinde";
            this.chkBrinde.UseVisualStyleBackColor = true;
            // 
            // chkInterno
            // 
            this.chkInterno.AutoSize = true;
            this.chkInterno.Location = new System.Drawing.Point(353, 199);
            this.chkInterno.Name = "chkInterno";
            this.chkInterno.Size = new System.Drawing.Size(64, 19);
            this.chkInterno.TabIndex = 7;
            this.chkInterno.Text = "Interno";
            this.chkInterno.UseVisualStyleBackColor = true;
            // 
            // chkRestrito
            // 
            this.chkRestrito.AutoSize = true;
            this.chkRestrito.Location = new System.Drawing.Point(353, 224);
            this.chkRestrito.Name = "chkRestrito";
            this.chkRestrito.Size = new System.Drawing.Size(66, 19);
            this.chkRestrito.TabIndex = 8;
            this.chkRestrito.Text = "Restrito";
            this.chkRestrito.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(353, 82);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(435, 23);
            this.txtDescricao.TabIndex = 9;
            // 
            // labDescricao
            // 
            this.labDescricao.AutoSize = true;
            this.labDescricao.Location = new System.Drawing.Point(353, 64);
            this.labDescricao.Name = "labDescricao";
            this.labDescricao.Size = new System.Drawing.Size(58, 15);
            this.labDescricao.TabIndex = 10;
            this.labDescricao.Text = "Descrição";
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.Location = new System.Drawing.Point(650, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(30, 30);
            this.cmdExcluir.TabIndex = 49;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.Location = new System.Drawing.Point(686, 12);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(30, 30);
            this.cmdNovo.TabIndex = 48;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.Location = new System.Drawing.Point(722, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 47;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.Location = new System.Drawing.Point(758, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 46;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // frmNaturezaDaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.labDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.chkRestrito);
            this.Controls.Add(this.chkInterno);
            this.Controls.Add(this.chkBrinde);
            this.Controls.Add(this.chkBonificacao);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.grdNatOperacao);
            this.Name = "frmNaturezaDaOperacao";
            this.Text = "Natureza da Operação";
            ((System.ComponentModel.ISupportInitialize)(this.grdNatOperacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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