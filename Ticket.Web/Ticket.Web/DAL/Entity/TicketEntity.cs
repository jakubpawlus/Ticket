using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Entity
{
    public class TicketEntity
    {

        public TicketEntity()
        {
            this.TicketDiscussions = new List<TicketDiscussionEntity>();
        }

        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatedById { get; set; }
        public int AssignToId { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public bool IsClose { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public virtual UserEntity AssignTo { get; set; }
        public virtual UserEntity CreatedBy { get; set; }
        public virtual ICollection<TicketDiscussionEntity> TicketDiscussions { get; set; }

    }
}