using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Movie : BaseEntity
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short Rank { get; set; }

        public List<Category> Categories { get; set; }
        public List<Theater> Theaters { get; set; }
    }
}
