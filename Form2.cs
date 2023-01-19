using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // sql bağlantısını sağlıyoruz
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EE7QA6OF\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //üye eklme işlemini yapması için sql komutunu yazıyoruz.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into uye (tc,adSoyad,yaş,cinsiyet,telefon,adres,email) values(@tc,@adSoyad,@yaş,@cinsiyet,@telefon,@adres,@email)", baglanti);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adSoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@yaş", txtyas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", listcinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı."); 
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item!= txtemail)
                    {
                        item.Text = "";
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
