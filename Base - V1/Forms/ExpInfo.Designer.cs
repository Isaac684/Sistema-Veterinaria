﻿namespace Base___V1
{
	partial class ExpInfo
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
            ExpInfoPanel = new Panel();
            label12 = new Label();
            btnCapturar = new Button();
            pb2 = new PictureBox();
            pbFoto = new PictureBox();
            cbEdicion = new CheckBox();
            txtSeñas = new TextBox();
            txtEdad = new TextBox();
            lblNombrePaciente = new Label();
            label13 = new Label();
            txtTelefono = new TextBox();
            label14 = new Label();
            txtCorreo = new TextBox();
            label11 = new Label();
            txtDireccion = new TextBox();
            label10 = new Label();
            txtNombrePro = new TextBox();
            label8 = new Label();
            cbSexo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtColor = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtRaza = new TextBox();
            txtEspecie = new TextBox();
            lblDatosPaciente = new Label();
            lblDatosPropietario = new Label();
            ExpInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // ExpInfoPanel
            // 
            ExpInfoPanel.AutoScroll = true;
            ExpInfoPanel.BackColor = Color.White;
            ExpInfoPanel.Controls.Add(label12);
            ExpInfoPanel.Controls.Add(btnCapturar);
            ExpInfoPanel.Controls.Add(pb2);
            ExpInfoPanel.Controls.Add(pbFoto);
            ExpInfoPanel.Controls.Add(cbEdicion);
            ExpInfoPanel.Controls.Add(txtSeñas);
            ExpInfoPanel.Controls.Add(txtEdad);
            ExpInfoPanel.Controls.Add(lblNombrePaciente);
            ExpInfoPanel.Controls.Add(label13);
            ExpInfoPanel.Controls.Add(txtTelefono);
            ExpInfoPanel.Controls.Add(label14);
            ExpInfoPanel.Controls.Add(txtCorreo);
            ExpInfoPanel.Controls.Add(label11);
            ExpInfoPanel.Controls.Add(txtDireccion);
            ExpInfoPanel.Controls.Add(label10);
            ExpInfoPanel.Controls.Add(txtNombrePro);
            ExpInfoPanel.Controls.Add(label8);
            ExpInfoPanel.Controls.Add(cbSexo);
            ExpInfoPanel.Controls.Add(label5);
            ExpInfoPanel.Controls.Add(label6);
            ExpInfoPanel.Controls.Add(txtColor);
            ExpInfoPanel.Controls.Add(label7);
            ExpInfoPanel.Controls.Add(label4);
            ExpInfoPanel.Controls.Add(label3);
            ExpInfoPanel.Controls.Add(txtRaza);
            ExpInfoPanel.Controls.Add(txtEspecie);
            ExpInfoPanel.Controls.Add(lblDatosPaciente);
            ExpInfoPanel.Controls.Add(lblDatosPropietario);
            ExpInfoPanel.Dock = DockStyle.Fill;
            ExpInfoPanel.Location = new Point(0, 0);
            ExpInfoPanel.Margin = new Padding(3, 2, 3, 2);
            ExpInfoPanel.Name = "ExpInfoPanel";
            ExpInfoPanel.Size = new Size(845, 445);
            ExpInfoPanel.TabIndex = 1;
            ExpInfoPanel.Paint += ExpInfoPanel_Paint;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(364, 446);
            label12.Name = "label12";
            label12.Size = new Size(80, 18);
            label12.TabIndex = 72;
            label12.Text = "Fotografia";
            // 
            // btnCapturar
            // 
            btnCapturar.AutoSize = true;
            btnCapturar.BackColor = Color.Gray;
            btnCapturar.FlatAppearance.BorderSize = 0;
            btnCapturar.FlatStyle = FlatStyle.Flat;
            btnCapturar.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapturar.ForeColor = Color.White;
            btnCapturar.Location = new Point(342, 643);
            btnCapturar.Margin = new Padding(3, 2, 3, 2);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(102, 33);
            btnCapturar.TabIndex = 67;
            btnCapturar.Text = "Capturar";
            btnCapturar.UseVisualStyleBackColor = false;
            btnCapturar.Click += btnCapturar_Click;
            // 
            // pb2
            // 
            pb2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pb2.Location = new Point(249, 479);
            pb2.Margin = new Padding(3, 2, 3, 2);
            pb2.Name = "pb2";
            pb2.Size = new Size(304, 150);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 71;
            pb2.TabStop = false;
            // 
            // pbFoto
            // 
            pbFoto.Image = Properties.Resources.dog_cat;
            pbFoto.ImageLocation = "";
            pbFoto.Location = new Point(31, 9);
            pbFoto.Margin = new Padding(3, 2, 3, 2);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(228, 121);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 66;
            pbFoto.TabStop = false;
            // 
            // cbEdicion
            // 
            cbEdicion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbEdicion.AutoSize = true;
            cbEdicion.BackColor = Color.Transparent;
            cbEdicion.ForeColor = Color.Black;
            cbEdicion.Location = new Point(611, 448);
            cbEdicion.Margin = new Padding(3, 2, 3, 2);
            cbEdicion.Name = "cbEdicion";
            cbEdicion.Size = new Size(113, 19);
            cbEdicion.TabIndex = 65;
            cbEdicion.Text = "Habilitar edicion";
            cbEdicion.UseVisualStyleBackColor = false;
            cbEdicion.CheckedChanged += cbEdicion_CheckedChanged;
            // 
            // txtSeñas
            // 
            txtSeñas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSeñas.Location = new Point(335, 150);
            txtSeñas.Margin = new Padding(3, 2, 3, 2);
            txtSeñas.Name = "txtSeñas";
            txtSeñas.Size = new Size(374, 23);
            txtSeñas.TabIndex = 64;
            txtSeñas.TextChanged += txtSeñas_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEdad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(354, 89);
            txtEdad.Margin = new Padding(3, 2, 3, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(140, 26);
            txtEdad.TabIndex = 63;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.BackColor = Color.Transparent;
            lblNombrePaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombrePaciente.ForeColor = Color.Black;
            lblNombrePaciente.Location = new Point(456, 9);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(340, 32);
            lblNombrePaciente.TabIndex = 61;
            lblNombrePaciente.Text = "Nombre del chuco";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(408, 385);
            label13.Name = "label13";
            label13.Size = new Size(70, 18);
            label13.TabIndex = 60;
            label13.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(484, 382);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(240, 26);
            txtTelefono.TabIndex = 59;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(50, 382);
            label14.Name = "label14";
            label14.Size = new Size(61, 18);
            label14.TabIndex = 58;
            label14.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(130, 382);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(255, 26);
            txtCorreo.TabIndex = 57;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(32, 317);
            label11.Name = "label11";
            label11.Size = new Size(79, 18);
            label11.TabIndex = 56;
            label11.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(130, 314);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(594, 38);
            txtDireccion.TabIndex = 55;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(32, 262);
            label10.Name = "label10";
            label10.Size = new Size(90, 18);
            label10.TabIndex = 54;
            label10.Text = "Propietario:";
            // 
            // txtNombrePro
            // 
            txtNombrePro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombrePro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePro.Location = new Point(130, 262);
            txtNombrePro.Margin = new Padding(3, 2, 3, 2);
            txtNombrePro.Name = "txtNombrePro";
            txtNombrePro.Size = new Size(594, 26);
            txtNombrePro.TabIndex = 53;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(269, 150);
            label8.Name = "label8";
            label8.Size = new Size(57, 18);
            label8.TabIndex = 50;
            label8.Text = "Señas:";
            // 
            // cbSexo
            // 
            cbSexo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cbSexo.Location = new Point(569, 90);
            cbSexo.Margin = new Padding(3, 2, 3, 2);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(140, 23);
            cbSexo.TabIndex = 48;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(32, 150);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 47;
            label5.Text = "Color:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(510, 95);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 46;
            label6.Text = "Sexo:";
            // 
            // txtColor
            // 
            txtColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtColor.Location = new Point(93, 147);
            txtColor.Margin = new Padding(3, 2, 3, 2);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(138, 23);
            txtColor.TabIndex = 62;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(290, 89);
            label7.Name = "label7";
            label7.Size = new Size(50, 18);
            label7.TabIndex = 44;
            label7.Text = "Edad:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(510, 47);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 42;
            label4.Text = "Raza:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(270, 45);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 41;
            label3.Text = "Especie:";
            // 
            // txtRaza
            // 
            txtRaza.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtRaza.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRaza.Location = new Point(569, 45);
            txtRaza.Margin = new Padding(3, 2, 3, 2);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(140, 26);
            txtRaza.TabIndex = 40;
            txtRaza.TextChanged += txtRaza_TextChanged;
            // 
            // txtEspecie
            // 
            txtEspecie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEspecie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecie.Location = new Point(354, 43);
            txtEspecie.Margin = new Padding(3, 2, 3, 2);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(134, 26);
            txtEspecie.TabIndex = 39;
            // 
            // lblDatosPaciente
            // 
            lblDatosPaciente.BackColor = Color.Transparent;
            lblDatosPaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPaciente.ForeColor = Color.Black;
            lblDatosPaciente.Location = new Point(265, 9);
            lblDatosPaciente.Name = "lblDatosPaciente";
            lblDatosPaciente.Size = new Size(208, 32);
            lblDatosPaciente.TabIndex = 38;
            lblDatosPaciente.Text = "Datos paciente:";
            // 
            // lblDatosPropietario
            // 
            lblDatosPropietario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDatosPropietario.BackColor = Color.Transparent;
            lblDatosPropietario.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPropietario.ForeColor = Color.Black;
            lblDatosPropietario.Location = new Point(31, 210);
            lblDatosPropietario.Name = "lblDatosPropietario";
            lblDatosPropietario.Size = new Size(464, 32);
            lblDatosPropietario.TabIndex = 37;
            lblDatosPropietario.Text = "Datos del propietario";
            // 
            // ExpInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(845, 445);
            Controls.Add(ExpInfoPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpInfo";
            Text = "ExpInfo";
            ExpInfoPanel.ResumeLayout(false);
            ExpInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ExpInfoPanel;
		private Label label13;
		private TextBox txtTelefono;
		private Label label14;
		private TextBox txtCorreo;
		private Label label11;
		private TextBox txtDireccion;
		private Label label10;
		private TextBox txtNombrePro;
		private Label label8;
		private ComboBox cbSexo;
		private Label label5;
		private Label label6;
		private TextBox txtColor;
		private Label label7;
		private Label label4;
		private Label label3;
		private TextBox txtRaza;
		private TextBox txtEspecie;
		private Label lblDatosPaciente;
		private Label lblDatosPropietario;
		private Label lblNombrePaciente;
		private TextBox txtSeñas;
		private TextBox txtEdad;
		private CheckBox cbEdicion;
		private PictureBox pbFoto;
		private Label label12;
		private Button btnCapturar;
		private PictureBox pb2;
		private VScrollBar vScrollBar1;
	}
}