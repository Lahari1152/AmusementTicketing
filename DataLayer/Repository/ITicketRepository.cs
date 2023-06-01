using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;


namespace DataLayer.Repository
{
    public interface ITicketRepository
    {
        List<Ticket> GetAllTickets();
        Ticket GetTicketById(int ticketId);
  
        void AddTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(int ticketId);
    }
}

