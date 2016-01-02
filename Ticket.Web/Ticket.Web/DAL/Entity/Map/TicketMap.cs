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
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(3000);

            // Table & Column Mappings
            this.ToTable("Ticket");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedById).HasColumnName("CreatedById");
            this.Property(t => t.AssignToId).HasColumnName("AssignToId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.IsClose).HasColumnName("IsClose");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");

            // Relationships
            this.HasRequired(t => t.AssignTo)
                .WithMany(t => t.Tickets)
                .HasForeignKey(d => d.AssignToId);
            this.HasRequired(t => t.CreatedBy)
                .WithMany(t => t.Tickets1)
                .HasForeignKey(d => d.CreatedById);

        }
    }
}