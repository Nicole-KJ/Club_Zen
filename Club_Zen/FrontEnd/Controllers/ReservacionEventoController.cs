using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionEventoController : Controller
    {
        ReservacionEventoHelper reservacionEventoHelper;
        // GET: ReservacionEventoController
        public ActionResult Index()
        {
            reservacionEventoHelper = new ReservacionEventoHelper();
            List<ReservacionEventoViewModel> list = reservacionEventoHelper.GetAll();
            return View(list);
        }

        // GET: ReservacionEventoController/Details/5
        public ActionResult Details(int id)
        {
            reservacionEventoHelper = new ReservacionEventoHelper();
            ReservacionEventoViewModel reservacionevento = reservacionEventoHelper.Get(id);

            return View(reservacionevento);
        }

        // GET: ReservacionEventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionEventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionEventoViewModel reservacionevento)
        {
            try
            {
                reservacionEventoHelper = new ReservacionEventoHelper();
                reservacionevento = reservacionEventoHelper.Create(reservacionevento);

                return RedirectToAction("Details", new { id = reservacionevento.IdReservacionEvento });
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionEventoController/Edit/5
        public ActionResult Edit(int id)
        {
            reservacionEventoHelper = new ReservacionEventoHelper();
            ReservacionEventoViewModel reservacionevento = reservacionEventoHelper.Get(id);
            return View(reservacionevento);
        }

        // POST: ReservacionEventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservacionEventoViewModel reservacionevento)
        {
            try
            {
                reservacionEventoHelper = new ReservacionEventoHelper();
                reservacionevento = reservacionEventoHelper.Edit(reservacionevento);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionEventoController/Delete/5
        public ActionResult Delete(int id)
        {
            reservacionEventoHelper = new ReservacionEventoHelper();
            ReservacionEventoViewModel reservacionevento = reservacionEventoHelper.Get(id);

            return View(reservacionevento);
        }

        // POST: ReservacionEventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReservacionEventoViewModel reservacionevento)
        {
            try
            {
                reservacionEventoHelper = new ReservacionEventoHelper();
                reservacionEventoHelper.Delete(reservacionevento.IdReservacionEvento);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
