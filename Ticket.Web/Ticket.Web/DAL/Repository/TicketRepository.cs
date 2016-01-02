using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ticket.Web.DAL.Entity;
using Ticket.Web.DAL.Repository.Model.Ticket;
using Ticket.Web.Entity;
using System.Data.Entity;

namespace Ticket.Web.DAL.Repository
{
    public class TicketRepository
    {

        public List<TicketShortModel> GetTickets(UnitOfWork unit)
        {
            var tickets = unit.Context.Tickets.Include(z=>z.AssignTo).Include(z=>z.CreatedBy).Select(z => new TicketShortModel()
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

        public TicketDetailsModel GetTicketDetails(UnitOfWork unit, int id)
        {
            var result = new TicketDetailsModel();
            var ticket = unit.Context.Tickets.Select(z => new TicketShortModel()
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
            result.Ticket = ticket;
            var discusions = unit.Context.TicketDiscussions.Where(z => z.TicketId == id)
                .Select(z => new TicketDiscussionModel()
                {
                    DateCreate = z.DateCreated,
                    Description = z.Description,
                    CreatedBy = z.CreatedBy.UserName,
                }).ToList();
            result.TicketDisciusions = discusions;
            return result;
        }

        public void UpdateTicket(UnitOfWork unit, TicketShortModel ticket)
        {
            var ticketDb = unit.Context.Tickets.FirstOrDefault(z => z.Id == ticket.Id);
            if (ticketDb != null)
            { 
                
            }
        }

        public void Create(UnitOfWork unit, TicketShortModel mode)
        {
            var record = new TicketEntity();
            record.AssignToId = mode.AssignToId;
            record.CreatedById = unit.UserId;
            record.Description = mode.Description;
            record.DateCreated = DateTime.Now;
            record.ModifyDate = DateTime.Now;
            record.Priority = mode.PriorityId;
            record.Status = mode.StatusId;
            record.IsClose = false;
            record.Title = mode.Title;
            unit.Context.Tickets.Add(record);
         
        }

        public void CreateCommnet(UnitOfWork unit, string comment, int ticketId)
        {
            var record = new TicketDiscussionEntity()
            {
                CreatedById = unit.UserId,
                DateCreated = DateTime.Now,
                Description = comment,
                TicketId = ticketId
            };
            unit.Context.TicketDiscussions.Add(record);

        }
    }
}