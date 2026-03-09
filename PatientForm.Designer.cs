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
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPid
            // 
            lblPid.AutoSize = true;
            lblPid.BackColor = Color.Transparent;
            lblPid.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblPid.Location = new Point(41, 75);
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
            lblPName.Location = new Point(41, 122);
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
            lblGender.Location = new Point(41, 174);
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
            lblAge.Location = new Point(41, 269);
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
            lblContact.Location = new Point(531, 75);
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
            lblAddress.Location = new Point(531, 122);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(141, 41);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address:";
            lblAddress.Click += lblAddress_Click;
            // 
            // txtPid
            // 
            txtPid.Location = new Point(236, 84);
            txtPid.Margin = new Padding(3, 4, 3, 4);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(228, 27);
            txtPid.TabIndex = 1;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(236, 130);
            txtPName.Margin = new Padding(3, 4, 3, 4);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(228, 27);
            txtPName.TabIndex = 2;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.BackColor = Color.Transparent;
            rdoMale.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            rdoMale.Location = new Point(236, 176);
            rdoMale.Margin = new Padding(3, 4, 3, 4);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(94, 39);
            rdoMale.TabIndex = 3;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.BackColor = Color.Transparent;
            rdoFemale.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            rdoFemale.Location = new Point(337, 176);
            rdoFemale.Margin = new Padding(3, 4, 3, 4);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(120, 39);
            rdoFemale.TabIndex = 4;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(236, 281);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(228, 27);
            txtAge.TabIndex = 30;
            txtAge.TabStop = false;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(796, 84);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(228, 27);
            txtContact.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(796, 134);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(228, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(646, 311);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 42);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(646, 363);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 42);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(744, 311);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 42);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClear.Location = new Point(744, 361);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Bottom;
            dgvPatients.Location = new Point(0, 446);
            dgvPatients.Margin = new Padding(3, 4, 3, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.Size = new Size(1054, 197);
            dgvPatients.TabIndex = 0;
            dgvPatients.TabStop = false;
            dgvPatients.CellClick += dgvPatients_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label2.Location = new Point(41, 220);
            label2.Name = "label2";
            label2.Size = new Size(90, 41);
            label2.TabIndex = 31;
            label2.Text = "DOB:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label3.Location = new Point(531, 174);
            label3.Name = "label3";
            label3.Size = new Size(223, 41);
            label3.TabIndex = 33;
            label3.Text = "Doctor_Name:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(796, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.patientpage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblPid);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblPName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblContact);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtPid);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtPName);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(rdoFemale);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(rdoMale);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtContact);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 446);
            panel1.TabIndex = 35;
            // 
            // PatientForm
            // 
            AcceptButton = btnAdd;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnClear;
            ClientSize = new Size(1054, 643);
            Controls.Add(panel1);
            Controls.Add(dgvPatients);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Application Window";
            WindowState = FormWindowState.Maximized;
            Load += PatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox1;
        private Panel panel1;
    }
}