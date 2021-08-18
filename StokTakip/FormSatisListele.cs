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
    public partial class FormSatisListele : Form
    {
        public FormSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CVANAKGUL;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();//kayıtları geçici olarak tutmak için
        private void satisListele()
        {
            baglanti.Open();
            SqlDataAdapter getir = new SqlDataAdapter("select * from Table_Satis", baglanti);
            getir.Fill(daset, "Table_Satis");
            dataGridView1.DataSource = daset.Tables["Table_Satis"];
             baglanti.Close();
        }
        private void FormSatisListele_Load(object sender, EventArgs e)
        {
            satisListele();
        }
    }
}
