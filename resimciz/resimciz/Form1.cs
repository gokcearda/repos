using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resimciz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ciz=new Bitmap(pictureBox1.Width,pictureBox1.Height);
        }
        int y = 10;
        Bitmap ciz;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image= ciz;
            ciz.SetPixel(15, y, Color.Magenta);
            y++;

        }
    }
}
