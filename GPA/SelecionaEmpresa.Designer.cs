namespace Formularios
{
    partial class SelecionaEmpresa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdSelecionar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // CmdSelecionar
            // 
            this.CmdSelecionar.Location = new System.Drawing.Point(632, 1);
            this.CmdSelecionar.Name = "CmdSelecionar";
            this.CmdSelecionar.Size = new System.Drawing.Size(75, 23);
            this.CmdSelecionar.TabIndex = 1;
            this.CmdSelecionar.Text = "Selecionar";
            this.CmdSelecionar.UseVisualStyleBackColor = true;
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(713, 1);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 23);
            this.cmdSair.TabIndex = 2;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            // 
            // SelecionaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.CmdSelecionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelecionaEmpresa";
            this.ShowIcon = false;
            this.Text = "Selecionar Empresa";
            this.Load += new System.EventHandler(this.SelecionaEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button CmdSelecionar;
        private Button cmdSair;
    }
}