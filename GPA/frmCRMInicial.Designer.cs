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
            labConsolidado = new Label();
            pgrsbMeta = new ProgressBar();
            labProgressao = new Label();
            labMeta = new Label();
            grdUltimasVendas = new DataGridView();
            DataVenda = new DataGridViewTextBoxColumn();
            VRazao = new DataGridViewTextBoxColumn();
            VValor = new DataGridViewTextBoxColumn();
            grdUltContato = new DataGridView();
            UltContato = new DataGridViewTextBoxColumn();
            RazSocial = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            txtObjetivoDiario = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            grdAvisos = new DataGridView();
            avTexto = new DataGridViewTextBoxColumn();
            grdDatainicio = new DataGridViewTextBoxColumn();
            grdDataTermino = new DataGridViewTextBoxColumn();
            label5 = new Label();
            grdContatosAgendados = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cmdCriarAviso = new Button();
            labVlrProgressao = new Label();
            labVlrConsolidado = new Label();
            labVlrMeta = new Label();
            cmdAgendarContato = new Button();
            labAgendarContato = new Label();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            MnuCadEmpresas = new ToolStripMenuItem();
            MnuCadProdutos = new ToolStripMenuItem();
            MnuNatOperacao = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            MnuPedidos = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            MnuUltimasVendas = new ToolStripMenuItem();
            MnuConsultaPedidos = new ToolStripMenuItem();
            MnuMeusClientes = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            rankingDeVendasToolStripMenuItem = new ToolStripMenuItem();
            vendasPorVendedorToolStripMenuItem = new ToolStripMenuItem();
            parametrosToolStripMenuItem = new ToolStripMenuItem();
            MnuParametros = new ToolStripMenuItem();
            controleContatoToolStripMenuItem = new ToolStripMenuItem();
            MnuRegistraContato = new ToolStripMenuItem();
            labNomeEmpresa = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdUltimasVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdUltContato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdAvisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdContatosAgendados).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // CalendarioContatos
            // 
            CalendarioContatos.Location = new Point(15, 123);
            CalendarioContatos.Name = "CalendarioContatos";
            CalendarioContatos.TabIndex = 0;
            CalendarioContatos.KeyDown += CalendarioContatos_KeyDown;
            // 
            // labConsolidado
            // 
            labConsolidado.AutoSize = true;
            labConsolidado.Location = new Point(254, 472);
            labConsolidado.Name = "labConsolidado";
            labConsolidado.Size = new Size(77, 15);
            labConsolidado.TabIndex = 2;
            labConsolidado.Text = "Consolidado:";
            // 
            // pgrsbMeta
            // 
            pgrsbMeta.Location = new Point(254, 490);
            pgrsbMeta.Name = "pgrsbMeta";
            pgrsbMeta.Size = new Size(751, 23);
            pgrsbMeta.TabIndex = 3;
            // 
            // labProgressao
            // 
            labProgressao.AutoSize = true;
            labProgressao.Location = new Point(588, 472);
            labProgressao.Name = "labProgressao";
            labProgressao.Size = new Size(78, 15);
            labProgressao.TabIndex = 4;
            labProgressao.Text = "Progressão%:";
            // 
            // labMeta
            // 
            labMeta.AutoSize = true;
            labMeta.Location = new Point(905, 472);
            labMeta.Name = "labMeta";
            labMeta.Size = new Size(37, 15);
            labMeta.TabIndex = 5;
            labMeta.Text = "Meta:";
            // 
            // grdUltimasVendas
            // 
            grdUltimasVendas.AllowUserToAddRows = false;
            grdUltimasVendas.AllowUserToDeleteRows = false;
            grdUltimasVendas.BackgroundColor = SystemColors.GradientActiveCaption;
            grdUltimasVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUltimasVendas.Columns.AddRange(new DataGridViewColumn[] { DataVenda, VRazao, VValor });
            grdUltimasVendas.Location = new Point(635, 175);
            grdUltimasVendas.Name = "grdUltimasVendas";
            grdUltimasVendas.ReadOnly = true;
            grdUltimasVendas.RowHeadersWidth = 5;
            grdUltimasVendas.RowTemplate.Height = 25;
            grdUltimasVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUltimasVendas.Size = new Size(370, 294);
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
            grdUltContato.BackgroundColor = SystemColors.GradientActiveCaption;
            grdUltContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUltContato.Columns.AddRange(new DataGridViewColumn[] { UltContato, RazSocial, Numero });
            grdUltContato.Location = new Point(254, 175);
            grdUltContato.Name = "grdUltContato";
            grdUltContato.ReadOnly = true;
            grdUltContato.RowHeadersWidth = 5;
            grdUltContato.RowTemplate.Height = 25;
            grdUltContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUltContato.Size = new Size(370, 294);
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
            // txtObjetivoDiario
            // 
            txtObjetivoDiario.Location = new Point(129, 75);
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
            label4.Location = new Point(15, 78);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 12;
            label4.Text = "Objetivo Diario";
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(254, 153);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 14;
            label6.Text = "Clientes não contatados: ";
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(635, 153);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 15;
            label7.Text = "Ultimas Vendas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(15, 48);
            label8.Name = "label8";
            label8.Size = new Size(100, 17);
            label8.TabIndex = 21;
            label8.Text = "Não Consolidado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 45);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 20;
            // 
            // grdAvisos
            // 
            grdAvisos.AllowUserToAddRows = false;
            grdAvisos.AllowUserToDeleteRows = false;
            grdAvisos.BackgroundColor = SystemColors.GradientActiveCaption;
            grdAvisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAvisos.Columns.AddRange(new DataGridViewColumn[] { avTexto, grdDatainicio, grdDataTermino });
            grdAvisos.Location = new Point(254, 45);
            grdAvisos.Name = "grdAvisos";
            grdAvisos.ReadOnly = true;
            grdAvisos.RowHeadersWidth = 5;
            grdAvisos.RowTemplate.Height = 25;
            grdAvisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAvisos.Size = new Size(750, 105);
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
            label5.Location = new Point(254, 27);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 25;
            label5.Text = "Avisos:";
            // 
            // grdContatosAgendados
            // 
            grdContatosAgendados.AllowUserToAddRows = false;
            grdContatosAgendados.AllowUserToDeleteRows = false;
            grdContatosAgendados.BackgroundColor = SystemColors.GradientActiveCaption;
            grdContatosAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContatosAgendados.Columns.AddRange(new DataGridViewColumn[] { grdID, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            grdContatosAgendados.Location = new Point(12, 297);
            grdContatosAgendados.MultiSelect = false;
            grdContatosAgendados.Name = "grdContatosAgendados";
            grdContatosAgendados.ReadOnly = true;
            grdContatosAgendados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdContatosAgendados.RowHeadersWidth = 5;
            grdContatosAgendados.RowTemplate.Height = 25;
            grdContatosAgendados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContatosAgendados.Size = new Size(230, 216);
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
            // cmdCriarAviso
            // 
            cmdCriarAviso.BackgroundImage = Properties.Resources.adicionar;
            cmdCriarAviso.BackgroundImageLayout = ImageLayout.Zoom;
            cmdCriarAviso.Location = new Point(984, 24);
            cmdCriarAviso.Name = "cmdCriarAviso";
            cmdCriarAviso.Size = new Size(20, 20);
            cmdCriarAviso.TabIndex = 31;
            cmdCriarAviso.UseVisualStyleBackColor = true;
            cmdCriarAviso.Click += cmdCriarAviso_Click;
            // 
            // labVlrProgressao
            // 
            labVlrProgressao.AutoSize = true;
            labVlrProgressao.Location = new Point(672, 472);
            labVlrProgressao.Name = "labVlrProgressao";
            labVlrProgressao.Size = new Size(46, 15);
            labVlrProgressao.TabIndex = 32;
            labVlrProgressao.Text = "xxxx,xx";
            // 
            // labVlrConsolidado
            // 
            labVlrConsolidado.AutoSize = true;
            labVlrConsolidado.Location = new Point(337, 472);
            labVlrConsolidado.Name = "labVlrConsolidado";
            labVlrConsolidado.Size = new Size(46, 15);
            labVlrConsolidado.TabIndex = 33;
            labVlrConsolidado.Text = "xxxx,xx";
            // 
            // labVlrMeta
            // 
            labVlrMeta.AutoSize = true;
            labVlrMeta.Location = new Point(942, 472);
            labVlrMeta.Name = "labVlrMeta";
            labVlrMeta.Size = new Size(46, 15);
            labVlrMeta.TabIndex = 34;
            labVlrMeta.Text = "xxxx,xx";
            // 
            // cmdAgendarContato
            // 
            cmdAgendarContato.BackgroundImage = Properties.Resources.adicionar;
            cmdAgendarContato.BackgroundImageLayout = ImageLayout.Zoom;
            cmdAgendarContato.Location = new Point(222, 102);
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
            labAgendarContato.Location = new Point(15, 107);
            labAgendarContato.Name = "labAgendarContato";
            labAgendarContato.Size = new Size(104, 15);
            labAgendarContato.TabIndex = 36;
            labAgendarContato.Text = "Agendar Contato:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, vendasToolStripMenuItem, consultasToolStripMenuItem, relatóriosToolStripMenuItem, parametrosToolStripMenuItem, controleContatoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1045, 24);
            menuStrip1.TabIndex = 38;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuCadEmpresas, MnuCadProdutos, MnuNatOperacao });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // MnuCadEmpresas
            // 
            MnuCadEmpresas.Name = "MnuCadEmpresas";
            MnuCadEmpresas.Size = new Size(150, 22);
            MnuCadEmpresas.Text = "Empresas";
            MnuCadEmpresas.Click += MnuCadEmpresas_Click;
            // 
            // MnuCadProdutos
            // 
            MnuCadProdutos.Name = "MnuCadProdutos";
            MnuCadProdutos.Size = new Size(150, 22);
            MnuCadProdutos.Text = "Produtos";
            MnuCadProdutos.Click += MnuCadProdutos_Click;
            // 
            // MnuNatOperacao
            // 
            MnuNatOperacao.Name = "MnuNatOperacao";
            MnuNatOperacao.Size = new Size(150, 22);
            MnuNatOperacao.Text = "Nat. Operação";
            MnuNatOperacao.Click += MnuNatOperacao_Click;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuPedidos });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(103, 20);
            vendasToolStripMenuItem.Text = "Pedidos\\Vendas";
            // 
            // MnuPedidos
            // 
            MnuPedidos.Name = "MnuPedidos";
            MnuPedidos.Size = new Size(116, 22);
            MnuPedidos.Text = "Pedidos";
            MnuPedidos.Click += MnuPedidos_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuUltimasVendas, MnuConsultaPedidos, MnuMeusClientes });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // MnuUltimasVendas
            // 
            MnuUltimasVendas.Name = "MnuUltimasVendas";
            MnuUltimasVendas.Size = new Size(166, 22);
            MnuUltimasVendas.Text = "Ultimas Vendas";
            MnuUltimasVendas.Click += MnuUltimasVendas_Click;
            // 
            // MnuConsultaPedidos
            // 
            MnuConsultaPedidos.Name = "MnuConsultaPedidos";
            MnuConsultaPedidos.Size = new Size(166, 22);
            MnuConsultaPedidos.Text = "Consulta Pedidos";
            MnuConsultaPedidos.Click += MnuConsultaPedidos_Click;
            // 
            // MnuMeusClientes
            // 
            MnuMeusClientes.Name = "MnuMeusClientes";
            MnuMeusClientes.Size = new Size(166, 22);
            MnuMeusClientes.Text = "Meus Clientes";
            MnuMeusClientes.Click += MnuMeusClientes_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rankingDeVendasToolStripMenuItem, vendasPorVendedorToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // rankingDeVendasToolStripMenuItem
            // 
            rankingDeVendasToolStripMenuItem.Name = "rankingDeVendasToolStripMenuItem";
            rankingDeVendasToolStripMenuItem.Size = new Size(185, 22);
            rankingDeVendasToolStripMenuItem.Text = "Ranking de Vendas";
            rankingDeVendasToolStripMenuItem.Visible = false;
            rankingDeVendasToolStripMenuItem.Click += rankingDeVendasToolStripMenuItem_Click;
            // 
            // vendasPorVendedorToolStripMenuItem
            // 
            vendasPorVendedorToolStripMenuItem.Name = "vendasPorVendedorToolStripMenuItem";
            vendasPorVendedorToolStripMenuItem.Size = new Size(185, 22);
            vendasPorVendedorToolStripMenuItem.Text = "Vendas por Vendedor";
            vendasPorVendedorToolStripMenuItem.Click += vendasPorVendedorToolStripMenuItem_Click;
            // 
            // parametrosToolStripMenuItem
            // 
            parametrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuParametros });
            parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            parametrosToolStripMenuItem.Size = new Size(86, 20);
            parametrosToolStripMenuItem.Text = "Manutenção";
            // 
            // MnuParametros
            // 
            MnuParametros.Name = "MnuParametros";
            MnuParametros.Size = new Size(134, 22);
            MnuParametros.Text = "Parametros";
            MnuParametros.Click += MnuParametros_Click;
            // 
            // controleContatoToolStripMenuItem
            // 
            controleContatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuRegistraContato });
            controleContatoToolStripMenuItem.Name = "controleContatoToolStripMenuItem";
            controleContatoToolStripMenuItem.Size = new Size(113, 20);
            controleContatoToolStripMenuItem.Text = "Controle\\Contato";
            // 
            // MnuRegistraContato
            // 
            MnuRegistraContato.Name = "MnuRegistraContato";
            MnuRegistraContato.Size = new Size(167, 22);
            MnuRegistraContato.Text = "Registra Contatos";
            MnuRegistraContato.Click += MnuRegistraContato_Click;
            // 
            // labNomeEmpresa
            // 
            labNomeEmpresa.AutoSize = true;
            labNomeEmpresa.Location = new Point(78, 27);
            labNomeEmpresa.Name = "labNomeEmpresa";
            labNomeEmpresa.Size = new Size(0, 15);
            labNomeEmpresa.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(15, 27);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 40;
            label10.Text = "Empresa:";
            // 
            // frmCRMInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1045, 526);
            Controls.Add(labNomeEmpresa);
            Controls.Add(label10);
            Controls.Add(labAgendarContato);
            Controls.Add(cmdAgendarContato);
            Controls.Add(labVlrMeta);
            Controls.Add(labVlrConsolidado);
            Controls.Add(labVlrProgressao);
            Controls.Add(cmdCriarAviso);
            Controls.Add(grdContatosAgendados);
            Controls.Add(label5);
            Controls.Add(grdAvisos);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtObjetivoDiario);
            Controls.Add(grdUltContato);
            Controls.Add(grdUltimasVendas);
            Controls.Add(labMeta);
            Controls.Add(labProgressao);
            Controls.Add(pgrsbMeta);
            Controls.Add(labConsolidado);
            Controls.Add(CalendarioContatos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmCRMInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GPA - Home";
            Load += frmCRMInicial_Load;
            ((System.ComponentModel.ISupportInitialize)grdUltimasVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdUltContato).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdAvisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdContatosAgendados).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar CalendarioContatos;
        private Label labConsolidado;
        private ProgressBar pgrsbMeta;
        private Label labProgressao;
        private Label labMeta;
        private DataGridView grdUltimasVendas;
        private DataGridView grdUltContato;
        private TextBox txtObjetivoDiario;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Dispensar;
        private DataGridView grdAvisos;
        private Label label5;
        private DataGridView grdContatosAgendados;
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
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem parametrosToolStripMenuItem;
        private ToolStripMenuItem rankingDeVendasToolStripMenuItem;
        private ToolStripMenuItem MnuParametros;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem MnuCadEmpresas;
        private ToolStripMenuItem MnuCadProdutos;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem MnuPedidos;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem MnuUltimasVendas;
        private ToolStripMenuItem MnuConsultaPedidos;
        private ToolStripMenuItem MnuMeusClientes;
        private ToolStripMenuItem controleContatoToolStripMenuItem;
        private ToolStripMenuItem MnuRegistraContato;
        private ToolStripMenuItem MnuNatOperacao;
        private Label labNomeEmpresa;
        private Label label10;
        private ToolStripMenuItem vendasPorVendedorToolStripMenuItem;
    }
}