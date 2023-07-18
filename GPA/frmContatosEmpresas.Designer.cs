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
            labEmpresa = new Label();
            txtEmpresa = new TextBox();
            lbCabeçallho = new Label();
            cmdExcluir = new Button();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            labDataContato = new Label();
            txtRegistro = new TextBox();
            labRegistro = new Label();
            txtDataContato = new MaskedTextBox();
            labCtt1 = new Label();
            TxtContato1 = new MaskedTextBox();
            TxtContato2 = new MaskedTextBox();
            labCtt2 = new Label();
            cmdContatos = new Button();
            grdRegistros = new DataGridView();
            grdIDRegistro = new DataGridViewTextBoxColumn();
            grdData = new DataGridViewTextBoxColumn();
            grdRegistro = new DataGridViewTextBoxColumn();
            labListaRegistros = new Label();
            txtTranscricao = new TextBox();
            labTranscricao = new Label();
            ((System.ComponentModel.ISupportInitialize)grdRegistros).BeginInit();
            SuspendLayout();
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.BackColor = Color.Transparent;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(12, 42);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 0;
            labEmpresa.Text = "Empresa - F1";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmpresa.Location = new Point(12, 60);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(771, 23);
            txtEmpresa.TabIndex = 1;
            txtEmpresa.KeyDown += txtEmpresa_KeyDown;
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbCabeçallho.BackColor = Color.Transparent;
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 3);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(843, 30);
            lbCabeçallho.TabIndex = 3;
            lbCabeçallho.Text = "Contatos com Empresas";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdExcluir
            // 
            cmdExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdExcluir.Location = new Point(861, 3);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(30, 30);
            cmdExcluir.TabIndex = 14;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(897, 3);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 15;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(933, 3);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 16;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(969, 3);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 17;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // labDataContato
            // 
            labDataContato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labDataContato.AutoSize = true;
            labDataContato.BackColor = Color.Transparent;
            labDataContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDataContato.Location = new Point(787, 42);
            labDataContato.Name = "labDataContato";
            labDataContato.Size = new Size(80, 15);
            labDataContato.TabIndex = 51;
            labDataContato.Text = "Data Contato";
            // 
            // txtRegistro
            // 
            txtRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRegistro.Location = new Point(11, 165);
            txtRegistro.Multiline = true;
            txtRegistro.Name = "txtRegistro";
            txtRegistro.ScrollBars = ScrollBars.Vertical;
            txtRegistro.Size = new Size(987, 170);
            txtRegistro.TabIndex = 6;
            // 
            // labRegistro
            // 
            labRegistro.AutoSize = true;
            labRegistro.BackColor = Color.Transparent;
            labRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labRegistro.Location = new Point(12, 147);
            labRegistro.Name = "labRegistro";
            labRegistro.Size = new Size(54, 15);
            labRegistro.TabIndex = 54;
            labRegistro.Text = "Registro";
            // 
            // txtDataContato
            // 
            txtDataContato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDataContato.Location = new Point(789, 60);
            txtDataContato.Mask = "00/00/0000";
            txtDataContato.Name = "txtDataContato";
            txtDataContato.Size = new Size(100, 23);
            txtDataContato.TabIndex = 2;
            txtDataContato.ValidatingType = typeof(DateTime);
            txtDataContato.Leave += txtDataContato_Leave;
            // 
            // labCtt1
            // 
            labCtt1.AutoSize = true;
            labCtt1.BackColor = Color.Transparent;
            labCtt1.Location = new Point(12, 86);
            labCtt1.Name = "labCtt1";
            labCtt1.Size = new Size(59, 15);
            labCtt1.TabIndex = 70;
            labCtt1.Text = "Contato 1";
            labCtt1.Visible = false;
            // 
            // TxtContato1
            // 
            TxtContato1.Location = new Point(12, 104);
            TxtContato1.Mask = "(99) 00000-0000";
            TxtContato1.Name = "TxtContato1";
            TxtContato1.Size = new Size(130, 23);
            TxtContato1.TabIndex = 3;
            TxtContato1.Visible = false;
            // 
            // TxtContato2
            // 
            TxtContato2.Location = new Point(148, 104);
            TxtContato2.Mask = "(99) 00000-0000";
            TxtContato2.Name = "TxtContato2";
            TxtContato2.Size = new Size(130, 23);
            TxtContato2.TabIndex = 4;
            TxtContato2.Visible = false;
            // 
            // labCtt2
            // 
            labCtt2.AutoSize = true;
            labCtt2.BackColor = Color.Transparent;
            labCtt2.Location = new Point(148, 86);
            labCtt2.Name = "labCtt2";
            labCtt2.Size = new Size(59, 15);
            labCtt2.TabIndex = 72;
            labCtt2.Text = "Contato 2";
            labCtt2.Visible = false;
            // 
            // cmdContatos
            // 
            cmdContatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmdContatos.Location = new Point(900, 56);
            cmdContatos.Name = "cmdContatos";
            cmdContatos.Size = new Size(99, 29);
            cmdContatos.TabIndex = 5;
            cmdContatos.Text = "Contatos";
            cmdContatos.UseVisualStyleBackColor = true;
            cmdContatos.Click += cmdContatos_Click;
            // 
            // grdRegistros
            // 
            grdRegistros.AllowUserToAddRows = false;
            grdRegistros.AllowUserToDeleteRows = false;
            grdRegistros.AllowUserToResizeRows = false;
            grdRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grdRegistros.BackgroundColor = SystemColors.GradientActiveCaption;
            grdRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRegistros.Columns.AddRange(new DataGridViewColumn[] { grdIDRegistro, grdData, grdRegistro });
            grdRegistros.Location = new Point(11, 356);
            grdRegistros.MultiSelect = false;
            grdRegistros.Name = "grdRegistros";
            grdRegistros.ReadOnly = true;
            grdRegistros.RowHeadersVisible = false;
            grdRegistros.RowTemplate.Height = 25;
            grdRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdRegistros.Size = new Size(984, 170);
            grdRegistros.TabIndex = 13;
            grdRegistros.SelectionChanged += grdRegistros_SelectionChanged;
            // 
            // grdIDRegistro
            // 
            grdIDRegistro.HeaderText = "ID";
            grdIDRegistro.Name = "grdIDRegistro";
            grdIDRegistro.ReadOnly = true;
            grdIDRegistro.Visible = false;
            // 
            // grdData
            // 
            grdData.HeaderText = "Data";
            grdData.Name = "grdData";
            grdData.ReadOnly = true;
            // 
            // grdRegistro
            // 
            grdRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grdRegistro.HeaderText = "Registro";
            grdRegistro.Name = "grdRegistro";
            grdRegistro.ReadOnly = true;
            // 
            // labListaRegistros
            // 
            labListaRegistros.AutoSize = true;
            labListaRegistros.BackColor = Color.Transparent;
            labListaRegistros.Location = new Point(11, 338);
            labListaRegistros.Name = "labListaRegistros";
            labListaRegistros.Size = new Size(55, 15);
            labListaRegistros.TabIndex = 57;
            labListaRegistros.Text = "Registros";
            // 
            // txtTranscricao
            // 
            txtTranscricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTranscricao.BackColor = Color.Gainsboro;
            txtTranscricao.Location = new Point(11, 547);
            txtTranscricao.Multiline = true;
            txtTranscricao.Name = "txtTranscricao";
            txtTranscricao.ReadOnly = true;
            txtTranscricao.ScrollBars = ScrollBars.Vertical;
            txtTranscricao.Size = new Size(984, 170);
            txtTranscricao.TabIndex = 73;
            // 
            // labTranscricao
            // 
            labTranscricao.AutoSize = true;
            labTranscricao.BackColor = Color.Transparent;
            labTranscricao.Location = new Point(12, 529);
            labTranscricao.Name = "labTranscricao";
            labTranscricao.Size = new Size(66, 15);
            labTranscricao.TabIndex = 74;
            labTranscricao.Text = "Transcrição";
            // 
            // frmContatosEmpresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1008, 729);
            ControlBox = false;
            Controls.Add(labTranscricao);
            Controls.Add(txtTranscricao);
            Controls.Add(cmdContatos);
            Controls.Add(TxtContato2);
            Controls.Add(labCtt2);
            Controls.Add(TxtContato1);
            Controls.Add(labCtt1);
            Controls.Add(txtDataContato);
            Controls.Add(labListaRegistros);
            Controls.Add(labRegistro);
            Controls.Add(txtRegistro);
            Controls.Add(grdRegistros);
            Controls.Add(labDataContato);
            Controls.Add(cmdExcluir);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(lbCabeçallho);
            Controls.Add(txtEmpresa);
            Controls.Add(labEmpresa);
            Name = "frmContatosEmpresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contatos Empresas";
            Load += frmContatosEmpresas_Load;
            ((System.ComponentModel.ISupportInitialize)grdRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labEmpresa;
        private TextBox txtEmpresa;
        private Label lbCabeçallho;
        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private Label labDataContato;
        private Label labRegistro;
        private TextBox txtRegistro;
        private MaskedTextBox txtDataContato;
        private Label labCtt1;
        private MaskedTextBox TxtContato1;
        private MaskedTextBox TxtContato2;
        private Label labCtt2;
        private Button cmdContatos;
        private DataGridView grdRegistros;
        private Label labListaRegistros;
        private TextBox txtTranscricao;
        private Label labTranscricao;
        private DataGridViewTextBoxColumn grdIDRegistro;
        private DataGridViewTextBoxColumn grdData;
        private DataGridViewTextBoxColumn grdRegistro;
    }
}