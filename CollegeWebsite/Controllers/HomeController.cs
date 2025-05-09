using Microsoft.AspNetCore.Mvc;
using CollegeWebsite.Models;
using System.Collections.Generic;

namespace CollegeWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }
        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult Library()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Admission()
        {
            return View();
        }

        public IActionResult AdmissionForm()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Faculty()
        {
            return View();
        }

        public IActionResult Admissions()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Departments()
        {
            var departments = new List<Department>
            {
                new Department
                {
                    Name = "Computer Engineering",
                    Description = "The Computer Engineering department focuses on the design, development, and maintenance of computer systems.",
                    Head = "Dr. John Doe",
                    ImageUrl = "/images/computer.jpg"
                },
                new Department
                {
                    Name = "Mechanical Engineering",
                    Description = "The Mechanical Engineering department deals with the application of principles of physics for analysis, design, manufacturing, and maintenance of mechanical systems.",
                    Head = "Dr. Jane Smith",
                    ImageUrl = "/images/mechanical.jpg"
                },
                new Department
                {
                    Name = "Electrical Engineering",
                    Description = "The Electrical Engineering department focuses on the study and application of electricity, electronics, and electromagnetism.",
                    Head = "Dr. Raj Kumar",
                    ImageUrl = "/images/electrical.jpg"
                },
                new Department
                {
                    Name = "Civil Engineering",
                    Description = "The Civil Engineering department focuses on the planning, design, construction, and maintenance of infrastructure projects.",
                    Head = "Dr. Priya Verma",
                    ImageUrl = "/images/civil.jpg"
                }
            };

            return View(departments);
        }
    }
}
