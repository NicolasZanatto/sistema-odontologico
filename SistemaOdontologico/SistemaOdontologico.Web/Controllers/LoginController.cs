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

        public ActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}