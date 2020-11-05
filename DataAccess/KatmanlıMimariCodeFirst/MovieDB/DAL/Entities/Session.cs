using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Session : BaseEntity
    {
        public int ID { get; set; }
        public TimeSpan SessionTime { get; set; }

        public List<Theater> Theaters { get; set; }
    }
}
