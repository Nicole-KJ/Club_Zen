using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionMesaController : Controller
    {
        // GET: ReservacionMesaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservacionMesaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservacionMesaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionMesaController/Create
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

        // GET: ReservacionMesaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservacionMesaController/Edit/5
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

        // GET: ReservacionMesaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservacionMesaController/Delete/5
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
