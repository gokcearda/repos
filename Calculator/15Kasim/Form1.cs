using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Kasim
{
    public partial class Form1 : Form
    {
        double number1 = 0, number2 = 0, result = 0;
        string oprater = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string writetext(string number)
        {
            if (writeText.Text=="0" && writeText.Text==null)
            {
                writeText.Text = number;
            }
            else
            {
                writeText.Text+=number;  
            }
            return number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "1";
            }
            else
            {
                writeText.Text += "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writetext("2");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "3";
            }
            else
            {
                writeText.Text += "3";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "4";
            }
            else
            {
                writeText.Text += "4";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "5";
            }
            else
            {
                writeText.Text += "5";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "6";
            }
            else
            {
                writeText.Text += "6";
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "7";
            }
            else
            {
                writeText.Text += "7";
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "8";
            }
            else
            {
                writeText.Text += "8";
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "9";
            }
            else
            {
                writeText.Text += "9";
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = "0";
            }
            else
            {
                writeText.Text += "0";
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (writeText.Text == "0" && writeText.Text == null)
            {
                writeText.Text = ",";
            }
            else
            {
                writeText.Text += ",";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1+=Convert.ToDouble(writeText.Text);
            writeText.Text = null;
            oprater += "+";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 += Convert.ToDouble(writeText.Text);
            writeText.Text = null;
            oprater += "-";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 += Convert.ToDouble(writeText.Text);
            writeText.Text = null;
            oprater += "*";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(writeText.Text);
            switch (oprater)
            {
                case "+":
                    result=number1 + number2;
                    Result.Text = result.ToString();
                    number1 = result;
                    break;
                    case "-":  
                        result=number2 - number1;
                    Result.Text = result.ToString();
                    number1 = result;
                    break;
                    case "*":
                        result=number1 * number2;
                    Result.Text = result.ToString();
                    number1 = result;
                    break;
                case "/":
                    result=number1 / number2;
                    Result.Text = result.ToString();
                    number1 = result;
                    break;

                default:
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number1 += Convert.ToDouble(writeText.Text);
            writeText.Text = null;
            oprater += "/";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            writeText.Text = null;
            writeText.Focus();
            result = 0;
            oprater += "";
        }
    }
}
