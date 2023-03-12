using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class MesaController : Controller
    {
        MesaHelper mesaHelper;

        // GET: EventoController
        public ActionResult Index()
        {
            mesaHelper = new MesaHelper();
            List<MesaViewModel> list = mesaHelper.GetAll();
            return View(list);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            mesaHelper = new MesaHelper();
            MesaViewModel mesa = mesaHelper.Get(id);

            return View(mesa);
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MesaViewModel mesa)
        {
            try
            {
                mesaHelper = new MesaHelper();
                mesa = mesaHelper.Create(mesa);

                return RedirectToAction("Details", new { id = mesa.IdMesa });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            mesaHelper = new MesaHelper();
            MesaViewModel mesa = mesaHelper.Get(id);
            return View(mesa);
        }

        // POST: EventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MesaViewModel mesa)
        {
            try
            {
                mesaHelper = new MesaHelper();
                mesa = mesaHelper.Edit(mesa);

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
            mesaHelper = new MesaHelper();
            MesaViewModel mesa = mesaHelper.Get(id);

            return View(mesa);
        }

        // POST: EventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(MesaViewModel mesa)
        {
            try
            {
                mesaHelper = new MesaHelper();
                mesaHelper.Delete(mesa.IdMesa);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}