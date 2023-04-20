namespace Formularios
{
    partial class frmSelecionarUsuario
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
            CmdSelecionar = new Button();
            grdUsuarios = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdNome = new DataGridViewTextBoxColumn();
            lbSelecUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
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
            // grdUsuarios
            // 
            grdUsuarios.AllowUserToAddRows = false;
            grdUsuarios.AllowUserToDeleteRows = false;
            grdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsuarios.Columns.AddRange(new DataGridViewColumn[] { grdID, grdNome });
            grdUsuarios.Location = new Point(12, 47);
            grdUsuarios.MultiSelect = false;
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.ReadOnly = true;
            grdUsuarios.RowTemplate.Height = 25;
            grdUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsuarios.Size = new Size(227, 410);
            grdUsuarios.TabIndex = 3;
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
            // grdNome
            // 
            grdNome.HeaderText = "Nome";
            grdNome.Name = "grdNome";
            grdNome.ReadOnly = true;
            grdNome.Resizable = DataGridViewTriState.True;
            grdNome.Width = 200;
            // 
            // lbSelecUsuario
            // 
            lbSelecUsuario.BorderStyle = BorderStyle.Fixed3D;
            lbSelecUsuario.Cursor = Cursors.IBeam;
            lbSelecUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSelecUsuario.ForeColor = Color.Black;
            lbSelecUsuario.Location = new Point(11, 12);
            lbSelecUsuario.Name = "lbSelecUsuario";
            lbSelecUsuario.Size = new Size(158, 29);
            lbSelecUsuario.TabIndex = 6;
            lbSelecUsuario.Text = "Usuarios";
            lbSelecUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmSelecionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 469);
            ControlBox = false;
            Controls.Add(lbSelecUsuario);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdUsuarios);
            Name = "frmSelecionarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Usuario";
            Load += frmSelecionaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdUsuarios;
        private Label lbSelecUsuario;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdNome;
    }
}