using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");
        bool durum;
        private void kategoriKontrol() //kategori textbox kontrolü
        {
            durum = true;
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_KategoriBilgileri", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                if (txtKategori.Text==oku["Kategori"].ToString() || txtKategori.Text=="")
                {
                    durum = false;
                }
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kategoriKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Table_KategoriBilgileri(Kategori) values('"+txtKategori.Text+"')", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                 
                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("Mevcut Kategori girdiniz.", "Uyarı");

            }
            txtKategori.Text = "";
        }
    }
}
