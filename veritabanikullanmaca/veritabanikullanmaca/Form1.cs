using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanikullanmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data source=.;Initial Catalog=NORTHWND;Integrated Security=True")) 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select*From Customers", con);
                SqlDataReader dr = cmd.ExecuteReader();
                List<string> list = new List<string>();
                
                while (dr.Read())
                {
                    list.Add(dr["Country"].ToString());
                }
                dr.Close();
                list=list.Distinct().ToList();
                list.Sort();
                comboBox1.DataSource = list;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
