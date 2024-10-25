namespace Base___V1.Forms.InternalViews
{
	partial class Camara
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
			pb1 = new PictureBox();
			label1 = new Label();
			tableLayoutPanel4 = new TableLayoutPanel();
			button1 = new Button();
			button2 = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			cbxCamara = new ComboBox();
			label9 = new Label();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(pb1, 0, 2);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 317F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(600, 450);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// pb1
			// 
			pb1.BackgroundImageLayout = ImageLayout.Stretch;
			pb1.Dock = DockStyle.Fill;
			pb1.Location = new Point(3, 94);
			pb1.Name = "pb1";
			pb1.Size = new Size(594, 311);
			pb1.TabIndex = 39;
			pb1.TabStop = false;
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
			label1.Size = new Size(594, 39);
			label1.TabIndex = 24;
			label1.Text = "Clave de Administrador";
			label1.TextAlign = ContentAlignment.MiddleCenter;
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
			tableLayoutPanel4.Location = new Point(3, 411);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Size = new Size(594, 36);
			tableLayoutPanel4.TabIndex = 29;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(31, 38, 67);
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(472, 4);
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
			button2.Location = new Point(213, 4);
			button2.Name = "button2";
			button2.Size = new Size(253, 28);
			button2.TabIndex = 4;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.13468F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.86532F));
			tableLayoutPanel2.Controls.Add(cbxCamara, 0, 0);
			tableLayoutPanel2.Controls.Add(label9, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 42);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(594, 46);
			tableLayoutPanel2.TabIndex = 30;
			// 
			// cbxCamara
			// 
			cbxCamara.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			cbxCamara.FormattingEnabled = true;
			cbxCamara.Location = new Point(182, 9);
			cbxCamara.Name = "cbxCamara";
			cbxCamara.Size = new Size(409, 28);
			cbxCamara.TabIndex = 38;
			cbxCamara.SelectedIndexChanged += cbxCamara_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			label9.AutoSize = true;
			label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.Black;
			label9.Location = new Point(3, 11);
			label9.Name = "label9";
			label9.Size = new Size(173, 23);
			label9.TabIndex = 39;
			label9.Text = "Camara";
			// 
			// Camara
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(600, 450);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Camara";
			Text = "Camara";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pb1).EndInit();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel4;
		private Button button1;
		private Button button2;
		private TableLayoutPanel tableLayoutPanel2;
		private PictureBox pb1;
		private ComboBox cbxCamara;
		private Label label9;
	}
}