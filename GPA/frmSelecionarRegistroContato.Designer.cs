namespace Formularios
{
    partial class frmSelecionarRegistroContato
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
            this.lbSelecRegistroContato = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Button();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.grdRegContatos = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRegContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelecRegistroContato
            // 
            this.lbSelecRegistroContato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSelecRegistroContato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbSelecRegistroContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelecRegistroContato.ForeColor = System.Drawing.Color.Black;
            this.lbSelecRegistroContato.Location = new System.Drawing.Point(13, 7);
            this.lbSelecRegistroContato.Name = "lbSelecRegistroContato";
            this.lbSelecRegistroContato.Size = new System.Drawing.Size(613, 29);
            this.lbSelecRegistroContato.TabIndex = 14;
            this.lbSelecRegistroContato.Text = "Selecionar Registro Contato";
            this.lbSelecRegistroContato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(713, 10);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 13;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.Location = new System.Drawing.Point(632, 10);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(75, 23);
            this.CmdSelecionar.TabIndex = 12;
            this.CmdSelecionar.Text = "Selecionar";
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            this.CmdSelecionar.Click += new System.EventHandler(this.CmdSelecionar_Click);
            // 
            // grdRegContatos
            // 
            this.grdRegContatos.AllowUserToAddRows = false;
            this.grdRegContatos.AllowUserToDeleteRows = false;
            this.grdRegContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRegContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdDescricao,
            this.grdCodigo});
            this.grdRegContatos.Location = new System.Drawing.Point(12, 39);
            this.grdRegContatos.MultiSelect = false;
            this.grdRegContatos.Name = "grdRegContatos";
            this.grdRegContatos.ReadOnly = true;
            this.grdRegContatos.RowTemplate.Height = 25;
            this.grdRegContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRegContatos.Size = new System.Drawing.Size(776, 210);
            this.grdRegContatos.TabIndex = 11;
            // 
            // grdID
            // 
            this.grdID.HeaderText = "Número";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grdDescricao
            // 
            this.grdDescricao.HeaderText = "Empresa";
            this.grdDescricao.Name = "grdDescricao";
            this.grdDescricao.ReadOnly = true;
            this.grdDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDescricao.Width = 450;
            // 
            // grdCodigo
            // 
            this.grdCodigo.HeaderText = "Data Contato";
            this.grdCodigo.Name = "grdCodigo";
            this.grdCodigo.ReadOnly = true;
            this.grdCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCodigo.Width = 200;
            // 
            // frmSelecionarRegistroContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.ControlBox = false;
            this.Controls.Add(this.lbSelecRegistroContato);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.grdRegContatos);
            this.Name = "frmSelecionarRegistroContato";
            this.Text = "frmSelecionarRegistroContato";
            this.Load += new System.EventHandler(this.frmSelecionarRegistroContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRegContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbSelecRegistroContato;
        private Button cmdSair;
        private Button CmdSelecionar;
        private DataGridView grdRegContatos;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdDescricao;
        private DataGridViewTextBoxColumn grdCodigo;
    }
}