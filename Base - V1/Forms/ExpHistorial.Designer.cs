﻿namespace Base___V1
{
    partial class ExpHistorial
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
            panel1 = new Panel();
            tblHistorialConsultas = new DataGridView();
            lblNombrePaciente = new Label();
            lblDatosPaciente = new Label();
            btnVerPaciente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblHistorialConsultas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(tblHistorialConsultas);
            panel1.Location = new Point(21, 49);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 344);
            panel1.TabIndex = 0;
            // 
            // tblHistorialConsultas
            // 
            tblHistorialConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblHistorialConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblHistorialConsultas.BackgroundColor = Color.White;
            tblHistorialConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblHistorialConsultas.GridColor = Color.Black;
            tblHistorialConsultas.Location = new Point(0, 0);
            tblHistorialConsultas.Margin = new Padding(3, 2, 3, 2);
            tblHistorialConsultas.Name = "tblHistorialConsultas";
            tblHistorialConsultas.RowHeadersWidth = 51;
            tblHistorialConsultas.Size = new Size(697, 344);
            tblHistorialConsultas.TabIndex = 0;
            tblHistorialConsultas.CellClick += tblHistorialConsultas_CellClick;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombrePaciente.ForeColor = Color.Black;
            lblNombrePaciente.Location = new Point(307, 15);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(340, 32);
            lblNombrePaciente.TabIndex = 67;
            lblNombrePaciente.Text = "Nombre del chucho";
            // 
            // lblDatosPaciente
            // 
            lblDatosPaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPaciente.ForeColor = Color.Black;
            lblDatosPaciente.Location = new Point(21, 15);
            lblDatosPaciente.Name = "lblDatosPaciente";
            lblDatosPaciente.Size = new Size(352, 32);
            lblDatosPaciente.TabIndex = 66;
            lblDatosPaciente.Text = "Historial de consultas:";
            // 
            // btnVerPaciente
            // 
            btnVerPaciente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerPaciente.AutoSize = true;
            btnVerPaciente.BackColor = Color.FromArgb(0, 126, 249);
            btnVerPaciente.FlatAppearance.BorderSize = 0;
            btnVerPaciente.FlatStyle = FlatStyle.Flat;
            btnVerPaciente.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerPaciente.ForeColor = Color.White;
            btnVerPaciente.Location = new Point(630, 397);
            btnVerPaciente.Margin = new Padding(3, 2, 3, 2);
            btnVerPaciente.Name = "btnVerPaciente";
            btnVerPaciente.Size = new Size(88, 29);
            btnVerPaciente.TabIndex = 68;
            btnVerPaciente.Text = "Ver\r\n";
            btnVerPaciente.UseVisualStyleBackColor = false;
            // 
            // ExpHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(752, 445);
            Controls.Add(btnVerPaciente);
            Controls.Add(lblNombrePaciente);
            Controls.Add(lblDatosPaciente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpHistorial";
            Text = "ExpHistorial";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblHistorialConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblNombrePaciente;
        private Label lblDatosPaciente;
        private DataGridView tblHistorialConsultas;
        private Button btnVerPaciente;
    }
}