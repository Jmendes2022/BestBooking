using Microsoft.AspNetCore.Mvc;

namespace BestBooking.Controllers
{
    public class NightLifeController : Controller
    {
        public IActionResult NightLifeIndex()
        {
            return View();
        }



    }
}
