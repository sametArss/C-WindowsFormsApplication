using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniATM2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = frm1.adi;
            textBox2.Text = frm1.soyadi;
            textBox3.Text = frm1.kullaniciAdi;
            textBox4.Text = frm1.sifre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.adi = textBox1.Text;
            frm1.soyadi = textBox2.Text;
            frm1.kullaniciAdi = textBox3.Text;
            frm1.sifre = textBox4.Text;

            MessageBox.Show("Bilgileriniz Başarılı Bir Şekilde Güncellenmiştir ....");
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }
    }
}
