using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionTennisController : Controller
    {
        // GET: ReservacionTennisController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservacionTennisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservacionTennisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservacionTennisController/Create
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

        // GET: ReservacionTennisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservacionTennisController/Edit/5
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

        // GET: ReservacionTennisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservacionTennisController/Delete/5
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
