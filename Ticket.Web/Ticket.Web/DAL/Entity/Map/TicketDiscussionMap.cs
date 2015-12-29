using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Entity.Map
{
    public class TicketDiscussionMap: EntityTypeConfiguration<TicketDiscussionEntity>
    {
        public TicketDiscussionMap()
        {
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("Ticket");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.CreatedById).HasColumnName("CreatedById");
            Property(t => t.DateCreate).HasColumnName("DateCreate");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.TicketId).HasColumnName("TicketId");
         

            HasRequired(z => z.Ticket).WithMany(z => z.TicketDiscussions).HasForeignKey(z => z.TicketId);

            HasRequired(z => z.CreatedBy).WithMany(z=>z.TicketDiscussions).HasForeignKey(z => z.CreatedById);
     
        }
    }
}