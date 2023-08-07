namespace Formularios
{
    partial class frmConsultarContatosAgendados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarContatosAgendados));
            grdAgendaContatos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            grdEmpresa = new DataGridViewTextBoxColumn();
            grdNome = new DataGridViewTextBoxColumn();
            grdData = new DataGridViewTextBoxColumn();
            grdFone = new DataGridViewTextBoxColumn();
            Concluido = new DataGridViewTextBoxColumn();
            lbPedidos = new Label();
            cmdSair = new Button();
            txtDataInicial = new MaskedTextBox();
            txtDataFinal = new MaskedTextBox();
            chkAtendido = new CheckBox();
            cmdBuscar = new Button();
            labDataInicial = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdAgendaContatos).BeginInit();
            SuspendLayout();
            // 
            // grdAgendaContatos
            // 
            grdAgendaContatos.AllowUserToAddRows = false;
            grdAgendaContatos.AllowUserToDeleteRows = false;
            grdAgendaContatos.BackgroundColor = SystemColors.ActiveCaption;
            grdAgendaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAgendaContatos.Columns.AddRange(new DataGridViewColumn[] { ID, grdEmpresa, grdNome, grdData, grdFone, Concluido });
            grdAgendaContatos.GridColor = Color.Gainsboro;
            grdAgendaContatos.Location = new Point(9, 92);
            grdAgendaContatos.MultiSelect = false;
            grdAgendaContatos.Name = "grdAgendaContatos";
            grdAgendaContatos.ReadOnly = true;
            grdAgendaContatos.RowHeadersVisible = false;
            grdAgendaContatos.RowTemplate.Height = 25;
            grdAgendaContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAgendaContatos.Size = new Size(844, 204);
            grdAgendaContatos.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // grdEmpresa
            // 
            grdEmpresa.HeaderText = "Empresa";
            grdEmpresa.Name = "grdEmpresa";
            grdEmpresa.ReadOnly = true;
            grdEmpresa.Width = 250;
            // 
            // grdNome
            // 
            grdNome.HeaderText = "Nome";
            grdNome.Name = "grdNome";
            grdNome.ReadOnly = true;
            grdNome.Width = 250;
            // 
            // grdData
            // 
            grdData.HeaderText = "Data";
            grdData.Name = "grdData";
            grdData.ReadOnly = true;
            grdData.Width = 80;
            // 
            // grdFone
            // 
            grdFone.HeaderText = "Fone";
            grdFone.Name = "grdFone";
            grdFone.ReadOnly = true;
            // 
            // Concluido
            // 
            Concluido.HeaderText = "Concluido";
            Concluido.Name = "Concluido";
            Concluido.ReadOnly = true;
            // 
            // lbPedidos
            // 
            lbPedidos.BackColor = Color.Transparent;
            lbPedidos.BorderStyle = BorderStyle.Fixed3D;
            lbPedidos.Cursor = Cursors.IBeam;
            lbPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPedidos.ForeColor = Color.Black;
            lbPedidos.Location = new Point(12, 9);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(745, 29);
            lbPedidos.TabIndex = 16;
            lbPedidos.Text = "Consulta Contatos";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(824, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 1;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // txtDataInicial
            // 
            txtDataInicial.Location = new Point(12, 63);
            txtDataInicial.Mask = "00/00/0000";
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(100, 23);
            txtDataInicial.TabIndex = 17;
            txtDataInicial.ValidatingType = typeof(DateTime);
            txtDataInicial.Leave += txtDataInicial_Leave;
            // 
            // txtDataFinal
            // 
            txtDataFinal.Location = new Point(148, 63);
            txtDataFinal.Mask = "00/00/0000";
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(100, 23);
            txtDataFinal.TabIndex = 18;
            txtDataFinal.ValidatingType = typeof(DateTime);
            txtDataFinal.Leave += txtDataFinal_Leave;
            // 
            // chkAtendido
            // 
            chkAtendido.AutoSize = true;
            chkAtendido.BackColor = Color.Transparent;
            chkAtendido.Location = new Point(272, 63);
            chkAtendido.Name = "chkAtendido";
            chkAtendido.Size = new Size(75, 19);
            chkAtendido.TabIndex = 19;
            chkAtendido.Text = "Atendido";
            chkAtendido.UseVisualStyleBackColor = false;
            // 
            // cmdBuscar
            // 
            cmdBuscar.BackgroundImage = (Image)resources.GetObject("cmdBuscar.BackgroundImage");
            cmdBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdBuscar.Location = new Point(353, 58);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(30, 30);
            cmdBuscar.TabIndex = 20;
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // labDataInicial
            // 
            labDataInicial.AutoSize = true;
            labDataInicial.BackColor = Color.Transparent;
            labDataInicial.Location = new Point(12, 45);
            labDataInicial.Name = "labDataInicial";
            labDataInicial.Size = new Size(65, 15);
            labDataInicial.TabIndex = 21;
            labDataInicial.Text = "Data Inicial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(148, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 22;
            label1.Text = "Data Final";
            // 
            // frmConsultarContatosAgendados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(868, 308);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(labDataInicial);
            Controls.Add(cmdBuscar);
            Controls.Add(chkAtendido);
            Controls.Add(txtDataFinal);
            Controls.Add(txtDataInicial);
            Controls.Add(cmdSair);
            Controls.Add(lbPedidos);
            Controls.Add(grdAgendaContatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConsultarContatosAgendados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Contatos";
            ((System.ComponentModel.ISupportInitialize)grdAgendaContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdAgendaContatos;
        private Label lbPedidos;
        private Button cmdSair;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn grdEmpresa;
        private DataGridViewTextBoxColumn grdNome;
        private DataGridViewTextBoxColumn grdData;
        private DataGridViewTextBoxColumn grdFone;
        private DataGridViewTextBoxColumn Concluido;
        private MaskedTextBox txtDataInicial;
        private MaskedTextBox txtDataFinal;
        private CheckBox chkAtendido;
        private Button cmdBuscar;
        private Label labDataInicial;
        private Label label1;
    }
}