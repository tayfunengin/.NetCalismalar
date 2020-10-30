using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MemberArea
{
   public class Personel
    {
        public Personel( string ad, string soyad, string tckn, string adres)
        {
            Ad = ad;
            Soyad = soyad;
            Tckn = tckn;
            ISeGirisTarihi = DateTime.Now;
            Adres = adres;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckn { get; set; }
        public DateTime ISeGirisTarihi { get; set; }
        public string Adres { get; set; }
    }
}
