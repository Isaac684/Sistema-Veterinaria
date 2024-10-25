namespace Base___V1.Forms.InternalViews
{
	partial class KeyConfirm
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
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox5 = new TextBox();
			tableLayoutPanel4 = new TableLayoutPanel();
			button1 = new Button();
			button2 = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 109F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(350, 200);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.FromArgb(31, 38, 67);
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Calibri", 14F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(344, 51);
			label1.TabIndex = 24;
			label1.Text = "Clave de Administrador";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3197975F));
			tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 54);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(344, 103);
			tableLayoutPanel2.TabIndex = 28;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 5;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.Controls.Add(textBox2, 0, 0);
			tableLayoutPanel3.Controls.Add(textBox1, 0, 0);
			tableLayoutPanel3.Controls.Add(textBox4, 3, 0);
			tableLayoutPanel3.Controls.Add(textBox3, 2, 0);
			tableLayoutPanel3.Controls.Add(textBox5, 4, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 3);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Size = new Size(338, 97);
			tableLayoutPanel3.TabIndex = 28;
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox2.BackColor = Color.Gray;
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
			textBox2.ForeColor = Color.White;
			textBox2.HideSelection = false;
			textBox2.ImeMode = ImeMode.On;
			textBox2.Location = new Point(70, 31);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '*';
			textBox2.PlaceholderText = "-";
			textBox2.Size = new Size(61, 34);
			textBox2.TabIndex = 15;
			textBox2.TextAlign = HorizontalAlignment.Center;
			textBox2.UseSystemPasswordChar = true;
			textBox2.WordWrap = false;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox1.BackColor = Color.Gray;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
			textBox1.ForeColor = Color.White;
			textBox1.ImeMode = ImeMode.On;
			textBox1.Location = new Point(3, 31);
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "-";
			textBox1.Size = new Size(61, 34);
			textBox1.TabIndex = 14;
			textBox1.TextAlign = HorizontalAlignment.Center;
			textBox1.UseSystemPasswordChar = true;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// textBox4
			// 
			textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox4.BackColor = Color.Gray;
			textBox4.BorderStyle = BorderStyle.None;
			textBox4.CharacterCasing = CharacterCasing.Upper;
			textBox4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
			textBox4.ForeColor = Color.White;
			textBox4.HideSelection = false;
			textBox4.ImeMode = ImeMode.On;
			textBox4.Location = new Point(204, 31);
			textBox4.Name = "textBox4";
			textBox4.PasswordChar = '*';
			textBox4.PlaceholderText = "-";
			textBox4.Size = new Size(61, 34);
			textBox4.TabIndex = 17;
			textBox4.TextAlign = HorizontalAlignment.Center;
			textBox4.UseSystemPasswordChar = true;
			textBox4.TextChanged += textBox4_TextChanged;
			// 
			// textBox3
			// 
			textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox3.BackColor = Color.Gray;
			textBox3.BorderStyle = BorderStyle.None;
			textBox3.CharacterCasing = CharacterCasing.Upper;
			textBox3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
			textBox3.ForeColor = Color.White;
			textBox3.HideSelection = false;
			textBox3.ImeMode = ImeMode.On;
			textBox3.Location = new Point(137, 31);
			textBox3.Name = "textBox3";
			textBox3.PasswordChar = '*';
			textBox3.PlaceholderText = "-";
			textBox3.Size = new Size(61, 34);
			textBox3.TabIndex = 16;
			textBox3.TextAlign = HorizontalAlignment.Center;
			textBox3.UseSystemPasswordChar = true;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// textBox5
			// 
			textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			textBox5.BackColor = Color.Gray;
			textBox5.BorderStyle = BorderStyle.None;
			textBox5.CharacterCasing = CharacterCasing.Upper;
			textBox5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
			textBox5.ForeColor = Color.White;
			textBox5.HideSelection = false;
			textBox5.ImeMode = ImeMode.On;
			textBox5.Location = new Point(271, 31);
			textBox5.Name = "textBox5";
			textBox5.PasswordChar = '*';
			textBox5.PlaceholderText = "-";
			textBox5.Size = new Size(64, 34);
			textBox5.TabIndex = 18;
			textBox5.TextAlign = HorizontalAlignment.Center;
			textBox5.UseSystemPasswordChar = true;
			textBox5.TextChanged += textBox5_TextChanged;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 3;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.7619057F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.2380943F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
			tableLayoutPanel4.Controls.Add(button1, 2, 0);
			tableLayoutPanel4.Controls.Add(button2, 1, 0);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 163);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Size = new Size(344, 34);
			tableLayoutPanel4.TabIndex = 29;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(31, 38, 67);
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(222, 3);
			button1.Name = "button1";
			button1.Size = new Size(119, 28);
			button1.TabIndex = 5;
			button1.Text = "Aceptar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button2.BackColor = Color.DimGray;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = SystemColors.Control;
			button2.Location = new Point(101, 3);
			button2.Name = "button2";
			button2.Size = new Size(115, 28);
			button2.TabIndex = 4;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// KeyConfirm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(350, 200);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "KeyConfirm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "KeyConfirm";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private TextBox textBox5;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private TableLayoutPanel tableLayoutPanel4;
		private Button button1;
		private Button button2;
	}
}