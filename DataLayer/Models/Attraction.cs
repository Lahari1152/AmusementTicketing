using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Attraction
    { 
        public int AttractionId { get; set; }

        [Required]
        public string AName { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public long Price { get; set; }
        public int Id { get; set; }
    }
}
