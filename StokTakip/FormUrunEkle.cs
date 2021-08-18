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
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");
        bool durum;
        private void barkodKontrol() 
        {
            durum = true;
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_Urun", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                if (txtBarkodNo.Text==oku["BarkodNo"].ToString() || txtBarkodNo.Text=="")
                {
                  durum = false;
                }

            }
            baglanti.Close();
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
        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Table_MarkaBilgileri tablosundan seçtiğim "Kategori"ye göre "Marka" comboBox'ımda gözükecek.
            comboBoxMarka.Items.Clear();
            comboBoxMarka.Text = "";
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_MarkaBilgileri where Kategori='" + comboBoxKategori.SelectedItem + "'", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                comboBoxMarka.Items.Add(oku["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Table_Urun(BarkodNo,Kategori,Marka,UrunAdi,Miktari,AlisFiyati,SatisFiyati,Tarih) values(@BarkodNo,@Kategori,@Marka,@UrunAdi,@Miktari,@AlisFiyati,@SatisFiyati,@Tarih)", baglanti);
                ekle.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                ekle.Parameters.AddWithValue("@Kategori", comboBoxKategori.Text);
                ekle.Parameters.AddWithValue("@Marka", comboBoxMarka.Text);
                ekle.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                ekle.Parameters.AddWithValue("@Miktari", int.Parse(txtMiktari.Text));
                ekle.Parameters.AddWithValue("@AlisFiyati", double.Parse(txtAlisFiyati.Text));
                ekle.Parameters.AddWithValue("@SatisFiyati", double.Parse(txtSatisFiyati.Text));
                ekle.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                ekle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün eklendi");
            }
            else
            {
                MessageBox.Show("Bu BarkodNo kayıtlıdır.","Uyarı");
            }
           
            comboBoxMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void txtBarkodNo2_TextChanged(object sender, EventArgs e)
        {

            if (txtBarkodNo2.Text == "")
            {
                lblVarOlanMiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if(item is TextBox)//textboxları temizle
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_Urun where BarkodNo like '" + txtBarkodNo2.Text + "'", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                txtKategori2.Text = oku["Kategori"].ToString();
                txtMarka2.Text = oku["Marka"].ToString();
                txtUrunAdi2.Text = oku["UrunAdi"].ToString();
                lblVarOlanMiktar.Text = oku["Miktari"].ToString();
                txtAlisFiyati2.Text = oku["AlisFiyati"].ToString();
                txtSatisFiyati2.Text = oku["SatisFiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnVarOlanEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update Table_Urun set Miktari=Miktari+'" + int.Parse(txtMiktari2.Text) + "'where BarkodNo='" + txtBarkodNo2.Text + "'", baglanti);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)//textboxları temizle
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
