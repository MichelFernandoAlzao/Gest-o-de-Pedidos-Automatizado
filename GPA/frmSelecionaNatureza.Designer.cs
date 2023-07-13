namespace Formularios
{
    partial class frmSelecionaNatureza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionaNatureza));
            lbSelectNatOperacao = new Label();
            cmdSair = new Button();
            CmdSelecionar = new Button();
            grdNatureza = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            grdCodigo = new DataGridViewTextBoxColumn();
            grdAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdNatureza).BeginInit();
            SuspendLayout();
            // 
            // lbSelectNatOperacao
            // 
            lbSelectNatOperacao.BackColor = Color.Transparent;
            lbSelectNatOperacao.BorderStyle = BorderStyle.Fixed3D;
            lbSelectNatOperacao.Cursor = Cursors.IBeam;
            lbSelectNatOperacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSelectNatOperacao.ForeColor = Color.Black;
            lbSelectNatOperacao.Location = new Point(13, 4);
            lbSelectNatOperacao.Name = "lbSelectNatOperacao";
            lbSelectNatOperacao.Size = new Size(286, 29);
            lbSelectNatOperacao.TabIndex = 14;
            lbSelectNatOperacao.Text = "Seleciona Natureza";
            lbSelectNatOperacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(386, 7);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(75, 23);
            cmdSair.TabIndex = 13;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // CmdSelecionar
            // 
            CmdSelecionar.Location = new Point(305, 7);
            CmdSelecionar.Name = "CmdSelecionar";
            CmdSelecionar.Size = new Size(75, 23);
            CmdSelecionar.TabIndex = 12;
            CmdSelecionar.Text = "Selecionar";
            CmdSelecionar.UseVisualStyleBackColor = true;
            CmdSelecionar.Click += CmdSelecionar_Click;
            // 
            // grdNatureza
            // 
            grdNatureza.AllowUserToAddRows = false;
            grdNatureza.AllowUserToDeleteRows = false;
            grdNatureza.BackgroundColor = SystemColors.GradientActiveCaption;
            grdNatureza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdNatureza.Columns.AddRange(new DataGridViewColumn[] { grdID, grdDescricao, grdCodigo, grdAtivo });
            grdNatureza.Location = new Point(12, 36);
            grdNatureza.MultiSelect = false;
            grdNatureza.Name = "grdNatureza";
            grdNatureza.ReadOnly = true;
            grdNatureza.RowTemplate.Height = 25;
            grdNatureza.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdNatureza.Size = new Size(457, 402);
            grdNatureza.TabIndex = 11;
            grdNatureza.CellDoubleClick += grdEmpresas_CellDoubleClick;
            grdNatureza.SelectionChanged += grdNatureza_SelectionChanged;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Resizable = DataGridViewTriState.True;
            grdID.Visible = false;
            // 
            // grdDescricao
            // 
            grdDescricao.HeaderText = "Descrição";
            grdDescricao.Name = "grdDescricao";
            grdDescricao.ReadOnly = true;
            grdDescricao.Resizable = DataGridViewTriState.True;
            grdDescricao.Width = 450;
            // 
            // grdCodigo
            // 
            grdCodigo.HeaderText = "Codigo";
            grdCodigo.Name = "grdCodigo";
            grdCodigo.ReadOnly = true;
            grdCodigo.Resizable = DataGridViewTriState.True;
            grdCodigo.Width = 200;
            // 
            // grdAtivo
            // 
            grdAtivo.HeaderText = "Ativo";
            grdAtivo.Name = "grdAtivo";
            grdAtivo.ReadOnly = true;
            grdAtivo.Resizable = DataGridViewTriState.True;
            // 
            // frmSelecionaNatureza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(480, 450);
            ControlBox = false;
            Controls.Add(lbSelectNatOperacao);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdNatureza);
            Name = "frmSelecionaNatureza";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Natureza";
            Load += frmSelecionaNatureza_Load;
            ((System.ComponentModel.ISupportInitialize)grdNatureza).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbSelectNatOperacao;
        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdNatureza;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
        private DataGridViewTextBoxColumn grdAtivo;
    }
}