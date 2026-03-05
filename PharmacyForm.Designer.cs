namespace HMS
{
    partial class PharmacyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyForm));
            panel2 = new Panel();
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            label6 = new Label();
            dgvmedi = new DataGridView();
            lblmed_id = new Label();
            lblmed_name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtmed_id = new TextBox();
            manu_date = new DateTimePicker();
            exp_date = new DateTimePicker();
            txtmed_name = new TextBox();
            cmbmed_type = new ComboBox();
            txtmed_price = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvmedi).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 585);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 18;
            label1.Text = "Main Menu";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(44, 62, 80);
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 290);
            button6.Name = "button6";
            button6.Size = new Size(171, 40);
            button6.TabIndex = 5;
            button6.Text = "Billing";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(44, 62, 80);
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 244);
            button5.Name = "button5";
            button5.Size = new Size(171, 40);
            button5.TabIndex = 4;
            button5.Text = "Pharmacy";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(44, 62, 80);
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 196);
            button4.Name = "button4";
            button4.Size = new Size(171, 40);
            button4.TabIndex = 3;
            button4.Text = "Rooms/Wards";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(44, 62, 80);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 150);
            button3.Name = "button3";
            button3.Size = new Size(171, 40);
            button3.TabIndex = 2;
            button3.Text = "Appointment";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 62, 80);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 104);
            button2.Name = "button2";
            button2.Size = new Size(171, 40);
            button2.TabIndex = 1;
            button2.Text = "Doctor Management";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 62, 80);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 58);
            button1.Name = "button1";
            button1.Size = new Size(171, 40);
            button1.TabIndex = 0;
            button1.Text = "Patient Management";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1162, 58);
            panel3.TabIndex = 32;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = Properties.Resources.logout;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1118, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 58);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 4);
            label6.Name = "label6";
            label6.Size = new Size(542, 50);
            label6.TabIndex = 0;
            label6.Text = "Hospital Management System";
            // 
            // dgvmedi
            // 
            dgvmedi.BackgroundColor = SystemColors.ActiveBorder;
            dgvmedi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmedi.Location = new Point(177, 449);
            dgvmedi.Margin = new Padding(3, 4, 3, 4);
            dgvmedi.Name = "dgvmedi";
            dgvmedi.RowHeadersWidth = 51;
            dgvmedi.Size = new Size(985, 194);
            dgvmedi.TabIndex = 33;
            dgvmedi.CellContentClick += dgvmedi_CellContentClick;
            // 
            // lblmed_id
            // 
            lblmed_id.AutoSize = true;
            lblmed_id.BackColor = Color.Transparent;
            lblmed_id.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            lblmed_id.Location = new Point(236, 112);
            lblmed_id.Name = "lblmed_id";
            lblmed_id.Size = new Size(203, 41);
            lblmed_id.TabIndex = 34;
            lblmed_id.Text = "Medicine ID :";
            // 
            // lblmed_name
            // 
            lblmed_name.AutoSize = true;
            lblmed_name.BackColor = Color.Transparent;
            lblmed_name.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            lblmed_name.Location = new Point(236, 158);
            lblmed_name.Name = "lblmed_name";
            lblmed_name.Size = new Size(257, 41);
            lblmed_name.TabIndex = 35;
            lblmed_name.Text = "Medicine Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            label2.Location = new Point(236, 204);
            label2.Name = "label2";
            label2.Size = new Size(240, 41);
            label2.TabIndex = 36;
            label2.Text = "Medicine Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            label3.Location = new Point(236, 250);
            label3.Name = "label3";
            label3.Size = new Size(318, 41);
            label3.TabIndex = 37;
            label3.Text = "Manufacturing Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            label4.Location = new Point(236, 298);
            label4.Name = "label4";
            label4.Size = new Size(197, 41);
            label4.TabIndex = 38;
            label4.Text = "Expiry Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            label5.Location = new Point(236, 344);
            label5.Name = "label5";
            label5.Size = new Size(104, 41);
            label5.TabIndex = 39;
            label5.Text = "Price :";
            // 
            // txtmed_id
            // 
            txtmed_id.Location = new Point(560, 124);
            txtmed_id.Name = "txtmed_id";
            txtmed_id.Size = new Size(151, 27);
            txtmed_id.TabIndex = 40;
            // 
            // manu_date
            // 
            manu_date.Location = new Point(560, 260);
            manu_date.Name = "manu_date";
            manu_date.Size = new Size(189, 27);
            manu_date.TabIndex = 41;
            // 
            // exp_date
            // 
            exp_date.Location = new Point(560, 308);
            exp_date.Name = "exp_date";
            exp_date.Size = new Size(189, 27);
            exp_date.TabIndex = 42;
            // 
            // txtmed_name
            // 
            txtmed_name.Location = new Point(560, 170);
            txtmed_name.Name = "txtmed_name";
            txtmed_name.Size = new Size(151, 27);
            txtmed_name.TabIndex = 43;
            // 
            // cmbmed_type
            // 
            cmbmed_type.FormattingEnabled = true;
            cmbmed_type.Items.AddRange(new object[] { "Tablet/Pills", "Syrup/Liquid", "Capsules", "Injection/IV", "Inhalers", "Patches", "Creams/Ointments" });
            cmbmed_type.Location = new Point(560, 216);
            cmbmed_type.Name = "cmbmed_type";
            cmbmed_type.Size = new Size(151, 28);
            cmbmed_type.TabIndex = 44;
            // 
            // txtmed_price
            // 
            txtmed_price.Location = new Point(560, 356);
            txtmed_price.Name = "txtmed_price";
            txtmed_price.Size = new Size(151, 27);
            txtmed_price.TabIndex = 45;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.AliceBlue;
            btnClear.Location = new Point(883, 391);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Location = new Point(785, 391);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 42);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.AliceBlue;
            btnUpdate.Location = new Point(883, 341);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 42);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.AliceBlue;
            btnAdd.Location = new Point(785, 341);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 42);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // PharmacyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pharmacypage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 643);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtmed_price);
            Controls.Add(cmbmed_type);
            Controls.Add(txtmed_name);
            Controls.Add(exp_date);
            Controls.Add(manu_date);
            Controls.Add(txtmed_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblmed_name);
            Controls.Add(lblmed_id);
            Controls.Add(dgvmedi);
            Controls.Add(panel2);
            Controls.Add(panel3);
            DoubleBuffered = true;
            Name = "PharmacyForm";
            Text = "PharmacyForm";
            Load += PharmacyForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvmedi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label6;
        private DataGridView dgvmedi;
        private Label lblmed_id;
        private Label lblmed_name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtmed_id;
        private DateTimePicker manu_date;
        private DateTimePicker exp_date;
        private TextBox txtmed_name;
        private ComboBox cmbmed_type;
        private TextBox txtmed_price;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}