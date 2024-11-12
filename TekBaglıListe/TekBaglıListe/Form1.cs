namespace TekBaglıListe

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Liste lis = new Liste();

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.BasaEkle(yeni.Name, yeni.Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.AraSonEkle(yeni.Name, yeni.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.AraSonEkle(yeni.Name, yeni.Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lis.Yazdir(listBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.Sil(yeni.Id); 
        }
    }
}
