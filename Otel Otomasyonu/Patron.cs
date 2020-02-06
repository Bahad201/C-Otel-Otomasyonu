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
 * Patron Formunda Amacimiz Yeni Calisan ekleyip, Silmek ve Oda Fiyatlarini Degistirmek.
 * Bir calisan silinmek istendiginde Kullanici adi istenir alinan deger
 * veri tabaninda aratilir eger var silinsinmi diye soru sorar ve silme islemi yapilir
 * ve txtFiyatGuncelle Adli textbox a sadece int degerler girilmesi icin sinirlama getirilmistir
 * txtKayitMedenihal Adli textbox a sadece string degerler girilmesi icin sinirlama getirilmistir
 * txtKayitCinsiyet Adli textbox a sadece string degerler girilmesi icin sinirlama getirilmistir
 * 
 */


namespace Otel_Otomasyonu
{
    
    public partial class Yönetici : Form
    {

        public Resepsiyonist rp= new Resepsiyonist() ;
        public Yönetici()
        {

            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            grpBoxCalısanEkle.Visible = false;
            
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security = true; AttachDbFilename=|DataDirectory|\OtelOtomasyon.mdf");
        SqlCommand komut = new SqlCommand();
        SqlDataReader rd;
        string ucret1kontrol;
        string ucret2kontrol;
        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false){
                groupBox1.Visible = true;
            }
            else{
             groupBox1.Visible = false;
            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {
            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Patron_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
            

           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxCalısanEkle_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grpBoxCalısanEkle.Visible == false)
            {
                grpBoxCalısanEkle.Visible = true;
            }
            else
            {
                grpBoxCalısanEkle.Visible = false;
            }

        }

        private void btnKaydetResepsiyonist_Click(object sender, EventArgs e)
        {
            if (rdbuttonPatron.Checked == true)
            {
                
                baglanti.Open(); 
                SqlCommand komut = new SqlCommand("insert into PatronBilgi (Adi,Soyadi,KullaniciAdi,Sifre,DogumTarihi,Medenihal,Cinsiyet) values ('" +txtKayitAd.Text+"' , '"+txtKayitSoyad.Text+"' , '"+txtKytKullaniciAdi.Text+"' , '"+txtKayitSifre.Text+"' , '"+txtKayitDogumTrh.Text+"' , '"+txtKayitMedeniHal.Text+"' , '"+txtKayitCinsiyet.Text+"')",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Patron Kaydı Yapıldı.");

            
            }
            else if (rdbuttonMudur.Checked == true)
            {
                
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into MudurBilgi (Adi,Soyadi,KullaniciAdi,Sifre,DogumTarihi,Medenihal,Cinsiyet) values ('" + txtKayitAd.Text + "' , '" + txtKayitSoyad.Text + "' , '" + txtKytKullaniciAdi.Text + "' , '" + txtKayitSifre.Text + "' , '" + txtKayitDogumTrh.Text + "' , '" + txtKayitMedeniHal.Text +"' , '"+ txtKayitCinsiyet.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Mudur Kaydı Yapıldı.");
                
            }
            else if (rdbuttonResepsiyonist.Checked== true)
            {
                
                baglanti.Open(); 
                SqlCommand komut = new SqlCommand("insert into ResepsiyonistBilgi (Adi,Soyadi,KullaniciAdi,Sifre,DogumTarihi,Medenihal,Cinsiyet) values ('" +txtKayitAd.Text+"' , '"+txtKayitSoyad.Text+"' , '"+txtKytKullaniciAdi.Text+"' , '"+txtKayitSifre.Text+"' , '"+txtKayitDogumTrh.Text+"' , '"+txtKayitMedeniHal.Text+"' , '"+ txtKayitCinsiyet.Text+"')",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Resepsiyonist Kaydı Yapıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen Çalışan Mevkisi Seçiniz.");
            }
        }
        
        public  void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM Ucretler", baglanti);
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                txtMevcutFiyat.Text = rd["Ucret1"].ToString();
                ucret1kontrol = rd["Ucret1"].ToString();
            }
            baglanti.Close();
            
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rdbtnSilResepsioynist.Checked==true)
            {


                baglanti.Open();
                string secmeSorgusu = "SELECT * from ResepsiyonistBilgi where KullaniciAdi=@KullaniciAdi";
                
                SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
                secmeKomutu.Parameters.AddWithValue("@KullaniciAdi", txtSilKullaniciAdi.Text);
                
                SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
                SqlDataReader dr = secmeKomutu.ExecuteReader();
                
                if (dr.Read()) 
                {
                    string Kullaniciadi = dr["KullaniciAdi"].ToString();
                    dr.Close();
                   
                    DialogResult durum = MessageBox.Show(Kullaniciadi + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    
                    if (DialogResult.Yes == durum)
                    {
                        string silmeSorgusu = "DELETE from ResepsiyonistBilgi where KullaniciAdi=@KullaniciAdi";
                        
                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silKomutu.Parameters.AddWithValue("@KullaniciAdi", txtSilKullaniciAdi.Text);
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi...");
                       
                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");
                baglanti.Close();
            }
            else if (rdbtnSilMudur.Checked==true)
            {


                baglanti.Open();
                string secmeSorgusu = "SELECT * from MudurBilgi where KullaniciAdi=@KullaniciAdi";

                SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
                secmeKomutu.Parameters.AddWithValue("@KullaniciAdi", txtSilKullaniciAdi.Text);

                SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
                SqlDataReader dr = secmeKomutu.ExecuteReader();

                if (dr.Read())
                {
                    string Kullaniciadi = dr["KullaniciAdi"].ToString();
                    dr.Close();

                    DialogResult durum = MessageBox.Show(Kullaniciadi + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {
                        string silmeSorgusu = "DELETE from MudurBilgi where KullaniciAdi=@KullaniciAdi";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silKomutu.Parameters.AddWithValue("@KullaniciAdi", txtSilKullaniciAdi.Text);
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi...");

                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");
                baglanti.Close();
            }
            else if (rdbtnSilPatron.Checked==true)
            {


                baglanti.Open();
                string secmeSorgusu = "SELECT * from PatronBilgi where KullaniciAdi=@KullaniciAdi";

                SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
                secmeKomutu.Parameters.AddWithValue("@KullaniciAdi", txtSilKullaniciAdi.Text);

                SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
                SqlDataReader dr = secmeKomutu.ExecuteReader();

                if (dr.Read())
                {
                    string Kullaniciadi = dr["KullaniciAdi"].ToString();
                    dr.Close();

                    DialogResult durum = MessageBox.Show(Kullaniciadi + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {
                        string silmeSorgusu = "DELETE from PatronBilgi where KullaniciAdi=@KullaniciAdi";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silKomutu.Parameters.AddWithValue("@KullaniciAdi", txtSilKullaniciAdi.Text);
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi...");

                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lutfen bir mevki seciniz.");
            }
        }

        public  void button7_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("SELECT * FROM Ucretler", baglanti);
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            rd = komut.ExecuteReader();
            while (rd.Read())
            {
                txtMevcutFiyat.Text = rd["Ucret2"].ToString();
                string ucret2kontrol = rd["Ucret2"].ToString();
            }
            baglanti.Close();
 

        }

        public void txtFiyatGir_TextChanged(object sender, EventArgs e)
        {

 
                

           }
           
        

        private void btnFiyatListesi_Click(object sender, EventArgs e)
        {
            


            baglanti.Open();
            if (txtMevcutFiyat.Text == null)
            {
                MessageBox.Show("Lütfen bir oda türü seçiniz.");
            }
            else
            {
                


                    if (txtFiyatGuncelle.Text != null)
                    {

                        if (txtMevcutFiyat.Text == ucret1kontrol)
                        {

                            komut = new SqlCommand("update Ucretler set Ucret1='" + txtFiyatGuncelle.Text + "'", baglanti);
                            komut.ExecuteNonQuery();
                            txtFiyatGuncelle.Clear();

                        }


                        else 
                        {

                            komut = new SqlCommand("update Ucretler set Ucret2='" + txtFiyatGuncelle.Text + "'", baglanti);
                            komut.ExecuteNonQuery();
                            txtFiyatGuncelle.Clear();


                        }
                    
                }
            }
            baglanti.Close();
        }
            
        


        private void txtMevcutFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiyatGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Patron_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void txtKayitDogumTrh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKayitDogumTrh_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtKayitMedeniHal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtKayitCinsiyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}


