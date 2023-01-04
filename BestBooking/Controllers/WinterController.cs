using Microsoft.AspNetCore.Mvc;

namespace BestBooking.Controllers
{
    public class WinterController : Controller
    {
        public IActionResult WinterIndex()
        {
            return View();
        }

        public IActionResult Aspen()
        {
            return View();
        }

        public IActionResult Colorado()
        {
            return View();
        }

        public IActionResult Alaska()
        {
            return View();    
        }

        public IActionResult Vermont()
        {
            return View();
        }
    }
}
