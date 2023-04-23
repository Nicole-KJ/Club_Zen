using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionTennisController : Controller
    {
       ReservacionTennisHelper reservacionTennisHelper;
        // GET: ReservacionTennisController
        public ActionResult Index()
        {
            reservacionTennisHelper = new ReservacionTennisHelper();
            List<ReservacionTennisViewModel> list = reservacionTennisHelper.GetAll();
            return View(list);
        }

        // GET: ReservacionTennisController/Details/5
        public ActionResult Details(int id)
        {
            reservacionTennisHelper = new ReservacionTennisHelper();
            ReservacionTennisViewModel reservacionevento = reservacionTennisHelper.Get(id);

            return View(reservacionevento);
        }

        // GET: ReservacionTennisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionTennisController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionTennisViewModel reservacionevento)
        {
            try
            {
                reservacionTennisHelper = new ReservacionTennisHelper();
                reservacionevento = reservacionTennisHelper.Create(reservacionevento);

                return RedirectToAction("Details", new { id = reservacionevento.IdReservacionTennis});
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionTennisController/Edit/5
        public ActionResult Edit(int id)
        {
            reservacionTennisHelper = new ReservacionTennisHelper();
            ReservacionTennisViewModel reservacionevento = reservacionTennisHelper.Get(id);
            return View(reservacionevento);
        }

        // POST: ReservacionTennisController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservacionTennisViewModel reservacionevento)
        {
            try
            {
                reservacionTennisHelper = new ReservacionTennisHelper();
                reservacionevento = reservacionTennisHelper.Edit(reservacionevento);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionTennisController/Delete/5
        public ActionResult Delete(int id)
        {
            reservacionTennisHelper = new ReservacionTennisHelper();
            ReservacionTennisViewModel reservacionevento = reservacionTennisHelper.Get(id);

            return View(reservacionevento);
        }

        // POST: ReservacionTennisController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReservacionTennisViewModel reservacionevento)
        {
            try
            {
                reservacionTennisHelper = new ReservacionTennisHelper();
                reservacionTennisHelper.Delete(reservacionevento.IdReservacionTennis);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
