﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Theater : BaseEntity
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int SessionId { get; set; }
        public int SaloonId { get; set; }
        public int WeekId { get; set; }

        public Movie Movie { get; set; }
        public Session Session { get; set; }
        public Saloon Saloon { get; set; }
        public Week Week { get; set; }
    }
}
