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
/**
 * Burasi Bilgilendirme Formudur.
 * Kayit Yapildiktan Sonra son Kaydin verilerini veriTabanindan Cekip 
 * Yeni bir kayit Yapildigi Anda Ona gerekli verilerin bi bilgi formunda gosterilmesini saglar.
 * 
 */
namespace Otel_Otomasyonu
{
    public partial class Bilgilendirme : Form
    {
        public Bilgilendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security = true; AttachDbFilename=|DataDirectory|\OtelOtomasyon.mdf");
        SqlCommand komut = new SqlCommand();
        SqlDataReader rd;
        private void Bilgilendirme_Load(object sender, EventArgs e)
        {
                    timer1.Enabled = true;
                    komut.CommandText = "SELECT * FROM KayitIslemleri";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;
                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        DateTime dt = DateTime.Now;
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriGirisTarihi.Text = dt.ToShortDateString();


                    }
                    baglanti.Close();
                }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMusteriSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriGirisTarihi_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtMusteriSaat.Text = dt.ToString("HH.mm");
        }
        }
    }

