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
 * Form1 ekrani Kullanicilarin giris yaptigi ekrandir
 * Veri Tabanin Gerekli veriler Cekilerek txtkullaniciAdi
 * ve txtSifre ile ayni mi dogrulanir ona gore giris yapilmasi saglanir.
 * 
 * Ilk Giris Olarak Admin girisi altta belirtimistir patron formu icin.
 * 
 * ve kullanici sifre girerken sifrenin gizlenmesi veya gozukmesi icin gerekli kodlar asagida belirtilmistir.
 * */

namespace Otel_Otomasyonu
{
    public partial class Otel : Form
    {
        public Otel()
        {
            InitializeComponent();
        }
        SqlDataReader rd;
        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security = true; AttachDbFilename=|DataDirectory|\OtelOtomasyon.mdf");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtnPatron.Checked == true)
            {

                Yönetici gecis = new Yönetici();
                if (txtkullaniciAdi.Text == "admin" && txtSifre.Text == "1234")
                {
                    this.Hide();
                    gecis.ShowDialog();
                    this.Show();
                }
                komut = new SqlCommand("SELECT * FROM PatronBilgi WHERE KullaniciAdi ='" + txtkullaniciAdi.Text.Trim() + "' and  Sifre='" + txtSifre.Text.Trim() + "'", baglanti);
                baglanti.Open();
                rd = komut.ExecuteReader();
                if (rd.Read())
                {
                 
                    
                    this.Hide();
                    gecis.ShowDialog();
                    this.Show();
                    txtkullaniciAdi.Clear();
                    txtSifre.Clear();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya sifre hatali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();

            }

            if (rdbtnMudur.Checked == true)
            {
                
                komut = new SqlCommand("SELECT * FROM MudurBilgi WHERE KullaniciAdi ='" + txtkullaniciAdi.Text.Trim() + "' and  Sifre='" + txtSifre.Text.Trim() + "'", baglanti);
                baglanti.Open();
                rd = komut.ExecuteReader();
                if (rd.Read())
                {
                    Mudur gecis1 = new Mudur();
                    this.Hide();
                    gecis1.ShowDialog();
                    this.Show();
                    txtkullaniciAdi.Clear();
                    txtSifre.Clear();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya sifre hatali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
            if (rdbtnResepsiyonist.Checked == true)
            {
                komut = new SqlCommand("SELECT * FROM ResepsiyonistBilgi WHERE KullaniciAdi ='"+txtkullaniciAdi.Text.Trim()+"' and  Sifre='"+txtSifre.Text.Trim()+"'",baglanti);
                baglanti.Open();
                rd = komut.ExecuteReader();
                if (rd.Read())
                {
                    Resepsiyonist gecis2 = new Resepsiyonist();
                    this.Hide();
                    gecis2.ShowDialog();
                    this.Show();
                    txtkullaniciAdi.Clear();
                    txtSifre.Clear();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya sifre hatali.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void Otel_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
                checkBox1.Text = "Gizle";
            }
            else
            {
                txtSifre.PasswordChar = '*';
                checkBox1.Text = "Göster";
            }
        }

        private void txtkullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
