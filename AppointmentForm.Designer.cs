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
            cmbpatient = new ComboBox();
            cmbdoc = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(38, 39);
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
            label2.Location = new Point(38, 85);
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
            label3.Location = new Point(38, 131);
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
            label4.Location = new Point(38, 177);
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
            label5.Location = new Point(38, 225);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 41);
            label5.TabIndex = 4;
            label5.Text = "Room_ID :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 51);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(253, 187);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // cmbroom
            // 
            cmbroom.FormattingEnabled = true;
            cmbroom.Location = new Point(253, 237);
            cmbroom.Margin = new Padding(2);
            cmbroom.Name = "cmbroom";
            cmbroom.Size = new Size(241, 28);
            cmbroom.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(500, 324);
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
            button2.Location = new Point(616, 324);
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
            button3.Location = new Point(500, 381);
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
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 437);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(784, 206);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(616, 381);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(92, 42);
            button4.TabIndex = 14;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cmbpatient
            // 
            cmbpatient.FormattingEnabled = true;
            cmbpatient.Location = new Point(253, 97);
            cmbpatient.Name = "cmbpatient";
            cmbpatient.Size = new Size(241, 28);
            cmbpatient.TabIndex = 33;
            // 
            // cmbdoc
            // 
            cmbdoc.FormattingEnabled = true;
            cmbdoc.Location = new Point(253, 143);
            cmbdoc.Name = "cmbdoc";
            cmbdoc.Size = new Size(241, 28);
            cmbdoc.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.appointmentpage;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbdoc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbpatient);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbroom);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 437);
            panel1.TabIndex = 35;
            // 
            // AppointmentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 643);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "AppointmentForm";
            Text = "Appointment Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbroom;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private ComboBox cmbpatient;
        private ComboBox cmbdoc;
        private Panel panel1;
    }
}
