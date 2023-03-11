using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class FacturaController : Controller
    {
        FacturaHelper facturaHelper;

        // GET: EventoController
        public ActionResult Index()
        {
            facturaHelper = new FacturaHelper();
            List<FacturaViewModel> list = facturaHelper.GetAll();
            return View(list);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            facturaHelper = new FacturaHelper();
            FacturaViewModel factura = facturaHelper.Get(id);

            return View(factura);
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FacturaViewModel factura)
        {
            try
            {
                facturaHelper = new FacturaHelper();
                factura = facturaHelper.Create(factura);

                return RedirectToAction("Details", new { id = factura.IdFactura });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            facturaHelper = new FacturaHelper();
            FacturaViewModel factura = facturaHelper.Get(id);
            return View(factura);
        }

        // POST: EventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FacturaViewModel factura)
        {
            try
            {
                facturaHelper = new FacturaHelper();
                factura = facturaHelper.Edit(factura);

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
            facturaHelper = new FacturaHelper();
            FacturaViewModel factura = facturaHelper.Get(id);

            return View(factura);
        }

        // POST: EventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(FacturaViewModel factura)
        {
            try
            {
                facturaHelper = new FacturaHelper();
                facturaHelper.Delete(factura.IdFactura);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
