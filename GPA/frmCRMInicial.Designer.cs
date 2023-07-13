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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRMInicial));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            labVlrProgressao = new Label();
            labVlrConsolidado = new Label();
            labVlrMeta = new Label();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            MnuCadEmpresas = new ToolStripMenuItem();
            MnuCadProdutos = new ToolStripMenuItem();
            MnuNatOperacao = new ToolStripMenuItem();
            mnuCadastraAvisos = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            MnuPedidos = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            MnuUltimasVendas = new ToolStripMenuItem();
            MnuConsultaPedidos = new ToolStripMenuItem();
            MnuMeusClientes = new ToolStripMenuItem();
            mnuBuscaCadastros = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            rankingDeVendasToolStripMenuItem = new ToolStripMenuItem();
            vendasPorVendedorToolStripMenuItem = new ToolStripMenuItem();
            registrosDeContatosToolStripMenuItem = new ToolStripMenuItem();
            parametrosToolStripMenuItem = new ToolStripMenuItem();
            MnuParametros = new ToolStripMenuItem();
            controleContatoToolStripMenuItem = new ToolStripMenuItem();
            MnuRegistraContato = new ToolStripMenuItem();
            mnuAvisos = new ToolStripMenuItem();
            mnuContatosAgendados = new ToolStripMenuItem();
            NotifyAvisos = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            chrtVendasMesaMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            NotifyAgendaContato = new NotifyIcon(components);
            mnuCadAgendarContatos = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdUltimasVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdUltContato).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtVendasMesaMes).BeginInit();
            SuspendLayout();
            // 
            // labConsolidado
            // 
            resources.ApplyResources(labConsolidado, "labConsolidado");
            labConsolidado.BackColor = Color.Transparent;
            labConsolidado.Name = "labConsolidado";
            // 
            // pgrsbMeta
            // 
            resources.ApplyResources(pgrsbMeta, "pgrsbMeta");
            pgrsbMeta.BackColor = Color.Gainsboro;
            pgrsbMeta.ForeColor = Color.Gainsboro;
            pgrsbMeta.MarqueeAnimationSpeed = 0;
            pgrsbMeta.Name = "pgrsbMeta";
            pgrsbMeta.Style = ProgressBarStyle.Marquee;
            // 
            // labProgressao
            // 
            resources.ApplyResources(labProgressao, "labProgressao");
            labProgressao.BackColor = Color.Transparent;
            labProgressao.Name = "labProgressao";
            // 
            // labMeta
            // 
            resources.ApplyResources(labMeta, "labMeta");
            labMeta.BackColor = Color.Transparent;
            labMeta.Name = "labMeta";
            // 
            // grdUltimasVendas
            // 
            resources.ApplyResources(grdUltimasVendas, "grdUltimasVendas");
            grdUltimasVendas.AllowUserToAddRows = false;
            grdUltimasVendas.AllowUserToDeleteRows = false;
            grdUltimasVendas.BackgroundColor = SystemColors.GradientActiveCaption;
            grdUltimasVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUltimasVendas.Columns.AddRange(new DataGridViewColumn[] { DataVenda, VRazao, VValor });
            grdUltimasVendas.MultiSelect = false;
            grdUltimasVendas.Name = "grdUltimasVendas";
            grdUltimasVendas.ReadOnly = true;
            grdUltimasVendas.RowTemplate.Height = 25;
            grdUltimasVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // DataVenda
            // 
            resources.ApplyResources(DataVenda, "DataVenda");
            DataVenda.Name = "DataVenda";
            DataVenda.ReadOnly = true;
            // 
            // VRazao
            // 
            resources.ApplyResources(VRazao, "VRazao");
            VRazao.Name = "VRazao";
            VRazao.ReadOnly = true;
            // 
            // VValor
            // 
            resources.ApplyResources(VValor, "VValor");
            VValor.Name = "VValor";
            VValor.ReadOnly = true;
            // 
            // grdUltContato
            // 
            resources.ApplyResources(grdUltContato, "grdUltContato");
            grdUltContato.AllowUserToAddRows = false;
            grdUltContato.AllowUserToDeleteRows = false;
            grdUltContato.BackgroundColor = SystemColors.GradientActiveCaption;
            grdUltContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUltContato.Columns.AddRange(new DataGridViewColumn[] { UltContato, RazSocial, Numero });
            grdUltContato.MultiSelect = false;
            grdUltContato.Name = "grdUltContato";
            grdUltContato.ReadOnly = true;
            grdUltContato.RowTemplate.Height = 25;
            grdUltContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // UltContato
            // 
            resources.ApplyResources(UltContato, "UltContato");
            UltContato.Name = "UltContato";
            UltContato.ReadOnly = true;
            // 
            // RazSocial
            // 
            resources.ApplyResources(RazSocial, "RazSocial");
            RazSocial.Name = "RazSocial";
            RazSocial.ReadOnly = true;
            // 
            // Numero
            // 
            resources.ApplyResources(Numero, "Numero");
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // txtObjetivoDiario
            // 
            resources.ApplyResources(txtObjetivoDiario, "txtObjetivoDiario");
            txtObjetivoDiario.Name = "txtObjetivoDiario";
            txtObjetivoDiario.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Name = "label8";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            // 
            // labVlrProgressao
            // 
            resources.ApplyResources(labVlrProgressao, "labVlrProgressao");
            labVlrProgressao.BackColor = Color.Transparent;
            labVlrProgressao.Name = "labVlrProgressao";
            // 
            // labVlrConsolidado
            // 
            resources.ApplyResources(labVlrConsolidado, "labVlrConsolidado");
            labVlrConsolidado.BackColor = Color.Transparent;
            labVlrConsolidado.Name = "labVlrConsolidado";
            // 
            // labVlrMeta
            // 
            resources.ApplyResources(labVlrMeta, "labVlrMeta");
            labVlrMeta.BackColor = Color.Transparent;
            labVlrMeta.Name = "labVlrMeta";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, vendasToolStripMenuItem, consultasToolStripMenuItem, relatóriosToolStripMenuItem, parametrosToolStripMenuItem, controleContatoToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            resources.ApplyResources(cadastrosToolStripMenuItem, "cadastrosToolStripMenuItem");
            cadastrosToolStripMenuItem.BackColor = Color.Transparent;
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuCadEmpresas, MnuCadProdutos, MnuNatOperacao, mnuCadastraAvisos, mnuCadAgendarContatos });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            // 
            // MnuCadEmpresas
            // 
            resources.ApplyResources(MnuCadEmpresas, "MnuCadEmpresas");
            MnuCadEmpresas.Name = "MnuCadEmpresas";
            MnuCadEmpresas.Click += MnuCadEmpresas_Click;
            // 
            // MnuCadProdutos
            // 
            resources.ApplyResources(MnuCadProdutos, "MnuCadProdutos");
            MnuCadProdutos.Name = "MnuCadProdutos";
            MnuCadProdutos.Click += MnuCadProdutos_Click;
            // 
            // MnuNatOperacao
            // 
            resources.ApplyResources(MnuNatOperacao, "MnuNatOperacao");
            MnuNatOperacao.Name = "MnuNatOperacao";
            MnuNatOperacao.Click += MnuNatOperacao_Click;
            // 
            // mnuCadastraAvisos
            // 
            resources.ApplyResources(mnuCadastraAvisos, "mnuCadastraAvisos");
            mnuCadastraAvisos.Name = "mnuCadastraAvisos";
            mnuCadastraAvisos.Click += mnuCadastraAvisos_Click;
            // 
            // vendasToolStripMenuItem
            // 
            resources.ApplyResources(vendasToolStripMenuItem, "vendasToolStripMenuItem");
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuPedidos });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            // 
            // MnuPedidos
            // 
            resources.ApplyResources(MnuPedidos, "MnuPedidos");
            MnuPedidos.BackColor = Color.Transparent;
            MnuPedidos.Name = "MnuPedidos";
            MnuPedidos.Click += MnuPedidos_Click;
            // 
            // consultasToolStripMenuItem
            // 
            resources.ApplyResources(consultasToolStripMenuItem, "consultasToolStripMenuItem");
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuUltimasVendas, MnuConsultaPedidos, MnuMeusClientes, mnuBuscaCadastros });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            // 
            // MnuUltimasVendas
            // 
            resources.ApplyResources(MnuUltimasVendas, "MnuUltimasVendas");
            MnuUltimasVendas.Name = "MnuUltimasVendas";
            MnuUltimasVendas.Click += MnuUltimasVendas_Click;
            // 
            // MnuConsultaPedidos
            // 
            resources.ApplyResources(MnuConsultaPedidos, "MnuConsultaPedidos");
            MnuConsultaPedidos.Name = "MnuConsultaPedidos";
            MnuConsultaPedidos.Click += MnuConsultaPedidos_Click;
            // 
            // MnuMeusClientes
            // 
            resources.ApplyResources(MnuMeusClientes, "MnuMeusClientes");
            MnuMeusClientes.Name = "MnuMeusClientes";
            MnuMeusClientes.Click += MnuMeusClientes_Click;
            // 
            // mnuBuscaCadastros
            // 
            resources.ApplyResources(mnuBuscaCadastros, "mnuBuscaCadastros");
            mnuBuscaCadastros.Name = "mnuBuscaCadastros";
            mnuBuscaCadastros.Click += mnuBuscaCadastros_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            resources.ApplyResources(relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rankingDeVendasToolStripMenuItem, vendasPorVendedorToolStripMenuItem, registrosDeContatosToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            // 
            // rankingDeVendasToolStripMenuItem
            // 
            resources.ApplyResources(rankingDeVendasToolStripMenuItem, "rankingDeVendasToolStripMenuItem");
            rankingDeVendasToolStripMenuItem.Name = "rankingDeVendasToolStripMenuItem";
            rankingDeVendasToolStripMenuItem.Click += rankingDeVendasToolStripMenuItem_Click;
            // 
            // vendasPorVendedorToolStripMenuItem
            // 
            resources.ApplyResources(vendasPorVendedorToolStripMenuItem, "vendasPorVendedorToolStripMenuItem");
            vendasPorVendedorToolStripMenuItem.Name = "vendasPorVendedorToolStripMenuItem";
            vendasPorVendedorToolStripMenuItem.Click += vendasPorVendedorToolStripMenuItem_Click;
            // 
            // registrosDeContatosToolStripMenuItem
            // 
            resources.ApplyResources(registrosDeContatosToolStripMenuItem, "registrosDeContatosToolStripMenuItem");
            registrosDeContatosToolStripMenuItem.Name = "registrosDeContatosToolStripMenuItem";
            registrosDeContatosToolStripMenuItem.Click += registrosDeContatosToolStripMenuItem_Click;
            // 
            // parametrosToolStripMenuItem
            // 
            resources.ApplyResources(parametrosToolStripMenuItem, "parametrosToolStripMenuItem");
            parametrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuParametros });
            parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            // 
            // MnuParametros
            // 
            resources.ApplyResources(MnuParametros, "MnuParametros");
            MnuParametros.Name = "MnuParametros";
            MnuParametros.Click += MnuParametros_Click;
            // 
            // controleContatoToolStripMenuItem
            // 
            resources.ApplyResources(controleContatoToolStripMenuItem, "controleContatoToolStripMenuItem");
            controleContatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuRegistraContato, mnuAvisos, mnuContatosAgendados });
            controleContatoToolStripMenuItem.Name = "controleContatoToolStripMenuItem";
            // 
            // MnuRegistraContato
            // 
            resources.ApplyResources(MnuRegistraContato, "MnuRegistraContato");
            MnuRegistraContato.Name = "MnuRegistraContato";
            MnuRegistraContato.Click += MnuRegistraContato_Click;
            // 
            // mnuAvisos
            // 
            resources.ApplyResources(mnuAvisos, "mnuAvisos");
            mnuAvisos.Name = "mnuAvisos";
            mnuAvisos.Click += mnuAvisos_Click;
            // 
            // mnuContatosAgendados
            // 
            resources.ApplyResources(mnuContatosAgendados, "mnuContatosAgendados");
            mnuContatosAgendados.Name = "mnuContatosAgendados";
            mnuContatosAgendados.Click += mnuContatosAgendados_Click;
            // 
            // NotifyAvisos
            // 
            resources.ApplyResources(NotifyAvisos, "NotifyAvisos");
            NotifyAvisos.BalloonTipClicked += NotifyAvisos_BalloonTipClicked;
            NotifyAvisos.Click += NotifyAvisos_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // chrtVendasMesaMes
            // 
            resources.ApplyResources(chrtVendasMesaMes, "chrtVendasMesaMes");
            chrtVendasMesaMes.BackColor = Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.BackColor = Color.FromArgb(192, 255, 255);
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.Name = "ChartArea1";
            chrtVendasMesaMes.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.InterlacedRowsColor = Color.Transparent;
            legend1.Name = "Janeiro";
            legend1.Title = "Meses";
            chrtVendasMesaMes.Legends.Add(legend1);
            chrtVendasMesaMes.Name = "chrtVendasMesaMes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Janeiro";
            series1.Name = "Series1";
            chrtVendasMesaMes.Series.Add(series1);
            title1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Vendas Mês a Mês";
            chrtVendasMesaMes.Titles.Add(title1);
            // 
            // NotifyAgendaContato
            // 
            resources.ApplyResources(NotifyAgendaContato, "NotifyAgendaContato");
            NotifyAgendaContato.BalloonTipClicked += NotifyAgendaContato_BalloonTipClicked;
            // 
            // mnuCadAgendarContatos
            // 
            resources.ApplyResources(mnuCadAgendarContatos, "mnuCadAgendarContatos");
            mnuCadAgendarContatos.Name = "mnuCadAgendarContatos";
            mnuCadAgendarContatos.Click += mnuCadAgendarContatos_Click;
            // 
            // frmCRMInicial
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightCyan;
            Controls.Add(chrtVendasMesaMes);
            Controls.Add(pictureBox1);
            Controls.Add(labVlrMeta);
            Controls.Add(labVlrConsolidado);
            Controls.Add(labVlrProgressao);
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
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "frmCRMInicial";
            WindowState = FormWindowState.Maximized;
            Load += frmCRMInicial_Load;
            ((System.ComponentModel.ISupportInitialize)grdUltimasVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdUltContato).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrtVendasMesaMes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label labVlrProgressao;
        private Label labVlrConsolidado;
        private Label labVlrMeta;
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewTextBoxColumn VRazao;
        private DataGridViewTextBoxColumn VValor;
        private DataGridViewTextBoxColumn UltContato;
        private DataGridViewTextBoxColumn RazSocial;
        private DataGridViewTextBoxColumn Numero;
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
        private ToolStripMenuItem mnuBuscaCadastros;
        private ToolStripMenuItem registrosDeContatosToolStripMenuItem;
        private ToolStripMenuItem mnuCadastraAvisos;
        private ToolStripMenuItem mnuAvisos;
        private NotifyIcon NotifyAvisos;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtVendasMesaMes;
        private NotifyIcon NotifyAgendaContato;
        private ToolStripMenuItem mnuContatosAgendados;
        private ToolStripMenuItem mnuCadAgendarContatos;
    }
}