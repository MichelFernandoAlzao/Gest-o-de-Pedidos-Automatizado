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
            this.labEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lbCabeçallho = new System.Windows.Forms.Label();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.txtDataContato = new System.Windows.Forms.TextBox();
            this.labDataContato = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grdDescItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdVlrofertado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAceito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grdQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labSugestoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labProdSugeridos = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labEmpresa
            // 
            this.labEmpresa.AutoSize = true;
            this.labEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labEmpresa.Location = new System.Drawing.Point(12, 54);
            this.labEmpresa.Name = "labEmpresa";
            this.labEmpresa.Size = new System.Drawing.Size(78, 15);
            this.labEmpresa.TabIndex = 0;
            this.labEmpresa.Text = "Empresa - F1";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(12, 72);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(610, 23);
            this.txtEmpresa.TabIndex = 1;
            // 
            // lbCabeçallho
            // 
            this.lbCabeçallho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCabeçallho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbCabeçallho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCabeçallho.ForeColor = System.Drawing.Color.Black;
            this.lbCabeçallho.Location = new System.Drawing.Point(12, 3);
            this.lbCabeçallho.Name = "lbCabeçallho";
            this.lbCabeçallho.Size = new System.Drawing.Size(632, 30);
            this.lbCabeçallho.TabIndex = 3;
            this.lbCabeçallho.Text = "Contatos com Empresas";
            this.lbCabeçallho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.Location = new System.Drawing.Point(653, 3);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(30, 30);
            this.cmdExcluir.TabIndex = 49;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.Location = new System.Drawing.Point(689, 3);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(30, 30);
            this.cmdNovo.TabIndex = 48;
            this.cmdNovo.UseVisualStyleBackColor = true;
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.Location = new System.Drawing.Point(725, 3);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 47;
            this.cmdGravar.UseVisualStyleBackColor = true;
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.Location = new System.Drawing.Point(761, 3);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 46;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // txtDataContato
            // 
            this.txtDataContato.Location = new System.Drawing.Point(653, 72);
            this.txtDataContato.Name = "txtDataContato";
            this.txtDataContato.Size = new System.Drawing.Size(138, 23);
            this.txtDataContato.TabIndex = 50;
            // 
            // labDataContato
            // 
            this.labDataContato.AutoSize = true;
            this.labDataContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDataContato.Location = new System.Drawing.Point(653, 54);
            this.labDataContato.Name = "labDataContato";
            this.labDataContato.Size = new System.Drawing.Size(80, 15);
            this.labDataContato.TabIndex = 51;
            this.labDataContato.Text = "Data Contato";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdDescItem,
            this.grdVlrofertado,
            this.grdAceito,
            this.grdQuantidade});
            this.dataGridView1.Location = new System.Drawing.Point(12, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 111);
            this.dataGridView1.TabIndex = 52;
            // 
            // grdDescItem
            // 
            this.grdDescItem.HeaderText = "Produto";
            this.grdDescItem.Name = "grdDescItem";
            this.grdDescItem.ReadOnly = true;
            this.grdDescItem.Width = 350;
            // 
            // grdVlrofertado
            // 
            this.grdVlrofertado.HeaderText = "Valor Ofertado";
            this.grdVlrofertado.Name = "grdVlrofertado";
            this.grdVlrofertado.ReadOnly = true;
            this.grdVlrofertado.Width = 120;
            // 
            // grdAceito
            // 
            this.grdAceito.HeaderText = "Aceito";
            this.grdAceito.Name = "grdAceito";
            this.grdAceito.ReadOnly = true;
            this.grdAceito.Width = 50;
            // 
            // grdQuantidade
            // 
            this.grdQuantidade.HeaderText = "Quantidade";
            this.grdQuantidade.Name = "grdQuantidade";
            this.grdQuantidade.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 101);
            this.textBox1.TabIndex = 53;
            // 
            // labSugestoes
            // 
            this.labSugestoes.AutoSize = true;
            this.labSugestoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSugestoes.Location = new System.Drawing.Point(12, 111);
            this.labSugestoes.Name = "labSugestoes";
            this.labSugestoes.Size = new System.Drawing.Size(64, 15);
            this.labSugestoes.TabIndex = 54;
            this.labSugestoes.Text = "Sugestoes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(409, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Reclamações";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 101);
            this.textBox2.TabIndex = 55;
            // 
            // labProdSugeridos
            // 
            this.labProdSugeridos.AutoSize = true;
            this.labProdSugeridos.Location = new System.Drawing.Point(12, 309);
            this.labProdSugeridos.Name = "labProdSugeridos";
            this.labProdSugeridos.Size = new System.Drawing.Size(110, 15);
            this.labProdSugeridos.TabIndex = 57;
            this.labProdSugeridos.Text = "Produtos Sugeridos";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(610, 23);
            this.textBox3.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Produto - F1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmContatosEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labProdSugeridos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labSugestoes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labDataContato);
            this.Controls.Add(this.txtDataContato);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.lbCabeçallho);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.labEmpresa);
            this.Name = "frmContatosEmpresas";
            this.Text = "Contatos Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labEmpresa;
        private TextBox txtEmpresa;
        private Label lbCabeçallho;
        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private TextBox txtDataContato;
        private Label labDataContato;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn grdDescItem;
        private DataGridViewTextBoxColumn grdVlrofertado;
        private DataGridViewCheckBoxColumn grdAceito;
        private DataGridViewTextBoxColumn grdQuantidade;
        private TextBox textBox1;
        private Label labSugestoes;
        private Label label1;
        private TextBox textBox2;
        private Label labProdSugeridos;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
    }
}