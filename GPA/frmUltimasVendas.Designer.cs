﻿namespace Formularios
{
    partial class frmUltimasVendas
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
            grdListaPedido = new DataGridView();
            grdNumero = new DataGridViewTextBoxColumn();
            grdRazao = new DataGridViewTextBoxColumn();
            grdData = new DataGridViewTextBoxColumn();
            cmdSelecionar = new Button();
            cmdBuscar = new Button();
            lbCabeçallho = new Label();
            LabDTinicial = new Label();
            labDTFinal = new Label();
            chkConcluido = new CheckBox();
            chkCancelado = new CheckBox();
            txtDataInicio = new MaskedTextBox();
            txtDataFim = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)grdListaPedido).BeginInit();
            SuspendLayout();
            // 
            // cmdSair
            // 
            cmdSair.Location = new Point(716, 11);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(72, 30);
            cmdSair.TabIndex = 15;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += button3_Click;
            // 
            // grdListaPedido
            // 
            grdListaPedido.AllowUserToAddRows = false;
            grdListaPedido.AllowUserToDeleteRows = false;
            grdListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdListaPedido.Columns.AddRange(new DataGridViewColumn[] { grdNumero, grdRazao, grdData });
            grdListaPedido.Location = new Point(12, 115);
            grdListaPedido.Name = "grdListaPedido";
            grdListaPedido.ReadOnly = true;
            grdListaPedido.RowTemplate.Height = 25;
            grdListaPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdListaPedido.Size = new Size(776, 267);
            grdListaPedido.TabIndex = 14;
            grdListaPedido.DoubleClick += grdListaPedido_DoubleClick;
            // 
            // grdNumero
            // 
            grdNumero.HeaderText = "Numero";
            grdNumero.Name = "grdNumero";
            grdNumero.ReadOnly = true;
            // 
            // grdRazao
            // 
            grdRazao.HeaderText = "Razão Social";
            grdRazao.Name = "grdRazao";
            grdRazao.ReadOnly = true;
            grdRazao.Width = 500;
            // 
            // grdData
            // 
            grdData.HeaderText = "Data";
            grdData.Name = "grdData";
            grdData.ReadOnly = true;
            // 
            // cmdSelecionar
            // 
            cmdSelecionar.Location = new Point(638, 11);
            cmdSelecionar.Name = "cmdSelecionar";
            cmdSelecionar.Size = new Size(72, 30);
            cmdSelecionar.TabIndex = 13;
            cmdSelecionar.Text = "Selecionar";
            cmdSelecionar.UseVisualStyleBackColor = true;
            cmdSelecionar.Click += cmdSelecionar_Click;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(265, 74);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(77, 23);
            cmdBuscar.TabIndex = 11;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 11);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(620, 30);
            lbCabeçallho.TabIndex = 10;
            lbCabeçallho.Text = "Consulta Pedidos";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabDTinicial
            // 
            LabDTinicial.AutoSize = true;
            LabDTinicial.Location = new Point(12, 52);
            LabDTinicial.Name = "LabDTinicial";
            LabDTinicial.Size = new Size(65, 15);
            LabDTinicial.TabIndex = 16;
            LabDTinicial.Text = "Data Inicial";
            // 
            // labDTFinal
            // 
            labDTFinal.AutoSize = true;
            labDTFinal.Location = new Point(138, 52);
            labDTFinal.Name = "labDTFinal";
            labDTFinal.Size = new Size(59, 15);
            labDTFinal.TabIndex = 18;
            labDTFinal.Text = "Data Final";
            // 
            // chkConcluido
            // 
            chkConcluido.AutoSize = true;
            chkConcluido.Location = new Point(573, 78);
            chkConcluido.Name = "chkConcluido";
            chkConcluido.Size = new Size(81, 19);
            chkConcluido.TabIndex = 19;
            chkConcluido.Text = "Concluido";
            chkConcluido.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            chkCancelado.AutoSize = true;
            chkCancelado.Location = new Point(706, 78);
            chkCancelado.Name = "chkCancelado";
            chkCancelado.Size = new Size(82, 19);
            chkCancelado.TabIndex = 20;
            chkCancelado.Text = "Cancelado";
            chkCancelado.UseVisualStyleBackColor = true;
            // 
            // txtDataInicio
            // 
            txtDataInicio.Location = new Point(12, 74);
            txtDataInicio.Mask = "00/00/0000";
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(100, 23);
            txtDataInicio.TabIndex = 21;
            txtDataInicio.ValidatingType = typeof(DateTime);
            txtDataInicio.Leave += txtDataInicio_Leave;
            // 
            // txtDataFim
            // 
            txtDataFim.Location = new Point(138, 74);
            txtDataFim.Mask = "00/00/0000";
            txtDataFim.Name = "txtDataFim";
            txtDataFim.Size = new Size(100, 23);
            txtDataFim.TabIndex = 22;
            txtDataFim.ValidatingType = typeof(DateTime);
            txtDataFim.Leave += txtDataFim_Leave;
            // 
            // frmUltimasVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            ControlBox = false;
            Controls.Add(txtDataFim);
            Controls.Add(txtDataInicio);
            Controls.Add(chkCancelado);
            Controls.Add(chkConcluido);
            Controls.Add(labDTFinal);
            Controls.Add(LabDTinicial);
            Controls.Add(cmdSair);
            Controls.Add(grdListaPedido);
            Controls.Add(cmdSelecionar);
            Controls.Add(cmdBuscar);
            Controls.Add(lbCabeçallho);
            Name = "frmUltimasVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUltimasVendas";
            ((System.ComponentModel.ISupportInitialize)grdListaPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdSair;
        private DataGridView grdListaPedido;
        private Button cmdSelecionar;
        private Button cmdBuscar;
        private Label lbCabeçallho;
        private Label LabDTinicial;
        private Label labDTFinal;
        private CheckBox chkConcluido;
        private CheckBox chkCancelado;
        private MaskedTextBox txtDataInicio;
        private MaskedTextBox txtDataFim;
        private DataGridViewTextBoxColumn grdNumero;
        private DataGridViewTextBoxColumn grdRazao;
        private DataGridViewTextBoxColumn grdData;
    }
}