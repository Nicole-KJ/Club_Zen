using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioHelper usuarioHelper;

        // GET: EventoController
        public ActionResult Index()
        {
            usuarioHelper = new UsuarioHelper();
            List<UsuarioViewModel> list = usuarioHelper.GetAll();
            return View(list);
        }

        // GET: EventoController/Details/5
        public ActionResult Details(int id)
        {
            usuarioHelper = new UsuarioHelper();
            UsuarioViewModel usuario = usuarioHelper.Get(id);

            return View(usuario);
        }

        // GET: EventoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            try
            {
                usuarioHelper = new UsuarioHelper();
                usuario = usuarioHelper.Create(usuario);

                return RedirectToAction("Details", new { id = usuario.IdUsuario });
            }
            catch
            {
                return View();
            }
        }

        // GET: EventoController/Edit/5
        public ActionResult Edit(int id)
        {
            usuarioHelper = new UsuarioHelper();
            UsuarioViewModel usuario = usuarioHelper.Get(id);
            return View(usuario);
        }

        // POST: EventoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            try
            {
                usuarioHelper = new UsuarioHelper();
                usuario = usuarioHelper.Edit(usuario);

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
            usuarioHelper = new UsuarioHelper();
            UsuarioViewModel usuario = usuarioHelper.Get(id);

            return View(usuario);
        }

        // POST: EventoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UsuarioViewModel usuario)
        {
            try
            {
                usuarioHelper = new UsuarioHelper();
                usuarioHelper.Delete(usuario.IdUsuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}