using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admissions()
        {
            var admissions = new List<Admission>
            {
                new Admission { Id = 1, FullName = "Rahul Patil", Course = "Computer Engineering", Email = "rahul@example.com", Phone = "9876543210", AppliedDate = DateTime.Parse("2025-05-06") },
                new Admission { Id = 2, FullName = "Pooja More", Course = "AI & Data Science", Email = "pooja@example.com", Phone = "9765432109", AppliedDate = DateTime.Parse("2025-05-07") }
                // Add more as needed
            };

            return View(admissions);
        }
    }
}
