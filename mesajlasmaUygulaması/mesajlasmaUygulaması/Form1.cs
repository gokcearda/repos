using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesajlasmaUygulaması
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                richTextBox1.Text="Arda: "+textBox1.Text+"\n\n"+richTextBox1.Text;
                textBox1.Clear();
                textBox1.Focus();
                label1.Text = "140/0";
            }
            else
            {
                MessageBox.Show("Mesaj kutusu boş olmamalı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                richTextBox1.Text = "Yunus: " + textBox2.Text + "\n\n" + richTextBox1.Text;
                textBox2.Clear();
                textBox2.Focus();
                label2.Text = "140/0";
            }
            else
            {
                MessageBox.Show("Mesaj kutusu boş olmamalı.");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = textBox1.MaxLength.ToString() + "/" + textBox1.Text.Length;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            label2.Text= textBox2.MaxLength.ToString() + "/" + textBox2.Text.Length;
        }
    }
}
