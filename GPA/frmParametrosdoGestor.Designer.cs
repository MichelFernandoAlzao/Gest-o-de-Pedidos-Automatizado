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
            label1 = new Label();
            label2 = new Label();
            grdMetasMensais = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdNome = new DataGridViewTextBoxColumn();
            grdMetaMensal = new DataGridViewTextBoxColumn();
            txtPrazoContato = new TextBox();
            txtPrazoUltVenda = new TextBox();
            grdMetas = new Label();
            cmdGravar = new Button();
            cmdSair = new Button();
            labEmpresaPadrao = new Label();
            txtEmpresaPadrao = new TextBox();
            cmdGravarMetas = new Button();
            ((System.ComponentModel.ISupportInitialize)grdMetasMensais).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Prazo para contato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Prazo UltimaVenda:";
            // 
            // grdMetasMensais
            // 
            grdMetasMensais.AllowUserToAddRows = false;
            grdMetasMensais.AllowUserToDeleteRows = false;
            grdMetasMensais.BackgroundColor = SystemColors.GradientActiveCaption;
            grdMetasMensais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMetasMensais.Columns.AddRange(new DataGridViewColumn[] { grdID, grdNome, grdMetaMensal });
            grdMetasMensais.Location = new Point(12, 288);
            grdMetasMensais.Name = "grdMetasMensais";
            grdMetasMensais.RowTemplate.Height = 25;
            grdMetasMensais.Size = new Size(395, 150);
            grdMetasMensais.TabIndex = 2;
            // 
            // grdID
            // 
            grdID.HeaderText = "ID";
            grdID.Name = "grdID";
            grdID.Visible = false;
            // 
            // grdNome
            // 
            grdNome.HeaderText = "Nome";
            grdNome.Name = "grdNome";
            grdNome.Width = 250;
            // 
            // grdMetaMensal
            // 
            grdMetaMensal.HeaderText = "Meta Mensal";
            grdMetaMensal.Name = "grdMetaMensal";
            // 
            // txtPrazoContato
            // 
            txtPrazoContato.Location = new Point(132, 17);
            txtPrazoContato.Name = "txtPrazoContato";
            txtPrazoContato.Size = new Size(53, 23);
            txtPrazoContato.TabIndex = 1;
            // 
            // txtPrazoUltVenda
            // 
            txtPrazoUltVenda.Location = new Point(133, 50);
            txtPrazoUltVenda.Name = "txtPrazoUltVenda";
            txtPrazoUltVenda.Size = new Size(53, 23);
            txtPrazoUltVenda.TabIndex = 3;
            // 
            // grdMetas
            // 
            grdMetas.AutoSize = true;
            grdMetas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grdMetas.Location = new Point(12, 270);
            grdMetas.Name = "grdMetas";
            grdMetas.Size = new Size(91, 15);
            grdMetas.TabIndex = 4;
            grdMetas.Text = "Metas Mensais:";
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(342, 11);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(29, 29);
            cmdGravar.TabIndex = 44;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(377, 12);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(29, 29);
            cmdSair.TabIndex = 45;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // labEmpresaPadrao
            // 
            labEmpresaPadrao.AutoSize = true;
            labEmpresaPadrao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresaPadrao.Location = new Point(11, 90);
            labEmpresaPadrao.Name = "labEmpresaPadrao";
            labEmpresaPadrao.Size = new Size(95, 15);
            labEmpresaPadrao.TabIndex = 46;
            labEmpresaPadrao.Text = "Empresa Padrão";
            // 
            // txtEmpresaPadrao
            // 
            txtEmpresaPadrao.Location = new Point(11, 108);
            txtEmpresaPadrao.Name = "txtEmpresaPadrao";
            txtEmpresaPadrao.Size = new Size(395, 23);
            txtEmpresaPadrao.TabIndex = 47;
            txtEmpresaPadrao.KeyDown += txtEmpresaPadrao_KeyDown;
            // 
            // cmdGravarMetas
            // 
            cmdGravarMetas.BackgroundImage = Properties.Resources.save;
            cmdGravarMetas.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravarMetas.Location = new Point(377, 253);
            cmdGravarMetas.Name = "cmdGravarMetas";
            cmdGravarMetas.Size = new Size(29, 29);
            cmdGravarMetas.TabIndex = 48;
            cmdGravarMetas.UseVisualStyleBackColor = true;
            cmdGravarMetas.Click += cmdGravarMetas_Click;
            // 
            // frmParametrosdoGestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(419, 450);
            ControlBox = false;
            Controls.Add(cmdGravarMetas);
            Controls.Add(txtEmpresaPadrao);
            Controls.Add(labEmpresaPadrao);
            Controls.Add(cmdSair);
            Controls.Add(cmdGravar);
            Controls.Add(grdMetas);
            Controls.Add(txtPrazoUltVenda);
            Controls.Add(txtPrazoContato);
            Controls.Add(grdMetasMensais);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmParametrosdoGestor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parametros do Gestor";
            Load += frmParametrosdoGestor_Load;
            ((System.ComponentModel.ISupportInitialize)grdMetasMensais).EndInit();
            ResumeLayout(false);
            PerformLayout();
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