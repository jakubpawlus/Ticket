using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ticket.Web.DAL.Repository.Model.Ticket;
using Ticket.Web.Entity;

namespace Ticket.Web.DAL.Repository
{
    public class TicketRepository
    {

        public List<TicketShortModel> GetTickets(TicketContext context)
        {
            var tickets = context.Tickets.Select(z => new TicketShortModel()
            {
                Id = z.Id,
                AssignTo = z.AssignTo.UserName,
                DateCreated = z.DateCreated,
                Description = z.Description,
                IsClose = z.IsClose,
                ModifyDate = z.ModifyDate,
                Priority = (PiorityEnum) z.Priority,
                Title = z.Title,
                CreatedBy = z.CreatedBy.UserName,
                Status = (StatusEnum) z.Status
            }).ToList();
            return tickets;
        }

        public TicketShortModel GetTicket(TicketContext context, int id)
        {
            var ticket = context.Tickets.Select(z => new TicketShortModel()
            {
                Id = z.Id,
                AssignTo = z.AssignTo.UserName,
                DateCreated = z.DateCreated,
                Description = z.Description,
                IsClose = z.IsClose,
                ModifyDate = z.ModifyDate,
                Priority = (PiorityEnum)z.Priority,
                Title = z.Title,
                CreatedBy = z.CreatedBy.UserName,
                Status = (StatusEnum)z.Status
            }).FirstOrDefault(z => z.Id == id);
            return ticket;
        }

        public void UpdateTicket(TicketContext context, TicketShortModel ticket)
        {
            var ticketDb = context.Tickets.FirstOrDefault(z => z.Id == ticket.Id);
            if (ticketDb != null)
            { 
                
            }
        }
    }
}