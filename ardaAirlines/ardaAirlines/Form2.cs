using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardaAirlines
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        public void Form2_Load(object sender, EventArgs e)
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {


                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(j*30+20, i*30+30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j==4)
                    {
                        continue;
                    }
                    sayac++;
                    this.Controls.Add(btn);
                        
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
