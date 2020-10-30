using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MuzisyenEkle
{
   public class Gitar : MuzikAleti
    {
        public override string Cal()
        {
            return "gitar çalınıyor";
        }

        public override string ToString()
        {
            return "Gitar";
        }
    }
}
