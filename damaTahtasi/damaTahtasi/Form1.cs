using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen siyahKalem = new Pen(Color.Black, 10);
            int x=10, y=10;

            for (int i = 0; i < 8; i++)
            {
                e.Graphics.DrawRectangle(siyahKalem, new Rectangle(x,y, 20, 20));
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Brush firca = new SolidBrush(Color.Black);
                        e.Graphics.FillRectangle(firca, new Rectangle(x, y, 20, 20));
                    }
                    e.Graphics.DrawRectangle(siyahKalem, new Rectangle(x,y, 20, 20));
                    x += 40;
                    
                }
                y += 40;
                x = 10;
            }
            
            
        }
    }
}
