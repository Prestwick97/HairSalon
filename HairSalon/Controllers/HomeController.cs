using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]ß
      public ActionResult Index()
      {
        return View();
      }

    }
}