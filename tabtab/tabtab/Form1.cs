using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabtab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] urunler = new string[5, 4];
        int say = 0;
        Thread urunyenile;
        int index;
        int silindex;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            urunyenile = new Thread(new ThreadStart(urunyenilefc));
            urunyenile.Start();
        }
        public void urunyenilefc()
        {
            while (true)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                label1.Text = "";
                for (int i = 0; i < urunler.GetLength(0); i++)
                {
                    if (!string.IsNullOrEmpty(urunler[i, 0]) && (!string.IsNullOrEmpty(urunler[i,3])))
                    {
                        label2.Text += urunler[i,0]+"-"+urunler[i,3];
                        listBox1.Items.Add(urunler[i,0]);
                        listBox2.Items.Add(urunler[i,0]);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (say<urunler.GetLength(0))
            {
                urunler[say, 0] = textBox1.Text;
                urunler[say, 0] = textBox2.Text;
                urunler[say, 0] = textBox3.Text;
                urunler[say, 0] = comboBox1.SelectedItem.ToString();
                say++;
            }
        }

       


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            silindex = listBox2.SelectedIndex;
            label2.Text = urunler[silindex,0];
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            urunler[silindex, 0] = "";
            urunler[silindex, 1] = "";
            urunler[silindex, 2] = "";
            urunler[silindex, 3] = "";
            if (silindex!=urunler.GetLength(0)-1)
            {
                for (int i = silindex; i < urunler.GetLength(0); i++)
                {
                    if (i<urunler.GetLength(0)-1)
                    {
                        urunler[i, 0] = urunler[i + 1, 0];
                        urunler[i, 1] = urunler[i + 1, 1];
                        urunler[i, 2] = urunler[i + 1, 2];
                        urunler[i, 3] = urunler[i + 1, 3];
                    }
                    else if (i==urunler.GetLength(0)-1)
                    {
                        urunler[i, 0] = "";
                        urunler[i, 1] = "";
                        urunler[i, 2] = "";
                        urunler[i, 3] = "";
                    }
                }
            }
            say = say - 1;        
        }
    }
}
