namespace Base___V1
{
	partial class MenuAddCita
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
			tableLayoutPanel1 = new TableLayoutPanel();
			button2 = new Button();
			label2 = new Label();
			txtName = new TextBox();
			dateTimePicker1 = new DateTimePicker();
			label6 = new Label();
			tblCitas = new DataGridView();
			button1 = new Button();
			label1 = new Label();
			IblTittle = new Label();
			btnAgregar = new Button();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tblCitas).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.AutoScroll = true;
			panel1.BackColor = Color.FromArgb(32, 42, 64);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Controls.Add(tblCitas);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(IblTittle);
			panel1.Location = new Point(11, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(919, 559);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 5;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.35356F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.64644F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 257F));
			tableLayoutPanel1.Controls.Add(button2, 2, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 0);
			tableLayoutPanel1.Controls.Add(txtName, 1, 0);
			tableLayoutPanel1.Controls.Add(dateTimePicker1, 4, 0);
			tableLayoutPanel1.Controls.Add(label6, 3, 0);
			tableLayoutPanel1.Location = new Point(3, 82);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(913, 60);
			tableLayoutPanel1.TabIndex = 27;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button2.Location = new Point(382, 13);
			button2.Name = "button2";
			button2.Size = new Size(113, 34);
			button2.TabIndex = 26;
			button2.Text = "Buscar";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 7);
			label2.Name = "label2";
			label2.Size = new Size(122, 46);
			label2.TabIndex = 11;
			label2.Text = "Dueño de la mascota:";
			// 
			// txtName
			// 
			txtName.Anchor = AnchorStyles.Left;
			txtName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtName.Location = new Point(209, 15);
			txtName.Name = "txtName";
			txtName.Size = new Size(167, 30);
			txtName.TabIndex = 12;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Anchor = AnchorStyles.Left;
			dateTimePicker1.Location = new Point(658, 16);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(252, 27);
			dateTimePicker1.TabIndex = 24;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Left;
			label6.AutoSize = true;
			label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(501, 18);
			label6.Name = "label6";
			label6.Size = new Size(151, 23);
			label6.TabIndex = 21;
			label6.Text = "Agendada para:";
			// 
			// tblCitas
			// 
			tblCitas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tblCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tblCitas.Location = new Point(36, 251);
			tblCitas.Name = "tblCitas";
			tblCitas.RowHeadersWidth = 51;
			tblCitas.Size = new Size(846, 282);
			tblCitas.TabIndex = 26;
			// 
			// button1
			// 
			button1.Location = new Point(36, 148);
			button1.Name = "button1";
			button1.Size = new Size(137, 34);
			button1.TabIndex = 25;
			button1.Text = "Agregar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(158, 161, 176);
			label1.Location = new Point(24, 33);
			label1.Name = "label1";
			label1.Size = new Size(237, 43);
			label1.TabIndex = 9;
			label1.Text = "Registro";
			// 
			// IblTittle
			// 
			IblTittle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			IblTittle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			IblTittle.ForeColor = Color.FromArgb(158, 161, 176);
			IblTittle.Location = new Point(24, 206);
			IblTittle.Name = "IblTittle";
			IblTittle.Size = new Size(441, 42);
			IblTittle.TabIndex = 8;
			IblTittle.Text = "Citas agendadas";
			// 
			// btnAgregar
			// 
			btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAgregar.AutoSize = true;
			btnAgregar.BackColor = Color.FromArgb(0, 126, 249);
			btnAgregar.FlatAppearance.BorderSize = 0;
			btnAgregar.FlatStyle = FlatStyle.Flat;
			btnAgregar.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(760, 564);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(170, 39);
			btnAgregar.TabIndex = 11;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// MenuAddCita
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(46, 51, 73);
			ClientSize = new Size(935, 618);
			Controls.Add(btnAgregar);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "MenuAddCita";
			Text = "Pantalla3";
			FormClosed += MenuAddPaciente_FormClosed;
			panel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tblCitas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private Label label6;
		private TextBox txtName;
		private Button btnAgregar;
		private Label IblTittle;
		private DateTimePicker dateTimePicker1;
		private Button button1;
		private DataGridView tblCitas;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button2;
	}
}