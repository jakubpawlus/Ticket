using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket.Web.DAL.Repository.Model.Administration;

namespace Ticket.Web.Controllers
{
    public class AdministrationController : BaseController
    {
        //
        // GET: /Administration/

        public ActionResult Users()
        {
            var users = UnitOfWork.AdministrationRepository.GetUsers(UnitOfWork.TicketContext);
            return View("Users", users);
        }

        public ActionResult EditUser(int userId)
        {
            var user = UnitOfWork.AdministrationRepository.GetUser(UnitOfWork.TicketContext, userId);
            return PartialView("_editUserPartial", user);
        }

        [HttpPost]
        public ActionResult EditUser(User user)
        {
            UnitOfWork.AdministrationRepository.Update(UnitOfWork.TicketContext, user);
            return RedirectToAction("Users");
        }
    }
}
