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
    public partial class uyelistele : Form
    {
        public uyelistele()
        {
            InitializeComponent();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            //like kullanarak textbox üzerde tc ile arama veya filtreleme sağlıyoruz
            SqlCommand komut = new SqlCommand("select * from uye where tc like '%" + txttc.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();   
             while (read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                txtyas.Text = read["yaş"].ToString();
                listcinsiyet.Text = read["cinsiyet"].ToString();
                txttelefon.Text = read["telefon"].ToString();
                txtadres.Text = read["adres"].ToString();
                txtemail.Text = read["email"].ToString();
                

            }
             baglanti.Close();

        }
        //sql tablo bilgilerini formdaki datagridview e çektik.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text= dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EE7QA6OF\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
       
        DataSet daset= new DataSet();
        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye where tc like '%" + txttcara.Text + "%'", baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //silme işlemini teyit etmek için dialogresult kullandık
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
                daset.Tables.Clear();
                uyeListele();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye ",baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();

        }

        private void uyelistele_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //dışardan alınan bilgilerle mevcut bilgileri güncelledik(update)
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad=@adsoyad,yaş=@yaş,cinsiyet=@cinsiyet, telefon=@telefon,adres=@adres,email=@email where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("tc",txttc.Text);
            komut.Parameters.AddWithValue("adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("yaş", txtyas.Text);
            komut.Parameters.AddWithValue("cinsiyet", listcinsiyet.Text);
            komut.Parameters.AddWithValue("telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("adres", txtadres.Text);
            komut.Parameters.AddWithValue("email", txtemail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables.Clear();
            uyeListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
