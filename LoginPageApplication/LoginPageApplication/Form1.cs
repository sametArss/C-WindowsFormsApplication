namespace LoginPageApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        Kullan�c�Kay�tEtme newkllnc = new Kullan�c�Kay�tEtme();
        public string[] kullaniciName = new String[100];
        public string[] password = new String[100];

        private void button1_Click(object sender, EventArgs e)
        {
            // Giri� hesab�
            kullaniciName[0] = "admin";
            password[0] = "admin";

            int kontrol = 0; // bu kontrol kodu dizi i�inde kullanc� ad� ve password  tan�ml� diye kontrol eder. 

            for (int i = 0; i < kullaniciName.Length; i++)
            {
                if (kullaniciName[i] == textBox1.Text && password[i] == textBox2.Text)
                {
                    kontrol++;
                }
            }


            if (kontrol != 0)
            {
                MessageBox.Show("Giri� Ba�ar�l� Bir �ekilde Yap�lm��t�r .", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else
            {
                MessageBox.Show("Kullan�c� Ad� veya �ifre hatal�d�r .", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            newkllnc.Show();
            this.Hide();

        }

    }
}