using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ReservacionRanchitoController : Controller
    {
        ReservacionRanchitoHelper reservacionRanchitoHelper;
    // GET: ReservacionRanchitoController
    public ActionResult Index()
    {
        reservacionRanchitoHelper = new ReservacionRanchitoHelper();
        List<ReservacionRanchitoViewModel> list = reservacionRanchitoHelper.GetAll();
        return View(list);
    }

    // GET: ReservacionRanchitoController/Details/5
    public ActionResult Details(int id)
    {
        reservacionRanchitoHelper = new ReservacionRanchitoHelper();
        ReservacionRanchitoViewModel reservacionevento = reservacionRanchitoHelper.Get(id);

        return View(reservacionevento);
    }

    // GET: ReservacionRanchitoController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ReservacionRanchitoController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(ReservacionRanchitoViewModel reservacionevento)
    {
        try
        {
            reservacionRanchitoHelper = new ReservacionRanchitoHelper();
            reservacionevento = reservacionRanchitoHelper.Create(reservacionevento);

            return RedirectToAction("Details", new { id = reservacionevento.IdRanchito });
        }
        catch
        {
            return View();
        }
    }

    // GET: ReservacionRanchitoController/Edit/5
    public ActionResult Edit(int id)
    {
        reservacionRanchitoHelper = new ReservacionRanchitoHelper();
        ReservacionRanchitoViewModel reservacionevento = reservacionRanchitoHelper.Get(id);
        return View(reservacionevento);
    }

    // POST: ReservacionRanchitoController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(ReservacionRanchitoViewModel reservacionevento)
    {
        try
        {
            reservacionRanchitoHelper = new ReservacionRanchitoHelper();
            reservacionevento = reservacionRanchitoHelper.Edit(reservacionevento);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ReservacionRanchitoController/Delete/5
    public ActionResult Delete(int id)
    {
        reservacionRanchitoHelper = new ReservacionRanchitoHelper();
        ReservacionRanchitoViewModel reservacionevento = reservacionRanchitoHelper.Get(id);

        return View(reservacionevento);
    }

    // POST: ReservacionRanchitoController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(ReservacionRanchitoViewModel reservacionevento)
    {
        try
        {
            reservacionRanchitoHelper = new ReservacionRanchitoHelper();
            reservacionRanchitoHelper.Delete(reservacionevento.IdRanchito);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
}