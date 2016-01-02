using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Entity.Map
{
    public class UserMap : EntityTypeConfiguration<UserEntity>
    {

        public UserMap()
        {
            // Primary Key
            HasKey(t => t.UserId);

            // Table & Column Mappings
            ToTable("User");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.Surname).HasColumnName("Surname");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Phone).HasColumnName("Phone");

           
        }
    }
}