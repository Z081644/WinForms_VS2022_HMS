using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class LoginForm
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
            btnlogin = new Button();
            btnclear = new Button();
            txtuserid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtpassword = new TextBox();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnlogin.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btnlogin.Location = new Point(976, 554);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(140, 40);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclear
            // 
            btnclear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnclear.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btnclear.Location = new Point(820, 554);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(140, 40);
            btnclear.TabIndex = 9;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // txtuserid
            // 
            txtuserid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtuserid.Location = new Point(976, 442);
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(148, 27);
            txtuserid.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 22F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(762, 433);
            label1.Name = "label1";
            label1.Size = new Size(208, 45);
            label1.TabIndex = 11;
            label1.Text = "User Name: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 22F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(771, 483);
            label2.Name = "label2";
            label2.Size = new Size(189, 45);
            label2.TabIndex = 12;
            label2.Text = "Password: ";
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtpassword.Location = new Point(976, 494);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(148, 27);
            txtpassword.TabIndex = 13;
            // 
            // LoginForm
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.loginpage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 643);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtuserid);
            Controls.Add(btnclear);
            Controls.Add(btnlogin);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnlogin;
        private Button btnclear;
        private TextBox txtuserid;
        private Label label1;
        private Label label2;
        private TextBox txtpassword;
    }
}
