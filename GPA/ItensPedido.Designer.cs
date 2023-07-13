namespace Formularios
{
    partial class frmItensPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItensPedido));
            grdItensPedido = new DataGridView();
            grdNumero = new DataGridViewTextBoxColumn();
            grdProduto = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            grdQuantidade = new DataGridViewTextBoxColumn();
            grdCodigoItem = new DataGridViewTextBoxColumn();
            grdVlrItem = new DataGridViewTextBoxColumn();
            grdTotal = new DataGridViewTextBoxColumn();
            grdValorFornecedor = new DataGridViewTextBoxColumn();
            grdLote = new DataGridViewTextBoxColumn();
            txtDescProduto = new TextBox();
            txtQuantidade = new TextBox();
            lbProduto = new Label();
            lbQuantidade = new Label();
            txtLote = new TextBox();
            lbLote = new Label();
            btnOcorrencias = new Button();
            cmdUltimasCompras = new Button();
            lbValor = new Label();
            txtValor = new TextBox();
            lbFornecedor = new Label();
            txtFornecedor = new TextBox();
            lbTotal = new Label();
            lbTotalItem = new Label();
            grpbVlrPraticados = new GroupBox();
            LabVlrPraticado4 = new Label();
            lbVlrPraticado4 = new Label();
            lbVlrPraticado3 = new Label();
            labPraticado3 = new Label();
            lbVlrPraticado2 = new Label();
            lbPraticado2 = new Label();
            lbVlrPraticado1 = new Label();
            lbPraticado1 = new Label();
            labTotalPedido = new Label();
            label2 = new Label();
            cmdGravar = new Button();
            cmdSair = new Button();
            cmdNovo = new Button();
            labValorForencedor = new Label();
            txtValorFornecedor = new TextBox();
            cmdExcluir = new Button();
            chkFatura = new CheckBox();
            cmdCadProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)grdItensPedido).BeginInit();
            grpbVlrPraticados.SuspendLayout();
            SuspendLayout();
            // 
            // grdItensPedido
            // 
            grdItensPedido.AllowUserToAddRows = false;
            grdItensPedido.AllowUserToDeleteRows = false;
            grdItensPedido.BackgroundColor = SystemColors.GradientActiveCaption;
            grdItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdItensPedido.Columns.AddRange(new DataGridViewColumn[] { grdNumero, grdProduto, grdDescricao, grdQuantidade, grdCodigoItem, grdVlrItem, grdTotal, grdValorFornecedor, grdLote });
            grdItensPedido.Location = new Point(12, 30);
            grdItensPedido.Name = "grdItensPedido";
            grdItensPedido.ReadOnly = true;
            grdItensPedido.RowHeadersVisible = false;
            grdItensPedido.RowTemplate.Height = 25;
            grdItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdItensPedido.Size = new Size(776, 150);
            grdItensPedido.TabIndex = 0;
            grdItensPedido.SelectionChanged += grdItensPedido_SelectionChanged;
            // 
            // grdNumero
            // 
            grdNumero.HeaderText = "Numero";
            grdNumero.Name = "grdNumero";
            grdNumero.ReadOnly = true;
            grdNumero.Visible = false;
            grdNumero.Width = 60;
            // 
            // grdProduto
            // 
            grdProduto.HeaderText = "ProdutoID";
            grdProduto.Name = "grdProduto";
            grdProduto.ReadOnly = true;
            grdProduto.Visible = false;
            // 
            // grdDescricao
            // 
            grdDescricao.HeaderText = "Descrição";
            grdDescricao.Name = "grdDescricao";
            grdDescricao.ReadOnly = true;
            grdDescricao.Width = 400;
            // 
            // grdQuantidade
            // 
            grdQuantidade.HeaderText = "Quantidade";
            grdQuantidade.Name = "grdQuantidade";
            grdQuantidade.ReadOnly = true;
            // 
            // grdCodigoItem
            // 
            grdCodigoItem.HeaderText = "Codigo Item";
            grdCodigoItem.Name = "grdCodigoItem";
            grdCodigoItem.ReadOnly = true;
            // 
            // grdVlrItem
            // 
            grdVlrItem.HeaderText = "Vlr.Item";
            grdVlrItem.Name = "grdVlrItem";
            grdVlrItem.ReadOnly = true;
            grdVlrItem.Width = 60;
            // 
            // grdTotal
            // 
            grdTotal.HeaderText = "Total";
            grdTotal.Name = "grdTotal";
            grdTotal.ReadOnly = true;
            grdTotal.Width = 60;
            // 
            // grdValorFornecedor
            // 
            grdValorFornecedor.HeaderText = "ValorFornecedor";
            grdValorFornecedor.Name = "grdValorFornecedor";
            grdValorFornecedor.ReadOnly = true;
            grdValorFornecedor.Visible = false;
            // 
            // grdLote
            // 
            grdLote.HeaderText = "Lote";
            grdLote.Name = "grdLote";
            grdLote.ReadOnly = true;
            grdLote.Visible = false;
            // 
            // txtDescProduto
            // 
            txtDescProduto.Location = new Point(12, 207);
            txtDescProduto.Name = "txtDescProduto";
            txtDescProduto.Size = new Size(577, 23);
            txtDescProduto.TabIndex = 1;
            txtDescProduto.KeyDown += txtDescProduto_KeyDown;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(12, 261);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Leave += txtQuantidade_Leave;
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.BackColor = Color.Transparent;
            lbProduto.Location = new Point(12, 189);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(73, 15);
            lbProduto.TabIndex = 3;
            lbProduto.Text = "Produto - F1";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.BackColor = Color.Transparent;
            lbQuantidade.Location = new Point(12, 243);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(69, 15);
            lbQuantidade.TabIndex = 4;
            lbQuantidade.Text = "Quantidade";
            // 
            // txtLote
            // 
            txtLote.Location = new Point(131, 261);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(100, 23);
            txtLote.TabIndex = 3;
            // 
            // lbLote
            // 
            lbLote.AutoSize = true;
            lbLote.BackColor = Color.Transparent;
            lbLote.Location = new Point(131, 243);
            lbLote.Name = "lbLote";
            lbLote.Size = new Size(30, 15);
            lbLote.TabIndex = 6;
            lbLote.Text = "Lote";
            // 
            // btnOcorrencias
            // 
            btnOcorrencias.Location = new Point(653, 207);
            btnOcorrencias.Name = "btnOcorrencias";
            btnOcorrencias.Size = new Size(135, 23);
            btnOcorrencias.TabIndex = 8;
            btnOcorrencias.Text = "Ocorrencias";
            btnOcorrencias.UseVisualStyleBackColor = true;
            // 
            // cmdUltimasCompras
            // 
            cmdUltimasCompras.Location = new Point(653, 239);
            cmdUltimasCompras.Name = "cmdUltimasCompras";
            cmdUltimasCompras.Size = new Size(135, 23);
            cmdUltimasCompras.TabIndex = 9;
            cmdUltimasCompras.Text = "Ultimas Compras";
            cmdUltimasCompras.UseVisualStyleBackColor = true;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.BackColor = Color.Transparent;
            lbValor.Location = new Point(249, 243);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(58, 15);
            lbValor.TabIndex = 10;
            lbValor.Text = "Valor Unit";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(249, 261);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 4;
            txtValor.Leave += txtValor_Leave;
            // 
            // lbFornecedor
            // 
            lbFornecedor.AutoSize = true;
            lbFornecedor.BackColor = Color.Transparent;
            lbFornecedor.Location = new Point(12, 300);
            lbFornecedor.Name = "lbFornecedor";
            lbFornecedor.Size = new Size(90, 15);
            lbFornecedor.TabIndex = 12;
            lbFornecedor.Text = "Fornecedor - F1";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(12, 318);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(577, 23);
            txtFornecedor.TabIndex = 7;
            txtFornecedor.KeyDown += txtFornecedor_KeyDown;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.Transparent;
            lbTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(12, 361);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(70, 15);
            lbTotal.TabIndex = 13;
            lbTotal.Text = "Total Item: ";
            // 
            // lbTotalItem
            // 
            lbTotalItem.AutoSize = true;
            lbTotalItem.BackColor = Color.Transparent;
            lbTotalItem.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalItem.Location = new Point(88, 364);
            lbTotalItem.Name = "lbTotalItem";
            lbTotalItem.Size = new Size(50, 12);
            lbTotalItem.TabIndex = 14;
            lbTotalItem.Text = "XXXX,XX";
            // 
            // grpbVlrPraticados
            // 
            grpbVlrPraticados.BackColor = Color.Transparent;
            grpbVlrPraticados.Controls.Add(LabVlrPraticado4);
            grpbVlrPraticados.Controls.Add(lbVlrPraticado4);
            grpbVlrPraticados.Controls.Add(lbVlrPraticado3);
            grpbVlrPraticados.Controls.Add(labPraticado3);
            grpbVlrPraticados.Controls.Add(lbVlrPraticado2);
            grpbVlrPraticados.Controls.Add(lbPraticado2);
            grpbVlrPraticados.Controls.Add(lbVlrPraticado1);
            grpbVlrPraticados.Controls.Add(lbPraticado1);
            grpbVlrPraticados.Location = new Point(12, 392);
            grpbVlrPraticados.Name = "grpbVlrPraticados";
            grpbVlrPraticados.Size = new Size(577, 46);
            grpbVlrPraticados.TabIndex = 15;
            grpbVlrPraticados.TabStop = false;
            grpbVlrPraticados.Text = "Valore Praticados";
            // 
            // LabVlrPraticado4
            // 
            LabVlrPraticado4.AutoSize = true;
            LabVlrPraticado4.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            LabVlrPraticado4.Location = new Point(435, 22);
            LabVlrPraticado4.Name = "LabVlrPraticado4";
            LabVlrPraticado4.Size = new Size(50, 12);
            LabVlrPraticado4.TabIndex = 22;
            LabVlrPraticado4.Text = "XXXX,XX";
            // 
            // lbVlrPraticado4
            // 
            lbVlrPraticado4.AutoSize = true;
            lbVlrPraticado4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbVlrPraticado4.Location = new Point(378, 19);
            lbVlrPraticado4.Name = "lbVlrPraticado4";
            lbVlrPraticado4.Size = new Size(51, 15);
            lbVlrPraticado4.TabIndex = 21;
            lbVlrPraticado4.Text = "Valor 4: ";
            // 
            // lbVlrPraticado3
            // 
            lbVlrPraticado3.AutoSize = true;
            lbVlrPraticado3.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbVlrPraticado3.Location = new Point(310, 22);
            lbVlrPraticado3.Name = "lbVlrPraticado3";
            lbVlrPraticado3.Size = new Size(50, 12);
            lbVlrPraticado3.TabIndex = 20;
            lbVlrPraticado3.Text = "XXXX,XX";
            // 
            // labPraticado3
            // 
            labPraticado3.AutoSize = true;
            labPraticado3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labPraticado3.Location = new Point(253, 19);
            labPraticado3.Name = "labPraticado3";
            labPraticado3.Size = new Size(51, 15);
            labPraticado3.TabIndex = 19;
            labPraticado3.Text = "Valor 3: ";
            // 
            // lbVlrPraticado2
            // 
            lbVlrPraticado2.AutoSize = true;
            lbVlrPraticado2.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbVlrPraticado2.Location = new Point(189, 22);
            lbVlrPraticado2.Name = "lbVlrPraticado2";
            lbVlrPraticado2.Size = new Size(50, 12);
            lbVlrPraticado2.TabIndex = 18;
            lbVlrPraticado2.Text = "XXXX,XX";
            // 
            // lbPraticado2
            // 
            lbPraticado2.AutoSize = true;
            lbPraticado2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPraticado2.Location = new Point(132, 19);
            lbPraticado2.Name = "lbPraticado2";
            lbPraticado2.Size = new Size(51, 15);
            lbPraticado2.TabIndex = 17;
            lbPraticado2.Text = "Valor 2: ";
            // 
            // lbVlrPraticado1
            // 
            lbVlrPraticado1.AutoSize = true;
            lbVlrPraticado1.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lbVlrPraticado1.Location = new Point(63, 22);
            lbVlrPraticado1.Name = "lbVlrPraticado1";
            lbVlrPraticado1.Size = new Size(50, 12);
            lbVlrPraticado1.TabIndex = 16;
            lbVlrPraticado1.Text = "XXXX,XX";
            // 
            // lbPraticado1
            // 
            lbPraticado1.AutoSize = true;
            lbPraticado1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPraticado1.Location = new Point(6, 19);
            lbPraticado1.Name = "lbPraticado1";
            lbPraticado1.Size = new Size(51, 15);
            lbPraticado1.TabIndex = 15;
            lbPraticado1.Text = "Valor 1: ";
            // 
            // labTotalPedido
            // 
            labTotalPedido.AutoSize = true;
            labTotalPedido.BackColor = Color.Transparent;
            labTotalPedido.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            labTotalPedido.Location = new Point(539, 363);
            labTotalPedido.Name = "labTotalPedido";
            labTotalPedido.Size = new Size(50, 12);
            labTotalPedido.TabIndex = 17;
            labTotalPedido.Text = "XXXX,XX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(452, 361);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 16;
            label2.Text = "Total Pedido: ";
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(724, 1);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 13;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(759, 1);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 14;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdNovo.Location = new Point(689, 1);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(29, 29);
            cmdNovo.TabIndex = 12;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // labValorForencedor
            // 
            labValorForencedor.AutoSize = true;
            labValorForencedor.BackColor = Color.Transparent;
            labValorForencedor.Location = new Point(367, 243);
            labValorForencedor.Name = "labValorForencedor";
            labValorForencedor.Size = new Size(96, 15);
            labValorForencedor.TabIndex = 22;
            labValorForencedor.Text = "Valor Fornecedor";
            // 
            // txtValorFornecedor
            // 
            txtValorFornecedor.Location = new Point(367, 261);
            txtValorFornecedor.Name = "txtValorFornecedor";
            txtValorFornecedor.Size = new Size(100, 23);
            txtValorFornecedor.TabIndex = 5;
            txtValorFornecedor.Leave += txtValorFornecedor_Leave;
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            cmdExcluir.Location = new Point(653, 1);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(29, 29);
            cmdExcluir.TabIndex = 11;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // chkFatura
            // 
            chkFatura.AutoSize = true;
            chkFatura.BackColor = Color.Transparent;
            chkFatura.Location = new Point(485, 265);
            chkFatura.Name = "chkFatura";
            chkFatura.Size = new Size(59, 19);
            chkFatura.TabIndex = 6;
            chkFatura.Text = "Fatura";
            chkFatura.UseVisualStyleBackColor = false;
            // 
            // cmdCadProduto
            // 
            cmdCadProduto.Location = new Point(653, 268);
            cmdCadProduto.Name = "cmdCadProduto";
            cmdCadProduto.Size = new Size(135, 23);
            cmdCadProduto.TabIndex = 10;
            cmdCadProduto.Text = "Cad. Produtos";
            cmdCadProduto.UseVisualStyleBackColor = true;
            cmdCadProduto.Click += cmdCadProduto_Click;
            // 
            // frmItensPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(cmdCadProduto);
            Controls.Add(chkFatura);
            Controls.Add(cmdExcluir);
            Controls.Add(labValorForencedor);
            Controls.Add(txtValorFornecedor);
            Controls.Add(cmdNovo);
            Controls.Add(cmdSair);
            Controls.Add(cmdGravar);
            Controls.Add(labTotalPedido);
            Controls.Add(label2);
            Controls.Add(grpbVlrPraticados);
            Controls.Add(lbTotalItem);
            Controls.Add(lbTotal);
            Controls.Add(lbFornecedor);
            Controls.Add(txtFornecedor);
            Controls.Add(lbValor);
            Controls.Add(txtValor);
            Controls.Add(cmdUltimasCompras);
            Controls.Add(btnOcorrencias);
            Controls.Add(lbLote);
            Controls.Add(txtLote);
            Controls.Add(lbQuantidade);
            Controls.Add(lbProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtDescProduto);
            Controls.Add(grdItensPedido);
            Name = "frmItensPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Itens Pedido";
            Load += frmItensPedido_Load;
            ((System.ComponentModel.ISupportInitialize)grdItensPedido).EndInit();
            grpbVlrPraticados.ResumeLayout(false);
            grpbVlrPraticados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdItensPedido;
        private TextBox txtDescProduto;
        private TextBox txtQuantidade;
        private Label lbProduto;
        private Label lbQuantidade;
        private TextBox txtLote;
        private Label lbLote;
        private Button btnOcorrencias;
        private Button cmdUltimasCompras;
        private Label lbValor;
        private TextBox txtValor;
        private Label lbFornecedor;
        private TextBox txtFornecedor;
        private Label lbTotal;
        private Label lbTotalItem;
        private GroupBox grpbVlrPraticados;
        private Label LabVlrPraticado4;
        private Label lbVlrPraticado4;
        private Label lbVlrPraticado3;
        private Label labPraticado3;
        private Label lbVlrPraticado2;
        private Label lbPraticado2;
        private Label lbVlrPraticado1;
        private Label lbPraticado1;
        private Label labTotalPedido;
        private Label label2;
        private Button cmdGravar;
        private Button cmdSair;
        private Button cmdNovo;
        private Label labValorForencedor;
        private TextBox txtValorFornecedor;
        private DataGridViewTextBoxColumn grdNumero;
        private DataGridViewTextBoxColumn grdProduto;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdQuantidade;
        private DataGridViewTextBoxColumn grdCodigoItem;
        private DataGridViewTextBoxColumn grdVlrItem;
        private DataGridViewTextBoxColumn grdTotal;
        private DataGridViewTextBoxColumn grdLote;
        private DataGridViewTextBoxColumn grdValorFornecedor;
        private Button cmdExcluir;
        private CheckBox chkFatura;
        private Button cmdCadProduto;
    }
}