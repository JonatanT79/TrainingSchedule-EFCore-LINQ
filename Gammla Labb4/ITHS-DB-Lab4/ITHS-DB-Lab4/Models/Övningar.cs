using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Övningar
    {
        public int ID { get; set; }
        [Required]
        public string Övningensnamn { get; set; }
        public int Repetitioner { get; set; }
        public int Sets { get; set; }
    }
}
