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
    public partial class FormMusteriListele : Form
    {
        public FormMusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet datas = new DataSet();//kayıtları geçici olarak tutmak için
       
        private void KayitGoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Table_Musteri", baglanti);
            adtr.Fill(datas, "Table_Musteri"); //geçici tablo ve veritabanımdaki tablomu yazdım
            dataGridView1.DataSource = datas.Tables["Table_Musteri"]; //sonra datagridview'a aktarıyorum.
            baglanti.Close();
        }
        private void FormMusteriListele_Load(object sender, EventArgs e)
        {
            KayitGoster();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand update = new SqlCommand("update Table_Musteri set AdSoyad=@AdSoyad,Telefon=@Telefon,Adres=@Adres,Email=@Email where TcNo=@TcNo", baglanti);

            update.Parameters.AddWithValue("@TcNo", txtTC.Text);
            update.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            update.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            update.Parameters.AddWithValue("@Adres", txtAdres.Text);
            update.Parameters.AddWithValue("@Email", txtEmail.Text);
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi");
            datas.Tables["Table_Musteri"].Clear();//TAbloyu temizledik
            KayitGoster();
            foreach (Control item in this.Controls) //Formu temizleyecez
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_Musteri where TcNo='" + dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString(), baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            datas.Tables["Table_Musteri"].Clear();//TAbloyu temizledik
            KayitGoster();

            MessageBox.Show("Kayıt silindi");
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
