using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Entity
{
    public class TicketDiscussionEntity
    {
        public int Id{get;set;}
        public int TicketId{get;set;}
        public DateTime DateCreated{get;set;}
        public string Description{get;set;}
        public int CreatedById {get;set;}

        public virtual UserEntity CreatedBy{get;set;}
        public virtual TicketEntity Ticket{get;set;}

    }
}