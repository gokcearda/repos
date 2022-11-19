using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlForm
{
    public partial class Form1 : Form
    {
        Personel personel=new Personel();

        public Form1()
        {
            InitializeComponent();
            dgwPersonel.DataSource = personel.GetPersonel();
        }
        private void ClearControls()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox5.Text = "";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            personel.Id=Convert.ToInt32(textBox1.Text);
            personel.AdSoyad=textBox2.Text;
            personel.Yas = Convert.ToInt32(textBox3.Text);
            personel.Telefon=textBox4.Text;
            personel.Cinsiyet = comboBox5.SelectedItem.ToString();

            var kontrol = personel.InsertPersonel(personel);
            dgwPersonel.DataSource=personel.GetPersonel();

            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Personel başarıyla eklendi.");

            }
            else
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel.Id = Convert.ToInt32(textBox1.Text);
            personel.AdSoyad = textBox2.Text;
            personel.Yas = Convert.ToInt32(textBox3.Text);
            personel.Telefon = textBox4.Text;
            personel.Cinsiyet = comboBox5.SelectedItem.ToString();

            var kontrol = personel.UpdatePersonel(personel);
            dgwPersonel.DataSource = personel.GetPersonel();

            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Personel başarıyla güncellendi.");

            }
            else
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel.Id = Convert.ToInt32(textBox1.Text);
            

            var kontrol = personel.DeletePersonel(personel);
            dgwPersonel.DataSource = personel.GetPersonel();

            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Personel başarıyla silindi.");

            }
            else
            {
                MessageBox.Show("Hata! Lütfen tekrar deneyiniz.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgwPersonel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dgwPersonel.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dgwPersonel.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dgwPersonel.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dgwPersonel.CurrentRow.Cells[3].Value.ToString();
            comboBox5.Text = dgwPersonel.CurrentRow.Cells[4].Value.ToString();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbPersonelDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.dbPersonelDataSet.Personel);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personelTableAdapter.FillBy(this.dbPersonelDataSet.Personel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
