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
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel4 = new TableLayoutPanel();
			btnBuscar = new Button();
			IblTittle = new Label();
			dateCita = new DateTimePicker();
			tblCitas = new DataGridView();
			tableLayoutPanel2 = new TableLayoutPanel();
			txtDescription = new TextBox();
			label3 = new Label();
			button1 = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			button2 = new Button();
			label2 = new Label();
			txtName = new TextBox();
			timePicker = new DateTimePicker();
			label6 = new Label();
			label1 = new Label();
			btnAgregar = new Button();
			panel1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tblCitas).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.AutoScroll = true;
			panel1.BackColor = Color.FromArgb(32, 42, 64);
			panel1.Controls.Add(tableLayoutPanel3);
			panel1.Controls.Add(tableLayoutPanel2);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(11, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(919, 559);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
			tableLayoutPanel3.Controls.Add(tblCitas, 0, 1);
			tableLayoutPanel3.Location = new Point(3, 209);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8409891F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85.15901F));
			tableLayoutPanel3.Size = new Size(913, 347);
			tableLayoutPanel3.TabIndex = 30;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 3;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
			tableLayoutPanel4.Controls.Add(btnBuscar, 2, 0);
			tableLayoutPanel4.Controls.Add(IblTittle, 0, 0);
			tableLayoutPanel4.Controls.Add(dateCita, 1, 0);
			tableLayoutPanel4.Location = new Point(3, 3);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Size = new Size(906, 45);
			tableLayoutPanel4.TabIndex = 12;
			// 
			// btnBuscar
			// 
			btnBuscar.Dock = DockStyle.Fill;
			btnBuscar.Location = new Point(769, 3);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(134, 39);
			btnBuscar.TabIndex = 26;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = true;
			btnBuscar.Click += btnBuscar_Click;
			// 
			// IblTittle
			// 
			IblTittle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			IblTittle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			IblTittle.ForeColor = Color.FromArgb(158, 161, 176);
			IblTittle.Location = new Point(3, 3);
			IblTittle.Name = "IblTittle";
			IblTittle.Size = new Size(498, 42);
			IblTittle.TabIndex = 8;
			IblTittle.Text = "Citas agendadas";
			IblTittle.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// dateCita
			// 
			dateCita.Anchor = AnchorStyles.Left;
			dateCita.Location = new Point(507, 9);
			dateCita.Name = "dateCita";
			dateCita.Size = new Size(252, 27);
			dateCita.TabIndex = 25;
			// 
			// tblCitas
			// 
			tblCitas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tblCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tblCitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tblCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tblCitas.Location = new Point(3, 54);
			tblCitas.Name = "tblCitas";
			tblCitas.RowHeadersWidth = 51;
			tblCitas.Size = new Size(907, 290);
			tblCitas.TabIndex = 26;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.41958F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.58042F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			tableLayoutPanel2.Controls.Add(txtDescription, 1, 0);
			tableLayoutPanel2.Controls.Add(label3, 0, 0);
			tableLayoutPanel2.Controls.Add(button1, 2, 0);
			tableLayoutPanel2.Location = new Point(3, 138);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(916, 44);
			tableLayoutPanel2.TabIndex = 29;
			tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
			// 
			// txtDescription
			// 
			txtDescription.Anchor = AnchorStyles.Left;
			txtDescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtDescription.Location = new Point(149, 7);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(562, 30);
			txtDescription.TabIndex = 28;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(3, 10);
			label3.Name = "label3";
			label3.Size = new Size(118, 23);
			label3.TabIndex = 22;
			label3.Text = "Descripcion:";
			// 
			// button1
			// 
			button1.Dock = DockStyle.Fill;
			button1.Location = new Point(718, 3);
			button1.Name = "button1";
			button1.Size = new Size(195, 38);
			button1.TabIndex = 25;
			button1.Text = "Agregar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 5;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.10554F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.89446F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 257F));
			tableLayoutPanel1.Controls.Add(button2, 2, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 0);
			tableLayoutPanel1.Controls.Add(txtName, 1, 0);
			tableLayoutPanel1.Controls.Add(timePicker, 4, 0);
			tableLayoutPanel1.Controls.Add(label6, 3, 0);
			tableLayoutPanel1.Location = new Point(3, 82);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
			label2.Size = new Size(134, 46);
			label2.TabIndex = 11;
			label2.Text = "Nombre de la mascota:";
			label2.Click += label2_Click;
			// 
			// txtName
			// 
			txtName.Anchor = AnchorStyles.Left;
			txtName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtName.Location = new Point(155, 15);
			txtName.Name = "txtName";
			txtName.Size = new Size(202, 30);
			txtName.TabIndex = 12;
			// 
			// timePicker
			// 
			timePicker.Anchor = AnchorStyles.Left;
			timePicker.Location = new Point(658, 16);
			timePicker.Name = "timePicker";
			timePicker.Size = new Size(252, 27);
			timePicker.TabIndex = 24;
			timePicker.Value = new DateTime(2024, 10, 19, 23, 3, 48, 0);
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
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tblCitas).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
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
		private DateTimePicker timePicker;
		private Button button1;
		private DataGridView tblCitas;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button2;
		private TableLayoutPanel tableLayoutPanel2;
		private TextBox txtDescription;
		private Label label3;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel4;
		private Button btnBuscar;
		private DateTimePicker dateCita;
	}
}