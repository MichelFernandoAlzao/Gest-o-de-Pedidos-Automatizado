﻿namespace Formularios
{
    partial class frmConsultaPedido
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
            lbCabeçallho = new Label();
            cmdBuscar = new Button();
            txtNumero = new TextBox();
            cmdSelecionar = new Button();
            grdListaPedido = new DataGridView();
            grdID = new DataGridViewTextBoxColumn();
            grdRazao = new DataGridViewTextBoxColumn();
            grdData = new DataGridViewTextBoxColumn();
            cmdSair = new Button();
            ((System.ComponentModel.ISupportInitialize)grdListaPedido).BeginInit();
            SuspendLayout();
            // 
            // lbCabeçallho
            // 
            lbCabeçallho.BorderStyle = BorderStyle.Fixed3D;
            lbCabeçallho.Cursor = Cursors.IBeam;
            lbCabeçallho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCabeçallho.ForeColor = Color.Black;
            lbCabeçallho.Location = new Point(12, 9);
            lbCabeçallho.Name = "lbCabeçallho";
            lbCabeçallho.Size = new Size(620, 30);
            lbCabeçallho.TabIndex = 4;
            lbCabeçallho.Text = "Consulta Pedidos";
            lbCabeçallho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(137, 42);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(77, 30);
            cmdBuscar.TabIndex = 5;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 47);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(111, 23);
            txtNumero.TabIndex = 6;
            // 
            // cmdSelecionar
            // 
            cmdSelecionar.Location = new Point(638, 9);
            cmdSelecionar.Name = "cmdSelecionar";
            cmdSelecionar.Size = new Size(72, 30);
            cmdSelecionar.TabIndex = 7;
            cmdSelecionar.Text = "Selecionar";
            cmdSelecionar.UseVisualStyleBackColor = true;
            cmdSelecionar.Click += cmdSelecionar_Click;
            // 
            // grdListaPedido
            // 
            grdListaPedido.AllowUserToAddRows = false;
            grdListaPedido.AllowUserToDeleteRows = false;
            grdListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdListaPedido.Columns.AddRange(new DataGridViewColumn[] { grdID, grdRazao, grdData });
            grdListaPedido.Location = new Point(12, 78);
            grdListaPedido.Name = "grdListaPedido";
            grdListaPedido.ReadOnly = true;
            grdListaPedido.RowTemplate.Height = 25;
            grdListaPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdListaPedido.Size = new Size(776, 157);
            grdListaPedido.TabIndex = 8;
            // 
            // grdID
            // 
            grdID.HeaderText = "Numero";
            grdID.Name = "grdID";
            grdID.ReadOnly = true;
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
            // cmdSair
            // 
            cmdSair.Location = new Point(716, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(72, 30);
            cmdSair.TabIndex = 9;
            cmdSair.Text = "Sair";
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += button3_Click;
            // 
            // frmConsultaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 247);
            ControlBox = false;
            Controls.Add(cmdSair);
            Controls.Add(grdListaPedido);
            Controls.Add(cmdSelecionar);
            Controls.Add(txtNumero);
            Controls.Add(cmdBuscar);
            Controls.Add(lbCabeçallho);
            Name = "frmConsultaPedido";
            Text = "Consulta Pedido";
            ((System.ComponentModel.ISupportInitialize)grdListaPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCabeçallho;
        private Button cmdBuscar;
        private TextBox txtNumero;
        private Button cmdSelecionar;
        private DataGridView grdListaPedido;
        private Button cmdSair;
        private DataGridViewTextBoxColumn grdID;
        private DataGridViewTextBoxColumn grdRazao;
        private DataGridViewTextBoxColumn grdData;
    }
}