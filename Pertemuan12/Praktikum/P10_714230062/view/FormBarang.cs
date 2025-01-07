using P11_714230062.controller;
using P11_714230062.model;
using P11_714230062.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P11_714230062.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        Barang barang = new Barang();
        string id_barang;

        public FormBarang()
        {
            InitializeComponent();
        }

        public FormBarang(string id_barang)
        {
            this.id_barang = id_barang;
        }

        public void Tampil()
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }
        public void Reset()
        {
            textboxNamaBarang.Text = "";
            textboxHarga.Text = "";
            textboxID.Text = "";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reset();
            Tampil();
        }

        private void textboxNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNamaBarang.Text == "" || textboxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Nama_barang = textboxNamaBarang.Text;
                m_barang.Harga = textboxHarga.Text;
                barang.Insert(m_barang);
                Reset();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNamaBarang.Text == "" || textboxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Nama_barang = textboxNamaBarang.Text;
                m_barang.Harga = textboxHarga.Text;
                barang.Update(m_barang, textboxID.Text);
                Reset();
                Tampil();
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                barang.Delete(textboxID.Text);
                Reset();
                Tampil();
            }
        }

        private void textboxCariData_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM t_barang WHERE id_barang LIKE '%" + textboxCariData.Text + "%' OR nama_barang LIKE '%" + textboxCariData.Text + "%' OR harga LIKE '%" + textboxCariData.Text + "%'";
            DataBarang.DataSource = koneksi.ShowData(query);
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textboxHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxID.Text = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void textboxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
