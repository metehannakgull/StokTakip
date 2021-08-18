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
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");

        DataSet daset = new DataSet();
        private void urunListele()
        {

            baglanti.Open();
            SqlDataAdapter getir = new SqlDataAdapter("select * from Table_Urun", baglanti);
            getir.Fill(daset, "Table_Urun");
            dataGridView1.DataSource = daset.Tables["Table_Urun"];
            baglanti.Close();
        }
        private void kategoriGetir()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_KategoriBilgileri", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["Kategori"].ToString());

            }
            baglanti.Close();
        }

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            urunListele();
            kategoriGetir();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Table_MarkaBilgileri tablosundan seçtiğim "Kategori"ye göre "Marka" comboBox'ımda gözükecek.
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Table_MarkaBilgileri where Kategori='" + comboBox1.SelectedItem + "'", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku["Marka"].ToString());
            }
            baglanti.Close();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            txtKategori.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtMiktari.Text = dataGridView1.CurrentRow.Cells["Miktari"].Value.ToString();
            txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells["AlisFiyati"].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update Table_Urun set UrunAdi=@UrunAdi, Miktari=@Miktari, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati where BarkodNo=@BarkodNo",baglanti);
            guncelle.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            guncelle.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
            guncelle.Parameters.AddWithValue("@Miktari", int.Parse(txtMiktari.Text));
            guncelle.Parameters.AddWithValue("@AlisFiyati", double.Parse(txtAlisFiyati.Text));
            guncelle.Parameters.AddWithValue("@SatisFiyati", double.Parse(txtSatisFiyati.Text));
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Table_Urun"].Clear();//Güncelleme yaptıktan sonra önce tabloyu temizle.
            urunListele();                      //Sonra güncel şekilde verileri listele
            MessageBox.Show("Güncelleme yapıldı");
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {

            if (txtBarkodNo.Text != "")
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update Table_Urun set Kategori=@Kategori, Marka=@Marka where BarkodNo=@BarkodNo", baglanti);
                guncelle.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                guncelle.Parameters.AddWithValue("@Kategori", comboBox1.Text);
                guncelle.Parameters.AddWithValue("@Marka", comboBox2.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["Table_Urun"].Clear();//Güncelleme yaptıktan sonra önce tabloyu temizle.
                urunListele();                        //Sonra güncel şekilde verileri listele
                MessageBox.Show("Güncelleme yapıldı");

            }
            else
            {
                MessageBox.Show("BarkodNo yazılı değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_Urun where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString(), baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Table_Urun"].Clear();//TAbloyu temizledik
            urunListele();

            MessageBox.Show("Kayıt silindi");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Table_Urun where BarkodNo like '%" + txtBarkodNo.Text + "%'", baglanti);
            ara.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
