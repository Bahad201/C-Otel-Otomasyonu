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
 * Mudur sinifi ResepSiyonist sinifinin ozelliklerini aldigindan Bu form sadece
 * Resepsiyonist Calisanlarini Listelemek yeterli olmustur bunun icin de
 * veri tabanindan veri cekilerek bir data table olusturuldu 
 * bu Goster() adli metodun icinde gerceklesti amacimiz
 * ise kullanicci Listele Adli Butona Tikladiginda Calisanlari Listelemesi.
 * 
 */

namespace Otel_Otomasyonu
{
    public partial class Mudur : Resepsiyonist

    {
        public Mudur()
        {
            InitializeComponent();
            
            groupBox2.Visible = false;

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security = true; AttachDbFilename=|DataDirectory|\OtelOtomasyon.mdf");
        SqlDataAdapter da;
        DataSet ds;





        private void Müdür_Load(object sender, EventArgs e)
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

       

       public void  Goster(){
                 baglanti.Open();
            DataTable dt = baglanti.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["TABLE_NAME"]);
            }
            baglanti.Close();
            comboBox2.SelectedItem = "ResepsiyonistBilgi";

            }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Goster();
        }

        private void Mudur_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablo = comboBox2.Text;
            string sorgu = "SELECT *FROM " + tablo;
            da = new SqlDataAdapter(sorgu, baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, tablo);
            dataGridView1.DataSource = ds.Tables[tablo];
            baglanti.Close();
        }
    }
}
