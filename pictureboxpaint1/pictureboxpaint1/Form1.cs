using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureboxpaint1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen kırmızıKalem = new Pen(Color.Red, 10);
            Pen yesilKalem=new Pen(Color.Green, 10);

            e.Graphics.DrawRectangle(kırmızıKalem, new Rectangle(10, 10, 200, 150));
            e.Graphics.DrawRectangle(yesilKalem, new Rectangle(220, 10, 50, 50));
        }
    }
}
