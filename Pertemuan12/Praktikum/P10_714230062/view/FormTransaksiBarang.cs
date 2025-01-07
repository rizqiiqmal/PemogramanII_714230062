using MySql.Data.MySqlClient;
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
    public partial class FormTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksi m_transaksi = new M_transaksi();

        public FormTransaksiBarang(string id_transaksi)
        {
            this.id_transaksi = id_transaksi;
        }

        string id_transaksi;
        public FormTransaksiBarang()
        {
            InitializeComponent();
        }
        public void Tampil()
        {
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");

            DataTransaksiBarang.Columns[0].HeaderText = "ID";
            DataTransaksiBarang.Columns[1].HeaderText = "ID Barang";
            DataTransaksiBarang.Columns[2].HeaderText = "Nama Barang";
            DataTransaksiBarang.Columns[3].HeaderText = "Harga";
            DataTransaksiBarang.Columns[4].HeaderText = "Quantity";
            DataTransaksiBarang.Columns[5].HeaderText = "Total Harga";
        }
        public void GetDataBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                int id_barang = reader.GetInt32("id_barang");
                comboBoxIDBarang.Items.Add(id_barang.ToString());
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void getNamaBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + comboBoxIDBarang.Text + "'");
            while (reader.Read())
            {
                string nama_barang = reader.GetString("nama_barang");
                textboxNamaBrg.Text = nama_barang;
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getHargaBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + comboBoxIDBarang.Text + "'");
            while (reader.Read())
            {
                int harga = reader.GetInt32("harga");
                textboxHargaBrg.Text = harga.ToString();
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getTotal()
        {
            if (int.TryParse(textboxQuantity.Text, out int qty) && int.TryParse(textboxHargaBrg.Text, out int harga))
            {
                int total = qty * harga;
                textboxTotal.Text = total.ToString();
            }
        }
        public void Reset()
        {
            comboBoxIDBarang.SelectedIndex = -1;
            textboxNamaBrg.Text = "";
            textboxHargaBrg.Text = "";
            textboxQuantity.Text = "";
            textboxTotal.Text = "";
            textboxCariData.Text = "";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void comboBoxIDBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNamaBarang();
            getHargaBarang();
            getTotal();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxIDBarang.SelectedIndex == -1 || textboxQuantity.Text == "" || textboxTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Transaksi transaksi = new Transaksi();
                m_transaksi.Id_barang = comboBoxIDBarang.Text;
                m_transaksi.Qty = textboxQuantity.Text;
                m_transaksi.Total = textboxTotal.Text;
                transaksi.Insert(m_transaksi);
                Reset();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (comboBoxIDBarang.SelectedIndex == -1 || textboxQuantity.Text == "" || textboxTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Transaksi transaksi = new Transaksi();
                m_transaksi.Id_barang = comboBoxIDBarang.Text;
                m_transaksi.Qty = textboxQuantity.Text;
                m_transaksi.Total = textboxTotal.Text;
                transaksi.Update(m_transaksi, id_transaksi);
                Reset();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Transaksi transaksi = new Transaksi();
                transaksi.Delete(id_transaksi);
                Reset();
                Tampil();
            }
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataBarang();
        }

        private void DataTransaksiBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksiBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxIDBarang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textboxQuantity.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void textboxCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang WHERE id_transaksi LIKE '%" + textboxCariData.Text + "%' OR t_barang.id_barang LIKE '%" + textboxCariData.Text + "%' OR nama_barang LIKE '%" + textboxCariData.Text + "%' OR harga LIKE '%" + textboxCariData.Text + "%' OR qty LIKE '%" + textboxCariData.Text + "%' OR total LIKE '%" + textboxCariData.Text + "%'");
        }

        private void textboxQuantity_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void textboxHargaBrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DataTransaksiBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
