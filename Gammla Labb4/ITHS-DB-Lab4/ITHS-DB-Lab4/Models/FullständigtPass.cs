using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class FullständigtPass
    {
        public int ID { get; set; }
        public Användare Användare { get; set; }
        public TräningsPass TräningsPass { get; set; }
        public Övningar Övningar { get; set; }
        public Utrust Utrustning { get; set; }
        public Jobbinivå Jobbighetsnivå { get; set; }
    }
}
