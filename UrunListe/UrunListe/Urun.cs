using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunListe
{
    public class Urun
    {
        public int UrunKodu { get; set; }
        public string UrunName { get; set; }
        public double Fiyat { get; set; }

        public Urun next { get; set; }

        public Urun onceki { get; set; }

         
        public Urun(int id , string name , double fiyat)
        {
            UrunKodu = id;
            UrunName = name;
            Fiyat = fiyat;
            next = null;
            onceki = null;

        }
        public Urun(int id)
        {
            UrunKodu = id;
            next = null;
            onceki = null;

        }



    }

}



