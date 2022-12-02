using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimAcmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\sadea\OneDrive\Masaüstü\kedi.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Resimsec=new OpenFileDialog();
            if (Resimsec.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = Resimsec.FileName;
            }
            else
            {
                MessageBox.Show("Resim seçme işlemi iptal edildi.","Resim Seçme işlemi",MessageBoxButtons.YesNoCancel);
            }
        }
    }
}
