namespace Formularios
{
    partial class frmMostraContatosAgendados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostraContatosAgendados));
            grdAgendaContatos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            grdEmpresa = new DataGridViewTextBoxColumn();
            grdNome = new DataGridViewTextBoxColumn();
            grdData = new DataGridViewTextBoxColumn();
            grdFone = new DataGridViewTextBoxColumn();
            lbPedidos = new Label();
            cmdSair = new Button();
            cmdConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdAgendaContatos).BeginInit();
            SuspendLayout();
            // 
            // grdAgendaContatos
            // 
            grdAgendaContatos.AllowUserToAddRows = false;
            grdAgendaContatos.AllowUserToDeleteRows = false;
            grdAgendaContatos.BackgroundColor = SystemColors.ActiveCaption;
            grdAgendaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAgendaContatos.Columns.AddRange(new DataGridViewColumn[] { ID, grdEmpresa, grdNome, grdData, grdFone });
            grdAgendaContatos.GridColor = Color.Gainsboro;
            grdAgendaContatos.Location = new Point(12, 48);
            grdAgendaContatos.MultiSelect = false;
            grdAgendaContatos.Name = "grdAgendaContatos";
            grdAgendaContatos.ReadOnly = true;
            grdAgendaContatos.RowHeadersVisible = false;
            grdAgendaContatos.RowTemplate.Height = 25;
            grdAgendaContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAgendaContatos.Size = new Size(680, 151);
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
            // lbPedidos
            // 
            lbPedidos.BackColor = Color.Transparent;
            lbPedidos.BorderStyle = BorderStyle.Fixed3D;
            lbPedidos.Cursor = Cursors.IBeam;
            lbPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPedidos.ForeColor = Color.Black;
            lbPedidos.Location = new Point(12, 9);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(610, 29);
            lbPedidos.TabIndex = 16;
            lbPedidos.Text = "Avisos";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(663, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 1;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // cmdConfirmar
            // 
            cmdConfirmar.BackgroundImage = (Image)resources.GetObject("cmdConfirmar.BackgroundImage");
            cmdConfirmar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdConfirmar.Location = new Point(628, 9);
            cmdConfirmar.Name = "cmdConfirmar";
            cmdConfirmar.Size = new Size(29, 29);
            cmdConfirmar.TabIndex = 0;
            cmdConfirmar.UseVisualStyleBackColor = true;
            cmdConfirmar.Click += cmdConfirmar_Click;
            // 
            // frmMostraContatosAgendados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 211);
            ControlBox = false;
            Controls.Add(cmdConfirmar);
            Controls.Add(cmdSair);
            Controls.Add(lbPedidos);
            Controls.Add(grdAgendaContatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMostraContatosAgendados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostra Avisos";
            ((System.ComponentModel.ISupportInitialize)grdAgendaContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdAgendaContatos;
        private Label lbPedidos;
        private Button cmdSair;
        private Button cmdConfirmar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn grdEmpresa;
        private DataGridViewTextBoxColumn grdNome;
        private DataGridViewTextBoxColumn grdData;
        private DataGridViewTextBoxColumn grdFone;
    }
}