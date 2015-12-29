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
       

        //    // Relationships
        //    HasMany(t => t.Documents)
        //        .WithMany(t => t.AdditionalDatas)
        //        .Map(m =>
        //            {
        //                m.ToTable("DocumentAdditionalData");
        //                m.MapLeftKey("AdditionalDataId");
        //                m.MapRightKey("DocumentId");
        //            });

          
        //    HasOptional(t => t.AdditionalDataParent)
        //        .WithMany(t => t.AdditionalDataChildren)
        //        .HasForeignKey(d => d.AdditionalDataId);
        //    HasOptional(t => t.OrderItem)
        //        .WithMany(t => t.AdditionalDatas)
        //        .HasForeignKey(d => d.OrderItemId);
        //    HasOptional(t => t.UserProfile)
        //        .WithMany(t => t.AdditionalDatas)
        //        .HasForeignKey(d => d.UserProfileId);
        //    HasOptional(t => t.OrderItemGroup)
        //        .WithMany(t => t.AdditionalDatas)
        //        .HasForeignKey(d => d.OrderItemGroupId);
        }
    }
}