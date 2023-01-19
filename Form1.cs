namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmanetKitapVerfrm emanetkitapver = new EmanetKitapVerfrm();
            emanetkitapver.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        //Metotlarýn altýnda gerekli sayfalar çaðýrýyoruz.

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 uyeekle= new Form2();
            uyeekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyelistele uyeListele= new uyelistele();
            uyeListele.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapEkle = new KitapEklefrm();
            kitapEkle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitapListele = new KitapListelefrm();
            kitapListele.ShowDialog();
        }

        private void btnEmanetKitapListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListelefrm listele = new EmanetKitapListelefrm();
            listele.ShowDialog();
        }

        private void btnEmanetKitapAl_Click(object sender, EventArgs e)
        {
            EmanetKitapIadefrm emanetiade = new EmanetKitapIadefrm();
            emanetiade.ShowDialog();
        }
    }
}