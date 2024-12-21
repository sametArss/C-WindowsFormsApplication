using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekKuyruk
{
    public class İslemler
    {
        Kuyruk bas,son;
        IslKuyruk isBas, isSon;
        SiraliKuyruk siraliBas, siralaSon;
        Yigin yiginBas, ySon;
        public İslemler()
        {
            bas = son = null;
            isBas = isSon = null;
            siraliBas = siralaSon = null;
            yiginBas = ySon = null;
        }
        public void ProsesOlustur(string name, int id, int secim)
        {
            Kuyruk yeniKuyruk = new Kuyruk(id, name);

            if (secim == 1)
            {
                if (bas == null)
                {
                    son = yeniKuyruk;
                    bas = son;
                }

                else
                {
                    son.next = yeniKuyruk;
                    son = yeniKuyruk;
                }
            }
            if (secim == 2)
            {
                if (bas == null)
                {
                    son = yeniKuyruk;
                    bas = son;
                }

                else
                {
                    son.next = yeniKuyruk;
                    son = yeniKuyruk;
                }
            }
            if (secim == 3)
            {
                if (bas == null)
                {
                    son = yeniKuyruk;
                    bas = son;
                }

                else
                {
                    son.next = yeniKuyruk;
                    son = yeniKuyruk;
                }
            }



        }
        public void Yazdir(ListBox list, int secim)
        {
            list.Items.Clear();

            if (secim == 1)
            {
                Kuyruk gecici = bas;
                string yaz = "";
                while (gecici != null)
                {
                    if (gecici.PName == "P1-")
                    {
                        yaz = gecici.PName + gecici.Id;
                        list.Items.Add(yaz + "\n");
                       
                    }
                    gecici = gecici.next;
                }
            }

            else if (secim == 2)
            {

                Kuyruk gecici2 = bas;
                string yaz = "";
                while (gecici2 != null)
                {
                    if (gecici2.PName == "P2-")
                    {
                        yaz = gecici2.PName + gecici2.Id;
                        list.Items.Add(yaz + "\n");

                    }
                    gecici2 = gecici2.next;
                }
            }

            else if (secim == 3)
            {
                Kuyruk gecici3 = bas;
                string yaz = "";
                while (gecici3 != null)
                {
                    if (gecici3.PName == "P3-")
                    {
                        yaz = gecici3.PName + gecici3.Id;
                        list.Items.Add(yaz + "\n");

                    }
                    gecici3 = gecici3.next;
                }
            }
        }
        public void IslEkle(int id, string name)
        {
            IslKuyruk yeniKuyruk4 = new IslKuyruk(id, name);

            if (isBas == null)
            {
                isSon = yeniKuyruk4;
                isBas = isSon;
            }

            else
            {
                isSon.next = yeniKuyruk4;
                isSon = yeniKuyruk4;
            }
        }

        public void Cikar()
        {
            isBas = isBas.next;
        }
        public void Islemci(int p1, int p2, int p3)
        {
            bool kontrol = false;
            int sayac = 0;

            for (int i = 0; i < p1; i++)
            {

                if (bas!= null && bas.PName=="P1-")
                {
                    IslEkle(bas.Id, bas.PName);
                    bas = bas.next;
                    sayac++;
                   
                }
            }
            for (int i = 0; i < p2; i++)
            {

                if (bas != null && bas.PName=="P2-")
                {
                    IslEkle(bas.Id, bas.PName);
                    bas = bas.next;
                    sayac++;
                    
                }
            }
            for (int i = 0; i < p3; i++)
            {
                if (bas != null&& bas.PName=="P3-")
                {
                    IslEkle(bas.Id, bas.PName);
                    bas= bas.next;
                    sayac++;
                }
            }


            
            int[] dizi = new int[sayac];
            String[] proses = new String[sayac];

            IslKuyruk gecici = isBas;
            for (int j = 0; j < dizi.Length; j++)
            {
                dizi[j] = gecici.Id;
                proses[j] = gecici.PName;
                gecici = gecici.next;

            }
            int n = dizi.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;                         
                for (int j = i + 1; j < n; j++)
                {
                    if (dizi[j] < dizi[minIndex])
                    {
                        minIndex = j;
                    }
                }  
                // Sıralama 
                int temp = dizi[minIndex];
                string tem = proses[minIndex];
                dizi[minIndex] = dizi[i];
                proses[minIndex] = proses[i];
                dizi[i] = temp;
                proses[i] = tem;
            }

            for (int i = n - 1; i >= 0; i--)
            {
               SiraliKuyruk  yeniKuyruk4 = new SiraliKuyruk(dizi[i], proses[i]);

                if (siraliBas == null)
                {
                    siralaSon = yeniKuyruk4;
                    siraliBas = siralaSon;
                }

                else
                {
                    siralaSon.next = yeniKuyruk4;
                    siralaSon = yeniKuyruk4;
                }
                
                Cikar();
            }

        }

        public void Cikar2()
        {

            if (siraliBas != null)
            {

                YiginEkle(siraliBas.Id, siraliBas.PName);
                siraliBas = siraliBas.next;
            }
        }

        public void YazdirText(System.Windows.Forms.TextBox test)
        {

            test.Clear();
            SiraliKuyruk gecici = siraliBas;
            string yaz = "";
            while (gecici != null)
            {
                yaz += gecici.PName + gecici.Id+"->";
                test.Text = yaz;
                gecici = gecici.next;
            }


        }
        public void YiginEkle(int id, string name)
        {
            Yigin yeniYigin = new Yigin(id, name);
            yeniYigin.next = yiginBas;
            yiginBas = yeniYigin;
        }
        public void YiginBul(ListBox lis1, string name)
        {
            lis1.Items.Clear();
            Yigin gecici = yiginBas;


            string yaz = "";
            while (gecici != null)
            {
                if (gecici.PName == name)
                {
                    //yaz += gecici.PName + gecici.Id + "\n";
                    lis1.Items.Add(gecici.PName + gecici.Id);
                }
                gecici = gecici.next;
            }
        }

    }
}
