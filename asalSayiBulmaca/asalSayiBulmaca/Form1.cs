using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalSayiBulmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int baslangic, bitis;
            baslangic = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);

            int sayi = baslangic;
            bool durum = true;
            while (sayi < bitis)
            {
                sayi++;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        durum = false;
                    }

                }
                if (durum == true && sayi != 1)
                {
                    listBox1.Items.Add(sayi.ToString());
                }
                durum = true;
            }
            MessageBox.Show(listBox1.Items.Count.ToString() + "Adet asal sayı vardır.");

        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = (@"C:\\Users\\sadea\\OneDrive\\Masaüstü\\şahsi\\greencardvesikalik.jpg");
        }
    }
}
