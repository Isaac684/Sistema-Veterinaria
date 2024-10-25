namespace Base___V1
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
			ExpInfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
			ExpInfoPanel.Location = new Point(-1, 0);
			ExpInfoPanel.Name = "ExpInfoPanel";
			ExpInfoPanel.Size = new Size(882, 593);
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
			label12.Location = new Point(517, 598);
			label12.Name = "label12";
			label12.Size = new Size(98, 23);
			label12.TabIndex = 72;
			label12.Text = "Resultado";
			// 
			// btnCapturar
			// 
			btnCapturar.AutoSize = true;
			btnCapturar.BackColor = Color.Gray;
			btnCapturar.FlatAppearance.BorderSize = 0;
			btnCapturar.FlatStyle = FlatStyle.Flat;
			btnCapturar.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCapturar.ForeColor = Color.White;
			btnCapturar.Location = new Point(185, 860);
			btnCapturar.Name = "btnCapturar";
			btnCapturar.Size = new Size(117, 44);
			btnCapturar.TabIndex = 67;
			btnCapturar.Text = "Capturar";
			btnCapturar.UseVisualStyleBackColor = false;
			btnCapturar.Click += btnCapturar_Click;
			// 
			// pb2
			// 
			pb2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pb2.Location = new Point(257, 635);
			pb2.Name = "pb2";
			pb2.Size = new Size(358, 200);
			pb2.SizeMode = PictureBoxSizeMode.StretchImage;
			pb2.TabIndex = 71;
			pb2.TabStop = false;
			// 
			// pbFoto
			// 
			pbFoto.Image = Properties.Resources.dog_cat;
			pbFoto.ImageLocation = "";
			pbFoto.Location = new Point(35, 12);
			pbFoto.Name = "pbFoto";
			pbFoto.Size = new Size(261, 161);
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
			cbEdicion.Location = new Point(696, 597);
			cbEdicion.Name = "cbEdicion";
			cbEdicion.Size = new Size(142, 24);
			cbEdicion.TabIndex = 65;
			cbEdicion.Text = "Habilitar edicion";
			cbEdicion.UseVisualStyleBackColor = false;
			cbEdicion.CheckedChanged += cbEdicion_CheckedChanged;
			// 
			// txtSeñas
			// 
			txtSeñas.Location = new Point(383, 200);
			txtSeñas.Name = "txtSeñas";
			txtSeñas.Size = new Size(427, 27);
			txtSeñas.TabIndex = 64;
			txtSeñas.TextChanged += txtSeñas_TextChanged;
			// 
			// txtEdad
			// 
			txtEdad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			txtEdad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEdad.Location = new Point(405, 119);
			txtEdad.Name = "txtEdad";
			txtEdad.Size = new Size(159, 30);
			txtEdad.TabIndex = 63;
			// 
			// lblNombrePaciente
			// 
			lblNombrePaciente.BackColor = Color.Transparent;
			lblNombrePaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNombrePaciente.ForeColor = Color.Black;
			lblNombrePaciente.Location = new Point(521, 12);
			lblNombrePaciente.Name = "lblNombrePaciente";
			lblNombrePaciente.Size = new Size(389, 43);
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
			label13.Location = new Point(590, 512);
			label13.Name = "label13";
			label13.Size = new Size(90, 23);
			label13.TabIndex = 60;
			label13.Text = "Telefono:";
			// 
			// txtTelefono
			// 
			txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			txtTelefono.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtTelefono.Location = new Point(564, 509);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(274, 30);
			txtTelefono.TabIndex = 59;
			// 
			// label14
			// 
			label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label14.AutoSize = true;
			label14.BackColor = Color.Transparent;
			label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label14.ForeColor = Color.Black;
			label14.Location = new Point(57, 509);
			label14.Name = "label14";
			label14.Size = new Size(77, 23);
			label14.TabIndex = 58;
			label14.Text = "Correo:";
			// 
			// txtCorreo
			// 
			txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtCorreo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtCorreo.Location = new Point(149, 509);
			txtCorreo.Name = "txtCorreo";
			txtCorreo.Size = new Size(409, 30);
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
			label11.Location = new Point(37, 445);
			label11.Name = "label11";
			label11.Size = new Size(97, 23);
			label11.TabIndex = 56;
			label11.Text = "Dirección:";
			// 
			// txtDireccion
			// 
			txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtDireccion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtDireccion.Location = new Point(149, 419);
			txtDireccion.Multiline = true;
			txtDireccion.Name = "txtDireccion";
			txtDireccion.Size = new Size(689, 49);
			txtDireccion.TabIndex = 55;
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label10.AutoSize = true;
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.Black;
			label10.Location = new Point(37, 349);
			label10.Name = "label10";
			label10.Size = new Size(112, 23);
			label10.TabIndex = 54;
			label10.Text = "Propietario:";
			// 
			// txtNombrePro
			// 
			txtNombrePro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtNombrePro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtNombrePro.Location = new Point(149, 349);
			txtNombrePro.Name = "txtNombrePro";
			txtNombrePro.Size = new Size(689, 30);
			txtNombrePro.TabIndex = 53;
			// 
			// label8
			// 
			label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.Black;
			label8.Location = new Point(307, 200);
			label8.Name = "label8";
			label8.Size = new Size(72, 23);
			label8.TabIndex = 50;
			label8.Text = "Señas:";
			// 
			// cbSexo
			// 
			cbSexo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			cbSexo.FormattingEnabled = true;
			cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
			cbSexo.Location = new Point(650, 120);
			cbSexo.Name = "cbSexo";
			cbSexo.Size = new Size(159, 28);
			cbSexo.TabIndex = 48;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(37, 200);
			label5.Name = "label5";
			label5.Size = new Size(63, 23);
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
			label6.Location = new Point(583, 127);
			label6.Name = "label6";
			label6.Size = new Size(60, 23);
			label6.TabIndex = 46;
			label6.Text = "Sexo:";
			// 
			// txtColor
			// 
			txtColor.Location = new Point(106, 196);
			txtColor.Name = "txtColor";
			txtColor.Size = new Size(157, 27);
			txtColor.TabIndex = 62;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Black;
			label7.Location = new Point(331, 119);
			label7.Name = "label7";
			label7.Size = new Size(62, 23);
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
			label4.Location = new Point(583, 63);
			label4.Name = "label4";
			label4.Size = new Size(61, 23);
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
			label3.Location = new Point(309, 60);
			label3.Name = "label3";
			label3.Size = new Size(86, 23);
			label3.TabIndex = 41;
			label3.Text = "Especie:";
			// 
			// txtRaza
			// 
			txtRaza.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			txtRaza.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtRaza.Location = new Point(650, 60);
			txtRaza.Name = "txtRaza";
			txtRaza.Size = new Size(159, 30);
			txtRaza.TabIndex = 40;
			// 
			// txtEspecie
			// 
			txtEspecie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			txtEspecie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEspecie.Location = new Point(405, 57);
			txtEspecie.Name = "txtEspecie";
			txtEspecie.Size = new Size(153, 30);
			txtEspecie.TabIndex = 39;
			// 
			// lblDatosPaciente
			// 
			lblDatosPaciente.BackColor = Color.Transparent;
			lblDatosPaciente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDatosPaciente.ForeColor = Color.Black;
			lblDatosPaciente.Location = new Point(303, 12);
			lblDatosPaciente.Name = "lblDatosPaciente";
			lblDatosPaciente.Size = new Size(238, 43);
			lblDatosPaciente.TabIndex = 38;
			lblDatosPaciente.Text = "Datos paciente:";
			// 
			// lblDatosPropietario
			// 
			lblDatosPropietario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDatosPropietario.BackColor = Color.Transparent;
			lblDatosPropietario.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDatosPropietario.ForeColor = Color.Black;
			lblDatosPropietario.Location = new Point(35, 280);
			lblDatosPropietario.Name = "lblDatosPropietario";
			lblDatosPropietario.Size = new Size(541, 43);
			lblDatosPropietario.TabIndex = 37;
			lblDatosPropietario.Text = "Datos del propietario";
			// 
			// ExpInfo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = Color.FromArgb(46, 51, 73);
			ClientSize = new Size(882, 593);
			Controls.Add(ExpInfoPanel);
			FormBorderStyle = FormBorderStyle.None;
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