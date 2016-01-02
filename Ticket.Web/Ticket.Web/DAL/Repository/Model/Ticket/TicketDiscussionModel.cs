using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Repository.Model.Ticket
{
    public class TicketDiscussionModel
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public DateTime DateCreate { get; set; }
        public string Description { get; set; }
        public int CreatedById { get; set; }
        public string CreatedBy { get; set; }
    }
}