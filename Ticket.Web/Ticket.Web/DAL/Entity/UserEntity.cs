using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Entity
{
    public class UserEntity
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Surname{get;set;}

        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<TicketEntity> Tickets { get; set; }
        public virtual ICollection<TicketEntity> Tickets1 { get; set; }
        public virtual ICollection<TicketDiscussionEntity> TicketDiscussions { get; set; }
    }
}