using Microsoft.AspNetCore.Mvc;
using GrupparbeteMVC.Models;
using GrupparbeteMVC;
using Microsoft.EntityFrameworkCore;
using GrupparbeteMVC.Models;

namespace Grupparbete.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationContext Context;
        public TicketsController(ApplicationContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            List<Ticket> MyTickets = Context.Tickets.ToList();
            return View(MyTickets);
        }
        public string MyTicket()
        {
            return "de här problemen registrerades idag.";
        }
        public IActionResult Details(int Id)
        {
            //System.Diagnostics.Debug.Writeline("Id: " ´Id);
            Ticket Ticket = Context.Tickets.FirstOrDefault(x => x.Id == Id);
            return View(Ticket);

        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Title, string Description, string Creator)
        {
            Ticket NewTicket = new Ticket();
            NewTicket.Title = Title;
            NewTicket.Description = Description;
            NewTicket.Creator = Creator;
            Context.Tickets.Add(NewTicket);
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int Id)
        {
            Ticket Ticket = Context.Tickets.FirstOrDefault(x => x.Id == Id);
            return View(Ticket);
        }

        [HttpPost]
        public IActionResult Edit(int Id, string Title, string Description, string Creator)
        {
            Ticket NewTicket = Context.Tickets.FirstOrDefault(x => x.Id == Id);
            NewTicket.Title = Title;
            NewTicket.Description = Description;
            NewTicket.Creator = Creator;
            Context.Tickets.Update(NewTicket);
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Ticket Ticket = Context.Tickets.FirstOrDefault(x => x.Id == Id);
            return View(Ticket);
        }
        public IActionResult DeleteConfirm(int Id)
        {
            Ticket Ticket = Context.Tickets.FirstOrDefault(x => x.Id == Id);
            Context.Remove(Ticket);
            Context.SaveChanges(true);
            return RedirectToAction(nameof(Index));
        }

        

        public IActionResult Reply(int id)
        {
            var ticket = Context.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        [HttpPost]
        public IActionResult Reply(int id, string reply)
        {
            var ticket = Context.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            ticket.Reply = reply;

            Context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }





    }
}
