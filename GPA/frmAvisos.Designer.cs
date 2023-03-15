namespace Formularios
{
    partial class frmAvisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvisos));
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.lbPedidos = new System.Windows.Forms.Label();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.labAvisos = new System.Windows.Forms.Label();
            this.labInicio = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.txtDataTermino = new System.Windows.Forms.TextBox();
            this.labTermino = new System.Windows.Forms.Label();
            this.txtUsuarioDestino = new System.Windows.Forms.TextBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.grdAvisos = new System.Windows.Forms.DataGridView();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdIDusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTodos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExcluir.Location = new System.Drawing.Point(654, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(29, 29);
            this.cmdExcluir.TabIndex = 11;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdNovo.Location = new System.Drawing.Point(689, 12);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(29, 29);
            this.cmdNovo.TabIndex = 12;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSair.Location = new System.Drawing.Point(759, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(29, 29);
            this.cmdSair.TabIndex = 14;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGravar.Location = new System.Drawing.Point(724, 12);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(29, 29);
            this.cmdGravar.TabIndex = 13;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // lbPedidos
            // 
            this.lbPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPedidos.ForeColor = System.Drawing.Color.Black;
            this.lbPedidos.Location = new System.Drawing.Point(12, 12);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(632, 30);
            this.lbPedidos.TabIndex = 15;
            this.lbPedidos.Text = "Cadastro Avisos";
            this.lbPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAviso
            // 
            this.txtAviso.Location = new System.Drawing.Point(12, 60);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(632, 70);
            this.txtAviso.TabIndex = 16;
            // 
            // labAvisos
            // 
            this.labAvisos.AutoSize = true;
            this.labAvisos.Location = new System.Drawing.Point(12, 42);
            this.labAvisos.Name = "labAvisos";
            this.labAvisos.Size = new System.Drawing.Size(36, 15);
            this.labAvisos.TabIndex = 17;
            this.labAvisos.Text = "Aviso";
            // 
            // labInicio
            // 
            this.labInicio.AutoSize = true;
            this.labInicio.Location = new System.Drawing.Point(669, 44);
            this.labInicio.Name = "labInicio";
            this.labInicio.Size = new System.Drawing.Size(36, 15);
            this.labInicio.TabIndex = 19;
            this.labInicio.Text = "Inicio";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataInicio.Location = new System.Drawing.Point(669, 63);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(106, 23);
            this.txtDataInicio.TabIndex = 20;
            this.txtDataInicio.Tag = "";
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.Location = new System.Drawing.Point(669, 107);
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Size = new System.Drawing.Size(106, 23);
            this.txtDataTermino.TabIndex = 22;
            // 
            // labTermino
            // 
            this.labTermino.AutoSize = true;
            this.labTermino.Location = new System.Drawing.Point(668, 89);
            this.labTermino.Name = "labTermino";
            this.labTermino.Size = new System.Drawing.Size(50, 15);
            this.labTermino.TabIndex = 21;
            this.labTermino.Text = "Termino";
            // 
            // txtUsuarioDestino
            // 
            this.txtUsuarioDestino.Location = new System.Drawing.Point(647, 156);
            this.txtUsuarioDestino.Name = "txtUsuarioDestino";
            this.txtUsuarioDestino.Size = new System.Drawing.Size(141, 23);
            this.txtUsuarioDestino.TabIndex = 24;
            this.txtUsuarioDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioDestino_KeyDown);
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(647, 138);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(47, 15);
            this.labUsuario.TabIndex = 23;
            this.labUsuario.Text = "Usuario";
            // 
            // grdAvisos
            // 
            this.grdAvisos.AllowUserToAddRows = false;
            this.grdAvisos.AllowUserToDeleteRows = false;
            this.grdAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAvisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdAviso,
            this.grdInicio,
            this.grdTermino,
            this.grdUsuario,
            this.grdIDusuario,
            this.grdTodos});
            this.grdAvisos.Location = new System.Drawing.Point(12, 185);
            this.grdAvisos.Name = "grdAvisos";
            this.grdAvisos.ReadOnly = true;
            this.grdAvisos.RowTemplate.Height = 25;
            this.grdAvisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAvisos.Size = new System.Drawing.Size(776, 150);
            this.grdAvisos.TabIndex = 25;
            this.grdAvisos.SelectionChanged += new System.EventHandler(this.grdAvisos_SelectionChanged);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(12, 160);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(57, 19);
            this.chkTodos.TabIndex = 26;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // grdID
            // 
            this.grdID.HeaderText = "ID";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Visible = false;
            // 
            // grdAviso
            // 
            this.grdAviso.HeaderText = "Aviso";
            this.grdAviso.Name = "grdAviso";
            this.grdAviso.ReadOnly = true;
            this.grdAviso.Width = 400;
            // 
            // grdInicio
            // 
            this.grdInicio.HeaderText = "Inicio";
            this.grdInicio.Name = "grdInicio";
            this.grdInicio.ReadOnly = true;
            // 
            // grdTermino
            // 
            this.grdTermino.HeaderText = "Termino";
            this.grdTermino.Name = "grdTermino";
            this.grdTermino.ReadOnly = true;
            // 
            // grdUsuario
            // 
            this.grdUsuario.HeaderText = "Usuario";
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.ReadOnly = true;
            // 
            // grdIDusuario
            // 
            this.grdIDusuario.HeaderText = "IDUsuario";
            this.grdIDusuario.Name = "grdIDusuario";
            this.grdIDusuario.ReadOnly = true;
            this.grdIDusuario.Visible = false;
            // 
            // grdTodos
            // 
            this.grdTodos.HeaderText = "Todos";
            this.grdTodos.Name = "grdTodos";
            this.grdTodos.ReadOnly = true;
            this.grdTodos.Width = 50;
            // 
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.ControlBox = false;
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.grdAvisos);
            this.Controls.Add(this.txtUsuarioDestino);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.txtDataTermino);
            this.Controls.Add(this.labTermino);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.labInicio);
            this.Controls.Add(this.labAvisos);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.lbPedidos);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdGravar);
            this.Name = "frmAvisos";
            this.Text = "Cadastro Avisos";
            this.Load += new System.EventHandler(this.frmAvisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdSair;
        private Button cmdGravar;
        private Label lbPedidos;
        private TextBox txtAviso;
        private Label labAvisos;
        private Label labInicio;
        private TextBox txtDataInicio;
        private TextBox txtDataTermino;
        private Label labTermino;
        private TextBox txtUsuarioDestino;
        private Label labUsuario;
        private DataGridView grdAvisos;
        private CheckBox chkTodos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdAviso;
        private DataGridViewTextBoxColumn grdInicio;
        private DataGridViewTextBoxColumn grdTermino;
        private DataGridViewTextBoxColumn grdUsuario;
        private DataGridViewTextBoxColumn grdIDusuario;
        private DataGridViewTextBoxColumn grdTodos;
    }
}