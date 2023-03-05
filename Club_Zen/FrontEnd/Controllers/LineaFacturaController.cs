using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class LineaFacturaController : Controller
    {
        // GET: LineaFacturaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LineaFacturaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineaFacturaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineaFacturaController/Create
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

        // GET: LineaFacturaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LineaFacturaController/Edit/5
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

        // GET: LineaFacturaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LineaFacturaController/Delete/5
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
