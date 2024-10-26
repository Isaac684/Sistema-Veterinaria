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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAddCita));
            btnBuscar = new Button();
            IblTittle = new Label();
            dateCita = new DateTimePicker();
            tblCitas = new DataGridView();
            txtDescription = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            timePicker = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            txtName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tblCitas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(704, 141);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 30);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // IblTittle
            // 
            IblTittle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblTittle.ForeColor = Color.Black;
            IblTittle.Location = new Point(-1, 139);
            IblTittle.Name = "IblTittle";
            IblTittle.Size = new Size(436, 32);
            IblTittle.TabIndex = 8;
            IblTittle.Text = "Citas agendadas";
            IblTittle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateCita
            // 
            dateCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateCita.Location = new Point(467, 143);
            dateCita.Margin = new Padding(3, 2, 3, 2);
            dateCita.Name = "dateCita";
            dateCita.Size = new Size(231, 23);
            dateCita.TabIndex = 25;
            // 
            // tblCitas
            // 
            tblCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblCitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tblCitas.BackgroundColor = Color.White;
            tblCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCitas.GridColor = Color.Black;
            tblCitas.Location = new Point(5, 173);
            tblCitas.Margin = new Padding(3, 2, 3, 2);
            tblCitas.Name = "tblCitas";
            tblCitas.RowHeadersWidth = 51;
            tblCitas.Size = new Size(810, 278);
            tblCitas.TabIndex = 26;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(107, 94);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(566, 26);
            txtDescription.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 97);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 22;
            label3.Text = "Descripcion:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(705, 94);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 25;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(374, 49);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(98, 26);
            button2.TabIndex = 26;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(5, 52);
            label2.Name = "label2";
            label2.Size = new Size(170, 18);
            label2.TabIndex = 11;
            label2.Text = "Nombre de la mascota:";
            label2.Click += label2_Click;
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timePicker.Location = new Point(597, 52);
            timePicker.Margin = new Padding(3, 2, 3, 2);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(218, 23);
            timePicker.TabIndex = 24;
            timePicker.Value = new DateTime(2024, 10, 19, 23, 3, 48, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(478, 52);
            label6.Name = "label6";
            label6.Size = new Size(121, 18);
            label6.TabIndex = 21;
            label6.Text = "Agendada para:";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(323, 49);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(45, 26);
            button3.TabIndex = 27;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Enabled = false;
            txtName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(172, 49);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 26);
            txtName.TabIndex = 13;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(818, 32);
            label1.TabIndex = 9;
            label1.Text = "Registro";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(tblCitas);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(IblTittle);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(timePicker);
            panel2.Controls.Add(dateCita);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 464);
            panel2.TabIndex = 1;
            // 
            // MenuAddCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(818, 464);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuAddCita";
            Text = "Pantalla3";
            FormClosed += MenuAddPaciente_FormClosed;
            ((System.ComponentModel.ISupportInitialize)tblCitas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
		private Label label1;
		private Label label6;
		private Label IblTittle;
		private DateTimePicker timePicker;
		private Button button1;
		private DataGridView tblCitas;
		private Button button2;
		private TextBox txtDescription;
		private Label label3;
		private Button btnBuscar;
		private DateTimePicker dateCita;
		private Button button3;
		private TextBox txtName;
        private Panel panel2;
    }
}