using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandevuSistemi
{
    public class Brans
    {
        public string Ad { get; set; }
        public List<Doktor> Doktorlar { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
