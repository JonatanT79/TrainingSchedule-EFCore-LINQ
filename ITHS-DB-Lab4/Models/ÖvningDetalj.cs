using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class ÖvningDetalj
    {
        public int ID { get; set; }
        public int JobbighetsNivå { get; set; }
        public TräningsPass TräningsPass { get; set; }
        public Övningar Övningar { get; set; }
    }
}
