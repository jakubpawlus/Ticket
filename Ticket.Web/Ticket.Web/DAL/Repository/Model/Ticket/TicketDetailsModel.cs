using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Repository.Model.Ticket
{
    public class TicketDetailsModel
    {
        public TicketDetailsModel()
        {
            Ticket = new TicketShortModel();
            TicketDisciusions = new List<TicketDiscussionModel>();
        }
        public TicketShortModel Ticket { get; set; }
        public List<TicketDiscussionModel> TicketDisciusions { get; set; }
    }
}