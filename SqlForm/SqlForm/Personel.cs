using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SqlForm
{
    class Personel
    {
        int _id;
        string _adsoyad;
        int _yas;
        string _telefon;
        string _cinsiyet;
        public int Id { get { return _id; } set { _id = value; } }
        public string AdSoyad { get { return _adsoyad; } set { _adsoyad = value; } }
        public int Yas { get { return _yas; } set { _yas = value; } }
        public string Telefon { get { return _telefon; } set { _telefon = value; } }
        public string Cinsiyet { get { return _cinsiyet; } set { _cinsiyet = value; } }
        
        

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string InsertQuery = "Insert Into Personel(Id,AdSoyad,Yas,Telefon,Cinsiyet) Values(@personelId,@PersonelAdSoyad,@PersonelYas,@PersonelTelefon,@PersonelCinsiyet)";
        
        public Boolean InsertPersonel(Personel personel)
        {
            int rows;
            using(SqlConnection conn = new SqlConnection(myConn))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, conn))
                {
                    com.Parameters.AddWithValue("@PersonelId",personel.Id);
                    com.Parameters.AddWithValue("@PersonelAdSoyad",personel.AdSoyad);
                    com.Parameters.AddWithValue("@PersonelYas",personel.Yas);
                    com.Parameters.AddWithValue("@PersonelTelefon",personel.Telefon);
                    com.Parameters.AddWithValue("@PersonelCinsiyet",personel.Cinsiyet);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        private const string UpdateQuery = "Update Personel set AdSoyad=@PersonelAdSoyad, Yas=@PersonelYas,Telefon=@PersonelTelefon,Cinsiyet=@PersonelCinsiyet where Id=@PersonelId";

        public bool UpdatePersonel(Personel personel)
        {
            int rows;
            using (SqlConnection conn = new SqlConnection(myConn))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, conn))
                {
                    com.Parameters.AddWithValue("@PersonelId", personel.Id);
                    com.Parameters.AddWithValue("@PersonelAdSoyad", personel.AdSoyad);
                    com.Parameters.AddWithValue("@PersonelYas", personel.Yas);
                    com.Parameters.AddWithValue("@PersonelTelefon", personel.Telefon);
                    com.Parameters.AddWithValue("@PersonelCinsiyet", personel.Cinsiyet);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        private const string DeleteQuery = "Delete from personel where Id=@PersonelId";
        public bool DeletePersonel(Personel personel)
        {
            int rows;
            using (SqlConnection conn = new SqlConnection(myConn))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, conn))
                {
                    com.Parameters.AddWithValue("@PersonelId", personel.Id);
                    
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        private const string SelectQuery = "Select*From Personel";
        public DataTable GetPersonel()
        {
            var datatable = new DataTable();
            using (SqlConnection conn = new SqlConnection(myConn))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, conn))
                {
                    using(SqlDataAdapter adapter=new SqlDataAdapter(com))
                    {
                       adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }
    }
}
