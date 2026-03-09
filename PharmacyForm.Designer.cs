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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvmedi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvmedi
            // 
            dgvmedi.BackgroundColor = SystemColors.ActiveBorder;
            dgvmedi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmedi.Dock = DockStyle.Bottom;
            dgvmedi.Location = new Point(0, 449);
            dgvmedi.Margin = new Padding(3, 4, 3, 4);
            dgvmedi.Name = "dgvmedi";
            dgvmedi.RowHeadersWidth = 51;
            dgvmedi.Size = new Size(809, 194);
            dgvmedi.TabIndex = 33;
            dgvmedi.TabStop = false;
            dgvmedi.CellContentClick += dgvmedi_CellContentClick;
            // 
            // lblmed_id
            // 
            lblmed_id.AutoSize = true;
            lblmed_id.BackColor = Color.Transparent;
            lblmed_id.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold);
            lblmed_id.Location = new Point(37, 62);
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
            lblmed_name.Location = new Point(37, 108);
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
            label2.Location = new Point(37, 154);
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
            label3.Location = new Point(37, 200);
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
            label4.Location = new Point(37, 248);
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
            label5.Location = new Point(37, 294);
            label5.Name = "label5";
            label5.Size = new Size(104, 41);
            label5.TabIndex = 39;
            label5.Text = "Price :";
            // 
            // txtmed_id
            // 
            txtmed_id.Location = new Point(361, 74);
            txtmed_id.Name = "txtmed_id";
            txtmed_id.Size = new Size(151, 27);
            txtmed_id.TabIndex = 1;
            // 
            // manu_date
            // 
            manu_date.Location = new Point(361, 210);
            manu_date.Name = "manu_date";
            manu_date.Size = new Size(189, 27);
            manu_date.TabIndex = 4;
            // 
            // exp_date
            // 
            exp_date.Location = new Point(361, 258);
            exp_date.Name = "exp_date";
            exp_date.Size = new Size(189, 27);
            exp_date.TabIndex = 5;
            // 
            // txtmed_name
            // 
            txtmed_name.Location = new Point(361, 120);
            txtmed_name.Name = "txtmed_name";
            txtmed_name.Size = new Size(151, 27);
            txtmed_name.TabIndex = 2;
            // 
            // cmbmed_type
            // 
            cmbmed_type.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbmed_type.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbmed_type.FormattingEnabled = true;
            cmbmed_type.Items.AddRange(new object[] { "Tablet/Pills", "Syrup/Liquid", "Capsules", "Injection/IV", "Inhalers", "Patches", "Creams/Ointments" });
            cmbmed_type.Location = new Point(361, 166);
            cmbmed_type.Name = "cmbmed_type";
            cmbmed_type.Size = new Size(151, 28);
            cmbmed_type.TabIndex = 3;
            // 
            // txtmed_price
            // 
            txtmed_price.Location = new Point(361, 306);
            txtmed_price.Name = "txtmed_price";
            txtmed_price.Size = new Size(151, 27);
            txtmed_price.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.AliceBlue;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClear.Location = new Point(629, 370);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(531, 370);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 42);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.AliceBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(629, 320);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 42);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.AliceBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(531, 320);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.pharmacypage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblmed_id);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblmed_name);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtmed_price);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbmed_type);
            panel1.Controls.Add(txtmed_id);
            panel1.Controls.Add(txtmed_name);
            panel1.Controls.Add(manu_date);
            panel1.Controls.Add(exp_date);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 449);
            panel1.TabIndex = 50;
            // 
            // PharmacyForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 643);
            Controls.Add(panel1);
            Controls.Add(dgvmedi);
            DoubleBuffered = true;
            Name = "PharmacyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PharmacyForm";
            WindowState = FormWindowState.Maximized;
            Load += PharmacyForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvmedi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel1;
    }
}