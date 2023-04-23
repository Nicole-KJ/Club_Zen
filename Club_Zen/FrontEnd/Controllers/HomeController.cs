using Microsoft.AspNetCore.Http;
using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UsuarioAViewModel usuario)
        {
            try
            {
                SecurityHelper securityHelper = new SecurityHelper();
            TokenModel tokenModel = securityHelper.Login(usuario);
            HttpContext.Session.SetString("token", tokenModel.Token);
            return RedirectToAction("Index");
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Reservaciones()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}