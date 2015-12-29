using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Ticket.Web.DAL.Entity;
using Ticket.Web.DAL.Entity.Map;

namespace Ticket.Web.Entity
{
    public class TicketContext : DbContext
    {

        public TicketContext(): base("TicketDataBaseContext")
        {
           
        }
        
        public DbSet<UserEntity> Users {get;set;}
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<TicketDiscussionEntity> TicketDiscussions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TicketDiscussionMap());
     
        }
    }
}