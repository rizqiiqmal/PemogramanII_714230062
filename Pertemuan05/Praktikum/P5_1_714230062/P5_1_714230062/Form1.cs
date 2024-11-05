using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_714230062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Hello world";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormHello_Load(object sender, EventArgs e)
        {

        }
    }
}
