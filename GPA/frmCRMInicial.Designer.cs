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
            this.CalendarioContatos = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdConsultaPedido = new System.Windows.Forms.Button();
            this.grdUltimasVendas = new System.Windows.Forms.DataGridView();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdUltContato = new System.Windows.Forms.DataGridView();
            this.UltContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispensar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdRegistraContatos = new System.Windows.Forms.Button();
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
            this.grdAvisos = new System.Windows.Forms.DataGridView();
            this.DtCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avTexto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.grdContatosAgendados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labContatos = new System.Windows.Forms.Label();
            this.cmdNatOperacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUltimasVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUltContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContatosAgendados)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarioContatos
            // 
            this.CalendarioContatos.Location = new System.Drawing.Point(18, 321);
            this.CalendarioContatos.Name = "CalendarioContatos";
            this.CalendarioContatos.TabIndex = 0;
            this.CalendarioContatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalendarioContatos_KeyDown);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdConsultaPedido
            // 
            this.cmdConsultaPedido.FlatAppearance.BorderSize = 3;
            this.cmdConsultaPedido.Location = new System.Drawing.Point(132, 101);
            this.cmdConsultaPedido.Name = "cmdConsultaPedido";
            this.cmdConsultaPedido.Size = new System.Drawing.Size(113, 44);
            this.cmdConsultaPedido.TabIndex = 7;
            this.cmdConsultaPedido.Text = "Consulta Pedidos";
            this.cmdConsultaPedido.UseVisualStyleBackColor = true;
            this.cmdConsultaPedido.Click += new System.EventHandler(this.cmdConsultaPedido_Click);
            // 
            // grdUltimasVendas
            // 
            this.grdUltimasVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUltimasVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataVenda,
            this.VRazao,
            this.VValor});
            this.grdUltimasVendas.Location = new System.Drawing.Point(669, 159);
            this.grdUltimasVendas.Name = "grdUltimasVendas";
            this.grdUltimasVendas.RowTemplate.Height = 25;
            this.grdUltimasVendas.Size = new System.Drawing.Size(390, 280);
            this.grdUltimasVendas.TabIndex = 8;
            this.grdUltimasVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // grdUltContato
            // 
            this.grdUltContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUltContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UltContato,
            this.RazSocial,
            this.Dispensar});
            this.grdUltContato.Location = new System.Drawing.Point(257, 159);
            this.grdUltContato.Name = "grdUltContato";
            this.grdUltContato.RowTemplate.Height = 25;
            this.grdUltContato.Size = new System.Drawing.Size(390, 280);
            this.grdUltContato.TabIndex = 9;
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
            // cmdRegistraContatos
            // 
            this.cmdRegistraContatos.FlatAppearance.BorderSize = 3;
            this.cmdRegistraContatos.Location = new System.Drawing.Point(18, 51);
            this.cmdRegistraContatos.Name = "cmdRegistraContatos";
            this.cmdRegistraContatos.Size = new System.Drawing.Size(113, 44);
            this.cmdRegistraContatos.TabIndex = 10;
            this.cmdRegistraContatos.Text = "Registrar contato";
            this.cmdRegistraContatos.UseVisualStyleBackColor = true;
            this.cmdRegistraContatos.Click += new System.EventHandler(this.cmdRegistraContatos_Click);
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
            // grdAvisos
            // 
            this.grdAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAvisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DtCadastro,
            this.avTexto,
            this.dtTermino,
            this.Prioridade});
            this.grdAvisos.Location = new System.Drawing.Point(257, 33);
            this.grdAvisos.Name = "grdAvisos";
            this.grdAvisos.RowTemplate.Height = 25;
            this.grdAvisos.Size = new System.Drawing.Size(802, 97);
            this.grdAvisos.TabIndex = 24;
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
            // grdContatosAgendados
            // 
            this.grdContatosAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContatosAgendados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.grdContatosAgendados.Location = new System.Drawing.Point(1080, 33);
            this.grdContatosAgendados.Name = "grdContatosAgendados";
            this.grdContatosAgendados.RowTemplate.Height = 25;
            this.grdContatosAgendados.Size = new System.Drawing.Size(168, 406);
            this.grdContatosAgendados.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ult.COntato";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Razao Social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Disp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // labContatos
            // 
            this.labContatos.AutoSize = true;
            this.labContatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labContatos.Location = new System.Drawing.Point(1080, 15);
            this.labContatos.Name = "labContatos";
            this.labContatos.Size = new System.Drawing.Size(58, 15);
            this.labContatos.TabIndex = 27;
            this.labContatos.Text = "Contatar:";
            // 
            // cmdNatOperacao
            // 
            this.cmdNatOperacao.Location = new System.Drawing.Point(1080, 460);
            this.cmdNatOperacao.Name = "cmdNatOperacao";
            this.cmdNatOperacao.Size = new System.Drawing.Size(168, 23);
            this.cmdNatOperacao.TabIndex = 28;
            this.cmdNatOperacao.Text = "Nat. Operação";
            this.cmdNatOperacao.UseVisualStyleBackColor = true;
            this.cmdNatOperacao.Click += new System.EventHandler(this.cmdNatOperacao_Click);
            // 
            // frmCRMInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 501);
            this.Controls.Add(this.cmdNatOperacao);
            this.Controls.Add(this.labContatos);
            this.Controls.Add(this.grdContatosAgendados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdAvisos);
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
            this.Controls.Add(this.cmdRegistraContatos);
            this.Controls.Add(this.grdUltContato);
            this.Controls.Add(this.grdUltimasVendas);
            this.Controls.Add(this.cmdConsultaPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalendarioContatos);
            this.Name = "frmCRMInicial";
            this.Text = "CRM - GPA";
            this.Load += new System.EventHandler(this.frmCRMInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUltimasVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUltContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContatosAgendados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar CalendarioContatos;
        private Button button1;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button cmdConsultaPedido;
        private DataGridView grdUltimasVendas;
        private DataGridView grdUltContato;
        private Button cmdRegistraContatos;
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
        private DataGridView grdAvisos;
        private DataGridViewTextBoxColumn DtCadastro;
        private DataGridViewTextBoxColumn avTexto;
        private DataGridViewTextBoxColumn dtTermino;
        private DataGridViewTextBoxColumn Prioridade;
        private Label label5;
        private DataGridView grdContatosAgendados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label labContatos;
        private Button cmdNatOperacao;
    }
}