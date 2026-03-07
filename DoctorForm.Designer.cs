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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.BackColor = Color.Transparent;
            lblDoctorId.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblDoctorId.Location = new Point(41, 43);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(160, 41);
            lblDoctorId.TabIndex = 14;
            lblDoctorId.Text = "Doctor ID:";
            // 
            // lblDocName
            // 
            lblDocName.AutoSize = true;
            lblDocName.BackColor = Color.Transparent;
            lblDocName.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblDocName.Location = new Point(41, 87);
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
            lblSpecialization.Location = new Point(41, 126);
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
            lblPhone.Location = new Point(41, 169);
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
            lblEmail.Location = new Point(41, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(105, 41);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(267, 55);
            txtDoctorId.Margin = new Padding(3, 4, 3, 4);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(228, 27);
            txtDoctorId.TabIndex = 9;
            // 
            // txtDocName
            // 
            txtDocName.Location = new Point(267, 99);
            txtDocName.Margin = new Padding(3, 4, 3, 4);
            txtDocName.Name = "txtDocName";
            txtDocName.Size = new Size(228, 27);
            txtDocName.TabIndex = 8;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(267, 137);
            txtSpecialization.Margin = new Padding(3, 4, 3, 4);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(228, 27);
            txtSpecialization.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(267, 181);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(228, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 226);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.AliceBlue;
            btnAdd.Location = new Point(513, 266);
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
            btnUpdate.Location = new Point(611, 266);
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
            btnDelete.Location = new Point(513, 316);
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
            btnClear.Location = new Point(611, 316);
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
            dgvDoctors.Dock = DockStyle.Bottom;
            dgvDoctors.Location = new Point(0, 365);
            dgvDoctors.Margin = new Padding(3, 4, 3, 4);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.Size = new Size(735, 231);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.doctorpage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblDoctorId);
            panel1.Controls.Add(lblDocName);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(lblSpecialization);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtDoctorId);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtDocName);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtSpecialization);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 365);
            panel1.TabIndex = 15;
            // 
            // DoctorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(735, 596);
            Controls.Add(panel1);
            Controls.Add(dgvDoctors);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorForm";
            Text = "Doctor Form";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}