using Microsoft.AspNetCore.Mvc;

namespace BestBooking.Controllers
{
    public class TropicalController : Controller
    {
        public IActionResult TropicalIndex()
        {
            return View();
        }

        public IActionResult Aruba()
        {
            return View();
        }

        public IActionResult Bahamas()
        {
            return View();
        }

        public IActionResult Bermuda()
        {
            return View();
        }
        
        public IActionResult Jamaica()
        {
            return View();
        }
    }
}
