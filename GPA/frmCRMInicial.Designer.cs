namespace Formularios
{
    partial class frmCRMInicial
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.UltContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispensar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdPedidos = new System.Windows.Forms.Button();
            this.cmdCadastroProduto = new System.Windows.Forms.Button();
            this.cmdCadastrosEmpresas = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.DtCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 321);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Location = new System.Drawing.Point(132, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Meus Clientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meta";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(257, 460);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(802, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Progressão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1021, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.Location = new System.Drawing.Point(18, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ultimas Vendas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.Location = new System.Drawing.Point(132, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Consulta Pedidos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataVenda,
            this.VRazao,
            this.VValor});
            this.dataGridView1.Location = new System.Drawing.Point(669, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(390, 280);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataVenda
            // 
            this.DataVenda.HeaderText = "Data";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.Width = 75;
            // 
            // VRazao
            // 
            this.VRazao.HeaderText = "Razao Social";
            this.VRazao.Name = "VRazao";
            this.VRazao.Width = 200;
            // 
            // VValor
            // 
            this.VValor.HeaderText = "Valor";
            this.VValor.Name = "VValor";
            this.VValor.Width = 70;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UltContato,
            this.RazSocial,
            this.Dispensar});
            this.dataGridView2.Location = new System.Drawing.Point(257, 159);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(390, 280);
            this.dataGridView2.TabIndex = 9;
            // 
            // UltContato
            // 
            this.UltContato.HeaderText = "Ult.COntato";
            this.UltContato.Name = "UltContato";
            this.UltContato.Width = 75;
            // 
            // RazSocial
            // 
            this.RazSocial.HeaderText = "Razao Social";
            this.RazSocial.Name = "RazSocial";
            this.RazSocial.Width = 230;
            // 
            // Dispensar
            // 
            this.Dispensar.HeaderText = "Disp";
            this.Dispensar.Name = "Dispensar";
            this.Dispensar.Width = 40;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.Location = new System.Drawing.Point(18, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "Registrar contato";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(113, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Objetivo Diario";
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(257, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Clientes não contatados: ";
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(669, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ultimas Vendas:";
            // 
            // cmdPedidos
            // 
            this.cmdPedidos.Location = new System.Drawing.Point(18, 151);
            this.cmdPedidos.Name = "cmdPedidos";
            this.cmdPedidos.Size = new System.Drawing.Size(113, 44);
            this.cmdPedidos.TabIndex = 16;
            this.cmdPedidos.Text = "Pedidos";
            this.cmdPedidos.UseVisualStyleBackColor = true;
            this.cmdPedidos.Click += new System.EventHandler(this.cmdPedidos_Click);
            // 
            // cmdCadastroProduto
            // 
            this.cmdCadastroProduto.Enabled = false;
            this.cmdCadastroProduto.Location = new System.Drawing.Point(132, 201);
            this.cmdCadastroProduto.Name = "cmdCadastroProduto";
            this.cmdCadastroProduto.Size = new System.Drawing.Size(113, 44);
            this.cmdCadastroProduto.TabIndex = 17;
            this.cmdCadastroProduto.Text = "Produtos";
            this.cmdCadastroProduto.UseVisualStyleBackColor = true;
            this.cmdCadastroProduto.Click += new System.EventHandler(this.cmdCadastroProduto_Click);
            // 
            // cmdCadastrosEmpresas
            // 
            this.cmdCadastrosEmpresas.Enabled = false;
            this.cmdCadastrosEmpresas.Location = new System.Drawing.Point(18, 201);
            this.cmdCadastrosEmpresas.Name = "cmdCadastrosEmpresas";
            this.cmdCadastrosEmpresas.Size = new System.Drawing.Size(113, 44);
            this.cmdCadastrosEmpresas.TabIndex = 18;
            this.cmdCadastrosEmpresas.Text = "Cadastros";
            this.cmdCadastrosEmpresas.UseVisualStyleBackColor = true;
            this.cmdCadastrosEmpresas.Click += new System.EventHandler(this.cmdCadastrosEmpresas_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(132, 151);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 44);
            this.button8.TabIndex = 19;
            this.button8.Text = "Relatórios";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Não Consolidado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(113, 23);
            this.textBox2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(18, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Vendedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Empresa:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtCadastro,
            this.avTexto,
            this.dtTermino,
            this.Prioridade});
            this.dataGridView3.Location = new System.Drawing.Point(257, 33);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(802, 97);
            this.dataGridView3.TabIndex = 24;
            // 
            // DtCadastro
            // 
            this.DtCadastro.HeaderText = "Data";
            this.DtCadastro.Name = "DtCadastro";
            this.DtCadastro.Width = 90;
            // 
            // avTexto
            // 
            this.avTexto.HeaderText = "Aviso";
            this.avTexto.Name = "avTexto";
            this.avTexto.Width = 500;
            // 
            // dtTermino
            // 
            this.dtTermino.HeaderText = "Prazo";
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Width = 90;
            // 
            // Prioridade
            // 
            this.Prioridade.HeaderText = "Prioridade";
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Width = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Avisos:";
            // 
            // frmCRMInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.cmdCadastrosEmpresas);
            this.Controls.Add(this.cmdCadastroProduto);
            this.Controls.Add(this.cmdPedidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "frmCRMInicial";
            this.Text = "CRM - GPA";
            this.Load += new System.EventHandler(this.frmCRMInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button button1;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button4;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button cmdPedidos;
        private Button cmdCadastroProduto;
        private Button cmdCadastrosEmpresas;
        private Button button8;
        private Label label8;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewTextBoxColumn VRazao;
        private DataGridViewTextBoxColumn VValor;
        private DataGridViewTextBoxColumn UltContato;
        private DataGridViewTextBoxColumn RazSocial;
        private DataGridViewTextBoxColumn Dispensar;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn DtCadastro;
        private DataGridViewTextBoxColumn avTexto;
        private DataGridViewTextBoxColumn dtTermino;
        private DataGridViewTextBoxColumn Prioridade;
        private Label label5;
    }
}