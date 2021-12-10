using Microsoft.AspNetCore.Mvc;
using Student2._1Mvc.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student2._1Mvc.Controllers
{
    public class StudentController : Controller
   {
        [HttpGet]
        public IActionResult Index()
        {
            return View(StudentData.Students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            StudentviewModel model = new StudentviewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddStudent(StudentviewModel model)
        {
            if (ModelState.IsValid)
            {
                StudentData.Students.Add(model);
            }
            return RedirectToAction("Index");
        }
    }
}
