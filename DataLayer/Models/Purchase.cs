using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        [Required]
        [ForeignKey("TicketId")]
        public virtual Ticket Ticket { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public long TotalPrice { get; set; }

        public int Id { get; internal set; }
        public string AName { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
    }
}
