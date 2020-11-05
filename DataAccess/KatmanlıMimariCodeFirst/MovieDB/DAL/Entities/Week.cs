using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Week : BaseEntity
    {
        public int ID { get; set; }
        public string WeekName { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }

        public List<Theater> Theaters { get; set; }
    }
}
