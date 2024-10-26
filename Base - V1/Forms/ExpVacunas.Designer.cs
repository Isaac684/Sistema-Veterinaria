namespace Base___V1
{
    partial class ExpVacunas
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNombrePaciente = new Label();
            lblDatosPaciente = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Location = new Point(10, 59);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(731, 367);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.BackColor = Color.White;
            lblNombrePaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombrePaciente.ForeColor = Color.Black;
            lblNombrePaciente.Location = new Point(268, 15);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(340, 32);
            lblNombrePaciente.TabIndex = 63;
            lblNombrePaciente.Text = "Nombre del chucho";
            // 
            // lblDatosPaciente
            // 
            lblDatosPaciente.BackColor = Color.White;
            lblDatosPaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPaciente.ForeColor = Color.Black;
            lblDatosPaciente.Location = new Point(10, 15);
            lblDatosPaciente.Name = "lblDatosPaciente";
            lblDatosPaciente.Size = new Size(292, 32);
            lblDatosPaciente.TabIndex = 62;
            lblDatosPaciente.Text = "Control de Vacunas:";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.FromArgb(0, 126, 249);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(593, 20);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 29);
            btnAgregar.TabIndex = 64;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // ExpVacunas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(752, 445);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombrePaciente);
            Controls.Add(lblDatosPaciente);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpVacunas";
            Text = "ExpVacunas";
            Activated += ExpVacunas_Activated;
            Load += ExpVacunas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblNombrePaciente;
        private Label lblDatosPaciente;
        private Button btnAgregar;
    }
}