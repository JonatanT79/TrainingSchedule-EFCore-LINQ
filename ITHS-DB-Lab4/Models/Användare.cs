using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Användare
    {
        public int ID { get; set; }
      //  public string Namn { get; set; }

        [Required]
        [MaxLength(255)]
        public string Förnamn { get; set; }

        [Required]
        [MaxLength(255)]
        public string Efternamn { get; set; }
        public string Email { get; set; }

        public List<TräningsPass> TräningsPass { get; set; }
    }

}



