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
            label2 = new Label();
            button1 = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            tblProductos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(tblProductos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 411);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 11;
            label2.Text = "Buscar:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(689, 72);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 12;
            button1.Text = "Nuevo producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(81, 72);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(311, 23);
            txtSearch.TabIndex = 13;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(818, 36);
            label1.TabIndex = 9;
            label1.Text = "Administracion de productos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblProductos
            // 
            tblProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tblProductos.BackgroundColor = Color.White;
            tblProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProductos.GridColor = Color.Black;
            tblProductos.Location = new Point(0, 125);
            tblProductos.Margin = new Padding(3, 2, 3, 2);
            tblProductos.Name = "tblProductos";
            tblProductos.ReadOnly = true;
            tblProductos.RowHeadersWidth = 51;
            tblProductos.Size = new Size(818, 284);
            tblProductos.TabIndex = 12;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 411);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventarioForm";
            Text = "Inventarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Label label2;
		private Label label1;
		private Button button1;
		private DataGridView tblProductos;
		private TextBox txtSearch;
	}
}