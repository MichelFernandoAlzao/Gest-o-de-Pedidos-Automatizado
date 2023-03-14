namespace Formularios
{
    partial class frmParametrosdoGestor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdMetasMensais = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMetaMensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrazoContato = new System.Windows.Forms.TextBox();
            this.txtPrazoUltVenda = new System.Windows.Forms.TextBox();
            this.grdMetas = new System.Windows.Forms.Label();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.labEmpresaPadrao = new System.Windows.Forms.Label();
            this.txtEmpresaPadrao = new System.Windows.Forms.TextBox();
            this.cmdGravarMetas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMetasMensais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prazo para contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prazo UltimaVenda:";
            // 
            // grdMetasMensais
            // 
            this.grdMetasMensais.AllowUserToAddRows = false;
            this.grdMetasMensais.AllowUserToDeleteRows = false;
            this.grdMetasMensais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMetasMensais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdNome,
            this.grdMetaMensal});
            this.grdMetasMensais.Location = new System.Drawing.Point(12, 288);
            this.grdMetasMensais.Name = "grdMetasMensais";
            this.grdMetasMensais.RowTemplate.Height = 25;
            this.grdMetasMensais.Size = new System.Drawing.Size(395, 150);
            this.grdMetasMensais.TabIndex = 2;
            // 
            // grdID
            // 
            this.grdID.HeaderText = "ID";
            this.grdID.Name = "grdID";
            this.grdID.Visible = false;
            // 
            // grdNome
            // 
            this.grdNome.HeaderText = "Nome";
            this.grdNome.Name = "grdNome";
            this.grdNome.Width = 250;
            // 
            // grdMetaMensal
            // 
            this.grdMetaMensal.HeaderText = "Meta Mensal";
            this.grdMetaMensal.Name = "grdMetaMensal";
            // 
            // txtPrazoContato
            // 
            this.txtPrazoContato.Location = new System.Drawing.Point(132, 17);
            this.txtPrazoContato.Name = "txtPrazoContato";
            this.txtPrazoContato.Size = new System.Drawing.Size(53, 23);
            this.txtPrazoContato.TabIndex = 1;
            // 
            // txtPrazoUltVenda
            // 
            this.txtPrazoUltVenda.Location = new System.Drawing.Point(133, 50);
            this.txtPrazoUltVenda.Name = "txtPrazoUltVenda";
            this.txtPrazoUltVenda.Size = new System.Drawing.Size(53, 23);
            this.txtPrazoUltVenda.TabIndex = 3;
            // 
            // grdMetas
            // 
            this.grdMetas.AutoSize = true;
            this.grdMetas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grdMetas.Location = new System.Drawing.Point(12, 270);
            this.grdMetas.Name = "grdMetas";
            this.grdMetas.Size = new System.Drawing.Size(91, 15);
            this.grdMetas.TabIndex = 4;
            this.grdMetas.Text = "Metas Mensais:";
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.Location = new System.Drawing.Point(342, 11);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(29, 29);
            this.cmdGravar.TabIndex = 44;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.Location = new System.Drawing.Point(377, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(29, 29);
            this.cmdSair.TabIndex = 45;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // labEmpresaPadrao
            // 
            this.labEmpresaPadrao.AutoSize = true;
            this.labEmpresaPadrao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labEmpresaPadrao.Location = new System.Drawing.Point(11, 90);
            this.labEmpresaPadrao.Name = "labEmpresaPadrao";
            this.labEmpresaPadrao.Size = new System.Drawing.Size(95, 15);
            this.labEmpresaPadrao.TabIndex = 46;
            this.labEmpresaPadrao.Text = "Empresa Padrão";
            // 
            // txtEmpresaPadrao
            // 
            this.txtEmpresaPadrao.Location = new System.Drawing.Point(11, 108);
            this.txtEmpresaPadrao.Name = "txtEmpresaPadrao";
            this.txtEmpresaPadrao.Size = new System.Drawing.Size(395, 23);
            this.txtEmpresaPadrao.TabIndex = 47;
            this.txtEmpresaPadrao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpresaPadrao_KeyDown);
            // 
            // cmdGravarMetas
            // 
            this.cmdGravarMetas.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravarMetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravarMetas.Location = new System.Drawing.Point(377, 253);
            this.cmdGravarMetas.Name = "cmdGravarMetas";
            this.cmdGravarMetas.Size = new System.Drawing.Size(29, 29);
            this.cmdGravarMetas.TabIndex = 48;
            this.cmdGravarMetas.UseVisualStyleBackColor = true;
            this.cmdGravarMetas.Click += new System.EventHandler(this.cmdGravarMetas_Click);
            // 
            // frmParametrosdoGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmdGravarMetas);
            this.Controls.Add(this.txtEmpresaPadrao);
            this.Controls.Add(this.labEmpresaPadrao);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.grdMetas);
            this.Controls.Add(this.txtPrazoUltVenda);
            this.Controls.Add(this.txtPrazoContato);
            this.Controls.Add(this.grdMetasMensais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParametrosdoGestor";
            this.Text = "Parametros do Gestor";
            this.Load += new System.EventHandler(this.frmParametrosdoGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMetasMensais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView grdMetasMensais;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdNome;
        private DataGridViewTextBoxColumn grdMetaMensal;
        private TextBox txtPrazoContato;
        private TextBox txtPrazoUltVenda;
        private Label grdMetas;
        private Button cmdGravar;
        private Button cmdSair;
        private Label labEmpresaPadrao;
        private TextBox txtEmpresaPadrao;
        private Button cmdGravarMetas;
    }
}