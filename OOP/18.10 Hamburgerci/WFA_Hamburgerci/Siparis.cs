using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Hamburgerci
{
   public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Ekstra> Ekstralar { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar
        {
            get; set;
        }
        public override string ToString()
        {
            string ekstaMalzemeler = null;
            foreach (Ekstra item in Ekstralar)
            {
                ekstaMalzemeler += item.EkstraAd + " ";
            }

            string format = $"Menu: {SeciliMenu}TL Boyut: {Boyut} ({ekstaMalzemeler}) Adet : {Adet} Toplam Tutar : {ToplamTutar}";
            return format;
        }

       public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;
            switch (Boyut)
            {
                case Boyut.Küçük:
                    break;
                case Boyut.Orta:
                    ToplamTutar += 2;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += 5;
                    break;                
            }
            foreach (Ekstra item in Ekstralar)
            {
                ToplamTutar += item.Fiyat;
            }

           ToplamTutar = ToplamTutar * Adet;
            
        }


    }
}
