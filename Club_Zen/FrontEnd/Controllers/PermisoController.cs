using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class PermisoController : Controller
    {
        // GET: PermisoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PermisoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PermisoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermisoController/Create
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

        // GET: PermisoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PermisoController/Edit/5
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

        // GET: PermisoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PermisoController/Delete/5
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
