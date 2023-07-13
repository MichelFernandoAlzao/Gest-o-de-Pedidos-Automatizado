namespace Formularios
{
    partial class frmSelecionaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionaProduto));
            cmdSair = new Button();
            CmdSelecionar = new Button();
            grdProdutos = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            grdCodigo = new DataGridViewTextBoxColumn();
            grdAtivo = new DataGridViewTextBoxColumn();
            lbCadProdutos = new Label();
            ((System.ComponentModel.ISupportInitialize)grdProdutos).BeginInit();
            SuspendLayout();
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(712, 7);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(75, 23);
            cmdSair.TabIndex = 5;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // CmdSelecionar
            // 
            CmdSelecionar.Location = new Point(631, 7);
            CmdSelecionar.Name = "CmdSelecionar";
            CmdSelecionar.Size = new Size(75, 23);
            CmdSelecionar.TabIndex = 4;
            CmdSelecionar.Text = "Selecionar";
            CmdSelecionar.UseVisualStyleBackColor = true;
            CmdSelecionar.Click += CmdSelecionar_Click;
            // 
            // grdProdutos
            // 
            grdProdutos.AllowUserToAddRows = false;
            grdProdutos.AllowUserToDeleteRows = false;
            grdProdutos.BackgroundColor = SystemColors.GradientActiveCaption;
            grdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProdutos.Columns.AddRange(new DataGridViewColumn[] { grdID, grdDescricao, grdCodigo, grdAtivo });
            grdProdutos.Location = new Point(11, 36);
            grdProdutos.MultiSelect = false;
            grdProdutos.Name = "grdProdutos";
            grdProdutos.ReadOnly = true;
            grdProdutos.RowTemplate.Height = 25;
            grdProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProdutos.Size = new Size(776, 210);
            grdProdutos.TabIndex = 3;
            grdProdutos.DoubleClick += grdProdutos_DoubleClick;
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
            // lbCadProdutos
            // 
            lbCadProdutos.BackColor = Color.Transparent;
            lbCadProdutos.BorderStyle = BorderStyle.Fixed3D;
            lbCadProdutos.Cursor = Cursors.IBeam;
            lbCadProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCadProdutos.ForeColor = Color.Black;
            lbCadProdutos.Location = new Point(12, 4);
            lbCadProdutos.Name = "lbCadProdutos";
            lbCadProdutos.Size = new Size(613, 29);
            lbCadProdutos.TabIndex = 6;
            lbCadProdutos.Text = "Seleciona Produtos";
            lbCadProdutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmSelecionaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 250);
            ControlBox = false;
            Controls.Add(lbCadProdutos);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdProdutos);
            Name = "frmSelecionaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Produto";
            Load += frmSelecionaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)grdProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdProdutos;
        private Label lbCadProdutos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
        private DataGridViewTextBoxColumn grdAtivo;
    }
}