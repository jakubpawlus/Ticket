using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ticket.Web.Models.Account
{
    public class LoginModel
    {
        [Required(ErrorMessage="Please fill E-mail field")]
        public string Email { get; set; }

        [Required(ErrorMessage="Please fill Password field")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}