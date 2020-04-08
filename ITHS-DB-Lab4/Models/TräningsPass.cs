using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class TräningsPass
    {
        public int ID { get; set; }
        [Required]
        public string Passnamn { get; set; }
        public string Beskrivning { get; set; }
        public string Tid { get; set; }
        public string Typ { get; set; }
        public Användare Användare { get; set; }
        public List<ÖvningDetalj> ÖvningDetalj { get; set; }
        public List<TräningsUtrustning> TräningsUtrustning { get; set; }

    }
}
