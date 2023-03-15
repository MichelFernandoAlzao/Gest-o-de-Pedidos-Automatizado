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
            this.cmdSair = new System.Windows.Forms.Button();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.lbSelecUsuario = new System.Windows.Forms.Label();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Location = new System.Drawing.Point(210, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(29, 29);
            this.cmdSair.TabIndex = 5;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.BackgroundImage = global::Formularios.Properties.Resources.verificar;
            this.CmdSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdSelecionar.Location = new System.Drawing.Point(175, 12);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(29, 29);
            this.CmdSelecionar.TabIndex = 4;
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            this.CmdSelecionar.Click += new System.EventHandler(this.CmdSelecionar_Click);
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdNome});
            this.grdUsuarios.Location = new System.Drawing.Point(12, 47);
            this.grdUsuarios.MultiSelect = false;
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.RowTemplate.Height = 25;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(227, 410);
            this.grdUsuarios.TabIndex = 3;
            // 
            // lbSelecUsuario
            // 
            this.lbSelecUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSelecUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbSelecUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelecUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbSelecUsuario.Location = new System.Drawing.Point(11, 12);
            this.lbSelecUsuario.Name = "lbSelecUsuario";
            this.lbSelecUsuario.Size = new System.Drawing.Size(158, 29);
            this.lbSelecUsuario.TabIndex = 6;
            this.lbSelecUsuario.Text = "Usuarios";
            this.lbSelecUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdID
            // 
            this.grdID.HeaderText = "ID";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdID.Visible = false;
            this.grdID.Width = 150;
            // 
            // grdNome
            // 
            this.grdNome.HeaderText = "Nome";
            this.grdNome.Name = "grdNome";
            this.grdNome.ReadOnly = true;
            this.grdNome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNome.Width = 200;
            // 
            // frmSelecionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 469);
            this.ControlBox = false;
            this.Controls.Add(this.lbSelecUsuario);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.grdUsuarios);
            this.Name = "frmSelecionarUsuario";
            this.Text = "Selecionar Usuario";
            this.Load += new System.EventHandler(this.frmSelecionaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);

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