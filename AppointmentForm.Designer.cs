using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HMS
{
    partial class AppointmentForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbroom = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            cmbpatient = new ComboBox();
            cmbdoc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(196, 84);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 0;
            label1.Text = "App_No. :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            label2.Location = new Point(196, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(183, 41);
            label2.TabIndex = 1;
            label2.Text = "Patient_ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            label3.Location = new Point(196, 176);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 41);
            label3.TabIndex = 2;
            label3.Text = "Doctor_ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            label4.Location = new Point(196, 222);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 41);
            label4.TabIndex = 3;
            label4.Text = "App_Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            label5.Location = new Point(196, 270);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 41);
            label5.TabIndex = 4;
            label5.Text = "Room_ID :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 96);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(411, 232);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // cmbroom
            // 
            cmbroom.FormattingEnabled = true;
            cmbroom.Location = new Point(411, 282);
            cmbroom.Margin = new Padding(2);
            cmbroom.Name = "cmbroom";
            cmbroom.Size = new Size(241, 28);
            cmbroom.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(711, 302);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 42);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(827, 302);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 42);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(711, 359);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 42);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(177, 437);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(985, 206);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(827, 359);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(92, 42);
            button4.TabIndex = 14;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button10);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 585);
            panel2.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(168, 38);
            label6.TabIndex = 18;
            label6.Text = "Main Menu";
            label6.Click += label6_Click;
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
            // button7
            // 
            button7.BackColor = Color.FromArgb(44, 62, 80);
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 196);
            button7.Name = "button7";
            button7.Size = new Size(171, 40);
            button7.TabIndex = 3;
            button7.Text = "Rooms/Wards";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(44, 62, 80);
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(3, 150);
            button8.Name = "button8";
            button8.Size = new Size(171, 40);
            button8.TabIndex = 2;
            button8.Text = "Appointment";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(44, 62, 80);
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(3, 104);
            button9.Name = "button9";
            button9.Size = new Size(171, 40);
            button9.TabIndex = 1;
            button9.Text = "Doctor Management";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(44, 62, 80);
            button10.FlatAppearance.BorderColor = Color.White;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 73, 94);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(3, 58);
            button10.Name = "button10";
            button10.Size = new Size(171, 40);
            button10.TabIndex = 0;
            button10.Text = "Patient Management";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(label7);
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
            pictureBox8.Location = new Point(1118, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 58);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new System.Drawing.Font("Segoe UI", 22F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1, 4);
            label7.Name = "label7";
            label7.Size = new Size(542, 50);
            label7.TabIndex = 0;
            label7.Text = "Hospital Management System";
            // 
            // cmbpatient
            // 
            cmbpatient.FormattingEnabled = true;
            cmbpatient.Location = new Point(411, 142);
            cmbpatient.Name = "cmbpatient";
            cmbpatient.Size = new Size(241, 28);
            cmbpatient.TabIndex = 33;
            // 
            // cmbdoc
            // 
            cmbdoc.FormattingEnabled = true;
            cmbdoc.Location = new Point(411, 188);
            cmbdoc.Name = "cmbdoc";
            cmbdoc.Size = new Size(241, 28);
            cmbdoc.TabIndex = 34;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.appointmentpage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 643);
            Controls.Add(cmbdoc);
            Controls.Add(cmbpatient);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbroom);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "AppointmentForm";
            Text = "Appointment Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbroom;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Panel panel2;
        private Label label6;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label7;
        private ComboBox cmbpatient;
        private ComboBox cmbdoc;
    }
}
