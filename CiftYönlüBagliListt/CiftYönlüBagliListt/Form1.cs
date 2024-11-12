namespace CiftYönlüBagliListt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Listele lis = new Listele();
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.Bas(yeni.Name, yeni.Id);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.Araya(yeni.Name, yeni.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int id = int.Parse(textBox2.Text);
            Dugum yeni = new Dugum(name, id);
            lis.Son(yeni.Name, yeni.Id);
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
