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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int bakiye = 1000;
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            cekilecekYatirilacakTextBox.Visible = false;
            yatirButton.Visible = false;
            ParaCekmeButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bakiyeGör = bakiye;
            MessageBox.Show("Bakiyeniz : " + bakiyeGör + " TL", "Bakiye Görüntüleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kredi = bakiye * 120 / 100;
            MessageBox.Show("Alabileceğiniz max tutar kredi : " + kredi + " TL", "Kredi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            cekilecekYatirilacakTextBox.Visible = true;
            ParaCekmeButton.Visible = true;
            yatirButton.Visible = false;

            label2.Text = "Çekilecek Tutarı Giriniz :";
        }

        private void ParaCekmeButton_Click(object sender, EventArgs e)
        {
            int cekilecek = Convert.ToInt32(cekilecekYatirilacakTextBox.Text);
            if (cekilecek < bakiye)
            {
                MessageBox.Show("Paranız Başarılı Bir Şekilde Çekilmiştir ....");
                bakiye = bakiye - cekilecek;
            }
            else
            {
                MessageBox.Show("Bakiyenizden fazla para çekemezsiniz ... ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            cekilecekYatirilacakTextBox.Visible = true;
            ParaCekmeButton.Visible = false;
            yatirButton.Visible = true;

            label2.Text = "Yatırılacak  Tutarı Giriniz :";
        }

        private void yatirButton_Click(object sender, EventArgs e)
        {
            int yatirilacak = Convert.ToInt32(cekilecekYatirilacakTextBox.Text);
            MessageBox.Show("Paranız hesabınıza yatırılmıştır ...");
            bakiye = bakiye + yatirilacak;
        }
    }
}
