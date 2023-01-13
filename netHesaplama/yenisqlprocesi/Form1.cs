using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yenisqlprocesi
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
            double turkceDogru, turkceYanlis, turkceNet;
            double matDogru, matYanlis, matNet;
            double fenDogru, fenYanlis, fenNet;

            turkceDogru=Convert.ToDouble(textBox1.Text);
            turkceYanlis=Convert.ToDouble(textBox4.Text);
            matDogru=Convert.ToDouble(textBox3.Text);
            matYanlis=Convert.ToDouble(textBox6.Text);
            fenDogru=Convert.ToDouble(textBox2.Text);
            fenYanlis=Convert.ToDouble(textBox5.Text);

            turkceNet = turkceDogru - (turkceYanlis / 4);
            matNet = matDogru - (matYanlis / 4);
            fenNet=fenDogru - (fenYanlis / 4);

            textBox7.Text=turkceNet.ToString();
            textBox7.Enabled=false;
            textBox8.Text=fenNet.ToString();
            textBox8.Enabled=false;
            textBox9.Text=matNet.ToString();
            textBox9.Enabled=false;



        }
    }
}
