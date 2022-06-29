using Microsoft.AspNetCore.Mvc;

namespace Geolocation.Controllers
{
    public class GeolocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
