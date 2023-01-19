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
    public partial class KitapListelefrm : Form
    {
        public KitapListelefrm()
        {
            InitializeComponent();
        }
        //sql baülantısı
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EE7QA6OF\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");

        DataSet daset = new DataSet();
        private void kitapListele()
        {
            //tüm kitapları listeliyoruz
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap ", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();

        }
        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //kitap silme işlemini teyit etmek için dialogresult kullanıyoruz. 
            DialogResult dialog;
            dialog= MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
                //bilgiler girilip işlem tamamlandıktan sonra textboxları temizliyoruz
                daset.Tables.Clear();
                kitapListele();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        //kitap barkodnoya göre aranan bilgileri bu metot ile update kullanarak güncelliyoruz
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kitap set barkodno=@barkodno,kitapAdi=@kitapAdi,yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi, turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno, aciklama=@aciklama where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("kitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("yazari", txtKitapYazari.Text);
            komut.Parameters.AddWithValue("yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("turu", comboTuru.Text);
            komut.Parameters.AddWithValue("stoksayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("aciklama", txtAciklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.");
            daset.Tables.Clear();
            kitapListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
             baglanti.Open();

          //kitap kayıtlarını barkodnoya göre arayıp listeliyoruz.
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodno like '%" + txtBarkodNo.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtBarkodNo.Text = read["barkodno"].ToString();
                txtKitapAdi.Text = read["kitapAdi"].ToString();
                txtKitapYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();


            }
            baglanti.Close();

        }


        private void txtbarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where barkodno like '%" + txtbarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
