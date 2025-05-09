using Microsoft.AspNetCore.Mvc;

namespace CollegeWebsite.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult CE()
        {
            return View();
        }
        public IActionResult IT()
        {
            return View();
        }
        
        public IActionResult Mech()
        {
            return View();
        }
        public IActionResult ENTC()
        {
            return View();
        }

        // You can add more department actions like: CE(), ME(), etc.
    }
}
