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
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lbCabeçallho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDescricao = new System.Windows.Forms.Label();
            this.txtxDescricao = new System.Windows.Forms.TextBox();
            this.labPedido = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.labProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.cmdSelecionar = new System.Windows.Forms.Button();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.grdIDItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdVlrProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdQtdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDataOcorrencia = new System.Windows.Forms.Label();
            this.txtDataOcorrencia = new System.Windows.Forms.TextBox();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.labFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.labDataResolucao = new System.Windows.Forms.Label();
            this.txtDataReolucao = new System.Windows.Forms.TextBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(12, 73);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(544, 23);
            this.txtEmpresa.TabIndex = 0;
            // 
            // lbCabeçallho
            // 
            this.lbCabeçallho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCabeçallho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbCabeçallho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCabeçallho.ForeColor = System.Drawing.Color.Black;
            this.lbCabeçallho.Location = new System.Drawing.Point(12, 12);
            this.lbCabeçallho.Name = "lbCabeçallho";
            this.lbCabeçallho.Size = new System.Drawing.Size(612, 30);
            this.lbCabeçallho.TabIndex = 11;
            this.lbCabeçallho.Text = "Registro Ocorrencias";
            this.lbCabeçallho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Empresa";
            // 
            // labDescricao
            // 
            this.labDescricao.AutoSize = true;
            this.labDescricao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescricao.Location = new System.Drawing.Point(12, 161);
            this.labDescricao.Name = "labDescricao";
            this.labDescricao.Size = new System.Drawing.Size(61, 15);
            this.labDescricao.TabIndex = 20;
            this.labDescricao.Text = "Descrição";
            // 
            // txtxDescricao
            // 
            this.txtxDescricao.Location = new System.Drawing.Point(12, 179);
            this.txtxDescricao.Multiline = true;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.Size = new System.Drawing.Size(775, 112);
            this.txtxDescricao.TabIndex = 4;
            // 
            // labPedido
            // 
            this.labPedido.AutoSize = true;
            this.labPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPedido.Location = new System.Drawing.Point(579, 294);
            this.labPedido.Name = "labPedido";
            this.labPedido.Size = new System.Drawing.Size(45, 15);
            this.labPedido.TabIndex = 22;
            this.labPedido.Text = "Pedido";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(579, 312);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(101, 23);
            this.txtPedido.TabIndex = 5;
            // 
            // labProduto
            // 
            this.labProduto.AutoSize = true;
            this.labProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labProduto.Location = new System.Drawing.Point(12, 294);
            this.labProduto.Name = "labProduto";
            this.labProduto.Size = new System.Drawing.Size(52, 15);
            this.labProduto.TabIndex = 24;
            this.labProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(12, 312);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(544, 23);
            this.txtProduto.TabIndex = 23;
            // 
            // cmdSelecionar
            // 
            this.cmdSelecionar.Location = new System.Drawing.Point(691, 312);
            this.cmdSelecionar.Name = "cmdSelecionar";
            this.cmdSelecionar.Size = new System.Drawing.Size(97, 23);
            this.cmdSelecionar.TabIndex = 6;
            this.cmdSelecionar.Text = "Selecionar";
            this.cmdSelecionar.UseVisualStyleBackColor = true;
            this.cmdSelecionar.Click += new System.EventHandler(this.cmdSelecionar_Click);
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdIDItem,
            this.grdDescProduto,
            this.grdVlrProd,
            this.grdQtdPedido,
            this.grdTotalItem});
            this.grdProdutos.Location = new System.Drawing.Point(12, 341);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowTemplate.Height = 25;
            this.grdProdutos.Size = new System.Drawing.Size(776, 97);
            this.grdProdutos.TabIndex = 26;
            // 
            // grdIDItem
            // 
            this.grdIDItem.HeaderText = "ID";
            this.grdIDItem.Name = "grdIDItem";
            this.grdIDItem.ReadOnly = true;
            this.grdIDItem.Visible = false;
            // 
            // grdDescProduto
            // 
            this.grdDescProduto.HeaderText = "Produto";
            this.grdDescProduto.Name = "grdDescProduto";
            this.grdDescProduto.ReadOnly = true;
            this.grdDescProduto.Width = 450;
            // 
            // grdVlrProd
            // 
            this.grdVlrProd.HeaderText = "Valor Unit";
            this.grdVlrProd.Name = "grdVlrProd";
            this.grdVlrProd.ReadOnly = true;
            // 
            // grdQtdPedido
            // 
            this.grdQtdPedido.HeaderText = "Quantidade";
            this.grdQtdPedido.Name = "grdQtdPedido";
            this.grdQtdPedido.ReadOnly = true;
            // 
            // grdTotalItem
            // 
            this.grdTotalItem.HeaderText = "Total";
            this.grdTotalItem.Name = "grdTotalItem";
            this.grdTotalItem.ReadOnly = true;
            // 
            // labDataOcorrencia
            // 
            this.labDataOcorrencia.AutoSize = true;
            this.labDataOcorrencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDataOcorrencia.Location = new System.Drawing.Point(686, 55);
            this.labDataOcorrencia.Name = "labDataOcorrencia";
            this.labDataOcorrencia.Size = new System.Drawing.Size(97, 15);
            this.labDataOcorrencia.TabIndex = 28;
            this.labDataOcorrencia.Text = "Data Ocorrencia";
            // 
            // txtDataOcorrencia
            // 
            this.txtDataOcorrencia.Location = new System.Drawing.Point(686, 73);
            this.txtDataOcorrencia.Name = "txtDataOcorrencia";
            this.txtDataOcorrencia.Size = new System.Drawing.Size(101, 23);
            this.txtDataOcorrencia.TabIndex = 1;
            // 
            // cmdNovo
            // 
            this.cmdNovo.AccessibleDescription = "Novo";
            this.cmdNovo.AccessibleName = "Novo";
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNovo.Location = new System.Drawing.Point(686, 13);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(29, 29);
            this.cmdNovo.TabIndex = 29;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.AccessibleDescription = "Gravar";
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGravar.Location = new System.Drawing.Point(722, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 30;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.AccessibleDescription = "Sair";
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Location = new System.Drawing.Point(758, 13);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 31;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // labFornecedor
            // 
            this.labFornecedor.AutoSize = true;
            this.labFornecedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFornecedor.Location = new System.Drawing.Point(12, 106);
            this.labFornecedor.Name = "labFornecedor";
            this.labFornecedor.Size = new System.Drawing.Size(95, 15);
            this.labFornecedor.TabIndex = 33;
            this.labFornecedor.Text = "Fornecedor - F1";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(12, 124);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(544, 23);
            this.txtFornecedor.TabIndex = 2;
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            // 
            // labDataResolucao
            // 
            this.labDataResolucao.AutoSize = true;
            this.labDataResolucao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDataResolucao.Location = new System.Drawing.Point(686, 106);
            this.labDataResolucao.Name = "labDataResolucao";
            this.labDataResolucao.Size = new System.Drawing.Size(92, 15);
            this.labDataResolucao.TabIndex = 35;
            this.labDataResolucao.Text = "Data Resolução";
            // 
            // txtDataReolucao
            // 
            this.txtDataReolucao.Location = new System.Drawing.Point(686, 124);
            this.txtDataReolucao.Name = "txtDataReolucao";
            this.txtDataReolucao.Size = new System.Drawing.Size(101, 23);
            this.txtDataReolucao.TabIndex = 3;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExcluir.Location = new System.Drawing.Point(650, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(29, 29);
            this.cmdExcluir.TabIndex = 40;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // frmOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.labDataResolucao);
            this.Controls.Add(this.txtDataReolucao);
            this.Controls.Add(this.labFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.labDataOcorrencia);
            this.Controls.Add(this.txtDataOcorrencia);
            this.Controls.Add(this.grdProdutos);
            this.Controls.Add(this.cmdSelecionar);
            this.Controls.Add(this.labProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.labPedido);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.labDescricao);
            this.Controls.Add(this.txtxDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCabeçallho);
            this.Controls.Add(this.txtEmpresa);
            this.Name = "frmOcorrencia";
            this.Text = "Ocorrencias";
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox txtDataOcorrencia;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private Label labFornecedor;
        private TextBox txtFornecedor;
        private Label labDataResolucao;
        private TextBox txtDataReolucao;
        private DataGridViewTextBoxColumn grdIDItem;
        private DataGridViewTextBoxColumn grdDescProduto;
        private DataGridViewTextBoxColumn grdVlrProd;
        private DataGridViewTextBoxColumn grdQtdPedido;
        private DataGridViewTextBoxColumn grdTotalItem;
        private Button cmdExcluir;
    }
}