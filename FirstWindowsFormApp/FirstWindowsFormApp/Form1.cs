using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormApp
{
    public partial class Form1 : Form
    {
        int sayi=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sayi+=1000000000;
            label1.Text=sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi--;
            label1.Text = sayi.ToString();
        }
    }
}
