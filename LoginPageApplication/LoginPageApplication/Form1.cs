namespace LoginPageApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        KullanýcýKayýtEtme newkllnc = new KullanýcýKayýtEtme();
        public string[] kullaniciName = new String[100];
        public string[] password = new String[100];

        private void button1_Click(object sender, EventArgs e)
        {
            // Giriþ hesabý
            kullaniciName[0] = "admin";
            password[0] = "admin";

            int kontrol = 0; // bu kontrol kodu dizi içinde kullancý adý ve password  tanýmlý diye kontrol eder. 

            for (int i = 0; i < kullaniciName.Length; i++)
            {
                if (kullaniciName[i] == textBox1.Text && password[i] == textBox2.Text)
                {
                    kontrol++;
                }
            }


            if (kontrol != 0)
            {
                MessageBox.Show("Giriþ Baþarýlý Bir Þekilde Yapýlmýþtýr .", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre hatalýdýr .", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            newkllnc.Show();
            this.Hide();

        }

    }
}