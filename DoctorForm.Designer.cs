using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class DoctorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            lblDoctorId = new Label();
            lblDocName = new Label();
            lblSpecialization = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            txtDoctorId = new TextBox();
            txtDocName = new TextBox();
            txtSpecialization = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvDoctors = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.BackColor = Color.Transparent;
            lblDoctorId.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblDoctorId.Location = new Point(200, 122);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(160, 41);
            lblDoctorId.TabIndex = 14;
            lblDoctorId.Text = "Doctor ID:";
            lblDoctorId.Click += lblDoctorId_Click;
            // 
            // lblDocName
            // 
            lblDocName.AutoSize = true;
            lblDocName.BackColor = Color.Transparent;
            lblDocName.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblDocName.Location = new Point(200, 166);
            lblDocName.Name = "lblDocName";
            lblDocName.Size = new Size(111, 41);
            lblDocName.TabIndex = 13;
            lblDocName.Text = "Name:";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.BackColor = Color.Transparent;
            lblSpecialization.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblSpecialization.Location = new Point(200, 205);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(220, 41);
            lblSpecialization.TabIndex = 12;
            lblSpecialization.Text = "Specialization:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblPhone.Location = new Point(670, 115);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(116, 41);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblEmail.Location = new Point(681, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 41);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(426, 134);
            txtDoctorId.Margin = new Padding(3, 4, 3, 4);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(228, 27);
            txtDoctorId.TabIndex = 9;
            // 
            // txtDocName
            // 
            txtDocName.Location = new Point(426, 178);
            txtDocName.Margin = new Padding(3, 4, 3, 4);
            txtDocName.Name = "txtDocName";
            txtDocName.Size = new Size(228, 27);
            txtDocName.TabIndex = 8;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(426, 216);
            txtSpecialization.Margin = new Padding(3, 4, 3, 4);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(228, 27);
            txtSpecialization.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(826, 127);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(228, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(826, 178);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.AliceBlue;
            btnAdd.Location = new Point(723, 247);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.AliceBlue;
            btnUpdate.Location = new Point(821, 247);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 42);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Location = new Point(723, 297);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.AliceBlue;
            btnClear.Location = new Point(821, 297);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // dgvDoctors
            // 
            dgvDoctors.BackgroundColor = SystemColors.ActiveBorder;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(177, 412);
            dgvDoctors.Margin = new Padding(3, 4, 3, 4);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.Size = new Size(991, 231);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
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
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.doctorpage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 643);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dgvDoctors);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtSpecialization);
            Controls.Add(txtDocName);
            Controls.Add(txtDoctorId);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblSpecialization);
            Controls.Add(lblDocName);
            Controls.Add(lblDoctorId);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorForm";
            Text = "Doctor Form";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Variable Declarations
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDoctors;
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
    }
}