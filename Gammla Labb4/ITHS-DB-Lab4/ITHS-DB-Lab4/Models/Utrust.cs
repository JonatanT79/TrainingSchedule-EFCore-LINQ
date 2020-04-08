using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Utrust
    {
        public int ID { get; set; }
        [Required]
        public string Utrustning { get; set; }
    }
}
