using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Inheritance
{
   public class Kitap : Urun
    {

        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Cevirmen { get; set; }
        public string YayinEvi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Dil { get; set; }

        public String Tur { get; set; }

    }
}
