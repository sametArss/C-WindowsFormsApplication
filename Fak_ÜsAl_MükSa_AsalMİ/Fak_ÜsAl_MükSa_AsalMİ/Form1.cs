using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fak_ÜsAl_MükSa_AsalMİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
            
        Form2 fr2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
           fr2.sec = 0;
           fr2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr2.sec = 1;
            fr2.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        { 
           fr2.sec =2;
           fr2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            fr2.sec =3;
            fr2.Show();
            this.Hide();
            
        }
    }
}
