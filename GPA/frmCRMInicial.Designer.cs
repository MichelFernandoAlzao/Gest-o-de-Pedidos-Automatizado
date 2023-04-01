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
            CalendarioContatos = new MonthCalendar();
            cmdMeusClientes = new Button();
            labConsolidado = new Label();
            pgrsbMeta = new ProgressBar();
            labProgressao = new Label();
            labMeta = new Label();
            button2 = new Button();
            cmdConsultaPedido = new Button();
            grdUltimasVendas = new DataGridView();
            DataVenda = new DataGridViewTextBoxColumn();
            VRazao = new DataGridViewTextBoxColumn();
            VValor = new DataGridViewTextBoxColumn();
            grdUltContato = new DataGridView();
            UltContato = new DataGridViewTextBoxColumn();
            RazSocial = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            cmdRegistraContatos = new Button();
            txtObjetivoDiario = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmdPedidos = new Button();
            cmdCadastroProduto = new Button();
            cmdCadastrosEmpresas = new Button();
            button8 = new Button();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            grdAvisos = new DataGridView();
            avTexto = new DataGridViewTextBoxColumn();
            grdDatainicio = new DataGridViewTextBoxColumn();
            grdDataTermino = new DataGridViewTextBoxColumn();
            label5 = new Label();
            grdContatosAgendados = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            labContatos = new Label();
            cmdNatOperacao = new Button();
            labNomeUsuario = new Label();
            cmdParametros = new Button();
            cmdCriarAviso = new Button();
            labVlrProgressao = new Label();
            labVlrConsolidado = new Label();
            labVlrMeta = new Label();
            cmdAgendarContato = new Button();
            labAgendarContato = new Label();
            labNomeEmpresa = new Label();
            ((System.ComponentModel.ISupportInitialize)grdUltimasVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdUltContato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdAvisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdContatosAgendados).BeginInit();
            SuspendLayout();
            // 
            // CalendarioContatos
            // 
            CalendarioContatos.Location = new Point(18, 321);
            CalendarioContatos.Name = "CalendarioContatos";
            CalendarioContatos.TabIndex = 0;
            CalendarioContatos.KeyDown += CalendarioContatos_KeyDown;
            // 
            // cmdMeusClientes
            // 
            cmdMeusClientes.FlatAppearance.BorderSize = 3;
            cmdMeusClientes.Location = new Point(132, 45);
            cmdMeusClientes.Name = "cmdMeusClientes";
            cmdMeusClientes.Size = new Size(113, 44);
            cmdMeusClientes.TabIndex = 1;
            cmdMeusClientes.Text = "Meus Clientes";
            cmdMeusClientes.UseVisualStyleBackColor = true;
            cmdMeusClientes.Click += cmdMeusClientes_Click;
            // 
            // labConsolidado
            // 
            labConsolidado.AutoSize = true;
            labConsolidado.Location = new Point(257, 442);
            labConsolidado.Name = "labConsolidado";
            labConsolidado.Size = new Size(77, 15);
            labConsolidado.TabIndex = 2;
            labConsolidado.Text = "Consolidado:";
            // 
            // pgrsbMeta
            // 
            pgrsbMeta.Location = new Point(257, 460);
            pgrsbMeta.Name = "pgrsbMeta";
            pgrsbMeta.Size = new Size(751, 23);
            pgrsbMeta.TabIndex = 3;
            // 
            // labProgressao
            // 
            labProgressao.AutoSize = true;
            labProgressao.Location = new Point(591, 442);
            labProgressao.Name = "labProgressao";
            labProgressao.Size = new Size(78, 15);
            labProgressao.TabIndex = 4;
            labProgressao.Text = "Progressão%:";
            // 
            // labMeta
            // 
            labMeta.AutoSize = true;
            labMeta.Location = new Point(918, 442);
            labMeta.Name = "labMeta";
            labMeta.Size = new Size(37, 15);
            labMeta.TabIndex = 5;
            labMeta.Text = "Meta:";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 3;
            button2.Location = new Point(18, 95);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 6;
            button2.Text = "Ultimas Vendas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmdConsultaPedido
            // 
            cmdConsultaPedido.FlatAppearance.BorderSize = 3;
            cmdConsultaPedido.Location = new Point(132, 95);
            cmdConsultaPedido.Name = "cmdConsultaPedido";
            cmdConsultaPedido.Size = new Size(113, 44);
            cmdConsultaPedido.TabIndex = 7;
            cmdConsultaPedido.Text = "Consulta Pedidos";
            cmdConsultaPedido.UseVisualStyleBackColor = true;
            cmdConsultaPedido.Click += cmdConsultaPedido_Click;
            // 
            // grdUltimasVendas
            // 
            grdUltimasVendas.AllowUserToAddRows = false;
            grdUltimasVendas.AllowUserToDeleteRows = false;
            grdUltimasVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUltimasVendas.Columns.AddRange(new DataGridViewColumn[] { DataVenda, VRazao, VValor });
            grdUltimasVendas.Location = new Point(638, 159);
            grdUltimasVendas.Name = "grdUltimasVendas";
            grdUltimasVendas.ReadOnly = true;
            grdUltimasVendas.RowHeadersWidth = 5;
            grdUltimasVendas.RowTemplate.Height = 25;
            grdUltimasVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUltimasVendas.Size = new Size(370, 280);
            grdUltimasVendas.TabIndex = 8;
            // 
            // DataVenda
            // 
            DataVenda.HeaderText = "Data";
            DataVenda.Name = "DataVenda";
            DataVenda.ReadOnly = true;
            DataVenda.Width = 75;
            // 
            // VRazao
            // 
            VRazao.HeaderText = "Razao Social";
            VRazao.Name = "VRazao";
            VRazao.ReadOnly = true;
            VRazao.Width = 210;
            // 
            // VValor
            // 
            VValor.HeaderText = "Valor";
            VValor.Name = "VValor";
            VValor.ReadOnly = true;
            VValor.Width = 70;
            // 
            // grdUltContato
            // 
            grdUltContato.AllowUserToAddRows = false;
            grdUltContato.AllowUserToDeleteRows = false;
            grdUltContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUltContato.Columns.AddRange(new DataGridViewColumn[] { UltContato, RazSocial, Numero });
            grdUltContato.Location = new Point(257, 159);
            grdUltContato.Name = "grdUltContato";
            grdUltContato.ReadOnly = true;
            grdUltContato.RowHeadersWidth = 5;
            grdUltContato.RowTemplate.Height = 25;
            grdUltContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUltContato.Size = new Size(370, 280);
            grdUltContato.TabIndex = 9;
            // 
            // UltContato
            // 
            UltContato.HeaderText = "Ult.Contato";
            UltContato.Name = "UltContato";
            UltContato.ReadOnly = true;
            UltContato.Width = 75;
            // 
            // RazSocial
            // 
            RazSocial.HeaderText = "Razao Social";
            RazSocial.Name = "RazSocial";
            RazSocial.ReadOnly = true;
            RazSocial.Width = 210;
            // 
            // Numero
            // 
            Numero.HeaderText = "Nº";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            Numero.Width = 40;
            // 
            // cmdRegistraContatos
            // 
            cmdRegistraContatos.FlatAppearance.BorderSize = 3;
            cmdRegistraContatos.Location = new Point(18, 45);
            cmdRegistraContatos.Name = "cmdRegistraContatos";
            cmdRegistraContatos.Size = new Size(113, 44);
            cmdRegistraContatos.TabIndex = 10;
            cmdRegistraContatos.Text = "Registrar contato";
            cmdRegistraContatos.UseVisualStyleBackColor = true;
            cmdRegistraContatos.Click += cmdRegistraContatos_Click;
            // 
            // txtObjetivoDiario
            // 
            txtObjetivoDiario.Location = new Point(132, 273);
            txtObjetivoDiario.Name = "txtObjetivoDiario";
            txtObjetivoDiario.ReadOnly = true;
            txtObjetivoDiario.Size = new Size(113, 23);
            txtObjetivoDiario.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(18, 276);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 12;
            label4.Text = "Objetivo Diario";
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(257, 133);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 14;
            label6.Text = "Clientes não contatados: ";
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(638, 133);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 15;
            label7.Text = "Ultimas Vendas:";
            // 
            // cmdPedidos
            // 
            cmdPedidos.Location = new Point(18, 145);
            cmdPedidos.Name = "cmdPedidos";
            cmdPedidos.Size = new Size(113, 44);
            cmdPedidos.TabIndex = 16;
            cmdPedidos.Text = "Pedidos";
            cmdPedidos.UseVisualStyleBackColor = true;
            cmdPedidos.Click += cmdPedidos_Click;
            // 
            // cmdCadastroProduto
            // 
            cmdCadastroProduto.Location = new Point(132, 195);
            cmdCadastroProduto.Name = "cmdCadastroProduto";
            cmdCadastroProduto.Size = new Size(113, 44);
            cmdCadastroProduto.TabIndex = 17;
            cmdCadastroProduto.Text = "Produtos";
            cmdCadastroProduto.UseVisualStyleBackColor = true;
            cmdCadastroProduto.Click += cmdCadastroProduto_Click;
            // 
            // cmdCadastrosEmpresas
            // 
            cmdCadastrosEmpresas.Location = new Point(18, 195);
            cmdCadastrosEmpresas.Name = "cmdCadastrosEmpresas";
            cmdCadastrosEmpresas.Size = new Size(113, 44);
            cmdCadastrosEmpresas.TabIndex = 18;
            cmdCadastrosEmpresas.Text = "Cadastros";
            cmdCadastrosEmpresas.UseVisualStyleBackColor = true;
            cmdCadastrosEmpresas.Click += cmdCadastrosEmpresas_Click;
            // 
            // button8
            // 
            button8.Location = new Point(132, 145);
            button8.Name = "button8";
            button8.Size = new Size(113, 44);
            button8.TabIndex = 19;
            button8.Text = "Relatórios";
            button8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(18, 246);
            label8.Name = "label8";
            label8.Size = new Size(100, 17);
            label8.TabIndex = 21;
            label8.Text = "Não Consolidado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 243);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 9);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 22;
            label9.Text = "Vendedor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(18, 24);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 23;
            label10.Text = "Empresa:";
            // 
            // grdAvisos
            // 
            grdAvisos.AllowUserToAddRows = false;
            grdAvisos.AllowUserToDeleteRows = false;
            grdAvisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAvisos.Columns.AddRange(new DataGridViewColumn[] { avTexto, grdDatainicio, grdDataTermino });
            grdAvisos.Location = new Point(257, 33);
            grdAvisos.Name = "grdAvisos";
            grdAvisos.ReadOnly = true;
            grdAvisos.RowHeadersWidth = 5;
            grdAvisos.RowTemplate.Height = 25;
            grdAvisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAvisos.Size = new Size(750, 97);
            grdAvisos.TabIndex = 24;
            // 
            // avTexto
            // 
            avTexto.HeaderText = "Aviso";
            avTexto.Name = "avTexto";
            avTexto.ReadOnly = true;
            avTexto.Width = 500;
            // 
            // grdDatainicio
            // 
            grdDatainicio.HeaderText = "Data Inicio";
            grdDatainicio.Name = "grdDatainicio";
            grdDatainicio.ReadOnly = true;
            // 
            // grdDataTermino
            // 
            grdDataTermino.HeaderText = "Data Termino";
            grdDataTermino.Name = "grdDataTermino";
            grdDataTermino.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(257, 9);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 25;
            label5.Text = "Avisos:";
            // 
            // grdContatosAgendados
            // 
            grdContatosAgendados.AllowUserToAddRows = false;
            grdContatosAgendados.AllowUserToDeleteRows = false;
            grdContatosAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContatosAgendados.Columns.AddRange(new DataGridViewColumn[] { grdID, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            grdContatosAgendados.Location = new Point(1018, 33);
            grdContatosAgendados.MultiSelect = false;
            grdContatosAgendados.Name = "grdContatosAgendados";
            grdContatosAgendados.ReadOnly = true;
            grdContatosAgendados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdContatosAgendados.RowHeadersWidth = 5;
            grdContatosAgendados.RowTemplate.Height = 25;
            grdContatosAgendados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContatosAgendados.Size = new Size(230, 406);
            grdContatosAgendados.TabIndex = 26;
            grdContatosAgendados.DoubleClick += grdContatosAgendados_DoubleClick;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Data";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Razao Social";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // labContatos
            // 
            labContatos.AutoSize = true;
            labContatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labContatos.Location = new Point(1013, 15);
            labContatos.Name = "labContatos";
            labContatos.Size = new Size(58, 15);
            labContatos.TabIndex = 27;
            labContatos.Text = "Contatar:";
            // 
            // cmdNatOperacao
            // 
            cmdNatOperacao.Location = new Point(1080, 445);
            cmdNatOperacao.Name = "cmdNatOperacao";
            cmdNatOperacao.Size = new Size(168, 23);
            cmdNatOperacao.TabIndex = 28;
            cmdNatOperacao.Text = "Nat. Operação";
            cmdNatOperacao.UseVisualStyleBackColor = true;
            cmdNatOperacao.Click += cmdNatOperacao_Click;
            // 
            // labNomeUsuario
            // 
            labNomeUsuario.AutoSize = true;
            labNomeUsuario.Location = new Point(88, 9);
            labNomeUsuario.Name = "labNomeUsuario";
            labNomeUsuario.Size = new Size(0, 15);
            labNomeUsuario.TabIndex = 29;
            // 
            // cmdParametros
            // 
            cmdParametros.Location = new Point(1080, 474);
            cmdParametros.Name = "cmdParametros";
            cmdParametros.Size = new Size(168, 23);
            cmdParametros.TabIndex = 30;
            cmdParametros.Text = "Parametros";
            cmdParametros.UseVisualStyleBackColor = true;
            cmdParametros.Click += cmdParametros_Click;
            // 
            // cmdCriarAviso
            // 
            cmdCriarAviso.BackgroundImage = Properties.Resources.adicionar;
            cmdCriarAviso.BackgroundImageLayout = ImageLayout.Zoom;
            cmdCriarAviso.Location = new Point(987, 12);
            cmdCriarAviso.Name = "cmdCriarAviso";
            cmdCriarAviso.Size = new Size(20, 20);
            cmdCriarAviso.TabIndex = 31;
            cmdCriarAviso.UseVisualStyleBackColor = true;
            cmdCriarAviso.Click += cmdCriarAviso_Click;
            // 
            // labVlrProgressao
            // 
            labVlrProgressao.AutoSize = true;
            labVlrProgressao.Location = new Point(675, 442);
            labVlrProgressao.Name = "labVlrProgressao";
            labVlrProgressao.Size = new Size(46, 15);
            labVlrProgressao.TabIndex = 32;
            labVlrProgressao.Text = "xxxx,xx";
            // 
            // labVlrConsolidado
            // 
            labVlrConsolidado.AutoSize = true;
            labVlrConsolidado.Location = new Point(340, 442);
            labVlrConsolidado.Name = "labVlrConsolidado";
            labVlrConsolidado.Size = new Size(46, 15);
            labVlrConsolidado.TabIndex = 33;
            labVlrConsolidado.Text = "xxxx,xx";
            // 
            // labVlrMeta
            // 
            labVlrMeta.AutoSize = true;
            labVlrMeta.Location = new Point(961, 442);
            labVlrMeta.Name = "labVlrMeta";
            labVlrMeta.Size = new Size(46, 15);
            labVlrMeta.TabIndex = 34;
            labVlrMeta.Text = "xxxx,xx";
            // 
            // cmdAgendarContato
            // 
            cmdAgendarContato.BackgroundImage = Properties.Resources.adicionar;
            cmdAgendarContato.BackgroundImageLayout = ImageLayout.Zoom;
            cmdAgendarContato.Location = new Point(225, 302);
            cmdAgendarContato.Name = "cmdAgendarContato";
            cmdAgendarContato.Size = new Size(20, 20);
            cmdAgendarContato.TabIndex = 35;
            cmdAgendarContato.UseVisualStyleBackColor = true;
            cmdAgendarContato.Click += cmdAgendarContato_Click;
            // 
            // labAgendarContato
            // 
            labAgendarContato.AutoSize = true;
            labAgendarContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labAgendarContato.Location = new Point(18, 305);
            labAgendarContato.Name = "labAgendarContato";
            labAgendarContato.Size = new Size(104, 15);
            labAgendarContato.TabIndex = 36;
            labAgendarContato.Text = "Agendar Contato:";
            // 
            // labNomeEmpresa
            // 
            labNomeEmpresa.AutoSize = true;
            labNomeEmpresa.Location = new Point(82, 24);
            labNomeEmpresa.Name = "labNomeEmpresa";
            labNomeEmpresa.Size = new Size(0, 15);
            labNomeEmpresa.TabIndex = 37;
            // 
            // frmCRMInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 501);
            Controls.Add(labNomeEmpresa);
            Controls.Add(labAgendarContato);
            Controls.Add(cmdAgendarContato);
            Controls.Add(labVlrMeta);
            Controls.Add(labVlrConsolidado);
            Controls.Add(labVlrProgressao);
            Controls.Add(cmdCriarAviso);
            Controls.Add(cmdParametros);
            Controls.Add(labNomeUsuario);
            Controls.Add(cmdNatOperacao);
            Controls.Add(labContatos);
            Controls.Add(grdContatosAgendados);
            Controls.Add(label5);
            Controls.Add(grdAvisos);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(button8);
            Controls.Add(cmdCadastrosEmpresas);
            Controls.Add(cmdCadastroProduto);
            Controls.Add(cmdPedidos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtObjetivoDiario);
            Controls.Add(cmdRegistraContatos);
            Controls.Add(grdUltContato);
            Controls.Add(grdUltimasVendas);
            Controls.Add(cmdConsultaPedido);
            Controls.Add(button2);
            Controls.Add(labMeta);
            Controls.Add(labProgressao);
            Controls.Add(pgrsbMeta);
            Controls.Add(labConsolidado);
            Controls.Add(cmdMeusClientes);
            Controls.Add(CalendarioContatos);
            Name = "frmCRMInicial";
            Text = "CRM - GPA";
            Load += frmCRMInicial_Load;
            ((System.ComponentModel.ISupportInitialize)grdUltimasVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdUltContato).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdAvisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdContatosAgendados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar CalendarioContatos;
        private Button cmdMeusClientes;
        private Label labConsolidado;
        private ProgressBar pgrsbMeta;
        private Label labProgressao;
        private Label labMeta;
        private Button button2;
        private Button cmdConsultaPedido;
        private DataGridView grdUltimasVendas;
        private DataGridView grdUltContato;
        private Button cmdRegistraContatos;
        private TextBox txtObjetivoDiario;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button cmdPedidos;
        private Button cmdCadastroProduto;
        private Button cmdCadastrosEmpresas;
        private Button button8;
        private Label label8;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Dispensar;
        private Label label9;
        private Label label10;
        private DataGridView grdAvisos;
        private Label label5;
        private DataGridView grdContatosAgendados;
        private Label labContatos;
        private Button cmdNatOperacao;
        private Label labNomeUsuario;
        private Button cmdParametros;
        private Button cmdCriarAviso;
        private Label labVlrProgressao;
        private Label labVlrConsolidado;
        private Label labVlrMeta;
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewTextBoxColumn VRazao;
        private DataGridViewTextBoxColumn VValor;
        private DataGridViewTextBoxColumn UltContato;
        private DataGridViewTextBoxColumn RazSocial;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn avTexto;
        private DataGridViewTextBoxColumn grdDatainicio;
        private DataGridViewTextBoxColumn grdDataTermino;
        private Button cmdAgendarContato;
        private Label labAgendarContato;
        private Label labNomeEmpresa;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}