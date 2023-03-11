using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Helpers;
using FrontEnd.Models;

namespace FrontEnd.Controllers
{
    public class EventoController : Controller
    {
        EventoHelper eventoHelper;

        // GET: EventoController
        public ActionResult Index()
        {
            eventoHelper = new EventoHelper();
            List<EventoViewModel> list = eventoHelper.GetAll();
            return View(list);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            eventoHelper = new EventoHelper();
            EventoViewModel evento = eventoHelper.Get(id);

            return View(evento);
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventoViewModel evento)
        {
            try
            {
                eventoHelper = new EventoHelper();
                evento = eventoHelper.Create(evento);

                return RedirectToAction("Details", new { id = evento.IdEvento });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            eventoHelper = new EventoHelper();
            EventoViewModel evento = eventoHelper.Get(id);
            return View(evento);
        }

        // POST: EventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventoViewModel evento)
        {
            try
            {
                eventoHelper = new EventoHelper();
                evento = eventoHelper.Edit(evento);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Delete/5
        public ActionResult Delete(int id)
        {
            eventoHelper = new EventoHelper();
            EventoViewModel evento = eventoHelper.Get(id);

            return View(evento);
        }

        // POST: EventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EventoViewModel evento)
        {
            try
            {
                eventoHelper = new EventoHelper();
                eventoHelper.Delete(evento.IdEvento);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}