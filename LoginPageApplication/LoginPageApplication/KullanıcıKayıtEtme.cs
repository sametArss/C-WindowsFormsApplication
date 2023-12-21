using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPageApplication
{
    public partial class KullanıcıKayıtEtme : Form
    {
        public KullanıcıKayıtEtme()
        {
            InitializeComponent();
        }

        public string kullaniciname;
        public string password;
        public int sayac = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox4.Text == textBox5.Text)
                {
                    kullaniciname = textBox3.Text;
                    password = textBox4.Text;
                    sayac++;

                    MessageBox.Show("Kullanıcı Kayıt Edildi ...","Kullanıcı Kayıt",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Kayıt alınan kullanıcı adını ve şifresini diziye atar .

                    Form1 frm1 = new Form1();
                    frm1.kullaniciName[sayac] = kullaniciname;
                    frm1.password[sayac] = password;
                    frm1.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Girdiğiniz paralolar  birbiri ile uymamaktaddır... ", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Lütfen Kullanıcı adı veya şifre alanını boş geçmeyiniz ... ", "Bilgilendirme Kutusu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = false;
            textBox5.UseSystemPasswordChar = false;
        }
    }
}
