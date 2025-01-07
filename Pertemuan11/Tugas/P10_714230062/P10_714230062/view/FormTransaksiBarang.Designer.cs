namespace P10_714230062.view
{
    partial class FormTransaksiBarang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTransaksiBarang = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textboxCariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxHargaBrg = new System.Windows.Forms.TextBox();
            this.textboxNamaBrg = new System.Windows.Forms.TextBox();
            this.comboBoxIDBarang = new System.Windows.Forms.ComboBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.textboxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTransaksiBarang);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Transaksi Barang";
            // 
            // DataTransaksiBarang
            // 
            this.DataTransaksiBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksiBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiBarang.Location = new System.Drawing.Point(5, 21);
            this.DataTransaksiBarang.Name = "DataTransaksiBarang";
            this.DataTransaksiBarang.RowHeadersWidth = 62;
            this.DataTransaksiBarang.Size = new System.Drawing.Size(869, 183);
            this.DataTransaksiBarang.TabIndex = 0;
            this.DataTransaksiBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiBarang_CellClick);
            this.DataTransaksiBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiBarang_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textboxCariData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(580, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Form Pencarian";
            // 
            // textboxCariData
            // 
            this.textboxCariData.Location = new System.Drawing.Point(84, 24);
            this.textboxCariData.Name = "textboxCariData";
            this.textboxCariData.Size = new System.Drawing.Size(220, 23);
            this.textboxCariData.TabIndex = 1;
            this.textboxCariData.TextChanged += new System.EventHandler(this.textboxCariData_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(580, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(17, 114);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(287, 25);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(17, 83);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(287, 25);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(17, 55);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(287, 22);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(17, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(287, 25);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.textboxTotal);
            this.groupBox2.Controls.Add(this.textboxQuantity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 214);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Transaksi Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rp";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID Barang";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textboxHargaBrg);
            this.groupBox5.Controls.Add(this.textboxNamaBrg);
            this.groupBox5.Controls.Add(this.comboBoxIDBarang);
            this.groupBox5.Location = new System.Drawing.Point(93, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(469, 112);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Harga Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textboxHargaBrg
            // 
            this.textboxHargaBrg.Location = new System.Drawing.Point(248, 73);
            this.textboxHargaBrg.Name = "textboxHargaBrg";
            this.textboxHargaBrg.ReadOnly = true;
            this.textboxHargaBrg.Size = new System.Drawing.Size(217, 23);
            this.textboxHargaBrg.TabIndex = 11;
            this.textboxHargaBrg.TextChanged += new System.EventHandler(this.textboxHargaBrg_TextChanged);
            // 
            // textboxNamaBrg
            // 
            this.textboxNamaBrg.Location = new System.Drawing.Point(6, 73);
            this.textboxNamaBrg.Name = "textboxNamaBrg";
            this.textboxNamaBrg.ReadOnly = true;
            this.textboxNamaBrg.Size = new System.Drawing.Size(207, 23);
            this.textboxNamaBrg.TabIndex = 10;
            // 
            // comboBoxIDBarang
            // 
            this.comboBoxIDBarang.FormattingEnabled = true;
            this.comboBoxIDBarang.Location = new System.Drawing.Point(6, 20);
            this.comboBoxIDBarang.Name = "comboBoxIDBarang";
            this.comboBoxIDBarang.Size = new System.Drawing.Size(207, 26);
            this.comboBoxIDBarang.TabIndex = 7;
            this.comboBoxIDBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDBarang_SelectedIndexChanged);
            // 
            // textboxTotal
            // 
            this.textboxTotal.Location = new System.Drawing.Point(99, 175);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(207, 23);
            this.textboxTotal.TabIndex = 8;
            this.textboxTotal.TextChanged += new System.EventHandler(this.textboxTotal_TextChanged);
            // 
            // textboxQuantity
            // 
            this.textboxQuantity.Location = new System.Drawing.Point(99, 147);
            this.textboxQuantity.Name = "textboxQuantity";
            this.textboxQuantity.Size = new System.Drawing.Size(207, 23);
            this.textboxQuantity.TabIndex = 7;
            this.textboxQuantity.TextChanged += new System.EventHandler(this.textboxQuantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity";
            // 
            // FormTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTransaksiBarang";
            this.Text = "FormTransaksiBarang";
            this.Load += new System.EventHandler(this.FormTransaksiBarang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTransaksiBarang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textboxCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.TextBox textboxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxIDBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxHargaBrg;
        private System.Windows.Forms.TextBox textboxNamaBrg;
    }
}