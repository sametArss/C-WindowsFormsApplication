using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int secim;
        int tutar =0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Ekle(int sec)
        {
            sec = secim;

            if (sec == 1)
            {
                listBox1.Items.Add("Espresso Small Boy 6$");
                tutar = tutar + 6;
                label13.Text = tutar.ToString();
            }
            else if (sec == 2)
            {
                listBox1.Items.Add("Espresso Large Boy 12$");
                tutar = tutar + 12;
                label13.Text = tutar.ToString();
            }
            else if (sec == 3)
            {
                listBox1.Items.Add("Americano Small Boy 4$");
                tutar = tutar + 4;
                label13.Text = tutar.ToString();
            }
            else if(sec == 4)
            {
                listBox1.Items.Add("Americano Large Boy 10$");
                tutar = tutar + 10;
                label13.Text = tutar.ToString();
            }
            else if((sec == 5))
            {
                listBox1.Items.Add("Türk Kahvesi Small Boy 5$");
                tutar = tutar + 5;
                label13.Text = tutar.ToString();
            }
            else if(sec == 6) {

                listBox1.Items.Add("Türk Kahvesİ Large Boy 10$");
                tutar = tutar + 10;
                label13.Text = tutar.ToString();
            }
            else if ((sec == 7))
            {
                listBox1.Items.Add("Latte Small Boy 5$");
                tutar = tutar + 5;
                label13.Text = tutar.ToString();
            }
            else if((sec == 8))
            {
                listBox1.Items.Add("Latte Large Boy 9$");
                tutar = tutar + 9;
                label13.Text = tutar.ToString();
            }
            else if(sec==9)
            {
                listBox1.Items.Add("Cappuccino Small Boy 4$");
                tutar = tutar + 4;
                label13.Text = tutar.ToString();
            }
            else if (sec == 10)
            {
                listBox1.Items.Add("Cappuccino Large Boy 6$");
                tutar = tutar + 6;
                label13.Text = tutar.ToString();
            }
            else if( sec == 11)
            {
                listBox1.Items.Add("Mocha Small Boy 5$");
                tutar = tutar + 5;
                label13.Text = tutar.ToString();
            }
            else if (sec == 12)
            {
                listBox1.Items.Add("Mocha Large Boy 8$");
                tutar = tutar + 8;
                label13.Text = tutar.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secim = 1;
            Ekle(secim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secim = 2;
            Ekle(secim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secim = 3;
            Ekle(secim);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secim = 4;
            Ekle(secim);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            secim = 5;
            Ekle(secim);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            secim = 6;
            Ekle(secim);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            secim = 7;
            Ekle(secim);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            secim = 8;
            Ekle(secim);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            secim = 9;
            Ekle(secim);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            secim = 10;
            Ekle(secim);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            secim = 11;
            Ekle(secim);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            secim = 12;
            Ekle(secim);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

        
    }


