namespace XIIRPL2_05_Ticketing.MasterForm
{
    partial class FormMasterMaskapai
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
            btnSimpan = new Button();
            button1 = new Button();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            txtJumlahKru = new NumericUpDown();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(582, 393);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(423, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(423, 281);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(234, 85);
            txtDeskripsi.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 284);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 30;
            label8.Text = "Deskripsi";
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(95, 343);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(186, 23);
            txtJumlahKru.TabIndex = 29;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(95, 312);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(186, 23);
            txtPerusahaan.TabIndex = 25;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(95, 281);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(186, 23);
            txtNama.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 345);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 22;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 315);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 21;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 284);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(276, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua Maskapai Yang Tedaftar Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 17;
            label1.Text = "Master Maskapai";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEdit, btnDelete });
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 213);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // FormMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtJumlahKru);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterMaskapai";
            Text = "FormMasterMaskapai";
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label8;
        private NumericUpDown txtJumlahKru;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}