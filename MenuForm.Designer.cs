using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class Menuform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuform));
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            rdpPatient = new RoundedPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            roundedPanel1 = new RoundedPanel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            roundedPanel2 = new RoundedPanel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            roundedPanel3 = new RoundedPanel();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            roundedPanel4 = new RoundedPanel();
            pictureBox5 = new PictureBox();
            label12 = new Label();
            roundedPanel5 = new RoundedPanel();
            pictureBox6 = new PictureBox();
            label14 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            rdpPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 62, 80);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(177, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 58);
            panel3.TabIndex = 30;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = Properties.Resources.logout;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(941, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 58);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
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
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 643);
            panel2.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(168, 38);
            label7.TabIndex = 18;
            label7.Text = "Main Menu";
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
            button6.Location = new Point(3, 288);
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
            button5.Location = new Point(3, 242);
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
            button1.Click += button1_Click_1;
            // 
            // rdpPatient
            // 
            rdpPatient.BackColor = Color.SlateGray;
            rdpPatient.BorderRadius = 30;
            rdpPatient.Controls.Add(label2);
            rdpPatient.Controls.Add(pictureBox1);
            rdpPatient.Controls.Add(label1);
            rdpPatient.Location = new Point(186, 150);
            rdpPatient.Name = "rdpPatient";
            rdpPatient.Size = new Size(320, 150);
            rdpPatient.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19F, FontStyle.Bold);
            label1.Location = new Point(116, 16);
            label1.Name = "label1";
            label1.Size = new Size(163, 78);
            label1.TabIndex = 0;
            label1.Text = "No. Of\r\nPatients :\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Patientlogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 120);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 103);
            label2.Name = "label2";
            label2.Size = new Size(98, 33);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.SlateGray;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(513, 150);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(320, 150);
            roundedPanel1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(181, 103);
            label3.Name = "label3";
            label3.Size = new Size(98, 33);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.doctorlogo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(12, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 120);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 19F, FontStyle.Bold);
            label4.Location = new Point(113, 16);
            label4.Name = "label4";
            label4.Size = new Size(166, 78);
            label4.TabIndex = 0;
            label4.Text = "Available\r\nDoctors :";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.SlateGray;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(pictureBox3);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Location = new Point(839, 150);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(320, 150);
            roundedPanel2.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 16F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(181, 103);
            label5.Name = "label5";
            label5.Size = new Size(98, 33);
            label5.TabIndex = 2;
            label5.Text = "label5";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.appointmentlogo;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(12, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(98, 120);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 19F, FontStyle.Bold);
            label8.Location = new Point(116, 16);
            label8.Name = "label8";
            label8.Size = new Size(147, 78);
            label8.TabIndex = 0;
            label8.Text = "Pending\r\nAppo. :\r\n";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.SlateGray;
            roundedPanel3.BorderRadius = 30;
            roundedPanel3.Controls.Add(label9);
            roundedPanel3.Controls.Add(pictureBox4);
            roundedPanel3.Controls.Add(label10);
            roundedPanel3.Location = new Point(186, 440);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(320, 150);
            roundedPanel3.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 16F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(181, 103);
            label9.Name = "label9";
            label9.Size = new Size(98, 33);
            label9.TabIndex = 2;
            label9.Text = "label9";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.bed;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(12, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(98, 120);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 19F, FontStyle.Bold);
            label10.Location = new Point(116, 16);
            label10.Name = "label10";
            label10.Size = new Size(166, 78);
            label10.TabIndex = 0;
            label10.Text = "Available\r\nRooms :";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.SlateGray;
            roundedPanel4.BorderRadius = 30;
            roundedPanel4.Controls.Add(pictureBox5);
            roundedPanel4.Controls.Add(label12);
            roundedPanel4.Location = new Point(513, 440);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(320, 150);
            roundedPanel4.TabIndex = 35;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.meds;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(12, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(98, 120);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 21F, FontStyle.Bold);
            label12.Location = new Point(113, 51);
            label12.Name = "label12";
            label12.Size = new Size(196, 43);
            label12.TabIndex = 0;
            label12.Text = "Pharmacy";
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.SlateGray;
            roundedPanel5.BorderRadius = 30;
            roundedPanel5.Controls.Add(pictureBox6);
            roundedPanel5.Controls.Add(label14);
            roundedPanel5.Location = new Point(839, 440);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(320, 150);
            roundedPanel5.TabIndex = 34;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.billlogo;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(12, 16);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(98, 120);
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 21F, FontStyle.Bold);
            label14.Location = new Point(116, 51);
            label14.Name = "label14";
            label14.Size = new Size(131, 43);
            label14.TabIndex = 0;
            label14.Text = "Billing";
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.menupage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 643);
            Controls.Add(roundedPanel5);
            Controls.Add(roundedPanel4);
            Controls.Add(roundedPanel3);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(rdpPatient);
            Controls.Add(panel3);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "Menuform";
            Padding = new Padding(10);
            Text = "Home Page";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            rdpPatient.ResumeLayout(false);
            rdpPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private RoundedPanel rdpPatient;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RoundedPanel roundedPanel1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private RoundedPanel roundedPanel2;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label8;
        private RoundedPanel roundedPanel3;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label10;
        private RoundedPanel roundedPanel4;
        private PictureBox pictureBox5;
        private Label label12;
        private RoundedPanel roundedPanel5;
        private PictureBox pictureBox6;
        private Label label14;
    }
}
