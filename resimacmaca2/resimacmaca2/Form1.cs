using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resimacmaca2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==0)
            {
                pictureBox1.ImageLocation = "https://nazarca.com/wp-content/uploads/2013/11/kolay-ucak-resmi-nasil-cizilir.jpg";
            }
            else if (listBox1.SelectedIndex==1)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJhBNrtWuIp0Ex5SkW7ym2hnb7MvIGgVUkEg&usqp=CAU";
            }
            else if (listBox1.SelectedIndex==2)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXEaQt52npj3CwVz0Ro8ckddjsRDA7F1n-gw&usqp=CAU";
            }
            else if (listBox1.SelectedIndex==3)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRypJLWN8NmJtljoS_TerZB8r1Y1Z_7Ud3nog&usqp=CAU";
            }else if (listBox1.SelectedIndex == 4)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZ56qZipty8UF5uygUMC_orQoNbJIfTpDD3w&usqp=CAU";
            }
        }
    }
}
