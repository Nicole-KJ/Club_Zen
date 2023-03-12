using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionEventoController : Controller
    {
        // GET: ReservacionEventoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservacionEventoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservacionEventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionEventoController/Create
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

        // GET: ReservacionEventoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservacionEventoController/Edit/5
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

        // GET: ReservacionEventoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservacionEventoController/Delete/5
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
