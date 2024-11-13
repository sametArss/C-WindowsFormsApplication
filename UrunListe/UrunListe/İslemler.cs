using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UrunListe
{
    public class İslemler
    {
        Urun bas;

        public İslemler()
        {
            bas = null;
        }


        public void Ekle(int id, string name, double fiyat) 
        {
            Urun newUrun = new Urun(id, name, fiyat);
            bool kontrol = false;

            if (bas == null)
            {

                newUrun.next = bas;
                bas = newUrun;
                newUrun.onceki = null;

            }
            else
            {
                Urun gecici = bas;
                while (gecici != null)
                {

                    if (gecici.UrunKodu == newUrun.UrunKodu)
                    {
                        MessageBox.Show("Aynı değer kodu giremezsiniz ...");
                        kontrol = true;
                        break;
                    }
                    gecici = gecici.next;

                }

                if (kontrol == false)
                {

                    newUrun.next = bas;
                    bas = newUrun;
                    newUrun.onceki = null;
                }

            }

        }



        public Urun Bul(int id)    
        {
            Urun newUrun = new Urun(id);
            Urun aranan = bas;


            if (aranan == null)
            {
                MessageBox.Show("Listeye önce ürün giriniz ");
            }

            bool kontrol = false;

            while (aranan != null)
            {

                if (aranan.UrunKodu == newUrun.UrunKodu)
                {
                    kontrol = true;

                    break;
                }

                aranan = aranan.next;

            }


            if (kontrol == false)
            {

                MessageBox.Show("Aradığınız Değer yoktur ");
                newUrun.UrunKodu = 000;
                newUrun.UrunName = "xxxx";
                newUrun.Fiyat = 0;
                return newUrun;

            }

            return aranan;

        }

        public void Sil(int id )
        {

            Urun newUrun = new Urun(id );


            if (bas == null)
            {
                MessageBox.Show("Silinecek ürün bulunamadı");
                return;
            }

            else if (bas.UrunKodu == newUrun.UrunKodu)
            {
                bas = bas.next;
                return;
            }


            Urun silinecek = bas;
            Urun onceki = null;

            bool kontrol = false;

            while (silinecek != null && silinecek.UrunKodu != newUrun.UrunKodu)
            {

                onceki = silinecek;
                silinecek = silinecek.next;

                if (silinecek == null)
                {
                    kontrol = true;
                    break;
                }

            }

            if (kontrol == true)
            {
                MessageBox.Show("Sileceğiniz deger bulunamadı  ");
                return;
            }


            if (silinecek.UrunKodu == newUrun.UrunKodu && kontrol == false)
            {
                    onceki.next = silinecek.next;

            }
        }


        public void Güncelle(int id, string name, double fiyat) 
        {
            Urun newUrun = new Urun(id, name, fiyat);

            Urun ara = bas;

            while (ara.UrunKodu != newUrun.UrunKodu && ara != null)
            {
                ara = ara.next;
            }

            ara.UrunKodu = newUrun.UrunKodu;
            ara.UrunName = newUrun.UrunName;
            ara.Fiyat = newUrun.Fiyat;

        }

        public void Yazdir(DataTable data)
        {
            data.Rows.Clear();
            Urun yazdir = bas;
            while (yazdir != null)
            {
                data.Rows.Add(yazdir.UrunKodu, yazdir.UrunName, yazdir.Fiyat);
                yazdir = yazdir.next;
            }
        }
    }
}
