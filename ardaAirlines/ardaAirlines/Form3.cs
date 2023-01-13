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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ardaAirlinesDataSet.flight' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.flightTableAdapter.Fill(this.ardaAirlinesDataSet.flight);

        }
        flightTableAdapters.flightTableAdapter ucus1=new flightTableAdapters.flightTableAdapter();

        public void button1_Click(object sender, EventArgs e)
        {

            ucus1.ucusEkleme(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, int.Parse(textBox5.Text));
            DialogResult result = MessageBox.Show("Uçuş başarıyla eklendi!","Mesaj", MessageBoxButtons.OK);
            dataGridView1.Refresh();
            
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            ucus1.flightGetData();
            this.flightTableAdapter.Fill(this.ardaAirlinesDataSet.flight);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
