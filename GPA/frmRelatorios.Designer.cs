﻿namespace Formularios
{
    partial class frmRelatorios
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
            ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // ReportViewer
            // 
            ReportViewer.Dock = DockStyle.Fill;
            ReportViewer.Location = new Point(0, 0);
            ReportViewer.Name = "ReportViewer";
            ReportViewer.ServerReport.BearerToken = null;
            ReportViewer.Size = new Size(800, 450);
            ReportViewer.TabIndex = 0;
            // 
            // frmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportViewer);
            Name = "frmRelatorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRelatorios";
            WindowState = FormWindowState.Maximized;
            Load += frmRelatorios_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
    }
}