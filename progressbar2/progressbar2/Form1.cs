using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i=0;
        Random rndm = new Random();

        double j = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            j=Math.Round((rndm.NextDouble()*2)+1);
            i += Convert.ToInt32(j);
            if (i>100)
            {
                i = 100;
                listBox1.Items.Add(textBox1.Text);
                timer1.Stop();
            }
            progressBar1.Value= i;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
