namespace XIIRPL2_05_Ticketing.MasterForm
{
    partial class FormMasterKodePromo
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
            txtKodePromo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtBerlakuSampai = new DateTimePicker();
            txtPresentaseDiskon = new NumericUpDown();
            txtMaksimumDiskon = new NumericUpDown();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(611, 389);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(452, 389);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(452, 284);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(234, 86);
            txtDeskripsi.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(378, 284);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 30;
            label8.Text = "Deskripsi";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(143, 281);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(186, 23);
            txtKodePromo.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 378);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 23;
            label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 345);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 22;
            label5.Text = "Presentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 315);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 21;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 284);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Promo";
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
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(292, 15);
            label2.TabIndex = 18;
            label2.Text = "Semua Kode Promo Yang Tedaftar Akan Muncul Disini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 17;
            label1.Text = "Master Kode Promo";
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(143, 313);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(186, 23);
            txtBerlakuSampai.TabIndex = 34;
            // 
            // txtPresentaseDiskon
            // 
            txtPresentaseDiskon.Location = new Point(143, 343);
            txtPresentaseDiskon.Name = "txtPresentaseDiskon";
            txtPresentaseDiskon.Size = new Size(186, 23);
            txtPresentaseDiskon.TabIndex = 35;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(143, 376);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(186, 23);
            txtMaksimumDiskon.TabIndex = 36;
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
            // FormMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPresentaseDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtKodePromo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterKodePromo";
            Text = "FormMasterKodePromo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label8;
        private TextBox txtKodePromo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtPresentaseDiskon;
        private NumericUpDown txtMaksimumDiskon;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}