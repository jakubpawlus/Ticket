using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ticket.Web.DAL.Entity;

namespace Ticket.Web.DAL.Repository.Model.Administration
{
    public class User
    {
        public User() { }
        public User(UserEntity item)
        {
            UserId = item.UserId;
            UserName = item.UserName;
            FirstName = item.FirstName;
            Surname = item.Surname;
            Phone = item.Phone;
            Email = item.Email;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}