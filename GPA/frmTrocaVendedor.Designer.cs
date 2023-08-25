namespace Formularios
{
    partial class frmTrocaVendedor
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
            labVendAnt = new Label();
            lbCabeçallho = new Label();
            cmdSair = new Button();
            cmdGravar = new Button();
            txtVendedorAnterior = new TextBox();
            txtNovoVendedor = new TextBox();
            label1 = new Label();
            grdEmpresasafetadas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Razao = new DataGridViewTextBoxColumn();
            labClieAfetados = new Label();
            ((System.ComponentModel.ISupportInitialize)grdEmpresasafetadas).BeginInit();
            SuspendLayout();
            // 
            // labVendAnt
            // 
            labVendAnt.AutoSize = true;
            labVendAnt.BackColor = Color.Transparent;
            labVendAnt.Location = new Point(12, 39);
            labVendAnt.Name = "labVendAnt";
            labVendAnt.Size = new Size(126, 15);
            labVendAnt.TabIndex = 0;
            labVendAnt.Text = "Vendedor Anterior - F1";
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BackColor = Color.Transparent;
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 9);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(205, 30);
            lbCabeçallho.TabIndex = 11;
            lbCabeçallho.Text = "Troca Vendedor";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(258, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 15;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGravar.Location = new Point(223, 10);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 16;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // txtVendedorAnterior
            // 
            txtVendedorAnterior.Location = new Point(12, 57);
            txtVendedorAnterior.Name = "txtVendedorAnterior";
            txtVendedorAnterior.Size = new Size(275, 23);
            txtVendedorAnterior.TabIndex = 17;
            txtVendedorAnterior.KeyDown += txtVendedorAnterior_KeyDown;
            // 
            // txtNovoVendedor
            // 
            txtNovoVendedor.Location = new Point(12, 115);
            txtNovoVendedor.Name = "txtNovoVendedor";
            txtNovoVendedor.Size = new Size(275, 23);
            txtNovoVendedor.TabIndex = 19;
            txtNovoVendedor.KeyDown += txtNovoVendedor_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 18;
            label1.Text = "Novo Vendedor - F1";
            // 
            // grdEmpresasafetadas
            // 
            grdEmpresasafetadas.AllowUserToAddRows = false;
            grdEmpresasafetadas.AllowUserToDeleteRows = false;
            grdEmpresasafetadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEmpresasafetadas.Columns.AddRange(new DataGridViewColumn[] { ID, Razao });
            grdEmpresasafetadas.Location = new Point(12, 172);
            grdEmpresasafetadas.Name = "grdEmpresasafetadas";
            grdEmpresasafetadas.ReadOnly = true;
            grdEmpresasafetadas.RowHeadersVisible = false;
            grdEmpresasafetadas.RowTemplate.Height = 25;
            grdEmpresasafetadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEmpresasafetadas.Size = new Size(275, 321);
            grdEmpresasafetadas.TabIndex = 20;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Razao
            // 
            Razao.HeaderText = "Razao Social";
            Razao.Name = "Razao";
            Razao.ReadOnly = true;
            Razao.Width = 270;
            // 
            // labClieAfetados
            // 
            labClieAfetados.AutoSize = true;
            labClieAfetados.BackColor = Color.Transparent;
            labClieAfetados.Location = new Point(12, 154);
            labClieAfetados.Name = "labClieAfetados";
            labClieAfetados.Size = new Size(109, 15);
            labClieAfetados.TabIndex = 21;
            labClieAfetados.Text = "Cadastros Afetados";
            // 
            // frmTrocaVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vecteezy_pattern_with_geometric_elements_light_blue_to_dark_blue_17216459;
            ClientSize = new Size(299, 505);
            ControlBox = false;
            Controls.Add(labClieAfetados);
            Controls.Add(grdEmpresasafetadas);
            Controls.Add(txtNovoVendedor);
            Controls.Add(label1);
            Controls.Add(txtVendedorAnterior);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(lbCabeçallho);
            Controls.Add(labVendAnt);
            Name = "frmTrocaVendedor";
            Text = "Troca Vendedor";
            ((System.ComponentModel.ISupportInitialize)grdEmpresasafetadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labVendAnt;
        private Label lbCabeçallho;
        private Button cmdSair;
        private Button cmdGravar;
        private TextBox txtVendedorAnterior;
        private TextBox txtNovoVendedor;
        private Label label1;
        private DataGridView grdEmpresasafetadas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Razao;
        private Label labClieAfetados;
    }
}