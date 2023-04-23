using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionMesaController : Controller
    {
        ReservacionMesaHelper reservacionMesaHelper;
        // GET: ReservacionMesaController
        public ActionResult Index()
        {
            reservacionMesaHelper = new ReservacionMesaHelper();
            List<ReservacionMesaViewModel> list = reservacionMesaHelper.GetAll();
            return View(list);
        }

        // GET: ReservacionMesaController/Details/5
        public ActionResult Details(int id)
        {
            reservacionMesaHelper = new ReservacionMesaHelper();
            ReservacionMesaViewModel reservacionmesa = reservacionMesaHelper.Get(id);

            return View(reservacionmesa);
        }

        // GET: ReservacionMesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionMesaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservacionMesaViewModel reservacionmesa)
        {
            try
            {
                reservacionMesaHelper = new ReservacionMesaHelper();
                reservacionmesa = reservacionMesaHelper.Create(reservacionmesa);

                return RedirectToAction("Details", new { id = reservacionmesa.IdReservacionMesa });
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionMesaController/Edit/5
        public ActionResult Edit(int id)
        {
            reservacionMesaHelper = new ReservacionMesaHelper();
            ReservacionMesaViewModel reservacionmesa = reservacionMesaHelper.Get(id);
            return View(reservacionmesa);
        }

        // POST: ReservacionMesaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservacionMesaViewModel reservacionmesa)
        {
            try
            {
                reservacionMesaHelper = new ReservacionMesaHelper();
                reservacionmesa = reservacionMesaHelper.Edit(reservacionmesa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionMesaController/Delete/5
        public ActionResult Delete(int id)
        {
            reservacionMesaHelper = new ReservacionMesaHelper();
            ReservacionMesaViewModel reservacionmesa = reservacionMesaHelper.Get(id);

            return View(reservacionmesa);
        }

        // POST: ReservacionMesaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ReservacionMesaViewModel reservacionmesa)
        {
            try
            {
                reservacionMesaHelper = new ReservacionMesaHelper();
                reservacionMesaHelper.Delete(reservacionmesa.IdReservacionMesa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
