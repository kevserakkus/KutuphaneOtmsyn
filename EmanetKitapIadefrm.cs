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
    public partial class EmanetKitapIadefrm : Form
    {
        public EmanetKitapIadefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-EE7QA6OF\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
        DataSet daset = new DataSet();

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapIadefrm_Load(object sender, EventArgs e)
        {
            EmanetListele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttcileara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where tc like '%"+txttcileara.Text+"%'",baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txttcileara.Text == "")
            {
                daset.Tables.Clear();
                EmanetListele();
            }
        }

        private void txtbarkodileara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where barkodno like '%" + txtbarkodileara.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtbarkodileara.Text == "")
            {
                daset.Tables.Clear();
                EmanetListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete  from EmanetKitaplar where tc=@tc and barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi+ '" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() +"' where barkodno=@barkodno",baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kitaplar iade edildi.");

            daset.Tables.Clear();
            EmanetListele();

        }
    }
}
