using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Data.Sql;
/**
 * Resepsiyonist Formunda Musteri kaydi ve Musteri Bilgileri Gosterebilirsiniz.
 * burada Kayit Yapildigi Anda "btnOda" isimlu buttonlar Kirmizi renkli hali alir.
 * ve o butonlara yeni musteri kaydi yapilamaz buradaki ilk amacimiz
 * btnGuncelle butonu form load Kisminda perform clicklernir ve calisir
 * btnguncelle tiklandiginda veri tabanindan OdaNo degerleri cekilir
 * eger veri tabinin daki degerle if else dongusunde deger birbirine denk ise
 * btnoda adli odayi kirmizi renge cevirir
 * bu renge cevirildigi anda OdaNo ve ve Btn Renklerine gore Herbir kirmizi odanin degerleri\
 * veri tabanindan cekilir
 * ve Kayit islemi esnasinda fiyat belirlemek icin kullanicinin girdigi tarihler ve sectigi oda turune gore
 * fiyat belirlenir.
 * kayit yapildigi anda Bilgilendirme Formu calisir ve secilen btn kirmizi renge doner
 * Kayit sirasinda txtKayitAd ve txtKayitSoyad isimli textboxlar sadece string deger almak ile sinirlandirilmistir.
 * 
 */



namespace Otel_Otomasyonu
{
    public partial class Resepsiyonist : Form
    {



        
       
        public Resepsiyonist()
        {
           
            InitializeComponent();
            
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox6.Visible = false;
            


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security = true; AttachDbFilename=|DataDirectory|\OtelOtomasyon.mdf");

        SqlCommand komut = new SqlCommand();
        SqlDataReader rd;
        public int ucret;
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=.\SQLEXPRESS;Integrated Security = true; AttachDbFilename=|DataDirectory|\OtelOtomasyon.mdf";
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            SqlDataReader oku;
            komut.Connection = baglanti;
            komut.CommandText = "SELECT *FROM KayitIslemleri";
            komut.CommandType = CommandType.Text;
            oku = komut.ExecuteReader();

            while (oku.Read())
            {

                textBox1.Text = oku["OdaNo"].ToString();

                if (textBox1.Text == "1")
                {

                    btnOda1.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "2")
                {
                    btnOda2.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "3")
                {
                    btnOda3.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "4")
                {
                    btnOda4.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "5")
                {
                    btnOda5.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "6")
                {
                    btnOda6.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "7")
                {
                    btnOda7.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "8")
                {
                    btnOda8.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "9")
                {
                    btnOda9.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "10")
                {
                    btnOda10.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "11")
                {
                    btnOda11.BackColor = Color.DarkRed;
                }
                else if (textBox1.Text == "12")
                {
                    btnOda12.BackColor = Color.DarkRed;
                }
                else
                {

                }
                textBox1.Clear();
            }

            baglanti.Close();
        }  
             
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox4.Visible == false)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }

        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            if (groupBox3.Visible == false)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
            
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Resepsiyonist_Load(object sender, EventArgs e)
        {
            btnGuncelle.PerformClick();
           
            timer1.Enabled = true;
            
            
        }
        private void Resepsiyonist_Closing(object sender, EventArgs e)
        {
            
        }
        
       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button12_Click(object sender, EventArgs e)
        {
            
            if (btnOda7.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "7";
                txtOdaTip.Text = " 1 ";
            }
            


                if (btnOda7.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {
                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '7'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;
                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda7.BackColor = Color.GreenYellow;
                        }
                    }
                    baglanti.Close();
                }
            
        }

        public void button13_Click(object sender, EventArgs e)
        {
            
            if (btnOda8.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "8";
                txtOdaTip.Text = " 1 ";
            }
            


                if (btnOda8.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '8'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda8.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();
                }
            
        }

        public void button14_Click(object sender, EventArgs e)
        {
            
            if (btnOda9.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {


                txtOdaNo.Text = "9";
                txtOdaTip.Text = " 1 ";
            }
            


                if (btnOda9.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '9'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda9.BackColor = Color.GreenYellow;
                        }
                        

                    }
                    baglanti.Close();

                }
            
          }


        public void button15_Click(object sender, EventArgs e)
        {
            
            if (btnOda10.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "10";
                txtOdaTip.Text = " 1 ";
            }
            


                if (btnOda10.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {

                    

                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '10'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi=rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda10.BackColor = Color.GreenYellow;
                        }

                    }

                    
                    baglanti.Close();
                }
            
        }

        public void button16_Click(object sender, EventArgs e)
        {
            
            if (btnOda11.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "11";
                txtOdaTip.Text = " 1 ";
            }
            



                if (btnOda11.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '11'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda11.BackColor = Color.GreenYellow;
                        }



                    }
                    baglanti.Close();
                }
            
        }

        public void button17_Click(object sender, EventArgs e)
        {
            
            if (btnOda12.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {


                txtOdaNo.Text = "12";
                txtOdaTip.Text = " 1 ";
            }
            


                if (btnOda12.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '12'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda12.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();
                }
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            
            if (btnOda1.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "1";
                txtOdaTip.Text = " 2 ";
            }
            


                if (btnOda1.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '1'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda1.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();

                }
            
            
        }

        public void button5_Click(object sender, EventArgs e)
        {
            
            if (btnOda2.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "2";
                txtOdaTip.Text = " 2 ";
            }
            

                if (btnOda2.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {

                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '2'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda2.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();
                }
            

        }

        public void button6_Click(object sender, EventArgs e)
        {
            
            if (btnOda3.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {


                txtOdaNo.Text = "3";
                txtOdaTip.Text = " 2 ";
            }
            

                if (btnOda3.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '3'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda3.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();
                }
            
        }

        public void button7_Click(object sender, EventArgs e)
        {
            
            if (btnOda4.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "4";
                txtOdaTip.Text = " 2 ";
            }
            


                if (btnOda4.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '4'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text=rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda4.BackColor = Color.GreenYellow;
                        }
                        


                    }
                    baglanti.Close();
                }
            
        }

        public void button8_Click(object sender, EventArgs e)
        {
            
            if (btnOda5.BackColor == Color.DarkRed && groupBox4.Visible == true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {


                txtOdaNo.Text = "5";
                txtOdaTip.Text = " 2 ";
            }
            


                if (btnOda5.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '5'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda5.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();
                }
            

        }

        public void button9_Click(object sender, EventArgs e)
        {
            
            if (btnOda6.BackColor==Color.DarkRed && groupBox4.Visible==true)
            {
                MessageBox.Show("Lutfen Bos Oda Seciniz.");
            }
            else
            {
                txtOdaNo.Text = "6";
                txtOdaTip.Text = " 2 ";
            }
            

                if (btnOda6.BackColor == Color.DarkRed && groupBox4.Visible == false)
                {


                    komut.CommandText = "SELECT * FROM KayitIslemleri WHERE OdaNo = '6'";
                    komut.Connection = baglanti;
                    komut.CommandType = CommandType.Text;

                    baglanti.Open();
                    rd = komut.ExecuteReader();
                    while (rd.Read())
                    {
                        txtMusteriAd.Text = rd["Adi"].ToString();
                        txtMusteriSoyad.Text = rd["Soyadi"].ToString();
                        txtMusteriCinsiyet.Text = rd["Cinsiyet"].ToString();
                        txtMusteriTelefon.Text = rd["Telefon"].ToString();
                        txtMusteriMail.Text = rd["Mail"].ToString();
                        txtMusteriOdaNo.Text = rd["OdaNo"].ToString();
                        txtMusteriOdaTip.Text = rd["Odatip"].ToString();
                        txtMusteriSaat.Text = rd["Saat"].ToString();
                        txtMusteriGirisTarihi.Text = rd["GirisTarihi"].ToString();
                        string cikistarihi = rd["CikisTarihi"].ToString();
                        if (cikistarihi == DateTime.Now.ToString("yyyy-MM-dd"))
                        {
                            btnOda6.BackColor = Color.GreenYellow;
                        }


                    }
                    baglanti.Close();
                }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (groupBox6.Visible== true)
            {
                groupBox6.Visible = false;
            }
            if (groupBox2.Visible==false)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
            }
            if (groupBox6.Visible == false)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
            int ucret1;
            int ucret2;
            

            komut = new SqlCommand("SELECT * FROM Ucretler", baglanti);
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            SqlDataReader rd = komut.ExecuteReader();

            DateTime kucukTarih = Convert.ToDateTime(dtpKucukTarih.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpBuyukTarih.Text);
            TimeSpan Sonuc = buyukTarih - kucukTarih;
            komut = new SqlCommand("SELECT * FROM Ucretler", baglanti);
            
            label33.Text = Sonuc.TotalDays.ToString();
            while (rd.Read())
            {


                if (txtOdaTip.Text == " 1 ")
                {

                    ucret1 = Convert.ToInt32(rd["Ucret1"]);
                    ucret = Convert.ToInt32(label33.Text) * ucret1;



                }
                else
                {
                    ucret2 = Convert.ToInt32(rd["Ucret2"]);
                    ucret = Convert.ToInt32(label33.Text) * ucret2;

                }
            }
            txtUcret.Text = ucret.ToString();
            baglanti.Close();
        }
        
        private void btnKaydet2_Click(object sender, EventArgs e)
        {
           
            
            
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("insert into KayitIslemleri (Adi,Soyadi,Cinsiyet,Telefon,Mail,OdaNo,Odatip,Ucret,GirisTarihi,CikisTarihi,Saat) values ('" +txtKayitAd.Text+"' , '"+txtKayitSoyad.Text+"' , '"+comboBox1.Text+"' , '"+txtKayitTelefon.Text+"' , '"+txtKayitMail.Text+"' , '"+txtOdaNo.Text+"' , '"+txtOdaTip.Text+"' , '"+txtUcret.Text+"' , '"+dtpKucukTarih.Value.ToString("yyyy-MM-dd") +"' , '"+dtpBuyukTarih.Value.ToString("yyyy-MM-dd")+"' , '"+txtKayitSaat.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Bilgilendirme bilgi = new Bilgilendirme();
            bilgi.ShowDialog();
            this.Show();
           
            if (txtOdaNo.Text == "1")
            {
                btnOda1.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "2")
            {
                btnOda2.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "3")
            {
                btnOda3.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "4")
            {
                btnOda4.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "5")
            {
                btnOda5.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "6")
            {
                btnOda6.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "7")
            {
                btnOda7.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "8")
            {
                btnOda8.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "9")
            {
                btnOda9.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "10")
            {
                btnOda10.BackColor = Color.DarkRed;
            }
            else if (txtOdaNo.Text == "11")
            {
                btnOda11.BackColor = Color.DarkRed;
            }
            else 
            {
                btnOda12.BackColor = Color.DarkRed;
            }

        }

        private void dtpKucukTarih_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOdaTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            
        }

       

        private void txtUcret_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Resepsiyonist_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }

        public DateTime Ucret1 { get; set; }

        private void txtKayitSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKayitAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKayitSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriGirisTarihi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriGirisTarihi_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtKayitSaat.Text = dt.ToString("HH.mm");
        }

        private void txtKayitAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtKayitSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
// @"Data Source=DESKTOP-L6841DJ\SQLEXPRESS;Initial Catalog=OtelOtomasyon;Integrated Security=True"
// "Data Source = (localdb)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|veritabanı ismi .mdf; Integrated Security = True"