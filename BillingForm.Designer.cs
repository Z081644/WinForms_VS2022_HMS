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
            lblNet = new Label();
            lblDiscount = new Label();
            lblTax = new Label();
            lblPatient = new Label();
            lblPayment = new Label();
            lblSubTotal = new Label();
            dgvBillList = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBillList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPatient
            // 
            cmbPatient.Location = new Point(323, 61);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(197, 28);
            cmbPatient.TabIndex = 12;
            // 
            // dgvBillDetails
            // 
            dgvBillDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetails.Columns.AddRange(new DataGridViewColumn[] { colService, colQty, colRate, colTotal });
            dgvBillDetails.Dock = DockStyle.Bottom;
            dgvBillDetails.Location = new Point(0, 418);
            dgvBillDetails.Name = "dgvBillDetails";
            dgvBillDetails.RowHeadersWidth = 82;
            dgvBillDetails.Size = new Size(1007, 225);
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
            txtSubTotal.Location = new Point(323, 160);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(113, 27);
            txtSubTotal.TabIndex = 7;
            txtSubTotal.Text = "0";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(323, 205);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(113, 27);
            txtTax.TabIndex = 5;
            txtTax.Text = "0";
            txtTax.TextChanged += CalculateFinalTotals;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(323, 250);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(113, 27);
            txtDiscount.TabIndex = 3;
            txtDiscount.Text = "0";
            txtDiscount.TextChanged += CalculateFinalTotals;
            // 
            // txtNet
            // 
            txtNet.Location = new Point(323, 348);
            txtNet.Name = "txtNet";
            txtNet.ReadOnly = true;
            txtNet.Size = new Size(113, 27);
            txtNet.TabIndex = 1;
            txtNet.Text = "0";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "UPI" });
            cmbPaymentMethod.Location = new Point(323, 113);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(197, 28);
            cmbPaymentMethod.TabIndex = 10;
            // 
            // btnSaveBill
            // 
            btnSaveBill.Location = new Point(482, 337);
            btnSaveBill.Name = "btnSaveBill";
            btnSaveBill.Size = new Size(140, 48);
            btnSaveBill.TabIndex = 0;
            btnSaveBill.Text = "Save Bill";
            btnSaveBill.Click += btnSaveBill_Click;
            // 
            // lblNet
            // 
            lblNet.BackColor = Color.Transparent;
            lblNet.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblNet.Location = new Point(45, 336);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(223, 51);
            lblNet.TabIndex = 2;
            lblNet.Text = "Net Payable:";
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblDiscount.Location = new Point(45, 239);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(223, 38);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Discount:";
            // 
            // lblTax
            // 
            lblTax.BackColor = Color.Transparent;
            lblTax.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblTax.Location = new Point(45, 193);
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
            lblPatient.Location = new Point(45, 49);
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
            lblPayment.Location = new Point(45, 101);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(272, 41);
            lblPayment.TabIndex = 11;
            lblPayment.Text = "Payment Method:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            lblSubTotal.Location = new Point(45, 152);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(223, 35);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "Sub Total:";
            // 
            // dgvBillList
            // 
            dgvBillList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillList.Dock = DockStyle.Right;
            dgvBillList.Location = new Point(720, 0);
            dgvBillList.Name = "dgvBillList";
            dgvBillList.RowHeadersWidth = 51;
            dgvBillList.Size = new Size(287, 418);
            dgvBillList.TabIndex = 29;
            dgvBillList.CellContentClick += dgvBillDetails_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.billingpage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblPatient);
            panel1.Controls.Add(cmbPatient);
            panel1.Controls.Add(btnSaveBill);
            panel1.Controls.Add(lblPayment);
            panel1.Controls.Add(txtNet);
            panel1.Controls.Add(cmbPaymentMethod);
            panel1.Controls.Add(lblNet);
            panel1.Controls.Add(lblSubTotal);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblTax);
            panel1.Controls.Add(txtTax);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 418);
            panel1.TabIndex = 30;
            // 
            // BillingForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1007, 643);
            Controls.Add(panel1);
            Controls.Add(dgvBillList);
            Controls.Add(dgvBillDetails);
            DoubleBuffered = true;
            Name = "BillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing Panel";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBillList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Label lblNet;
        private Label lblDiscount;
        private Label lblTax;
        private Label lblPatient;
        private Label lblPayment;
        private Label lblSubTotal;
        private DataGridView dgvBillList;
        private Panel panel1;
    }
}