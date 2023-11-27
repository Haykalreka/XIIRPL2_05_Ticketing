namespace XIIRPL2_05_Ticketing.MasterForm
{
    partial class FormMasterBandara
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNama = new TextBox();
            txtkodeIATA = new TextBox();
            txtKota = new TextBox();
            txtNegara = new ComboBox();
            label7 = new Label();
            txtJmTerminal = new NumericUpDown();
            label8 = new Label();
            txtAlamat = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtJmTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(269, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua Bandara Yang Tedaftar Akan Muncul Disini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 282);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 313);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 343);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 376);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(95, 279);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(186, 23);
            txtNama.TabIndex = 7;
            // 
            // txtkodeIATA
            // 
            txtkodeIATA.Location = new Point(95, 310);
            txtkodeIATA.Name = "txtkodeIATA";
            txtkodeIATA.Size = new Size(186, 23);
            txtkodeIATA.TabIndex = 8;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(95, 340);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(186, 23);
            txtKota.TabIndex = 9;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(93, 373);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(188, 23);
            txtNegara.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 282);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 11;
            label7.Text = "Jumlah Terminal";
            // 
            // txtJmTerminal
            // 
            txtJmTerminal.Location = new Point(452, 280);
            txtJmTerminal.Name = "txtJmTerminal";
            txtJmTerminal.Size = new Size(234, 23);
            txtJmTerminal.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 313);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 13;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(452, 309);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(234, 86);
            txtAlamat.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(452, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(611, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEdit, btnDelete });
            dataGridView1.Location = new Point(12, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 184);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // FormMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJmTerminal);
            Controls.Add(label7);
            Controls.Add(txtNegara);
            Controls.Add(txtKota);
            Controls.Add(txtkodeIATA);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterBandara";
            Text = "FormMasterBandara";
            Load += FormMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)txtJmTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtkodeIATA;
        private TextBox txtKota;
        private ComboBox txtNegara;
        private Label label7;
        private NumericUpDown txtJmTerminal;
        private Label label8;
        private TextBox txtAlamat;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}