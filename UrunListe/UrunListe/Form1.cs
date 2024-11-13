using System.Data;
using System.Runtime.InteropServices;

namespace UrunListe
{
    public partial class Form1 : Form
    {
        Ýslemler islem = new Ýslemler();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            if(textBox1.Text =="" || textBox2.Text == ""|| textBox3.Text == "")
            {
                MessageBox.Show("Lütfen txtboxlarý doldurunuz ");
                return;
            }
                       
            int kod = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            double fiyat = double.Parse(textBox3.Text);

            Urun yeniUrun = new Urun(kod, name, fiyat);
            islem.Ekle(yeniUrun.UrunKodu, yeniUrun.UrunName, yeniUrun.Fiyat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            islem.Yazdir(table);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(textBox6.Text);
            Urun newUrun = islem.Bul(kod);

            textBox5.Text = newUrun.UrunName;
            textBox4.Text = newUrun.Fiyat + "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(textBox6.Text);
           
            Urun newUrun = new Urun(kod);
            islem.Sil(newUrun.UrunKodu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(textBox9.Text);
            Urun newUrun = islem.Bul(kod);

            textBox8.Text = newUrun.UrunName;
            textBox7.Text = newUrun.Fiyat + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(textBox9.Text);
            string name = textBox8.Text;
            double fiyat = double.Parse(textBox7.Text);

            Urun yeniUrun = new Urun(kod, name, fiyat);
            islem.Güncelle(yeniUrun.UrunKodu, yeniUrun.UrunName, yeniUrun.Fiyat);
           table.Rows.Clear();

        }

        DataTable table = new DataTable(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader oku;
            oku = File.OpenText("C:\\Users\\Samet\\source\\repos\\UrunListe\\test.txt");

            string metin;

            while ((metin = oku.ReadLine()) != null)
            {
                string[] ayýr = metin.Split('#');


                foreach (var x in ayýr)
                {
                    string[] ayýr2 = x.Split(':', '-');

                    for (int y = 0; y < 1; y++)
                    {


                        int id = int.Parse(ayýr2[1]);
                        string name = ayýr2[3];
                        double fiyat = double.Parse(ayýr2[5]);
                        Urun newUrun = new Urun(id, name, fiyat);
                        islem.Ekle(newUrun.UrunKodu, newUrun.UrunName, newUrun.Fiyat);
                    }


                }
            }


            table.Columns.Add("UrunKodu", typeof(int));
            table.Columns.Add("UrunName", typeof(string));
            table.Columns.Add("Fiyat", typeof(double));

            dataGridView1.DataSource = table;





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
