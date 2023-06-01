using DataLayer.Data;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
        public class TicketRepository : ITicketRepository
        {
            private readonly AmuseDbContext _dbContext;

            public TicketRepository(AmuseDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public List<Ticket> GetAllTickets()
            {
                return _dbContext.Tickets.ToList();
            }

            public Ticket GetTicketById(int ticketId)
            {
                return _dbContext.Tickets.FirstOrDefault(t => t.Id == ticketId);
            }
            public void AddTicket(Ticket ticket)
            {
                _dbContext.Tickets.Add(ticket);
                _dbContext.SaveChanges();
            }

            public void UpdateTicket(Ticket ticket)
            {
                _dbContext.Tickets.Update(ticket);
                _dbContext.SaveChanges();
            }

            public void DeleteTicket(int ticketId)
            {
                var ticket = GetTicketById(ticketId);
                if (ticket != null)
                {
                    _dbContext.Tickets.Remove(ticket);
                    _dbContext.SaveChanges();
                }
            }
        }
    }


