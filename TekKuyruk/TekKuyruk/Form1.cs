using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TekKuyruk
{
    public partial class Form1 : Form
    {
        İslemler isl = new İslemler();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            isl.ProsesOlustur( "P1-", rnd.Next(0, 6), 1);
            isl.Yazdir(listBox1, 1);
            timer2.Interval = 1000 / trackBar2.Value;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            isl.ProsesOlustur("P2-", rnd.Next(0, 6), 2);
            isl.Yazdir(listBox2, 2);
            timer3.Interval = 1000 / trackBar3.Value;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            isl.ProsesOlustur("P3-", rnd.Next(0, 6), 3);
            isl.Yazdir(listBox3,3);
            timer4.Interval = 1000 / trackBar4.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / trackBar1.Value;
            for (int i = 0; i < 1; i++)
           {
                isl.Islemci(trackBar2.Value,trackBar3.Value, trackBar4.Value);
                isl.Cikar2();

            }
            isl.YazdirText(textBox1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isl.YiginBul(listBox4, "P1-");
            }
            if (checkBox2.Checked)
            {
                isl.YiginBul(listBox4, "P2-");
            }

            if (checkBox3.Checked)
            {
                isl.YiginBul(listBox4, "P1-");
            }
        }
    }
}
