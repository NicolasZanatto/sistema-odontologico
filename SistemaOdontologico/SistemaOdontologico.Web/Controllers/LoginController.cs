using SistemaOdontologico.Application.ViewModels.Login;
using System.Web.Mvc;

namespace SistemaOdontologico.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}