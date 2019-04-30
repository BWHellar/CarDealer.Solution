using Microsoft.AspNetCore.Mvc;

namespace CarsList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
