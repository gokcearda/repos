using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayıBul
{
    public partial class Form1 : Form
    {
        
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = 0, number2 = 0, number3 = 0, biggest = 0,smallest=0;
            number1=Convert.ToInt32(textBox1.Text);
            number2=Convert.ToInt32(textBox2.Text);
            number3=Convert.ToInt32(textBox3.Text);
            if (number1 < number2 && number1 < number3)
            {
                smallest=number1;
            }
            else if (number2<number3&&number2<number1)
            {
                smallest = number2;
            }
            else
            {
                smallest = number3;
            }
            if (number1 > number2 && number1 > number3)
            {
                biggest = number1;
            }
            else if (number2 > number3 && number2 > number1)
            {
                biggest = number2;
            }
            else
            {
                biggest = number3;
            }
            MessageBox.Show("En büyük sayı: " + biggest+"\n En küçük sayı: "+smallest);
        }
        
    }
}
