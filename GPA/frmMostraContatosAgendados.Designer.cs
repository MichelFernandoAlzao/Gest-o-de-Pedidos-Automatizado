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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostraAvisos));
            grdAviso = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            grdtxtAviso = new DataGridViewTextBoxColumn();
            grdInicio = new DataGridViewTextBoxColumn();
            grdTermino = new DataGridViewTextBoxColumn();
            lbPedidos = new Label();
            cmdSair = new Button();
            cmdConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdAviso).BeginInit();
            SuspendLayout();
            // 
            // grdAviso
            // 
            grdAviso.AllowUserToAddRows = false;
            grdAviso.AllowUserToDeleteRows = false;
            grdAviso.BackgroundColor = SystemColors.ActiveCaption;
            grdAviso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAviso.Columns.AddRange(new DataGridViewColumn[] { ID, grdtxtAviso, grdInicio, grdTermino });
            grdAviso.GridColor = Color.Gainsboro;
            grdAviso.Location = new Point(12, 48);
            grdAviso.MultiSelect = false;
            grdAviso.Name = "grdAviso";
            grdAviso.ReadOnly = true;
            grdAviso.RowHeadersVisible = false;
            grdAviso.RowTemplate.Height = 25;
            grdAviso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdAviso.Size = new Size(660, 151);
            grdAviso.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // grdtxtAviso
            // 
            grdtxtAviso.HeaderText = "Aviso";
            grdtxtAviso.Name = "grdtxtAviso";
            grdtxtAviso.ReadOnly = true;
            grdtxtAviso.Width = 450;
            // 
            // grdInicio
            // 
            grdInicio.HeaderText = "Inclusão";
            grdInicio.Name = "grdInicio";
            grdInicio.ReadOnly = true;
            // 
            // grdTermino
            // 
            grdTermino.HeaderText = "Data Limite";
            grdTermino.Name = "grdTermino";
            grdTermino.ReadOnly = true;
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
            lbPedidos.Size = new Size(590, 29);
            lbPedidos.TabIndex = 16;
            lbPedidos.Text = "Avisos";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSair.Location = new Point(643, 9);
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
            cmdConfirmar.Location = new Point(608, 9);
            cmdConfirmar.Name = "cmdConfirmar";
            cmdConfirmar.Size = new Size(29, 29);
            cmdConfirmar.TabIndex = 0;
            cmdConfirmar.UseVisualStyleBackColor = true;
            cmdConfirmar.Click += cmdConfirmar_Click;
            // 
            // frmMostraAvisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(684, 211);
            ControlBox = false;
            Controls.Add(cmdConfirmar);
            Controls.Add(cmdSair);
            Controls.Add(lbPedidos);
            Controls.Add(grdAviso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMostraAvisos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostra Avisos";
            ((System.ComponentModel.ISupportInitialize)grdAviso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdAviso;
        private Label lbPedidos;
        private Button cmdSair;
        private Button cmdConfirmar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn grdtxtAviso;
        private DataGridViewTextBoxColumn grdInicio;
        private DataGridViewTextBoxColumn grdTermino;
    }
}