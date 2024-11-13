namespace YiginÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


     
        private void button1_Click(object sender, EventArgs e)
        {
            string islem = textBox1.Text;
            Islemler isl = new Islemler();
            isl.Ekle(islem);
            isl.Sil(islem);
          


        }
    }
}
