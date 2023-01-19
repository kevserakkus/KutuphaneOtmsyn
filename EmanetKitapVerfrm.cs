using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class EmanetKitapVerfrm : Form
    {
        public EmanetKitapVerfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EE7QA6OF\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        DataSet daset = new DataSet();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select kitapsayisi from sepet", baglanti);
            baglanti.Close();

        }

        private void EmanetKitapVerfrm_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }


        //bilgileri girilen kitapları emanet verilmke üzere sepete ekler
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno, kitapadi, yazari,yayinevi," +
                "sayfasayisi, kitapsayisi,teslimtarihi,iadetarihi) values (@barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("kitapadi", txtkitapad.Text);
            komut.Parameters.AddWithValue("yazari", txtyazari.Text);
            komut.Parameters.AddWithValue("yayinevi", txtyayinevi.Text);
            komut.Parameters.AddWithValue("sayfasayisi", txtsayfasayisi.Text);
            komut.Parameters.AddWithValue("kitapsayisi", int.Parse(txtkitapsayisi.Text));
            komut.Parameters.AddWithValue("teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables.Clear();
            sepetlistele();
            lblraftakikitap.Text = "";
            kitapsayisi();
            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtkitapsayisi)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        //uyebilgileri grupbox ında tc ye göre arama yapar
        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like '" + txttc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                txtyas.Text = read["yaş"].ToString();
                txttelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select kitapsayisi from EmanetKitaplar", baglanti);
            baglanti.Close();

            if (txttc.Text == "")
            {
                foreach (Control item in grpUyeBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblkayitlikitap.Text = "";
                    }
                }
            }
        }
        //kitapbilgileri grupbox ında barkodno ya göre arama yapar
        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodno like '" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapad.Text = read["kitapAdi"].ToString();
                txtyazari.Text = read["yazari"].ToString();
                txtyayinevi.Text = read["yayinevi"].ToString();
                txtsayfasayisi.Text = read["sayfasayisi"].ToString();
            }
            baglanti.Close();
            if (txtbarkodno.Text == "")
            {

                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtkitapsayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno= '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşti", "silme işlemi");
            daset.Tables.Clear();
            sepetlistele();
            lblraftakikitap.Text = "";
            kitapsayisi();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            //üye bilgilerinin tam girilip girilmediğini kontrol eder.
            
                if (txttc.Text != "" && txtadsoyad.Text != "" && txtyas.Text != "" && txttelefon.Text != "")
                {
                //yukardaki şart sağlanıyorsa  stoktan düşer
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(tc, adsoyad, yas, telefon,barkodno, kitapadi, yazari,yayinevi,sayfasayisi,kitapsayisi, teslimtarihi,iadetarihi) " +
                            "values (@tc, @adsoyad, @yas, @telefon, @barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi)", baglanti);
                        komut.Parameters.AddWithValue("@tc", txttc.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                        komut.Parameters.AddWithValue("@yas", txtyas.Text);
                        komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                        komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                        komut.Parameters.AddWithValue("yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                        komut.Parameters.AddWithValue("yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                        komut.Parameters.AddWithValue("sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                        komut.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                        komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                        komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                        komut.ExecuteNonQuery();
                        SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi -1" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkodno'" + int.Parse(dataGridView1.Rows[i].Cells["barkodno"].Value.ToString()), baglanti);
                        baglanti.Close();


                    }
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap(lar) emanet edildi");
                    daset.Tables.Clear();
                    sepetlistele();
                    txttc.Text = "";
                    lblkayitlikitap.Text = "";
                    lblraftakikitap.Text = "";
                    kitapsayisi();
                }
                else
                {
                    MessageBox.Show("Öncelikle üye bilgilerini giriniz.", "uyarı");
                }
            
            
        }
    }
            
            }
        
    
