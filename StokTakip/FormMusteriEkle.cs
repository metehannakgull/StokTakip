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
    public partial class FormMusteriEkle : Form
    {
        public FormMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");

        private void FormMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into Table_Musteri (TcNo,AdSoyad,Telefon,Adres,Email) values(@TcNo,@AdSoyad,@Telefon,@Adres,@Email)",baglanti);
            ekle.Parameters.AddWithValue("@TcNo", txtTC.Text);
            ekle.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            ekle.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            ekle.Parameters.AddWithValue("@Adres", txtAdres.Text);
            ekle.Parameters.AddWithValue("@Email", txtEmail.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi");

            foreach (Control item in this.Controls) //Formu temizleyecez
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
