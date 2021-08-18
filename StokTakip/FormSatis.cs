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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }

        private void btnMusteriEkleme_Click(object sender, EventArgs e)
        {
            FormMusteriEkle fr = new FormMusteriEkle();
            fr.ShowDialog();
        }

        private void btnMusteriListeleme_Click(object sender, EventArgs e)
        {
            FormMusteriListele fr = new FormMusteriListele();
            fr.ShowDialog();
        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            FormUrunEkle fr = new FormUrunEkle();
            fr.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FormKategori fr = new FormKategori();
            fr.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            FormMarka fr = new FormMarka();
            fr.ShowDialog();
        }

        private void btnUrunListeleme_Click(object sender, EventArgs e)
        {
            FormUrunListele fr = new FormUrunListele();
            fr.ShowDialog();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter getir = new SqlDataAdapter("select * from Table_Sepet", baglanti);
            getir.Fill(daset, "Table_Sepet");
            dataGridView1.DataSource = daset.Tables["Table_Sepet"];
            dataGridView1.Columns[0].Visible = false; //1.sütunu gizledim
            dataGridView1.Columns[1].Visible = false; //2.sütunu gizledim
            dataGridView1.Columns[2].Visible = false; //3. sütunu gizledim
            baglanti.Close(); 
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand getir = new SqlCommand("select  sum(ToplamFiyat) from Table_Sepet", baglanti);
                lblGenelToplam2.Text = getir.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FormSatis_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_Musteri where TcNo like '"+txtTC.Text+"'", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                txtAdSoyad.Text = oku["AdSoyad"].ToString();
                txtTelefon.Text = oku["Telefon"].ToString();
            }
            baglanti.Close();
        }
        private void temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox) // texboxları temizle
                    {
                        if (item != txtMiktar) // txtMiktar textBox ı hariç diğerilerini temizle.
                        {
                            item.Text = "";
                        }
                    }

                }
            }
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_Urun where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                txtUrunAdi.Text = oku["UrunAdi"].ToString();
                txtSatisFiyati.Text = oku["SatisFiyati"].ToString();
            }
            baglanti.Close();
        }
        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if(item is TextBox) // texboxları temizle
                    {
                        if (item != txtMiktar) // txtMiktar textBox ı hariç diğerilerini temizle.
                        {
                            item.Text = "";
                        }
                    }
                    
                }
            }
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_Urun where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                txtUrunAdi.Text = oku["UrunAdi"].ToString();
                txtSatisFiyati.Text = oku["SatisFiyati"].ToString();
            }
            baglanti.Close();
        }
        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_Sepet", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                if (txtBarkodNo.Text == oku["BarkodNo"].ToString())
                {
                    durum = false;

                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum == true){
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Table_Sepet(TcNo,AdSoyad,Telefon,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyat,Tarih) values(@TcNo,@AdSoyad,@Telefon,@BarkodNo,@UrunAdi,@Miktari,@SatisFiyati,@ToplamFiyat,@Tarih)", baglanti);
                ekle.Parameters.AddWithValue("@TcNo", txtTC.Text);
                ekle.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                ekle.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                ekle.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                ekle.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                ekle.Parameters.AddWithValue("@Miktari", int.Parse(txtMiktar.Text));
                ekle.Parameters.AddWithValue("@SatisFiyati", double.Parse(txtSatisFiyati.Text));
                ekle.Parameters.AddWithValue("@ToplamFiyat", double.Parse(txtToplamFiyati.Text));
                ekle.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update Table_Sepet Miktari=Miktari+'"+int.Parse(txtMiktar.Text)+"'", baglanti);
                guncelle.ExecuteNonQuery();
                SqlCommand guncelle2 = new SqlCommand("update Table_Sepet ToplamFiyat = Miktari*SatisFiyati where BarkodNo='" + txtBarkodNo.Text + "'", baglanti);
                guncelle2.ExecuteNonQuery();

                baglanti.Close();
            }
             
            txtMiktar.Text = "1";
            daset.Tables["Table_Sepet"].Clear();
            sepetListele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox) // texboxları temizle
                {
                    if (item != txtMiktar) // txtMiktar textBox ı hariç diğerilerini temizle.
                    {
                        item.Text = "";
                    }
                }

            }

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();

            }
            catch (Exception)
            {

               
            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();

            }
            catch (Exception)
            {


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_Sepet where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()+"'", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
             
            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["Table_Sepet"].Clear();
            sepetListele();
            hesapla();
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_Sepet", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
             
            MessageBox.Show("Ürünler sepetten çıkarıldı");
            daset.Tables["Table_Sepet"].Clear();
            sepetListele();
            hesapla();
        }

        private void btnSatislariListeleme_Click(object sender, EventArgs e)
        {
            FormSatisListele fr = new FormSatisListele();
            fr.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Table_Satsi(TcNo,AdSoyad,Telefon,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyat,Tarih) values(@TcNo,@AdSoyad,@Telefon,@BarkodNo,@UrunAdi,@Miktari,@SatisFiyati,@ToplamFiyat,@Tarih)", baglanti);
                ekle.Parameters.AddWithValue("@TcNo", txtTC.Text);
                ekle.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                ekle.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                ekle.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString()); //kaç tane kayıt varsa barkodNo sütununa aktar dedim.
                ekle.Parameters.AddWithValue("@UrunAdi", dataGridView1.Rows[i].Cells["UrunAdi"].Value.ToString());
                ekle.Parameters.AddWithValue("@Miktari", int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()));
                ekle.Parameters.AddWithValue("@SatisFiyati", double.Parse(dataGridView1.Rows[i].Cells["SatisFiyati"].Value.ToString()));
                ekle.Parameters.AddWithValue("@ToplamFiyat", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyat"].Value.ToString()));
                ekle.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                ekle.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                
                SqlCommand guncelle = new SqlCommand("update Table_Urun set Miktari=Miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()) + "'where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_Sepet", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Table_Sepet"].Clear();
            sepetListele();
            hesapla();
        }
    }
}
