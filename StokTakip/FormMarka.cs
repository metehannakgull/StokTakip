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
    public partial class FormMarka : Form
    {
        public FormMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");
        bool durum;
        private void markaKontrol() //kategori textbox kontrolü
        {
            durum = true;
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_MarkaBilgileri", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                if (comboBoxKategori.Text==oku["Kategori"].ToString() &&  txtMarka.Text == oku["Marka"].ToString() || txtMarka.Text == ""|| comboBoxKategori.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            markaKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Table_MarkaBilgileri(Kategori,Marka) values('"+comboBoxKategori.Text+"','" + txtMarka.Text + "')", baglanti);
                ekle.ExecuteNonQuery();
                baglanti.Close(); 
                MessageBox.Show("Marka eklendi");
            }
            else
            {
                MessageBox.Show("Bu kategori ve marka mecvut", "Uyarı");
            }
            
            txtMarka.Text = "";
            comboBoxKategori.Text = "";
           
        }
        private void kategoriGetir()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_KategoriBilgileri", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                comboBoxKategori.Items.Add(oku["Kategori"].ToString());

            }
            baglanti.Close();
        }
        private void FormMarka_Load(object sender, EventArgs e)
        {
            //Form yüklendiğinde comboBox'a kategorilerim gelmeli
            kategoriGetir();
        }
    }
}
