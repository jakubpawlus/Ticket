using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Web.DAL.Repository.Model.Administration
{
    public class CreateUser : User
    {
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}