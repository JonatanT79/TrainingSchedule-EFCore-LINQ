using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class TräningsUtrustning
    {
        public int ID { get; set; }
        public TräningsPass TräningsPass { get; set; }
        public Utrust Utrustning { get; set; }
    }
}
