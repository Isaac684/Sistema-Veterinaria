namespace Base___V1.Logic
{
	partial class buscarInventarioForm
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
			button2 = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			button1 = new Button();
			label1 = new Label();
			txtSearch = new TextBox();
			tbl_dues = new DataGridView();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbl_dues).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button2.BackColor = Color.DimGray;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = SystemColors.Control;
			button2.Location = new Point(256, 3);
			button2.Name = "button2";
			button2.Size = new Size(139, 35);
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
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 304);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(544, 42);
			tableLayoutPanel2.TabIndex = 14;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(31, 38, 67);
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = SystemColors.Control;
			button1.Location = new Point(401, 3);
			button1.Name = "button1";
			button1.Size = new Size(140, 35);
			button1.TabIndex = 3;
			button1.Text = "Aceptar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
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
			label1.Size = new Size(544, 42);
			label1.TabIndex = 11;
			label1.Text = "Buscar producto";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtSearch
			// 
			txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			txtSearch.Location = new Point(3, 48);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(544, 27);
			txtSearch.TabIndex = 12;
			txtSearch.Tag = "";
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// tbl_dues
			// 
			tbl_dues.AllowUserToAddRows = false;
			tbl_dues.AllowUserToDeleteRows = false;
			tbl_dues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbl_dues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tbl_dues.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			tbl_dues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tbl_dues.Location = new Point(3, 85);
			tbl_dues.Name = "tbl_dues";
			tbl_dues.ReadOnly = true;
			tbl_dues.RowHeadersWidth = 51;
			tbl_dues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			tbl_dues.Size = new Size(544, 213);
			tbl_dues.TabIndex = 13;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(txtSearch, 0, 1);
			tableLayoutPanel1.Controls.Add(tbl_dues, 0, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1904755F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.8095245F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
			tableLayoutPanel1.Size = new Size(550, 349);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// buscarInventarioForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(550, 349);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "buscarInventarioForm";
			Text = "buscarDueñoForm";
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tbl_dues).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button button2;
		private TableLayoutPanel tableLayoutPanel2;
		private Button button1;
		private Label label1;
		private TextBox txtSearch;
		private DataGridView tbl_dues;
		private TableLayoutPanel tableLayoutPanel1;
	}
}