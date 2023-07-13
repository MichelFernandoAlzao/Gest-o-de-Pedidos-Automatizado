namespace Formularios
{
    partial class frmContatosEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContatosEmpresas));
            labEmpresa = new Label();
            txtEmpresa = new TextBox();
            lbCabeçallho = new Label();
            cmdExcluir = new Button();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            labDataContato = new Label();
            grdProdSugeridos = new DataGridView();
            grdIDProdSugerido = new DataGridViewTextBoxColumn();
            grdDescItem = new DataGridViewTextBoxColumn();
            grdVlrofertado = new DataGridViewTextBoxColumn();
            grdQuantidade = new DataGridViewTextBoxColumn();
            txtSugestoes = new TextBox();
            labSugestoes = new Label();
            label1 = new Label();
            txtReclamacoes = new TextBox();
            labProdSugeridos = new Label();
            txtDescProduto = new TextBox();
            label2 = new Label();
            cmdAdicionar = new Button();
            cmdRemover = new Button();
            labVlrOfertado = new Label();
            labQuantidade = new Label();
            txtQuantidade = new TextBox();
            label3 = new Label();
            txtRegistro = new TextBox();
            txtDataContato = new MaskedTextBox();
            txtValorOfertado = new TextBox();
            labCtt1 = new Label();
            TxtContato1 = new MaskedTextBox();
            TxtContato2 = new MaskedTextBox();
            labCtt2 = new Label();
            cmdContatos = new Button();
            ((System.ComponentModel.ISupportInitialize)grdProdSugeridos).BeginInit();
            SuspendLayout();
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.BackColor = Color.Transparent;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(117, 42);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 0;
            labEmpresa.Text = "Empresa - F1";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(117, 60);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(619, 23);
            txtEmpresa.TabIndex = 1;
            txtEmpresa.KeyDown += txtEmpresa_KeyDown;
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BackColor = Color.Transparent;
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 3);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(688, 30);
            lbCabeçallho.TabIndex = 3;
            lbCabeçallho.Text = "Contatos com Empresas";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdExcluir.Location = new Point(706, 3);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(30, 30);
            cmdExcluir.TabIndex = 14;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(742, 3);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 15;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(778, 3);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 16;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(814, 3);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 17;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // labDataContato
            // 
            labDataContato.AutoSize = true;
            labDataContato.BackColor = Color.Transparent;
            labDataContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDataContato.Location = new Point(742, 42);
            labDataContato.Name = "labDataContato";
            labDataContato.Size = new Size(80, 15);
            labDataContato.TabIndex = 51;
            labDataContato.Text = "Data Contato";
            // 
            // grdProdSugeridos
            // 
            grdProdSugeridos.AllowUserToAddRows = false;
            grdProdSugeridos.AllowUserToDeleteRows = false;
            grdProdSugeridos.BackgroundColor = SystemColors.GradientActiveCaption;
            grdProdSugeridos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProdSugeridos.Columns.AddRange(new DataGridViewColumn[] { grdIDProdSugerido, grdDescItem, grdVlrofertado, grdQuantidade });
            grdProdSugeridos.Location = new Point(12, 365);
            grdProdSugeridos.Name = "grdProdSugeridos";
            grdProdSugeridos.ReadOnly = true;
            grdProdSugeridos.RowTemplate.Height = 25;
            grdProdSugeridos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProdSugeridos.Size = new Size(832, 111);
            grdProdSugeridos.TabIndex = 13;
            grdProdSugeridos.SelectionChanged += grdProdSugeridos_SelectionChanged;
            // 
            // grdIDProdSugerido
            // 
            grdIDProdSugerido.HeaderText = "ID";
            grdIDProdSugerido.Name = "grdIDProdSugerido";
            grdIDProdSugerido.ReadOnly = true;
            grdIDProdSugerido.Visible = false;
            // 
            // grdDescItem
            // 
            grdDescItem.HeaderText = "Produto";
            grdDescItem.Name = "grdDescItem";
            grdDescItem.ReadOnly = true;
            grdDescItem.Width = 500;
            // 
            // grdVlrofertado
            // 
            grdVlrofertado.HeaderText = "Valor Ofertado";
            grdVlrofertado.Name = "grdVlrofertado";
            grdVlrofertado.ReadOnly = true;
            grdVlrofertado.Width = 120;
            // 
            // grdQuantidade
            // 
            grdQuantidade.HeaderText = "Quantidade";
            grdQuantidade.Name = "grdQuantidade";
            grdQuantidade.ReadOnly = true;
            // 
            // txtSugestoes
            // 
            txtSugestoes.Location = new Point(12, 146);
            txtSugestoes.Multiline = true;
            txtSugestoes.Name = "txtSugestoes";
            txtSugestoes.ScrollBars = ScrollBars.Vertical;
            txtSugestoes.Size = new Size(405, 136);
            txtSugestoes.TabIndex = 6;
            // 
            // labSugestoes
            // 
            labSugestoes.AutoSize = true;
            labSugestoes.BackColor = Color.Transparent;
            labSugestoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labSugestoes.Location = new Point(12, 128);
            labSugestoes.Name = "labSugestoes";
            labSugestoes.Size = new Size(64, 15);
            labSugestoes.TabIndex = 54;
            labSugestoes.Text = "Sugestoes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(448, 128);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 56;
            label1.Text = "Reclamações";
            // 
            // txtReclamacoes
            // 
            txtReclamacoes.Location = new Point(448, 146);
            txtReclamacoes.Multiline = true;
            txtReclamacoes.Name = "txtReclamacoes";
            txtReclamacoes.ScrollBars = ScrollBars.Vertical;
            txtReclamacoes.Size = new Size(396, 136);
            txtReclamacoes.TabIndex = 7;
            // 
            // labProdSugeridos
            // 
            labProdSugeridos.AutoSize = true;
            labProdSugeridos.BackColor = Color.Transparent;
            labProdSugeridos.Location = new Point(11, 340);
            labProdSugeridos.Name = "labProdSugeridos";
            labProdSugeridos.Size = new Size(110, 15);
            labProdSugeridos.TabIndex = 57;
            labProdSugeridos.Text = "Produtos Sugeridos";
            // 
            // txtDescProduto
            // 
            txtDescProduto.Location = new Point(11, 303);
            txtDescProduto.Name = "txtDescProduto";
            txtDescProduto.Size = new Size(442, 23);
            txtDescProduto.TabIndex = 8;
            txtDescProduto.KeyDown += txtProduto_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 285);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 59;
            label2.Text = "Produto - F1";
            // 
            // cmdAdicionar
            // 
            cmdAdicionar.BackgroundImage = Properties.Resources.adicionar;
            cmdAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdAdicionar.Location = new Point(723, 297);
            cmdAdicionar.Name = "cmdAdicionar";
            cmdAdicionar.Size = new Size(29, 29);
            cmdAdicionar.TabIndex = 11;
            cmdAdicionar.UseVisualStyleBackColor = true;
            cmdAdicionar.Click += cmdAdicionar_Click;
            // 
            // cmdRemover
            // 
            cmdRemover.BackgroundImage = (Image)resources.GetObject("cmdRemover.BackgroundImage");
            cmdRemover.BackgroundImageLayout = ImageLayout.Stretch;
            cmdRemover.Location = new Point(758, 297);
            cmdRemover.Name = "cmdRemover";
            cmdRemover.Size = new Size(29, 29);
            cmdRemover.TabIndex = 12;
            cmdRemover.UseVisualStyleBackColor = true;
            cmdRemover.Click += cmdRemover_Click;
            // 
            // labVlrOfertado
            // 
            labVlrOfertado.AutoSize = true;
            labVlrOfertado.BackColor = Color.Transparent;
            labVlrOfertado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labVlrOfertado.Location = new Point(470, 285);
            labVlrOfertado.Name = "labVlrOfertado";
            labVlrOfertado.Size = new Size(89, 15);
            labVlrOfertado.TabIndex = 63;
            labVlrOfertado.Text = "Valor Ofertado";
            // 
            // labQuantidade
            // 
            labQuantidade.AutoSize = true;
            labQuantidade.BackColor = Color.Transparent;
            labQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labQuantidade.Location = new Point(594, 285);
            labQuantidade.Name = "labQuantidade";
            labQuantidade.Size = new Size(71, 15);
            labQuantidade.TabIndex = 65;
            labQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(594, 303);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(108, 23);
            txtQuantidade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 67;
            label3.Text = "Registro - F1";
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(12, 60);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(99, 23);
            txtRegistro.TabIndex = 0;
            txtRegistro.KeyDown += txtRegistro_KeyDown;
            // 
            // txtDataContato
            // 
            txtDataContato.Location = new Point(744, 60);
            txtDataContato.Mask = "00/00/0000";
            txtDataContato.Name = "txtDataContato";
            txtDataContato.Size = new Size(100, 23);
            txtDataContato.TabIndex = 2;
            txtDataContato.ValidatingType = typeof(DateTime);
            txtDataContato.Leave += txtDataContato_Leave;
            // 
            // txtValorOfertado
            // 
            txtValorOfertado.Location = new Point(470, 303);
            txtValorOfertado.Name = "txtValorOfertado";
            txtValorOfertado.Size = new Size(100, 23);
            txtValorOfertado.TabIndex = 9;
            // 
            // labCtt1
            // 
            labCtt1.AutoSize = true;
            labCtt1.BackColor = Color.Transparent;
            labCtt1.Location = new Point(12, 86);
            labCtt1.Name = "labCtt1";
            labCtt1.Size = new Size(59, 15);
            labCtt1.TabIndex = 70;
            labCtt1.Text = "Contato 1";
            labCtt1.Visible = false;
            // 
            // TxtContato1
            // 
            TxtContato1.Location = new Point(12, 104);
            TxtContato1.Mask = "(99) 00000-0000";
            TxtContato1.Name = "TxtContato1";
            TxtContato1.Size = new Size(130, 23);
            TxtContato1.TabIndex = 3;
            TxtContato1.Visible = false;
            // 
            // TxtContato2
            // 
            TxtContato2.Location = new Point(148, 104);
            TxtContato2.Mask = "(99) 00000-0000";
            TxtContato2.Name = "TxtContato2";
            TxtContato2.Size = new Size(130, 23);
            TxtContato2.TabIndex = 4;
            TxtContato2.Visible = false;
            // 
            // labCtt2
            // 
            labCtt2.AutoSize = true;
            labCtt2.BackColor = Color.Transparent;
            labCtt2.Location = new Point(148, 86);
            labCtt2.Name = "labCtt2";
            labCtt2.Size = new Size(59, 15);
            labCtt2.TabIndex = 72;
            labCtt2.Text = "Contato 2";
            labCtt2.Visible = false;
            // 
            // cmdContatos
            // 
            cmdContatos.Location = new Point(742, 97);
            cmdContatos.Name = "cmdContatos";
            cmdContatos.Size = new Size(99, 30);
            cmdContatos.TabIndex = 5;
            cmdContatos.Text = "Contatos";
            cmdContatos.UseVisualStyleBackColor = true;
            cmdContatos.Click += cmdContatos_Click;
            // 
            // frmContatosEmpresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(856, 488);
            ControlBox = false;
            Controls.Add(cmdContatos);
            Controls.Add(TxtContato2);
            Controls.Add(labCtt2);
            Controls.Add(TxtContato1);
            Controls.Add(labCtt1);
            Controls.Add(txtValorOfertado);
            Controls.Add(txtDataContato);
            Controls.Add(label3);
            Controls.Add(txtRegistro);
            Controls.Add(labQuantidade);
            Controls.Add(txtQuantidade);
            Controls.Add(labVlrOfertado);
            Controls.Add(cmdRemover);
            Controls.Add(cmdAdicionar);
            Controls.Add(label2);
            Controls.Add(txtDescProduto);
            Controls.Add(labProdSugeridos);
            Controls.Add(label1);
            Controls.Add(txtReclamacoes);
            Controls.Add(labSugestoes);
            Controls.Add(txtSugestoes);
            Controls.Add(grdProdSugeridos);
            Controls.Add(labDataContato);
            Controls.Add(cmdExcluir);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(lbCabeçallho);
            Controls.Add(txtEmpresa);
            Controls.Add(labEmpresa);
            Name = "frmContatosEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contatos Empresas";
            Load += frmContatosEmpresas_Load;
            ((System.ComponentModel.ISupportInitialize)grdProdSugeridos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labEmpresa;
        private TextBox txtEmpresa;
        private Label lbCabeçallho;
        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private Label labDataContato;
        private DataGridView grdProdSugeridos;
        private TextBox txtSugestoes;
        private Label labSugestoes;
        private Label label1;
        private TextBox txtReclamacoes;
        private Label labProdSugeridos;
        private TextBox txtDescProduto;
        private Label label2;
        private Button cmdAdicionar;
        private Button cmdRemover;
        private DataGridViewTextBoxColumn grdIDProdSugerido;
        private DataGridViewTextBoxColumn grdDescItem;
        private DataGridViewTextBoxColumn grdVlrofertado;
        private DataGridViewTextBoxColumn grdQuantidade;
        private Label labVlrOfertado;
        private Label labQuantidade;
        private TextBox txtQuantidade;
        private Label label3;
        private TextBox txtRegistro;
        private MaskedTextBox txtDataContato;
        private TextBox txtValorOfertado;
        private Label labCtt1;
        private MaskedTextBox TxtContato1;
        private MaskedTextBox TxtContato2;
        private Label labCtt2;
        private Button cmdContatos;
    }
}