using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Operatör_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = 0, number2 = 0, result = 0;
            string oprt = "";
            number1 = Convert.ToDouble(Number1.Text);
            number2 = Convert.ToDouble(Number2.Text);
            oprt = Operatör.Text;
            switch (oprt)
            {
                case "+":
                result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;

                default:
                    Result.Text = result.ToString("Girilen operatör Hatalı! Tekrar Deneyiniz.");
                    
                    //Result.Text = result.ToString("Girilen operatör Hatalı! Tekrar Deneyiniz.");
                    MessageBox.Show("Girilen operatör Hatalı! Tekrar Deneyiniz.");
                    break;
            }
             Result.Text=result.ToString();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
