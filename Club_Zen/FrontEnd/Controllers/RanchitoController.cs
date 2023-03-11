using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class RanchitoController : Controller
    {
        RanchitoHelper ranchitoHelper;

        // GET: EventoController
        public ActionResult Index()
        {
            ranchitoHelper = new RanchitoHelper();
            List<RanchitoViewModel> list = ranchitoHelper.GetAll();
            return View(list);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            ranchitoHelper = new RanchitoHelper();
            RanchitoViewModel ranchito = ranchitoHelper.Get(id);

            return View(ranchito);
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RanchitoViewModel ranchito)
        {
            try
            {
                ranchitoHelper = new RanchitoHelper();
                ranchito = ranchitoHelper.Create(ranchito);

                return RedirectToAction("Details", new { id = ranchito.IdRanchito });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            ranchitoHelper = new RanchitoHelper();
            RanchitoViewModel ranchito = ranchitoHelper.Get(id);
            return View(ranchito);
        }

        // POST: EventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RanchitoViewModel ranchito)
        {
            try
            {
                ranchitoHelper = new RanchitoHelper();
                ranchito = ranchitoHelper.Edit(ranchito);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Delete/5
        public ActionResult Delete(int id)
        {
            ranchitoHelper = new RanchitoHelper();
            RanchitoViewModel ranchito = ranchitoHelper.Get(id);

            return View(ranchito);
        }

        // POST: EventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(RanchitoViewModel ranchito)
        {
            try
            {
                ranchitoHelper = new RanchitoHelper();
                ranchitoHelper.Delete(ranchito.IdRanchito);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
