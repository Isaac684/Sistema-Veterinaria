namespace Base___V1
{
    partial class ExpedienteVistaPrincipal
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
            PnlFormLoader2 = new Panel();
            btnHistorial = new Button();
            btnNewConsulta = new Button();
            btnVacunas = new Button();
            SuspendLayout();
            // 
            // PnlFormLoader2
            // 
            PnlFormLoader2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlFormLoader2.BackColor = Color.FromArgb(32, 42, 64);
            PnlFormLoader2.Location = new Point(10, 9);
            PnlFormLoader2.Margin = new Padding(3, 2, 3, 2);
            PnlFormLoader2.Name = "PnlFormLoader2";
            PnlFormLoader2.Size = new Size(675, 233);
            PnlFormLoader2.TabIndex = 0;
            // 
            // btnHistorial
            // 
            btnHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHistorial.AutoSize = true;
            btnHistorial.BackColor = Color.FromArgb(0, 126, 249);
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(362, 250);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(168, 29);
            btnHistorial.TabIndex = 10;
            btnHistorial.Text = "Historial de consultas";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnNewConsulta
            // 
            btnNewConsulta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewConsulta.AutoSize = true;
            btnNewConsulta.BackColor = Color.FromArgb(0, 126, 249);
            btnNewConsulta.FlatAppearance.BorderSize = 0;
            btnNewConsulta.FlatStyle = FlatStyle.Flat;
            btnNewConsulta.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewConsulta.ForeColor = Color.White;
            btnNewConsulta.Location = new Point(10, 250);
            btnNewConsulta.Margin = new Padding(3, 2, 3, 2);
            btnNewConsulta.Name = "btnNewConsulta";
            btnNewConsulta.Size = new Size(133, 29);
            btnNewConsulta.TabIndex = 9;
            btnNewConsulta.Text = "Nueva consulta";
            btnNewConsulta.UseVisualStyleBackColor = false;
            btnNewConsulta.Click += btnNewConsulta_Click;
            // 
            // btnVacunas
            // 
            btnVacunas.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVacunas.AutoSize = true;
            btnVacunas.BackColor = Color.FromArgb(0, 126, 249);
            btnVacunas.FlatAppearance.BorderSize = 0;
            btnVacunas.FlatStyle = FlatStyle.Flat;
            btnVacunas.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVacunas.ForeColor = Color.White;
            btnVacunas.Location = new Point(536, 250);
            btnVacunas.Margin = new Padding(3, 2, 3, 2);
            btnVacunas.Name = "btnVacunas";
            btnVacunas.Size = new Size(149, 29);
            btnVacunas.TabIndex = 11;
            btnVacunas.Text = "Control de vacuna";
            btnVacunas.UseVisualStyleBackColor = false;
            btnVacunas.Click += btnVacunas_Click;
            // 
            // ExpedienteVistaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(699, 290);
            Controls.Add(btnVacunas);
            Controls.Add(btnHistorial);
            Controls.Add(btnNewConsulta);
            Controls.Add(PnlFormLoader2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpedienteVistaPrincipal";
            Text = "Expediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel PnlFormLoader2;
        private Button btnHistorial;
        private Button btnNewConsulta;
        private Button btnVacunas;
    }
}