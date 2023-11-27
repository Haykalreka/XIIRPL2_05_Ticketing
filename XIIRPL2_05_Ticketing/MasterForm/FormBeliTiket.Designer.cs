namespace XIIRPL2_05_Ticketing.MasterForm
{
    partial class FormBeliTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeliTiket));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label16 = new Label();
            button3 = new Button();
            label17 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(31, 14);
            button1.Name = "button1";
            button1.Size = new Size(39, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 14);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 1;
            label1.Text = "Detail Penumpang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 44);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 2;
            label2.Text = "Mohon diisi data semua penumpang";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 79);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 3;
            label3.Text = "Penumpang #1";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 120);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 4;
            label4.Text = "Titel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 158);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 5;
            label5.Text = "Nama Lengkap";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(137, 185);
            label6.Name = "label6";
            label6.Size = new Size(303, 15);
            label6.TabIndex = 8;
            label6.Text = "Isi sesuai KTP/PASPOR/SIM (tanpa tanda baca dan gelar)";
            // 
            // panel1
            // 
            panel1.Controls.Add(label17);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(499, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 451);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 9);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 4;
            label7.Text = "Penerbangan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 44);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 5;
            label8.Text = "Juanda (SUB) ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 16);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(129, 45);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 7;
            label9.Text = "Soekarno-Hatta (CGK)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 63);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 8;
            label10.Text = "Pelita Air Service";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(10, 96);
            label11.Name = "label11";
            label11.Size = new Size(130, 17);
            label11.TabIndex = 9;
            label11.Text = "Detail Penerbangan";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(17, 16);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 150);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 15);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 185);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 13;
            label12.Text = "1 Penumpang";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 150);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 14;
            label13.Text = "19:50-21:25";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 121);
            label14.Name = "label14";
            label14.Size = new Size(119, 15);
            label14.TabIndex = 15;
            label14.Text = "Monday,22 May 2023";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(10, 221);
            label15.Name = "label15";
            label15.Size = new Size(84, 17);
            label15.TabIndex = 16;
            label15.Text = "Kode Promo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(237, 240);
            button2.Name = "button2";
            button2.Size = new Size(52, 23);
            button2.TabIndex = 17;
            button2.Text = "Pakai";
            button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(10, 386);
            label16.Name = "label16";
            label16.Size = new Size(119, 17);
            label16.TabIndex = 18;
            label16.Text = "Total Pembayaran";
            // 
            // button3
            // 
            button3.Location = new Point(10, 415);
            button3.Name = "button3";
            button3.Size = new Size(279, 23);
            button3.TabIndex = 19;
            button3.Text = "Konfirmasi Pembayaran";
            button3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.SkyBlue;
            label17.Location = new Point(154, 380);
            label17.Name = "label17";
            label17.Size = new Size(120, 25);
            label17.TabIndex = 20;
            label17.Text = "IDR 685.000";
            // 
            // FormBeliTiket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormBeliTiket";
            Text = "FormBeliTiket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button2;
        private TextBox textBox2;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label17;
        private Button button3;
        private Label label16;
    }
}