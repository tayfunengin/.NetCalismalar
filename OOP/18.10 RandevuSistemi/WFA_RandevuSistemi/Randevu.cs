using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandevuSistemi
{
   public class Randevu
    {
        public string TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Saat { get; set; }
        public string RandevuTarih { get; set; }

        public Brans Brans { get; set; }
        public Doktor Doktor { get; set; }
    }
}
