using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLotoApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int bakiye;
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int s1, s2, s3, s4, s5;



            if (bakiye < 50)
            {
                MessageBox.Show("Lütfen Para Miktarını Yükseltiniz ...", "Bilgilendirme Kutusu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


            s1 = rnd.Next(0, 10);
            s2 = rnd.Next(0, 10);
            s3 = rnd.Next(0, 10);
            s4 = rnd.Next(0, 10);
            s5 = rnd.Next(0, 10);

            label3.Text = s1.ToString();
            label4.Text = s2.ToString();
            label5.Text = s3.ToString();
            label6.Text = s4.ToString();
            label7.Text = s5.ToString();


            // sayi1
          
         if (textBox1.Text == label3.Text)
            {
                textBox1.BackColor = Color.Green;
                sayac++;
            }
            else { textBox1.BackColor = Color.Red; }

            // sayi2
            if (textBox2.Text == label4.Text)
            {
                textBox2.BackColor = Color.Green;
                sayac++;
            }
            else { textBox2.BackColor = Color.Red; }

            // sayi3
            if (textBox3.Text == label5.Text)
            {
                textBox3.BackColor = Color.Green;
                sayac++;
            }
            else { textBox3.BackColor = Color.Red; }

            // sayi4
            if (textBox4.Text == label6.Text)
            {
                textBox4.BackColor = Color.Green;
                sayac++;
            }
            else { textBox4.BackColor = Color.Red; }

            // sayi5
            if (textBox5.Text == label7.Text)
            {
                textBox5.BackColor = Color.Green;
                sayac++;
            }
            else { textBox5.BackColor = Color.Red; }

            bakiye = (bakiye - 50) + (sayac * 20);
            
            label8.Text = bakiye.ToString() + " TL";
            sayac = 0;


        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarılı Bir Şekilde Çıkış Yapılmıştır.", "Çıkış Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
