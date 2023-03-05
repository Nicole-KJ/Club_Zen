using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class TennisCourtController : Controller
    {
        // GET: TennisCourtController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TennisCourtController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TennisCourtController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TennisCourtController/Create
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

        // GET: TennisCourtController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TennisCourtController/Edit/5
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

        // GET: TennisCourtController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TennisCourtController/Delete/5
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
