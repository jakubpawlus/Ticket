using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Repository.Model.Ticket
{
    public class TicketShortModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string AssignTo{ get; set; }
        public StatusEnum Status { get; set; }
        public PiorityEnum Priority { get; set; }
        public bool IsClose { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}