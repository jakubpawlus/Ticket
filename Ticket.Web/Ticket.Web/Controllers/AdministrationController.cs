using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket.Web.DAL.Repository.Model.Administration;
using WebMatrix.WebData;

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

        public ActionResult CreateUser()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("TicketDataBaseContext", "User", "UserId", "UserName", autoCreateTables: true);
            }
            var user = new CreateUser();
            return PartialView("_createUserPartial", user); 
        }

        [HttpPost]
        public ActionResult CreateUser(CreateUser user)
        {
            UnitOfWork.AdministrationRepository.CreateUser(UnitOfWork.TicketContext, user);
            return RedirectToAction("Users");
        }

    }
}
