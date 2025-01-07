using P11_714230001.controller;
using P11_714230001.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714230001
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        public void Tampil()
        {
            // Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            // Mengubah Nama Kolom Tabel
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //memanggil method Tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNPM.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textboxNPM.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }
        public void ResetForm()
            {
                textboxNPM.Text = "";
                textboxNama.Text = "";
                comboBoxAngkatan.SelectedIndex = -1;
                textboxAlamat.Text = "";
                textboxEmail.Text = "";
                textboxNohp.Text = "";
                textboxCariData.Text = "";
            }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textboxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textboxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textboxNohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNPM.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textboxNPM.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mhs.Update(m_mhs, textboxNPM.Text);

                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textboxNPM.Text);
                ResetForm();
                Tampil();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textboxCariData_TextChanged(object sender, EventArgs e)
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%" + textboxCariData.Text + "%' OR nama LIKE '%" + textboxCariData.Text + "%'");
        }
    }
}

