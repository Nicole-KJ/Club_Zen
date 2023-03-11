using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class TennisCourtController : Controller
    {
        TennisCourtHelper tennisCourtHelper;

        // GET: EventoController
        public ActionResult Index()
        {
            tennisCourtHelper = new TennisCourtHelper();
            List<TennisCourtViewModel> list = tennisCourtHelper.GetAll();
            return View(list);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            tennisCourtHelper = new TennisCourtHelper();
            TennisCourtViewModel tennisCourt = tennisCourtHelper.Get(id);

            return View(tennisCourt);
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TennisCourtViewModel tennisCourt)
        {
            try
            {
                tennisCourtHelper = new TennisCourtHelper();
                tennisCourt = tennisCourtHelper.Create(tennisCourt);

                return RedirectToAction("Details", new { id = tennisCourt.IdTennisCourt });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            tennisCourtHelper = new TennisCourtHelper();
            TennisCourtViewModel tennisCourt = tennisCourtHelper.Get(id);
            return View(tennisCourt);
        }

        // POST: EventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TennisCourtViewModel tennisCourt)
        {
            try
            {
                tennisCourtHelper = new TennisCourtHelper();
                tennisCourt = tennisCourtHelper.Edit(tennisCourt);

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
            tennisCourtHelper = new TennisCourtHelper();
            TennisCourtViewModel tennisCourt = tennisCourtHelper.Get(id);

            return View(tennisCourt);
        }

        // POST: EventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(TennisCourtViewModel tennisCourt)
        {
            try
            {
                tennisCourtHelper = new TennisCourtHelper();
                tennisCourtHelper.Delete(tennisCourt.IdTennisCourt);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}