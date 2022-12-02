using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int baklava, sobiyet, fistiklisarma, kadayif, sutlac,kunefe;
        decimal baklavaFiyat, sobiyetFiyat, fistiklisarmaFiyat, kadayifFiyat, sutlacFiyat, kunefeFiyat;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        decimal toplamKasa =0;
        decimal toplam=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baklavaFiyat = Convert.ToDecimal(label17.Text);
            sobiyetFiyat = Convert.ToDecimal(label16.Text);
            fistiklisarmaFiyat = Convert.ToDecimal(label15.Text);
            kadayifFiyat = Convert.ToDecimal(label14.Text);
            sutlacFiyat = Convert.ToDecimal(label13.Text);
            kunefeFiyat = Convert.ToDecimal(label18.Text);

            baklava=Convert.ToInt32(textBox1.Text);
            sobiyet = Convert.ToInt32(textBox2.Text);
            fistiklisarma = Convert.ToInt32(textBox3.Text);
            kadayif = Convert.ToInt32(textBox4.Text);
            sutlac = Convert.ToInt32(textBox5.Text);
            kunefe = Convert.ToInt32(textBox6.Text);

            toplam = Convert.ToDecimal(label21.Text);
            toplamKasa=(baklava*baklavaFiyat)+(sobiyet*sobiyetFiyat)+(fistiklisarma*fistiklisarmaFiyat)+(kadayif*kadayifFiyat)+(sutlac*sutlacFiyat)+(kunefe*kunefeFiyat);
            toplamKasa+=toplam;
            label20.Text = toplam.ToString();
            label22.Text = toplam.ToString();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }
    }
}
