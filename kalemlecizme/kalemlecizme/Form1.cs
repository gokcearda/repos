using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalemlecizme
{
    public partial class Form1 : Form
    {
        Point baslangic;
        Point bitis;
        public Form1()
        {
            InitializeComponent();
        }
        bool durum=false;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            durum=false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum == true)
            {
                Graphics ciz;
                Pen kalem = new Pen(Color.Magenta);

                bitis = new Point(e.X, e.Y);
                baslangic = new Point(e.X - 1, e.Y - 1);
                ciz = pictureBox1.CreateGraphics();
                Brush firca = new SolidBrush(Color.Magenta);
                ciz.FillEllipse(firca, new Rectangle(e.X - 2, e.Y - 2, 10, 10));
                ciz.Dispose();
                label1.Text = "X:" + e.X + " Y:" + e.Y;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            durum=true;
        }
    }
}
