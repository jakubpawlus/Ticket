using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticket.Web.Controllers
{
    public class TicketController : BaseController
    {
        //
        // GET: /Ticket/

        public ActionResult Index()
        {
            return View();
        }

    }
}
