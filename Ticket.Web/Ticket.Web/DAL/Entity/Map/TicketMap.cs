using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Entity.Map
{
    public class TicketMap : EntityTypeConfiguration<TicketEntity>
    {
        public TicketMap()
        {
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("Ticket");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.AssignToId).HasColumnName("AssignToId");
            Property(t => t.CreatedById).HasColumnName("CreatedById");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.IsClose).HasColumnName("IsClose");
            Property(t => t.ModifyDate).HasColumnName("ModifyDate");
            Property(t => t.Priority).HasColumnName("Priority");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.Title).HasColumnName("Title");

            HasRequired(z => z.CreatedBy).WithMany(z => z.Tickets).HasForeignKey(z => z.CreatedById);

            HasRequired(z => z.AssignTo).WithMany(z => z.Tickets).HasForeignKey(z => z.AssignToId);
     
        }

    }
}