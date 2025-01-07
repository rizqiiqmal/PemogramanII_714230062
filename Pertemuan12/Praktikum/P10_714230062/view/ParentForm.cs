using P11_714230062;
using P11_714230062.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714230062.view
{
    public partial class ParentForm : Form
    {
        
        public ParentForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormMhs = new Form1();
            FormMhs.MdiParent = this;
            FormMhs.Show();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai FrmNilai = new FormNilai();
            FrmNilai.MdiParent = this;
            FrmNilai.Show();
        }

        private void tugasPratikum11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang FrmMasterBarang = new FormBarang();
            FrmMasterBarang.MdiParent = this;
            FrmMasterBarang.Show();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiBarang FrmTransaksi = new FormTransaksiBarang();
            FrmTransaksi.MdiParent = this;
            FrmTransaksi.Show();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
