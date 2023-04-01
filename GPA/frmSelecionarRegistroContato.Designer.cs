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
            lbSelecRegistroContato = new Label();
            cmdSair = new Button();
            CmdSelecionar = new Button();
            grdRegContatos = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdDescricao = new DataGridViewTextBoxColumn();
            grdCodigo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grdRegContatos).BeginInit();
            SuspendLayout();
            // 
            // lbSelecRegistroContato
            // 
            lbSelecRegistroContato.BorderStyle = BorderStyle.Fixed3D;
            lbSelecRegistroContato.Cursor = Cursors.IBeam;
            lbSelecRegistroContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSelecRegistroContato.ForeColor = Color.Black;
            lbSelecRegistroContato.Location = new Point(13, 7);
            lbSelecRegistroContato.Name = "lbSelecRegistroContato";
            lbSelecRegistroContato.Size = new Size(613, 29);
            lbSelecRegistroContato.TabIndex = 14;
            lbSelecRegistroContato.Text = "Selecionar Registro Contato";
            lbSelecRegistroContato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(713, 10);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(75, 23);
            cmdSair.TabIndex = 13;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // CmdSelecionar
            // 
            CmdSelecionar.Location = new Point(632, 10);
            CmdSelecionar.Name = "CmdSelecionar";
            CmdSelecionar.Size = new Size(75, 23);
            CmdSelecionar.TabIndex = 12;
            CmdSelecionar.Text = "Selecionar";
            CmdSelecionar.UseVisualStyleBackColor = true;
            CmdSelecionar.Click += CmdSelecionar_Click;
            // 
            // grdRegContatos
            // 
            grdRegContatos.AllowUserToAddRows = false;
            grdRegContatos.AllowUserToDeleteRows = false;
            grdRegContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRegContatos.Columns.AddRange(new DataGridViewColumn[] { grdID, grdDescricao, grdCodigo });
            grdRegContatos.Location = new Point(12, 39);
            grdRegContatos.MultiSelect = false;
            grdRegContatos.Name = "grdRegContatos";
            grdRegContatos.ReadOnly = true;
            grdRegContatos.RowTemplate.Height = 25;
            grdRegContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdRegContatos.Size = new Size(776, 210);
            grdRegContatos.TabIndex = 11;
            grdRegContatos.DoubleClick += grdRegContatos_DoubleClick;
            // 
            // grdID
            // 
            grdID.HeaderText = "Número";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
            grdID.Resizable = DataGridViewTriState.True;
            // 
            // grdDescricao
            // 
            grdDescricao.HeaderText = "Empresa";
            grdDescricao.Name = "grdDescricao";
            grdDescricao.ReadOnly = true;
            grdDescricao.Resizable = DataGridViewTriState.True;
            grdDescricao.Width = 450;
            // 
            // grdCodigo
            // 
            grdCodigo.HeaderText = "Data Contato";
            grdCodigo.Name = "grdCodigo";
            grdCodigo.ReadOnly = true;
            grdCodigo.Resizable = DataGridViewTriState.True;
            grdCodigo.Width = 200;
            // 
            // frmSelecionarRegistroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 255);
            ControlBox = false;
            Controls.Add(lbSelecRegistroContato);
            Controls.Add(cmdSair);
            Controls.Add(CmdSelecionar);
            Controls.Add(grdRegContatos);
            Name = "frmSelecionarRegistroContato";
            Text = "frmSelecionarRegistroContato";
            Load += frmSelecionarRegistroContato_Load;
            ((System.ComponentModel.ISupportInitialize)grdRegContatos).EndInit();
            ResumeLayout(false);
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