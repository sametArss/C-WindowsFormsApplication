using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekBaglıListe
{
    public class Liste
    {
        public Dugum bas;

        public Liste()
        {
            bas = null;
        }

        public void BasaEkle(string name, int id)
        {
            Dugum yeni = new Dugum(name, id);

            yeni.next = bas;
            bas = yeni;

        }

        public void AraSonEkle(string name, int id)
        {

            Dugum yeni = new Dugum(name, id);

            if (bas == null)
            {

                yeni.next = bas;
                bas = yeni;
            }

            else
            {
                Dugum gecici = bas;

                while (gecici.next != null && yeni.Id > gecici.next.Id)
                {
                    gecici = gecici.next;
                }
                yeni.next = gecici.next;
                gecici.next = yeni;
            }
        }

        public void Yazdir(ListBox listBox)
        {
            listBox.Items.Clear();
            Dugum yazdir = bas;
            String yaz = "";
            while (yazdir != null)
            {
                yaz += "No: " + yazdir.Id + "  Ad:" + yazdir.Name + "\t";

                yazdir = yazdir.next;
            }
            listBox.Items.Add(yaz);
        }




        public void Sil(int silinecekDeger)
        {
            
            if (bas == null)
            {
                MessageBox.Show("Silinecekk değer bulunmadı liste boş", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (bas.Id == silinecekDeger)
            {
                bas = bas.next;
                return;
            }



            Dugum gecici = bas;
            Dugum onceki = null;


            while (gecici != null && gecici.Id != silinecekDeger)
            {
                onceki = gecici;
                gecici = gecici.next;
            }

            
            if (gecici != null)
            {
                onceki.next = gecici.next;
            }
            else
            {
                MessageBox.Show("Silinecek değer bulunamadı", "Uyarı Mesajı ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








    







    }


}
