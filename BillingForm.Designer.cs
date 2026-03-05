using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HMS
{
    partial class BillingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbPatient = new ComboBox();
            dgvBillDetails = new DataGridView();
            colService = new DataGridViewComboBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colRate = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtDiscount = new TextBox();
            txtNet = new TextBox();
            cmbPaymentMethod = new ComboBox();
            btnSaveBill = new Button();
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
            lblNet = new Label();
            lblDiscount = new Label();
            lblTax = new Label();
            lblPatient = new Label();
            lblPayment = new Label();
            lblSubTotal = new Label();
            dgvBillList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillList).BeginInit();
            SuspendLayout();
            // 
            // cmbPatient
            // 
            cmbPatient.Location = new Point(490, 100);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(250, 28);
            cmbPatient.TabIndex = 12;
            // 
            // dgvBillDetails
            // 
            dgvBillDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetails.Columns.AddRange(new DataGridViewColumn[] { colService, colQty, colRate, colTotal });
            dgvBillDetails.Location = new Point(177, 418);
            dgvBillDetails.Name = "dgvBillDetails";
            dgvBillDetails.RowHeadersWidth = 82;
            dgvBillDetails.Size = new Size(645, 225);
            dgvBillDetails.TabIndex = 9;
            dgvBillDetails.CellContentClick += dgvBillDetails_CellContentClick;
            dgvBillDetails.CellValueChanged += dgvBillDetails_CellValueChanged;
            dgvBillDetails.RowsRemoved += dgvBillDetails_RowsRemoved;
            // 
            // colService
            // 
            colService.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            colService.HeaderText = "Service Description";
            colService.Items.AddRange(new object[] { "Emergency Bill", "OPD Bill (Out Patient Department)", "IPD Bill (In Patient Department)", "Consultation Bill", "Surgery Bill", "Laboratory Bill", "X-Ray", "CT Scan", "MRI", "ECG", "Sonography", "Pharmacy Bill", "Nursing Charges", "Operation Theatre (OT) Charges", "Room / Ward Charges", "ICU Bill", "Ambulance Bill", "Admission Charges", "Discharge Charges" });
            colService.MinimumWidth = 10;
            colService.Name = "colService";
            colService.Width = 250;
            // 
            // colQty
            // 
            colQty.HeaderText = "Qty";
            colQty.MinimumWidth = 10;
            colQty.Name = "colQty";
            colQty.Width = 80;
            // 
            // colRate
            // 
            colRate.HeaderText = "Rate";
            colRate.MinimumWidth = 10;
            colRate.Name = "colRate";
            colRate.Width = 110;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Line Total";
            colTotal.MinimumWidth = 10;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 120;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(490, 199);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 27);
            txtSubTotal.TabIndex = 7;
            txtSubTotal.Text = "0";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(490, 243);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 27);
            txtTax.TabIndex = 5;
            txtTax.Text = "0";
            txtTax.TextChanged += CalculateFinalTotals;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(490, 289);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 27);
            txtDiscount.TabIndex = 3;
            txtDiscount.Text = "0";
            txtDiscount.TextChanged += CalculateFinalTotals;
            // 
            // txtNet
            // 
            txtNet.Location = new Point(412, 376);
            txtNet.Name = "txtNet";
            txtNet.ReadOnly = true;
            txtNet.Size = new Size(100, 27);
            txtNet.TabIndex = 1;
            txtNet.Text = "0";
            txtNet.TextChanged += txtNet_TextChanged;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "UPI" });
            cmbPaymentMethod.Location = new Point(490, 152);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(150, 28);
            cmbPaymentMethod.TabIndex = 10;
            // 
            // btnSaveBill
            // 
            btnSaveBill.Location = new Point(551, 367);
            btnSaveBill.Name = "btnSaveBill";
            btnSaveBill.Size = new Size(140, 48);
            btnSaveBill.TabIndex = 0;
            btnSaveBill.Text = "Save Bill";
            btnSaveBill.Click += btnSaveBill_Click;
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
            panel3.TabIndex = 28;
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
            label6.Font = new System.Drawing.Font("Segoe UI", 22F, FontStyle.Bold);
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
            panel2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, FontStyle.Bold);
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
            button6.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button5.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button4.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button3.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button2.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            button1.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 58);
            button1.Name = "button1";
            button1.Size = new Size(171, 40);
            button1.TabIndex = 0;
            button1.Text = "Patient Management";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblNet
            // 
            lblNet.BackColor = Color.Transparent;
            lblNet.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblNet.Location = new Point(183, 364);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(223, 51);
            lblNet.TabIndex = 2;
            lblNet.Text = "Net Payable:";
            lblNet.Click += lblNet_Click;
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblDiscount.Location = new Point(212, 278);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(223, 38);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Discount:";
            // 
            // lblTax
            // 
            lblTax.BackColor = Color.Transparent;
            lblTax.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblTax.Location = new Point(212, 232);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(223, 36);
            lblTax.TabIndex = 6;
            lblTax.Text = "Tax amount:";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.BackColor = Color.Transparent;
            lblPatient.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblPatient.Location = new Point(212, 88);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(220, 41);
            lblPatient.TabIndex = 13;
            lblPatient.Text = "Select Patient:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.BackColor = Color.Transparent;
            lblPayment.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblPayment.Location = new Point(212, 140);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(272, 41);
            lblPayment.TabIndex = 11;
            lblPayment.Text = "Payment Method:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblSubTotal.Location = new Point(212, 191);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(223, 35);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "Sub Total:";
            // 
            // dgvBillList
            // 
            dgvBillList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillList.Location = new Point(875, 418);
            dgvBillList.Name = "dgvBillList";
            dgvBillList.RowHeadersWidth = 51;
            dgvBillList.Size = new Size(287, 225);
            dgvBillList.TabIndex = 29;
            dgvBillList.CellContentClick += dgvBillDetails_CellContentClick;
            // 
            // BillingForm
            // 
            BackgroundImage = Properties.Resources.billingpage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 643);
            Controls.Add(dgvBillList);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(btnSaveBill);
            Controls.Add(txtNet);
            Controls.Add(lblNet);
            Controls.Add(txtDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(txtTax);
            Controls.Add(lblTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblSubTotal);
            Controls.Add(dgvBillDetails);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblPayment);
            Controls.Add(cmbPatient);
            Controls.Add(lblPatient);
            DoubleBuffered = true;
            Name = "BillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing Panel";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.DataGridViewComboBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.TextBox txtSubTotal, txtTax, txtDiscount, txtNet;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnSaveBill;
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label6;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblNet;
        private Label lblDiscount;
        private Label lblTax;
        private Label lblPatient;
        private Label lblPayment;
        private Label lblSubTotal;
        private Label label1;
        private DataGridView dgvBillList;
    }
}