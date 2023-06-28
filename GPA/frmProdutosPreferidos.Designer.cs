namespace Formularios
{
    partial class frmProdutosPreferidos
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
            cmdSair = new Button();
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
            cmdSair.AccessibleDescription = "Sair";
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(758, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 17;
            cmdSair.UseVisualStyleBackColor = true;
            // 
            // grdProdutos
            // 
            grdProdutos.AllowUserToAddRows = false;
            grdProdutos.AllowUserToDeleteRows = false;
            grdProdutos.BackgroundColor = SystemColors.GradientActiveCaption;
            grdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProdutos.Columns.AddRange(new DataGridViewColumn[] { grdID, grdDescricao, grdCodigo, grdAtivo });
            grdProdutos.Location = new Point(12, 48);
            grdProdutos.MultiSelect = false;
            grdProdutos.Name = "grdProdutos";
            grdProdutos.ReadOnly = true;
            grdProdutos.RowTemplate.Height = 25;
            grdProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProdutos.Size = new Size(776, 246);
            grdProdutos.TabIndex = 18;
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
            lbCadProdutos.BorderStyle = BorderStyle.Fixed3D;
            lbCadProdutos.Cursor = Cursors.IBeam;
            lbCadProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCadProdutos.ForeColor = Color.Black;
            lbCadProdutos.Location = new Point(12, 13);
            lbCadProdutos.Name = "lbCadProdutos";
            lbCadProdutos.Size = new Size(740, 29);
            lbCadProdutos.TabIndex = 19;
            lbCadProdutos.Text = "Seleciona Produtos";
            lbCadProdutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmProdutosPreferidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 306);
            ControlBox = false;
            Controls.Add(lbCadProdutos);
            Controls.Add(grdProdutos);
            Controls.Add(cmdSair);
            Name = "frmProdutosPreferidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos Preferidos";
            ((System.ComponentModel.ISupportInitialize)grdProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cmdSair;
        private DataGridView grdProdutos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
        private DataGridViewTextBoxColumn grdAtivo;
        private Label lbCadProdutos;
    }
}