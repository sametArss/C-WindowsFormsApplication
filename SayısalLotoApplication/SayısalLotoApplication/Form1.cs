namespace SayısalLotoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            Form2 frm2 = new Form2();


            if (textBox1.Text != "" && textBox3.Text != "")
            {
                int yas = int.Parse(textBox2.Text);
                if (yas >= 18)
                {

                    frm2.bakiye = Convert.ToInt32(textBox3.Text);
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("18 yaşından küçükler giremez !!", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Lütfen Yukardaki Alanları Eksiksiz Bir Şekilde Doldurunuz ...", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}