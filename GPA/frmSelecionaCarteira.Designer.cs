namespace Formularios
{
    partial class frmSelecionaCarteira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionaCarteira));
            cmdSair = new Button();
            CmdSelecionar = new Button();
            grdCarteira = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdSigla = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            lbSelecUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)grdCarteira).BeginInit();
            SuspendLayout();
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(210, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 5;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // CmdSelecionar
            // 
            CmdSelecionar.BackgroundImage = Properties.Resources.verificar;
            CmdSelecionar.BackgroundImageLayout = ImageLayout.Stretch;
            CmdSelecionar.Location = new Point(175, 12);
            CmdSelecionar.Name = "CmdSelecionar";
            CmdSelecionar.Size = new Size(29, 29);
            CmdSelecionar.TabIndex = 4;
            CmdSelecionar.UseVisualStyleBackColor = true;
            CmdSelecionar.Click += CmdSelecionar_Click;
            // 
            // grdCarteira
            // 
            grdCarteira.AllowUserToAddRows = false;
            grdCarteira.AllowUserToDeleteRows = false;
            grdCarteira.BackgroundColor = SystemColors.GradientActiveCaption;
            grdCarteira.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdCarteira.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCarteira.Columns.AddRange(new DataGridViewColumn[] { grdID, grdSigla, grdDescricao });
            grdCarteira.Location = new Point(12, 47);
            grdCarteira.MultiSelect = false;
            grdCarteira.Name = "grdCarteira";
            grdCarteira.ReadOnly = true;
            grdCarteira.RowHeadersVisible = false;
            grdCarteira.RowTemplate.Height = 25;
            grdCarteira.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCarteira.Size = new Size(227, 410);
            grdCarteira.TabIndex = 3;
            grdCarteira.CellDoubleClick += grdCarteira_CellDoubleClick;
            grdCarteira.SelectionChanged += grdCarteira_SelectionChanged;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Resizable = DataGridViewTriState.True;
            grdID.Visible = false;
            grdID.Width = 150;
            // 
            // grdSigla
            // 
            grdSigla.HeaderText = "Sigla";
            grdSigla.Name = "grdSigla";
            grdSigla.ReadOnly = true;
            grdSigla.Resizable = DataGridViewTriState.True;
            grdSigla.Width = 50;
            // 
            // grdDescricao
            // 
            grdDescricao.HeaderText = "Descrição";
            grdDescricao.Name = "grdDescricao";
            grdDescricao.ReadOnly = true;
            grdDescricao.Width = 170;
            // 
            // lbSelecUsuario
            // 
            lbSelecUsuario.BackColor = Color.Transparent;
            lbSelecUsuario.BorderStyle = BorderStyle.Fixed3D;
            lbSelecUsuario.Cursor = Cursors.IBeam;
            lbSelecUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSelecUsuario.ForeColor = Color.Black;
            lbSelecUsuario.Location = new Point(11, 12);
            lbSelecUsuario.Name = "lbSelecUsuario";
            lbSelecUsuario.Size = new Size(158, 29);
            lbSelecUsuario.TabIndex = 6;
            lbSelecUsuario.Text = "Carteira";
            lbSelecUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmSelecionaCarteira
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(251, 469);
            ControlBox = false;
            Controls.Add(lbSelecUsuario);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdCarteira);
            Name = "frmSelecionaCarteira";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Usuario";
            Load += frmSelecionaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)grdCarteira).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdCarteira;
        private Label lbSelecUsuario;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdSigla;
        private DataGridViewTextBoxColumn grdDescricao;
    }
}