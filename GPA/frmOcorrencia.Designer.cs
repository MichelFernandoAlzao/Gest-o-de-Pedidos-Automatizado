namespace Formularios
{
    partial class frmOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcorrencia));
            txtEmpresa = new TextBox();
            lbCabeçallho = new Label();
            label1 = new Label();
            labDescricao = new Label();
            txtxDescricao = new TextBox();
            labPedido = new Label();
            txtPedido = new TextBox();
            labProduto = new Label();
            txtProduto = new TextBox();
            cmdSelecionar = new Button();
            grdProdutos = new DataGridView();
            grdIDItem = new DataGridViewTextBoxColumn();
            grdDescProduto = new DataGridViewTextBoxColumn();
            grdVlrProd = new DataGridViewTextBoxColumn();
            grdQtdPedido = new DataGridViewTextBoxColumn();
            grdTotalItem = new DataGridViewTextBoxColumn();
            labDataOcorrencia = new Label();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            labFornecedor = new Label();
            txtFornecedor = new TextBox();
            labDataResolucao = new Label();
            cmdExcluir = new Button();
            txtDataOcorrencia = new MaskedTextBox();
            txtDataReolucao = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grdProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtEmpresa
            // 
            txtEmpresa.Enabled = false;
            txtEmpresa.Location = new Point(12, 73);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(544, 23);
            txtEmpresa.TabIndex = 0;
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 12);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(612, 30);
            lbCabeçallho.TabIndex = 11;
            lbCabeçallho.Text = "Registro Ocorrencias";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Empresa";
            // 
            // labDescricao
            // 
            labDescricao.AutoSize = true;
            labDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescricao.Location = new Point(12, 161);
            labDescricao.Name = "labDescricao";
            labDescricao.Size = new Size(61, 15);
            labDescricao.TabIndex = 20;
            labDescricao.Text = "Descrição";
            // 
            // txtxDescricao
            // 
            txtxDescricao.Location = new Point(12, 179);
            txtxDescricao.Multiline = true;
            txtxDescricao.Name = "txtxDescricao";
            txtxDescricao.Size = new Size(775, 112);
            txtxDescricao.TabIndex = 4;
            // 
            // labPedido
            // 
            labPedido.AutoSize = true;
            labPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labPedido.Location = new Point(579, 294);
            labPedido.Name = "labPedido";
            labPedido.Size = new Size(45, 15);
            labPedido.TabIndex = 22;
            labPedido.Text = "Pedido";
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(579, 312);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(101, 23);
            txtPedido.TabIndex = 5;
            // 
            // labProduto
            // 
            labProduto.AutoSize = true;
            labProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labProduto.Location = new Point(12, 294);
            labProduto.Name = "labProduto";
            labProduto.Size = new Size(52, 15);
            labProduto.TabIndex = 24;
            labProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            txtProduto.Enabled = false;
            txtProduto.Location = new Point(12, 312);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(544, 23);
            txtProduto.TabIndex = 23;
            // 
            // cmdSelecionar
            // 
            cmdSelecionar.Location = new Point(691, 312);
            cmdSelecionar.Name = "cmdSelecionar";
            cmdSelecionar.Size = new Size(97, 23);
            cmdSelecionar.TabIndex = 6;
            cmdSelecionar.Text = "Selecionar";
            cmdSelecionar.UseVisualStyleBackColor = true;
            cmdSelecionar.Click += cmdSelecionar_Click;
            // 
            // grdProdutos
            // 
            grdProdutos.AllowUserToAddRows = false;
            grdProdutos.AllowUserToDeleteRows = false;
            grdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProdutos.Columns.AddRange(new DataGridViewColumn[] { grdIDItem, grdDescProduto, grdVlrProd, grdQtdPedido, grdTotalItem });
            grdProdutos.Location = new Point(12, 341);
            grdProdutos.Name = "grdProdutos";
            grdProdutos.ReadOnly = true;
            grdProdutos.RowTemplate.Height = 25;
            grdProdutos.Size = new Size(776, 97);
            grdProdutos.TabIndex = 26;
            // 
            // grdIDItem
            // 
            grdIDItem.HeaderText = "ID";
            grdIDItem.Name = "grdIDItem";
            grdIDItem.ReadOnly = true;
            grdIDItem.Visible = false;
            // 
            // grdDescProduto
            // 
            grdDescProduto.HeaderText = "Produto";
            grdDescProduto.Name = "grdDescProduto";
            grdDescProduto.ReadOnly = true;
            grdDescProduto.Width = 450;
            // 
            // grdVlrProd
            // 
            grdVlrProd.HeaderText = "Valor Unit";
            grdVlrProd.Name = "grdVlrProd";
            grdVlrProd.ReadOnly = true;
            // 
            // grdQtdPedido
            // 
            grdQtdPedido.HeaderText = "Quantidade";
            grdQtdPedido.Name = "grdQtdPedido";
            grdQtdPedido.ReadOnly = true;
            // 
            // grdTotalItem
            // 
            grdTotalItem.HeaderText = "Total";
            grdTotalItem.Name = "grdTotalItem";
            grdTotalItem.ReadOnly = true;
            // 
            // labDataOcorrencia
            // 
            labDataOcorrencia.AutoSize = true;
            labDataOcorrencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDataOcorrencia.Location = new Point(686, 55);
            labDataOcorrencia.Name = "labDataOcorrencia";
            labDataOcorrencia.Size = new Size(97, 15);
            labDataOcorrencia.TabIndex = 28;
            labDataOcorrencia.Text = "Data Ocorrencia";
            // 
            // cmdNovo
            // 
            cmdNovo.AccessibleDescription = "Novo";
            cmdNovo.AccessibleName = "Novo";
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdNovo.Location = new Point(686, 13);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(29, 29);
            cmdNovo.TabIndex = 29;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.AccessibleDescription = "Gravar";
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(722, 12);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 30;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.AccessibleDescription = "Sair";
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(758, 13);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 31;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // labFornecedor
            // 
            labFornecedor.AutoSize = true;
            labFornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labFornecedor.Location = new Point(12, 106);
            labFornecedor.Name = "labFornecedor";
            labFornecedor.Size = new Size(95, 15);
            labFornecedor.TabIndex = 33;
            labFornecedor.Text = "Fornecedor - F1";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(12, 124);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(544, 23);
            txtFornecedor.TabIndex = 2;
            txtFornecedor.KeyDown += txtFornecedor_KeyDown;
            // 
            // labDataResolucao
            // 
            labDataResolucao.AutoSize = true;
            labDataResolucao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDataResolucao.Location = new Point(686, 106);
            labDataResolucao.Name = "labDataResolucao";
            labDataResolucao.Size = new Size(92, 15);
            labDataResolucao.TabIndex = 35;
            labDataResolucao.Text = "Data Resolução";
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            cmdExcluir.Location = new Point(650, 12);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(29, 29);
            cmdExcluir.TabIndex = 40;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // txtDataOcorrencia
            // 
            txtDataOcorrencia.Location = new Point(688, 73);
            txtDataOcorrencia.Mask = "00/00/0000";
            txtDataOcorrencia.Name = "txtDataOcorrencia";
            txtDataOcorrencia.Size = new Size(100, 23);
            txtDataOcorrencia.TabIndex = 41;
            txtDataOcorrencia.ValidatingType = typeof(DateTime);
            txtDataOcorrencia.Leave += txtDataOcorrencia_Leave;
            // 
            // txtDataReolucao
            // 
            txtDataReolucao.Location = new Point(688, 124);
            txtDataReolucao.Mask = "00/00/0000";
            txtDataReolucao.Name = "txtDataReolucao";
            txtDataReolucao.Size = new Size(100, 23);
            txtDataReolucao.TabIndex = 42;
            txtDataReolucao.ValidatingType = typeof(DateTime);
            txtDataReolucao.Leave += txtDataReolucao_Leave;
            // 
            // frmOcorrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtDataReolucao);
            Controls.Add(txtDataOcorrencia);
            Controls.Add(cmdExcluir);
            Controls.Add(labDataResolucao);
            Controls.Add(labFornecedor);
            Controls.Add(txtFornecedor);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(labDataOcorrencia);
            Controls.Add(grdProdutos);
            Controls.Add(cmdSelecionar);
            Controls.Add(labProduto);
            Controls.Add(txtProduto);
            Controls.Add(labPedido);
            Controls.Add(txtPedido);
            Controls.Add(labDescricao);
            Controls.Add(txtxDescricao);
            Controls.Add(label1);
            Controls.Add(lbCabeçallho);
            Controls.Add(txtEmpresa);
            Name = "frmOcorrencia";
            Text = "Ocorrencias";
            ((System.ComponentModel.ISupportInitialize)grdProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lbCabeçallho;
        private Button button3;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox5;
        private TextBox txtEmpresa;
        private Label labDescricao;
        private TextBox txtxDescricao;
        private Label labPedido;
        private TextBox txtPedido;
        private Label labProduto;
        private TextBox txtProduto;
        private Button cmdSelecionar;
        private DataGridView grdProdutos;
        private Label labDataOcorrencia;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private Label labFornecedor;
        private TextBox txtFornecedor;
        private Label labDataResolucao;
        private DataGridViewTextBoxColumn grdIDItem;
        private DataGridViewTextBoxColumn grdDescProduto;
        private DataGridViewTextBoxColumn grdVlrProd;
        private DataGridViewTextBoxColumn grdQtdPedido;
        private DataGridViewTextBoxColumn grdTotalItem;
        private Button cmdExcluir;
        private MaskedTextBox txtDataOcorrencia;
        private MaskedTextBox txtDataReolucao;
    }
}