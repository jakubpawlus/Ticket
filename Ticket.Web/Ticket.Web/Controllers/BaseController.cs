using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket.Web.DAL.Repository;

namespace Ticket.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

        private UnitOfWork unitOfWork;
        public UnitOfWork UnitOfWork
        {
            get 
            {
                if (unitOfWork == null)
                {
                    unitOfWork = new UnitOfWork();
                }
                return unitOfWork;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (unitOfWork != null) unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}