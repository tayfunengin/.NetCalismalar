using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MuzisyenEkle
{
   public abstract class MuzikAleti
    {
        public string Tur { get; set; }
        public string Fiyat { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public abstract string Cal();
    }
}
