namespace XIIRPL2_05_Ticketing.MasterForm
{
    partial class FormListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPenerbangan));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 13);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 0;
            label1.Text = "List Penerbangan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 58);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Juanda (SUB) ";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(30, 12);
            button1.Name = "button1";
            button1.Size = new Size(35, 31);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 141);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 33);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 0;
            label3.Text = "Waktu Keberangkatan";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "00:00-06:00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(142, 51);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "06:00-12:00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(260, 51);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(85, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "12:00-18:00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(377, 51);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(85, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "18:00-24:00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 82);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 5;
            label4.Text = "Urutkan Berdasarkan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(607, 99);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 7;
            button2.Text = "Terapkan Filter";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 172);
            dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 16);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 57);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 6;
            label5.Text = "Soekarno-Hatta (CGK)";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(294, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 59);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 8;
            label6.Text = "Mon,22 May 2023";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(449, 59);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 60);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 10;
            label7.Text = "1 Penumpang";
            // 
            // FormListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormListPenerbangan";
            Text = "FormListPenerbangan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
    }
}