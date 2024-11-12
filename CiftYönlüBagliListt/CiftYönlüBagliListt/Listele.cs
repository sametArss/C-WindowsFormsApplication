using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYönlüBagliListt
{
    public class Listele
    {
        public Dugum bas;
        public Listele() {

            bas = null;
        }

        public void Bas(string name , int id)
        {
            Dugum yeni = new Dugum(name, id);
        
            yeni.next = bas;
            bas = yeni;
            bas.onceki = null;

        }

        public void Araya(string name, int id) {
            Dugum yeni = new Dugum(name, id);
            if (bas == null)
            {
               
                yeni.next = bas;
                bas = yeni;
                bas.onceki = null;
            }


            else 
            {
                Dugum gecici = bas;

                while (gecici.next != null && yeni.Id > gecici.next.Id)
                {

                    gecici = gecici.next;
                }

 
                gecici.next.onceki = yeni;
                yeni.next = gecici.next;
                gecici.next = yeni;
                yeni.onceki=gecici;


            }

        }


        public void Son(string name, int id) {

            Dugum yeni = new Dugum(name, id);
            if (bas == null)
            {
                
                yeni.next = bas;
                bas = yeni;
                bas.onceki = null;
            }


            else 
            {
                Dugum son = bas;
                while (son.next != null)
                {
                    son=son.next;   
                }

                son.next = yeni;
                yeni.onceki= son;
                son = yeni;
                son.next = null;

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
                bas.onceki = null;
                return;
            }



            Dugum gecici = bas;
            Dugum onceki = null;


            while (gecici != null && gecici.Id != silinecekDeger)
            {
                onceki = gecici;
                gecici = gecici.next;
            }

            
            if (gecici.next != null)
            {
               
                gecici.next.onceki=gecici.onceki;
            }
            if (gecici.onceki!=null)
            {
                
                gecici.onceki.next=gecici.next;     
               
            }

            else {
                MessageBox.Show("Silinecek değer bulunamadı", "Uyarı Mesajı ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
