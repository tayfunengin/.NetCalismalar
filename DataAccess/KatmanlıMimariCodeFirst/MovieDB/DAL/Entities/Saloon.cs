using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Saloon : BaseEntity
    {
        public int ID { get; set; }
        public string SaloonName { get; set; }
        public short Capacity { get; set; }

        public List<Theater> Theaters { get; set; }
    }
}
