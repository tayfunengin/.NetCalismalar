using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Hamburgerci
{
   public class Menu
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        
        public override string ToString()
        {
            return Ad + " " + Fiyat;
        }

    }

    
}
