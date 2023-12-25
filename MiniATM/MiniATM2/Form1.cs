namespace MiniATM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string kullaniciAdi = "admin";
        public string sifre = "12345";
        public string adi = "Samet";
        public string soyadi = "Arslan";
        public int bakiye = 10000;



        private void Form1_Load(object sender, EventArgs e)
        {
            // Güvenlik Kodu ....

            string kod1, kod2, kod3, kod4;
            Random rnd = new Random();

            string[] karakter1 = { "a", "b", "c", "d", "f", "h", "k", "l", "m", "n", "s", "t", "r", "e" };
            string[] karakter2 = { "1", "2", "5", "4", "7", "6", "9", "0", "8", "3" };
            string[] karakter3 = { "A", "B", "C", "D", "L", "K", "Z", "W", "Y" };
            string[] karakter4 = { "!", "-", "+", "/", ";", "=", "*" };

            int s1, s2, s3, s4;

            s1 = rnd.Next(0, karakter1.Length);
            s2 = rnd.Next(0, karakter2.Length);
            s3 = rnd.Next(0, karakter3.Length);
            s4 = rnd.Next(0, karakter4.Length);

            kod1 = karakter1[s1];
            kod2 = karakter2[s2];
            kod3 = karakter3[s3];
            kod4 = karakter4[s4];

            label4.Text = kod1 + kod2 + kod3 + kod4;
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            if (kullaniciAditextBox.Text == kullaniciAdi && SifretextBox.Text == sifre && güvenlikKodutextBox.Text == label4.Text)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Girdiðiniz Bilgiler hatalý veya yanlýþtýr ...", "Bilgilendirme Kutusu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}