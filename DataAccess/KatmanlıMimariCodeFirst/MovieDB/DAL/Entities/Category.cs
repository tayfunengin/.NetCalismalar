using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Category : BaseEntity
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
