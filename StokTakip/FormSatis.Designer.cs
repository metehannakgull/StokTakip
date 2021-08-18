
namespace StokTakip
{
    partial class FormSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtToplamFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblGenelToplam2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnSatislariListeleme = new System.Windows.Forms.Button();
            this.btnUrunListeleme = new System.Windows.Forms.Button();
            this.btnUrunEkleme = new System.Windows.Forms.Button();
            this.btnMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(31, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(37, 75);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(27, 49);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 13);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(59, 27);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(24, 13);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "TC:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 72);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(94, 49);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(94, 27);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 0;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblToplamFiyat);
            this.groupBox2.Controls.Add(this.lblSatisFiyati);
            this.groupBox2.Controls.Add(this.lblMiktar);
            this.groupBox2.Controls.Add(this.lblUrunAdi);
            this.groupBox2.Controls.Add(this.lblBarkodNo);
            this.groupBox2.Controls.Add(this.txtToplamFiyati);
            this.groupBox2.Controls.Add(this.txtSatisFiyati);
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.txtUrunAdi);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(31, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(18, 126);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(70, 13);
            this.lblToplamFiyat.TabIndex = 3;
            this.lblToplamFiyat.Text = "Toplam Fiyat:";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(27, 100);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(60, 13);
            this.lblSatisFiyati.TabIndex = 3;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(44, 74);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(39, 13);
            this.lblMiktar.TabIndex = 3;
            this.lblMiktar.Text = "Miktar:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(33, 48);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(50, 13);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürün adı:";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(22, 26);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(61, 13);
            this.lblBarkodNo.TabIndex = 3;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // txtToplamFiyati
            // 
            this.txtToplamFiyati.Location = new System.Drawing.Point(94, 126);
            this.txtToplamFiyati.Name = "txtToplamFiyati";
            this.txtToplamFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtToplamFiyati.TabIndex = 5;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(94, 100);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyati.TabIndex = 4;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.txtSatisFiyati_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(94, 74);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "1";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(94, 48);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(94, 23);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(237, 377);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(745, 148);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(745, 177);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatisIptal.TabIndex = 5;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.btnSatisIptal_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(663, 380);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(75, 23);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(369, 382);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(76, 13);
            this.lblGenelToplam.TabIndex = 7;
            this.lblGenelToplam.Text = "Genel Toplam:";
            // 
            // lblGenelToplam2
            // 
            this.lblGenelToplam2.AutoSize = true;
            this.lblGenelToplam2.Location = new System.Drawing.Point(451, 382);
            this.lblGenelToplam2.Name = "lblGenelToplam2";
            this.lblGenelToplam2.Size = new System.Drawing.Size(13, 13);
            this.lblGenelToplam2.TabIndex = 8;
            this.lblGenelToplam2.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnSatislariListeleme);
            this.panel1.Controls.Add(this.btnUrunListeleme);
            this.panel1.Controls.Add(this.btnUrunEkleme);
            this.panel1.Controls.Add(this.btnMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 100);
            this.panel1.TabIndex = 9;
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(724, 31);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(85, 40);
            this.btnMarka.TabIndex = 2;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(611, 31);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(107, 40);
            this.btnKategori.TabIndex = 1;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnSatislariListeleme
            // 
            this.btnSatislariListeleme.Location = new System.Drawing.Point(498, 31);
            this.btnSatislariListeleme.Name = "btnSatislariListeleme";
            this.btnSatislariListeleme.Size = new System.Drawing.Size(107, 40);
            this.btnSatislariListeleme.TabIndex = 0;
            this.btnSatislariListeleme.Text = "Satışları Listeleme";
            this.btnSatislariListeleme.UseVisualStyleBackColor = true;
            this.btnSatislariListeleme.Click += new System.EventHandler(this.btnSatislariListeleme_Click);
            // 
            // btnUrunListeleme
            // 
            this.btnUrunListeleme.Location = new System.Drawing.Point(372, 31);
            this.btnUrunListeleme.Name = "btnUrunListeleme";
            this.btnUrunListeleme.Size = new System.Drawing.Size(120, 40);
            this.btnUrunListeleme.TabIndex = 0;
            this.btnUrunListeleme.Text = "Ürün Listeleme";
            this.btnUrunListeleme.UseVisualStyleBackColor = true;
            this.btnUrunListeleme.Click += new System.EventHandler(this.btnUrunListeleme_Click);
            // 
            // btnUrunEkleme
            // 
            this.btnUrunEkleme.Location = new System.Drawing.Point(247, 31);
            this.btnUrunEkleme.Name = "btnUrunEkleme";
            this.btnUrunEkleme.Size = new System.Drawing.Size(117, 40);
            this.btnUrunEkleme.TabIndex = 0;
            this.btnUrunEkleme.Text = "Ürün Ekleme";
            this.btnUrunEkleme.UseVisualStyleBackColor = true;
            this.btnUrunEkleme.Click += new System.EventHandler(this.btnUrunEkleme_Click);
            // 
            // btnMusteriListeleme
            // 
            this.btnMusteriListeleme.Location = new System.Drawing.Point(125, 31);
            this.btnMusteriListeleme.Name = "btnMusteriListeleme";
            this.btnMusteriListeleme.Size = new System.Drawing.Size(116, 40);
            this.btnMusteriListeleme.TabIndex = 0;
            this.btnMusteriListeleme.Text = "Müşteri Listeleme";
            this.btnMusteriListeleme.UseVisualStyleBackColor = true;
            this.btnMusteriListeleme.Click += new System.EventHandler(this.btnMusteriListeleme_Click);
            // 
            // btnMusteriEkleme
            // 
            this.btnMusteriEkleme.Location = new System.Drawing.Point(12, 31);
            this.btnMusteriEkleme.Name = "btnMusteriEkleme";
            this.btnMusteriEkleme.Size = new System.Drawing.Size(107, 40);
            this.btnMusteriEkleme.TabIndex = 0;
            this.btnMusteriEkleme.Text = "Müşteri Ekleme";
            this.btnMusteriEkleme.UseVisualStyleBackColor = true;
            this.btnMusteriEkleme.Click += new System.EventHandler(this.btnMusteriEkleme_Click);
            // 
            // FormSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(821, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam2);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtToplamFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblGenelToplam2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatislariListeleme;
        private System.Windows.Forms.Button btnUrunListeleme;
        private System.Windows.Forms.Button btnUrunEkleme;
        private System.Windows.Forms.Button btnMusteriListeleme;
        private System.Windows.Forms.Button btnMusteriEkleme;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnKategori;
    }
}

