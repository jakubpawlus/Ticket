using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ticket.Web.Entity;

namespace Ticket.Web.DAL.Repository
{
    public class UnitOfWork :IDisposable
    {
        private TicketContext context;
        public TicketContext Context
        {
            get
            {
                if (context == null)
                    context = new TicketContext();

                return context;
            }
        }

        private AdministrationRepository administrationRepository;
        public AdministrationRepository AdministrationRepository
        {
            get 
            {
                if(administrationRepository == null)
                    administrationRepository = new AdministrationRepository();

                return administrationRepository;
            }
        }

        private TicketRepository ticketRepository;
        public TicketRepository TicketRepository
        {
            get
            {
                if (ticketRepository == null)
                    ticketRepository = new TicketRepository();

                return ticketRepository;
            }
        }

        private int userId;
        public int UserId
        {
            get 
            {
                if(userId == null || userId == 0)
                {
                    if (HttpContext.Current.User.Identity.IsAuthenticated)
                    {
                        var user = Context.Users.FirstOrDefault(z => z.UserName.Equals(HttpContext.Current.User.Identity.Name));
                        userId = user.UserId;
                    }
                }
                return userId;
            }
      
        }

        public void Dispose()
        {
            if(context != null)
                context.Dispose();
        }
    }
}