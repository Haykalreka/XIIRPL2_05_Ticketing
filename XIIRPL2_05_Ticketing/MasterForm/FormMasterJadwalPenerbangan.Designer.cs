namespace XIIRPL2_05_Ticketing.MasterForm
{
    partial class FormMasterJadwalPenerbangan
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
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(611, 417);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(452, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 315);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 30;
            label8.Text = "Waktu Keberangkatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 289);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 28;
            label7.Text = "Tanggal";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 375);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 378);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 23;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 345);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 22;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 315);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 21;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 284);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEdit, btnDelete });
            dataGridView1.Location = new Point(16, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(772, 201);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua Jadwal Penerbangan Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 17;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(136, 310);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 23);
            comboBox2.TabIndex = 34;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(136, 342);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(210, 23);
            comboBox3.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(545, 283);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 345);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 37;
            label9.Text = "Durasi Keberangkatan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 378);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 38;
            label10.Text = "Harga Per Tiket";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(545, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(545, 342);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 40;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(545, 376);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(229, 23);
            numericUpDown1.TabIndex = 41;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            // 
            // FormMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterJadwalPenerbangan";
            Text = "FormMasterJadwalPenerbangan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label8;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}