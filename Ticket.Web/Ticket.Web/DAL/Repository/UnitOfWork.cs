using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ticket.Web.Entity;

namespace Ticket.Web.DAL.Repository
{
    public class UnitOfWork :IDisposable
    {
        private TicketContext ticketContext;
        public TicketContext TicketContext
        {
            get
            {
                if (ticketContext == null)
                    ticketContext = new TicketContext();

                return ticketContext;
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

        public void Dispose()
        {
            if(ticketContext != null)
                ticketContext.Dispose();
        }
    }
}