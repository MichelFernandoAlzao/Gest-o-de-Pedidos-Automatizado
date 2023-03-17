﻿namespace Formularios
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
            this.grdItensPedido = new System.Windows.Forms.DataGridView();
            this.grdNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdVlrItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValorFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbProduto = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lbLote = new System.Windows.Forms.Label();
            this.btnOcorrencias = new System.Windows.Forms.Button();
            this.cmdUltimasCompras = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalItem = new System.Windows.Forms.Label();
            this.grpbVlrPraticados = new System.Windows.Forms.GroupBox();
            this.LabVlrPraticado4 = new System.Windows.Forms.Label();
            this.lbVlrPraticado4 = new System.Windows.Forms.Label();
            this.lbVlrPraticado3 = new System.Windows.Forms.Label();
            this.labPraticado3 = new System.Windows.Forms.Label();
            this.lbVlrPraticado2 = new System.Windows.Forms.Label();
            this.lbPraticado2 = new System.Windows.Forms.Label();
            this.lbVlrPraticado1 = new System.Windows.Forms.Label();
            this.lbPraticado1 = new System.Windows.Forms.Label();
            this.labTotalPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.labValorForencedor = new System.Windows.Forms.Label();
            this.txtValorFornecedor = new System.Windows.Forms.TextBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.chkFatura = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdItensPedido)).BeginInit();
            this.grpbVlrPraticados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdItensPedido
            // 
            this.grdItensPedido.AllowUserToAddRows = false;
            this.grdItensPedido.AllowUserToDeleteRows = false;
            this.grdItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNumero,
            this.grdProduto,
            this.grdDescricao,
            this.grdQuantidade,
            this.grdCodigoItem,
            this.grdVlrItem,
            this.grdTotal,
            this.grdValorFornecedor,
            this.grdLote});
            this.grdItensPedido.Location = new System.Drawing.Point(12, 30);
            this.grdItensPedido.Name = "grdItensPedido";
            this.grdItensPedido.ReadOnly = true;
            this.grdItensPedido.RowHeadersVisible = false;
            this.grdItensPedido.RowTemplate.Height = 25;
            this.grdItensPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItensPedido.Size = new System.Drawing.Size(776, 150);
            this.grdItensPedido.TabIndex = 0;
            this.grdItensPedido.SelectionChanged += new System.EventHandler(this.grdItensPedido_SelectionChanged);
            // 
            // grdNumero
            // 
            this.grdNumero.HeaderText = "Numero";
            this.grdNumero.Name = "grdNumero";
            this.grdNumero.ReadOnly = true;
            this.grdNumero.Visible = false;
            this.grdNumero.Width = 60;
            // 
            // grdProduto
            // 
            this.grdProduto.HeaderText = "ProdutoID";
            this.grdProduto.Name = "grdProduto";
            this.grdProduto.ReadOnly = true;
            this.grdProduto.Visible = false;
            // 
            // grdDescricao
            // 
            this.grdDescricao.HeaderText = "Descrição";
            this.grdDescricao.Name = "grdDescricao";
            this.grdDescricao.ReadOnly = true;
            this.grdDescricao.Width = 400;
            // 
            // grdQuantidade
            // 
            this.grdQuantidade.HeaderText = "Quantidade";
            this.grdQuantidade.Name = "grdQuantidade";
            this.grdQuantidade.ReadOnly = true;
            // 
            // grdCodigoItem
            // 
            this.grdCodigoItem.HeaderText = "Codigo Item";
            this.grdCodigoItem.Name = "grdCodigoItem";
            this.grdCodigoItem.ReadOnly = true;
            // 
            // grdVlrItem
            // 
            this.grdVlrItem.HeaderText = "Vlr.Item";
            this.grdVlrItem.Name = "grdVlrItem";
            this.grdVlrItem.ReadOnly = true;
            this.grdVlrItem.Width = 60;
            // 
            // grdTotal
            // 
            this.grdTotal.HeaderText = "Total";
            this.grdTotal.Name = "grdTotal";
            this.grdTotal.ReadOnly = true;
            this.grdTotal.Width = 60;
            // 
            // grdValorFornecedor
            // 
            this.grdValorFornecedor.HeaderText = "ValorFornecedor";
            this.grdValorFornecedor.Name = "grdValorFornecedor";
            this.grdValorFornecedor.ReadOnly = true;
            this.grdValorFornecedor.Visible = false;
            // 
            // grdLote
            // 
            this.grdLote.HeaderText = "Lote";
            this.grdLote.Name = "grdLote";
            this.grdLote.ReadOnly = true;
            this.grdLote.Visible = false;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Location = new System.Drawing.Point(12, 207);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(577, 23);
            this.txtDescProduto.TabIndex = 1;
            this.txtDescProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescProduto_KeyDown);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 261);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(12, 189);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(73, 15);
            this.lbProduto.TabIndex = 3;
            this.lbProduto.Text = "Produto - F1";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(12, 243);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(69, 15);
            this.lbQuantidade.TabIndex = 4;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(131, 261);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 23);
            this.txtLote.TabIndex = 3;
            // 
            // lbLote
            // 
            this.lbLote.AutoSize = true;
            this.lbLote.Location = new System.Drawing.Point(131, 243);
            this.lbLote.Name = "lbLote";
            this.lbLote.Size = new System.Drawing.Size(30, 15);
            this.lbLote.TabIndex = 6;
            this.lbLote.Text = "Lote";
            // 
            // btnOcorrencias
            // 
            this.btnOcorrencias.Location = new System.Drawing.Point(653, 207);
            this.btnOcorrencias.Name = "btnOcorrencias";
            this.btnOcorrencias.Size = new System.Drawing.Size(135, 23);
            this.btnOcorrencias.TabIndex = 7;
            this.btnOcorrencias.Text = "Ocorrencias";
            this.btnOcorrencias.UseVisualStyleBackColor = true;
            // 
            // cmdUltimasCompras
            // 
            this.cmdUltimasCompras.Location = new System.Drawing.Point(653, 239);
            this.cmdUltimasCompras.Name = "cmdUltimasCompras";
            this.cmdUltimasCompras.Size = new System.Drawing.Size(135, 23);
            this.cmdUltimasCompras.TabIndex = 8;
            this.cmdUltimasCompras.Text = "Ultimas Compras";
            this.cmdUltimasCompras.UseVisualStyleBackColor = true;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(249, 243);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(58, 15);
            this.lbValor.TabIndex = 10;
            this.lbValor.Text = "Valor Unit";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(249, 261);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 4;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Location = new System.Drawing.Point(12, 300);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(90, 15);
            this.lbFornecedor.TabIndex = 12;
            this.lbFornecedor.Text = "Fornecedor - F1";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(12, 318);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(577, 23);
            this.txtFornecedor.TabIndex = 6;
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(12, 361);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 15);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Total Item: ";
            // 
            // lbTotalItem
            // 
            this.lbTotalItem.AutoSize = true;
            this.lbTotalItem.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalItem.Location = new System.Drawing.Point(88, 364);
            this.lbTotalItem.Name = "lbTotalItem";
            this.lbTotalItem.Size = new System.Drawing.Size(50, 12);
            this.lbTotalItem.TabIndex = 14;
            this.lbTotalItem.Text = "XXXX,XX";
            // 
            // grpbVlrPraticados
            // 
            this.grpbVlrPraticados.Controls.Add(this.LabVlrPraticado4);
            this.grpbVlrPraticados.Controls.Add(this.lbVlrPraticado4);
            this.grpbVlrPraticados.Controls.Add(this.lbVlrPraticado3);
            this.grpbVlrPraticados.Controls.Add(this.labPraticado3);
            this.grpbVlrPraticados.Controls.Add(this.lbVlrPraticado2);
            this.grpbVlrPraticados.Controls.Add(this.lbPraticado2);
            this.grpbVlrPraticados.Controls.Add(this.lbVlrPraticado1);
            this.grpbVlrPraticados.Controls.Add(this.lbPraticado1);
            this.grpbVlrPraticados.Location = new System.Drawing.Point(12, 392);
            this.grpbVlrPraticados.Name = "grpbVlrPraticados";
            this.grpbVlrPraticados.Size = new System.Drawing.Size(577, 46);
            this.grpbVlrPraticados.TabIndex = 15;
            this.grpbVlrPraticados.TabStop = false;
            this.grpbVlrPraticados.Text = "Valore Praticados";
            // 
            // LabVlrPraticado4
            // 
            this.LabVlrPraticado4.AutoSize = true;
            this.LabVlrPraticado4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabVlrPraticado4.Location = new System.Drawing.Point(435, 22);
            this.LabVlrPraticado4.Name = "LabVlrPraticado4";
            this.LabVlrPraticado4.Size = new System.Drawing.Size(50, 12);
            this.LabVlrPraticado4.TabIndex = 22;
            this.LabVlrPraticado4.Text = "XXXX,XX";
            // 
            // lbVlrPraticado4
            // 
            this.lbVlrPraticado4.AutoSize = true;
            this.lbVlrPraticado4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVlrPraticado4.Location = new System.Drawing.Point(378, 19);
            this.lbVlrPraticado4.Name = "lbVlrPraticado4";
            this.lbVlrPraticado4.Size = new System.Drawing.Size(51, 15);
            this.lbVlrPraticado4.TabIndex = 21;
            this.lbVlrPraticado4.Text = "Valor 4: ";
            // 
            // lbVlrPraticado3
            // 
            this.lbVlrPraticado3.AutoSize = true;
            this.lbVlrPraticado3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVlrPraticado3.Location = new System.Drawing.Point(310, 22);
            this.lbVlrPraticado3.Name = "lbVlrPraticado3";
            this.lbVlrPraticado3.Size = new System.Drawing.Size(50, 12);
            this.lbVlrPraticado3.TabIndex = 20;
            this.lbVlrPraticado3.Text = "XXXX,XX";
            // 
            // labPraticado3
            // 
            this.labPraticado3.AutoSize = true;
            this.labPraticado3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPraticado3.Location = new System.Drawing.Point(253, 19);
            this.labPraticado3.Name = "labPraticado3";
            this.labPraticado3.Size = new System.Drawing.Size(51, 15);
            this.labPraticado3.TabIndex = 19;
            this.labPraticado3.Text = "Valor 3: ";
            // 
            // lbVlrPraticado2
            // 
            this.lbVlrPraticado2.AutoSize = true;
            this.lbVlrPraticado2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVlrPraticado2.Location = new System.Drawing.Point(189, 22);
            this.lbVlrPraticado2.Name = "lbVlrPraticado2";
            this.lbVlrPraticado2.Size = new System.Drawing.Size(50, 12);
            this.lbVlrPraticado2.TabIndex = 18;
            this.lbVlrPraticado2.Text = "XXXX,XX";
            // 
            // lbPraticado2
            // 
            this.lbPraticado2.AutoSize = true;
            this.lbPraticado2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPraticado2.Location = new System.Drawing.Point(132, 19);
            this.lbPraticado2.Name = "lbPraticado2";
            this.lbPraticado2.Size = new System.Drawing.Size(51, 15);
            this.lbPraticado2.TabIndex = 17;
            this.lbPraticado2.Text = "Valor 2: ";
            // 
            // lbVlrPraticado1
            // 
            this.lbVlrPraticado1.AutoSize = true;
            this.lbVlrPraticado1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVlrPraticado1.Location = new System.Drawing.Point(63, 22);
            this.lbVlrPraticado1.Name = "lbVlrPraticado1";
            this.lbVlrPraticado1.Size = new System.Drawing.Size(50, 12);
            this.lbVlrPraticado1.TabIndex = 16;
            this.lbVlrPraticado1.Text = "XXXX,XX";
            // 
            // lbPraticado1
            // 
            this.lbPraticado1.AutoSize = true;
            this.lbPraticado1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPraticado1.Location = new System.Drawing.Point(6, 19);
            this.lbPraticado1.Name = "lbPraticado1";
            this.lbPraticado1.Size = new System.Drawing.Size(51, 15);
            this.lbPraticado1.TabIndex = 15;
            this.lbPraticado1.Text = "Valor 1: ";
            // 
            // labTotalPedido
            // 
            this.labTotalPedido.AutoSize = true;
            this.labTotalPedido.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTotalPedido.Location = new System.Drawing.Point(539, 363);
            this.labTotalPedido.Name = "labTotalPedido";
            this.labTotalPedido.Size = new System.Drawing.Size(50, 12);
            this.labTotalPedido.TabIndex = 17;
            this.labTotalPedido.Text = "XXXX,XX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(452, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Pedido: ";
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGravar.Location = new System.Drawing.Point(724, 1);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(29, 29);
            this.cmdGravar.TabIndex = 9;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Location = new System.Drawing.Point(759, 1);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(29, 29);
            this.cmdSair.TabIndex = 10;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNovo.Location = new System.Drawing.Point(689, 1);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(29, 29);
            this.cmdNovo.TabIndex = 8;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // labValorForencedor
            // 
            this.labValorForencedor.AutoSize = true;
            this.labValorForencedor.Location = new System.Drawing.Point(367, 243);
            this.labValorForencedor.Name = "labValorForencedor";
            this.labValorForencedor.Size = new System.Drawing.Size(96, 15);
            this.labValorForencedor.TabIndex = 22;
            this.labValorForencedor.Text = "Valor Fornecedor";
            // 
            // txtValorFornecedor
            // 
            this.txtValorFornecedor.Location = new System.Drawing.Point(367, 261);
            this.txtValorFornecedor.Name = "txtValorFornecedor";
            this.txtValorFornecedor.Size = new System.Drawing.Size(100, 23);
            this.txtValorFornecedor.TabIndex = 5;
            this.txtValorFornecedor.Leave += new System.EventHandler(this.txtValorFornecedor_Leave);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExcluir.Location = new System.Drawing.Point(653, 1);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(29, 29);
            this.cmdExcluir.TabIndex = 7;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // chkFatura
            // 
            this.chkFatura.AutoSize = true;
            this.chkFatura.Location = new System.Drawing.Point(485, 265);
            this.chkFatura.Name = "chkFatura";
            this.chkFatura.Size = new System.Drawing.Size(59, 19);
            this.chkFatura.TabIndex = 23;
            this.chkFatura.Text = "Fatura";
            this.chkFatura.UseVisualStyleBackColor = true;
            // 
            // frmItensPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.chkFatura);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.labValorForencedor);
            this.Controls.Add(this.txtValorFornecedor);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.labTotalPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpbVlrPraticados);
            this.Controls.Add(this.lbTotalItem);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cmdUltimasCompras);
            this.Controls.Add(this.btnOcorrencias);
            this.Controls.Add(this.lbLote);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.grdItensPedido);
            this.Name = "frmItensPedido";
            this.Text = "ItensPedido";
            this.Load += new System.EventHandler(this.frmItensPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdItensPedido)).EndInit();
            this.grpbVlrPraticados.ResumeLayout(false);
            this.grpbVlrPraticados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}