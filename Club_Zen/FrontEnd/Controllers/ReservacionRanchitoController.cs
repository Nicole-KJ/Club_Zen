using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionRanchitoController : Controller
    {
        // GET: ReservacionRanchitoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservacionRanchitoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservacionRanchitoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionRanchitoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionRanchitoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservacionRanchitoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservacionRanchitoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservacionRanchitoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
