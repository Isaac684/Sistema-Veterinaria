namespace Base___V1.Forms
{
	partial class InventarioForm
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
			tableLayoutPanel2 = new TableLayoutPanel();
			label2 = new Label();
			button1 = new Button();
			txtSearch = new TextBox();
			label1 = new Label();
			tblProductos = new DataGridView();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tblProductos).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.BackColor = Color.FromArgb(32, 42, 64);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(935, 548);
			panel1.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(tblProductos, 0, 2);
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.02631F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9736843F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 379F));
			tableLayoutPanel1.Size = new Size(929, 532);
			tableLayoutPanel1.TabIndex = 13;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.61472F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.3852844F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 476F));
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(button1, 2, 0);
			tableLayoutPanel2.Controls.Add(txtSearch, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Left;
			tableLayoutPanel2.Location = new Point(3, 114);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(923, 35);
			tableLayoutPanel2.TabIndex = 11;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(77, 35);
			label2.TabIndex = 11;
			label2.Text = "Buscar:";
			// 
			// button1
			// 
			button1.Dock = DockStyle.Right;
			button1.Location = new Point(773, 3);
			button1.Name = "button1";
			button1.Size = new Size(147, 29);
			button1.TabIndex = 12;
			button1.Text = "Nuevo producto";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtSearch.Location = new Point(86, 4);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(357, 27);
			txtSearch.TabIndex = 13;
			txtSearch.KeyUp += txtSearch_KeyUp;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(158, 161, 176);
			label1.Location = new Point(233, 0);
			label1.Name = "label1";
			label1.Size = new Size(462, 111);
			label1.TabIndex = 9;
			label1.Text = "Administracion de productos";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tblProductos
			// 
			tblProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tblProductos.Dock = DockStyle.Fill;
			tblProductos.Location = new Point(3, 155);
			tblProductos.Name = "tblProductos";
			tblProductos.RowHeadersWidth = 51;
			tblProductos.Size = new Size(923, 374);
			tblProductos.TabIndex = 12;
			// 
			// InventarioForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(935, 548);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "InventarioForm";
			Text = "Inventarios";
			panel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tblProductos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Button button1;
		private DataGridView tblProductos;
		private TextBox txtSearch;
	}
}