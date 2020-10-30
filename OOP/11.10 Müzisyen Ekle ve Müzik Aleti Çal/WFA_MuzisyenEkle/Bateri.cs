using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MuzisyenEkle
{
   public class Bateri : MuzikAleti
    {
        public override string Cal()
        {
            return "bateri çalınıyor";
        }

        public override string ToString()
        {
            return "Bateri";
        }
    }
}
