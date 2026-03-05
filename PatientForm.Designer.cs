using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class PatientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            lblPid = new Label();
            lblPName = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblContact = new Label();
            lblAddress = new Label();
            txtPid = new TextBox();
            txtPName = new TextBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvPatients = new DataGridView();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPid
            // 
            lblPid.AutoSize = true;
            lblPid.BackColor = Color.Transparent;
            lblPid.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblPid.Location = new Point(209, 115);
            lblPid.Name = "lblPid";
            lblPid.Size = new Size(166, 41);
            lblPid.TabIndex = 19;
            lblPid.Text = "Patient ID:";
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.BackColor = Color.Transparent;
            lblPName.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblPName.Location = new Point(209, 162);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(111, 41);
            lblPName.TabIndex = 18;
            lblPName.Text = "Name:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblGender.Location = new Point(209, 214);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(131, 41);
            lblGender.TabIndex = 17;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblAge.Location = new Point(209, 309);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(81, 41);
            lblAge.TabIndex = 16;
            lblAge.Text = "Age:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.BackColor = Color.Transparent;
            lblContact.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblContact.Location = new Point(699, 115);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(136, 41);
            lblContact.TabIndex = 15;
            lblContact.Text = "Contact:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblAddress.Location = new Point(699, 162);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(141, 41);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address:";
            // 
            // txtPid
            // 
            txtPid.Location = new Point(404, 124);
            txtPid.Margin = new Padding(3, 4, 3, 4);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(228, 27);
            txtPid.TabIndex = 12;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(404, 170);
            txtPName.Margin = new Padding(3, 4, 3, 4);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(228, 27);
            txtPName.TabIndex = 11;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.BackColor = Color.Transparent;
            rdoMale.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            rdoMale.Location = new Point(404, 216);
            rdoMale.Margin = new Padding(3, 4, 3, 4);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(94, 39);
            rdoMale.TabIndex = 9;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.BackColor = Color.Transparent;
            rdoFemale.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            rdoFemale.Location = new Point(505, 216);
            rdoFemale.Margin = new Padding(3, 4, 3, 4);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(120, 39);
            rdoFemale.TabIndex = 10;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(404, 321);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(228, 27);
            txtAge.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(874, 124);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(228, 27);
            txtContact.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(874, 174);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(228, 27);
            txtAddress.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(743, 296);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(743, 348);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 42);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(841, 296);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(841, 346);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(177, 446);
            dgvPatients.Margin = new Padding(3, 4, 3, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(985, 197);
            dgvPatients.TabIndex = 0;
            dgvPatients.CellClick += dgvPatients_CellClick;
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
            panel3.TabIndex = 30;
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
            panel2.TabIndex = 29;
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
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
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
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
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
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
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
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
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
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 58);
            button1.Name = "button1";
            button1.Size = new Size(171, 40);
            button1.TabIndex = 0;
            button1.Text = "Patient Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label2.Location = new Point(209, 260);
            label2.Name = "label2";
            label2.Size = new Size(90, 41);
            label2.TabIndex = 31;
            label2.Text = "DOB:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(404, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 32;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label3.Location = new Point(699, 214);
            label3.Name = "label3";
            label3.Size = new Size(169, 41);
            label3.TabIndex = 33;
            label3.Text = "Doctor_ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(874, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 34;
            // 
            // PatientForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.patientpage;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnClear;
            ClientSize = new Size(1162, 643);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dgvPatients);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtAge);
            Controls.Add(rdoMale);
            Controls.Add(rdoFemale);
            Controls.Add(txtPName);
            Controls.Add(txtPid);
            Controls.Add(lblAddress);
            Controls.Add(lblContact);
            Controls.Add(lblAge);
            Controls.Add(lblGender);
            Controls.Add(lblPName);
            Controls.Add(lblPid);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Application Window";
            Load += PatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;

        // Added RadioButtons
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPatients;
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label6;
        private Panel panel2;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox1;
    }
}