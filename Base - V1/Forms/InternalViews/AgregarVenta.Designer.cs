﻿namespace Base___V1.Forms.InternalViews
{
	partial class AgregarVenta
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
			label1 = new Label();
			button2 = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			button1 = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			label2 = new Label();
			label4 = new Label();
			label5 = new Label();
			txt2 = new NumericUpDown();
			txt6 = new TextBox();
			txt4 = new TextBox();
			label3 = new Label();
			tableLayoutPanel5 = new TableLayoutPanel();
			button3 = new Button();
			txt1 = new TextBox();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)txt2).BeginInit();
			tableLayoutPanel5.SuspendLayout();
			SuspendLayout();
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
			label1.Size = new Size(466, 61);
			label1.TabIndex = 11;
			label1.Text = "Registrar venta";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button2.BackColor = Color.DimGray;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = SystemColors.Control;
			button2.Location = new Point(206, 3);
			button2.Name = "button2";
			button2.Size = new Size(111, 35);
			button2.TabIndex = 2;
			button2.Text = "Cancelar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.5F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.5F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
			tableLayoutPanel2.Controls.Add(button2, 1, 0);
			tableLayoutPanel2.Controls.Add(button1, 2, 0);
			tableLayoutPanel2.Location = new Point(3, 530);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(466, 42);
			tableLayoutPanel2.TabIndex = 14;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(31, 38, 67);
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(323, 3);
			button1.Name = "button1";
			button1.Size = new Size(140, 35);
			button1.TabIndex = 3;
			button1.Text = "Aceptar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.4058F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.594203F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 405F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
			tableLayoutPanel1.Size = new Size(472, 575);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 2;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.89817F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.10183F));
			tableLayoutPanel3.Controls.Add(label2, 0, 0);
			tableLayoutPanel3.Controls.Add(label4, 0, 1);
			tableLayoutPanel3.Controls.Add(label5, 0, 2);
			tableLayoutPanel3.Controls.Add(txt2, 1, 1);
			tableLayoutPanel3.Controls.Add(txt6, 1, 2);
			tableLayoutPanel3.Controls.Add(txt4, 1, 3);
			tableLayoutPanel3.Controls.Add(label3, 0, 3);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
			tableLayoutPanel3.Location = new Point(3, 72);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 4;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.42529F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.57471F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Size = new Size(466, 379);
			tableLayoutPanel3.TabIndex = 15;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(147, 97);
			label2.TabIndex = 13;
			label2.Text = "Producto";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(3, 97);
			label4.Name = "label4";
			label4.Size = new Size(147, 99);
			label4.TabIndex = 17;
			label4.Text = "Cantidad";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(3, 196);
			label5.Name = "label5";
			label5.Size = new Size(147, 102);
			label5.TabIndex = 19;
			label5.Text = "Precio unitario";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt2
			// 
			txt2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txt2.Location = new Point(156, 133);
			txt2.Name = "txt2";
			txt2.Size = new Size(307, 27);
			txt2.TabIndex = 16;
			txt2.ValueChanged += txt2_ValueChanged;
			// 
			// txt6
			// 
			txt6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txt6.Enabled = false;
			txt6.Location = new Point(156, 233);
			txt6.Name = "txt6";
			txt6.Size = new Size(307, 27);
			txt6.TabIndex = 25;
			// 
			// txt4
			// 
			txt4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txt4.Enabled = false;
			txt4.Location = new Point(156, 325);
			txt4.Name = "txt4";
			txt4.Size = new Size(307, 27);
			txt4.TabIndex = 27;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(3, 298);
			label3.Name = "label3";
			label3.Size = new Size(147, 81);
			label3.TabIndex = 26;
			label3.Text = "Monto total";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 2;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.312706F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6872959F));
			tableLayoutPanel5.Controls.Add(button3, 0, 0);
			tableLayoutPanel5.Controls.Add(txt1, 0, 0);
			tableLayoutPanel5.Location = new Point(156, 3);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.Size = new Size(307, 91);
			tableLayoutPanel5.TabIndex = 28;
			// 
			// button3
			// 
			button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button3.BackColor = Color.FromArgb(31, 38, 67);
			button3.FlatStyle = FlatStyle.Flat;
			button3.ForeColor = SystemColors.Control;
			button3.Location = new Point(225, 28);
			button3.Name = "button3";
			button3.Size = new Size(79, 35);
			button3.TabIndex = 25;
			button3.Text = "Buscar";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// txt1
			// 
			txt1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txt1.Location = new Point(3, 32);
			txt1.Name = "txt1";
			txt1.Size = new Size(216, 27);
			txt1.TabIndex = 24;
			// 
			// AgregarVenta
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(472, 575);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AgregarVenta";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Agregar_producto";
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)txt2).EndInit();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Button button2;
		private TableLayoutPanel tableLayoutPanel2;
		private Button button1;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label5;
		private Label label2;
		private Label label4;
		private TextBox txt6;
		private TextBox txt4;
		private Label label3;
		private TableLayoutPanel tableLayoutPanel5;
		private Button button3;
		private TextBox txt1;
		private NumericUpDown txt2;
	}
}