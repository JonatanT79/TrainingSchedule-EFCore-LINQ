using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Jobbinivå
    {
        public int ID { get; set; }
        public int JobbighetsNivå { get; set; }
    }
}
