using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket.Web.Filters;
using Ticket.Web.Models.Account;
using WebMatrix.WebData;

namespace Ticket.Web.Controllers
{
    [InitializeSimpleMembership]
    public class AccountController : BaseController
    {
        //
        // GET: /Accounts/
        [AllowAnonymous]
        public ActionResult LogOn()
        {
            return View("LogOn");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult LogOn(LoginModel model)
        {
            if (ModelState.IsValid && WebSecurity.Login(model.Email, model.Password, persistCookie:true))
            {
                return  RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            WebSecurity.Logout();

            return RedirectToAction("Index", "Home");
        } 


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
