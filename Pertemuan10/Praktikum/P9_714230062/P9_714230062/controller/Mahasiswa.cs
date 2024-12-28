using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P10_714230062;
using P9_714230062.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P9_714230062.controller
{
    internal class Mahasiswa
    {
        Koneksi Koneksi = new Koneksi();

        public bool Insert(M_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                Koneksi.OpenConnection();
                Koneksi.ExecetueQuery("INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp)" +
                " VALUES ('" + mahasiswa.Npm + "', '" + mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat + "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool Update(M_mahasiswa mahasiswa, string npm_mhs)
        {
            Boolean status = false;
            try
            {
                Koneksi.OpenConnection(); 
                Koneksi.ExecetueQuery("UPDATE t_mahasiswa SET nama='" + mahasiswa.Nama + "'," + "angkatan='" + mahasiswa.Angkatan + "'," + "alamat='" + mahasiswa.Alamat +
                "'," + "email='" + mahasiswa.Email + "'," + "nohp='" + mahasiswa.Nohp + "' WHERE npm = '" + npm_mhs + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        internal void Update(string v, object npm_mhs)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string npm_mhs)
        {
            Boolean status = false;
            try
            {
                Koneksi.OpenConnection();
                Koneksi.ExecetueQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm_mhs + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
