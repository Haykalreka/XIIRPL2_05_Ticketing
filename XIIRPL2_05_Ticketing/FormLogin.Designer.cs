﻿namespace XIIRPL2_05_Ticketing
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            Username = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(149, 211);
            Username.Name = "Username";
            Username.Size = new Size(81, 21);
            Username.TabIndex = 1;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 245);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(568, 328);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 379);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 6;
            label2.Text = "Belum punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(453, 379);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daftar Sekarang!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FromLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Name = "FromLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Username;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}