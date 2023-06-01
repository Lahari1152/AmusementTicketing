using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public int TicketId { get; set; }

        [Required]
        public decimal Price { get; set; }
        public int Id { get; internal set; }
        
    }
}
