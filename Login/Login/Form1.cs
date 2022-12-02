using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        string kullaniciAdi = "Arda Gökçe";
        string sifre = "123456";
        
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '?';
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                DialogResult girisKontrol = MessageBox.Show("Giriş yapılsın mı?", "Giriş Sistemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (girisKontrol == DialogResult.Yes)
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Giriş Yapılamadı :(");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
