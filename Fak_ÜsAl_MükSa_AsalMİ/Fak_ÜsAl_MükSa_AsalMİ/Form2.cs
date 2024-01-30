using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fak_ÜsAl_MükSa_AsalMİ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int sec; // Hangi kodun çalışacağını belirler .
        
        private void Form2_Load(object sender, EventArgs e)
        {  
            if (sec==0)
            {
                label1.Text = "**** Fakröriyel Hesaplama ****";
                label2.Text = "Faktöriyel alınacak sayı =";
                label4.Text = "1 den girilen sayıya kadar olan çarpam işleminin sonucu ...";
                label3.Visible= false;
                ussayiTexBox.Visible = false;
            }
            else if (sec==1)
            {
                label1.Text = "**** Uss Almaa ****";
                label4.Text = "Tabandaki sayı girilen üss sayı defa kendisi ile çarpılır...";
                label2.Text = "Taban sayısı  = ";
                label3.Text = "Üss sayısı = ";

            }
            else if (sec==2)
            {
                label1.Text = "**** Asal Sayı Mı ? ****";
                label4.Text = "1 veya kendisi dışında başka sayıya bölünemeyen sayıdır...";
                label2.Text = "Asal Sayı Mı =";
                label3.Visible = false;
                ussayiTexBox.Visible = false;
            }
            else if (sec==3)
            {
                label1.Text = "**** Mükemmel Sayı Mı ? ****";
                label4.Text = "Girilen sayının tam bölenleri toplamı o sayının 2 katı ise o sayı Mükemmel sayıdır...";
                label2.Text = "Mükemmel sayı mı = ";
                label3.Visible = false;
                ussayiTexBox.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                FaktöriyelHesapla(sayiTexBox.Text);


            }
            else if (sec == 1)
            {
                UsAlma(sayiTexBox.Text, ussayiTexBox.Text);

            }
            else if (sec == 2)
            {
                AsalMi(sayiTexBox.Text);

            }
            else if (sec == 3)
            {
                MukemmelSayi(sayiTexBox.Text);

            }
        }

        // Seçilen uygulamaya yönelik hesap metotları 
        static void FaktöriyelHesapla(string sayi1 )
        {
            int sayi = Convert.ToInt32(sayi1);

            int sonuc = 1;
            for(int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }

            string cevap = "Sonuç = " + sonuc.ToString();
            MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
        static void UsAlma(string taban,string us)
        {
            int tab = Convert.ToInt32(taban);
            int  uss = Convert.ToInt32(us);
            double sonuc = Math.Pow(tab, uss);

            string cevap ="Sonuc = "+sonuc.ToString();
            MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        static void AsalMi(string sayi)
        {
            int asalmi = Convert.ToInt32(sayi);

            int toplam = 0;
            for(int i = 2;i < asalmi; i++)
            {
                if (asalmi % i == 0)
                {
                    toplam ++;
                }
            }
            string cevap = " ";

            if(asalmi==2) { 
                cevap = "Sayınız asal sayıdır";
                MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if ( toplam == 0)
            {
                cevap = "Sayınız asal sayıdır";
                MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                cevap = "Sayınız asal sayı değildir";
                MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        static void MukemmelSayi(string sayi1)
        {
            int sayi = Convert.ToInt32(sayi1);

            int toplam = 0;
            for (int i =1;i<=sayi;i++)
            {
                if(sayi%i == 0)
                {
                    toplam = toplam + i;
                }
            }

            string cevap = " "; 
            if(toplam == sayi * 2)
            {
                cevap = " Sayınız Mükemmel sayıdır  ";
                MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                cevap = "Sayı Mükemmel Sayı değildir ";
                MessageBox.Show(cevap, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        // Geri tuşunun kodları Form1 e geri atar 
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

       
    }
}
