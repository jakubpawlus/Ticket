using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ticket.Web.DAL.Repository.Model.Administration;
using Ticket.Web.Entity;

namespace Ticket.Web.DAL.Repository
{
    public class AdministrationRepository
    {

        public List<User> GetUsers(TicketContext context)
        {
            var user = context.Users.Select(item => new User() 
            {
                UserId = item.UserId,
                UserName = item.UserName,
                FirstName = item.FirstName,
                Surname = item.Surname,
                Phone = item.Phone,
                Email = item.Email
            }).ToList();
            return user;
        }

        public User GetUser(TicketContext context, int userId)
        {
            var user = context.Users.FirstOrDefault(z => z.UserId == userId);
            var userView = new User(user);
            return userView;
        }

        public void Update(TicketContext context, User user)
        {
            var userdb = context.Users.FirstOrDefault(z => z.UserId == user.UserId);
            if (userdb == null)
            {
                userdb.FirstName = userdb.FirstName;
                userdb.UserName = userdb.UserName;
                userdb.Surname = userdb.Surname;
                userdb.Email = userdb.Email;
                userdb.Phone = userdb.Phone;
                context.SaveChanges();
            }
        }
    }
}