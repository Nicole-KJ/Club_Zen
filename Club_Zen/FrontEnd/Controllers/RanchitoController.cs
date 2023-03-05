using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class RanchitoController : Controller
    {
        // GET: RanchitoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RanchitoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RanchitoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RanchitoController/Create
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

        // GET: RanchitoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RanchitoController/Edit/5
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

        // GET: RanchitoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RanchitoController/Delete/5
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
