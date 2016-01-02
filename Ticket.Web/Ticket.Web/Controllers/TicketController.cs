using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket.Web.DAL.Repository.Model.Ticket;
namespace Ticket.Web.Controllers
{
    public class TicketController : BaseController
    {
        //
        // GET: /Ticket/

        public ActionResult Tickets()
        {
            var tickets = UnitOfWork.TicketRepository.GetTickets(UnitOfWork);

            return View("Tickets", tickets);
        }

        public ActionResult Create()
        {
            var model = new TicketShortModel();
            var users = UnitOfWork.AdministrationRepository.GetUsers(UnitOfWork);
            ViewData["Users"] = new SelectList(users,"UserId", "UserName");
            
            return View("CreateTicket", model);
        }

        [HttpPost]
        public ActionResult Create(TicketShortModel model)
        {
            UnitOfWork.TicketRepository.Create(UnitOfWork, model);
            UnitOfWork.Context.SaveChanges();
            return RedirectToAction("Tickets");
        }

        public ActionResult Details(int id)
        {
            var ticket = UnitOfWork.TicketRepository.GetTicketDetails(UnitOfWork, id);
            return View("Details", ticket);
        }

        [HttpPost]
        public ActionResult AddComment(int ticketId, string comment)
        {
            UnitOfWork.TicketRepository.CreateCommnet(UnitOfWork, comment, ticketId);
            UnitOfWork.Context.SaveChanges();
            return RedirectToAction("Details", new { id = ticketId });
        }
    }
}
