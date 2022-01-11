using Microsoft.AspNetCore.Mvc;
using ServicesData.Implementation;
using ServicesData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Data;

namespace WebUniversity.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_studentService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentService.Create(student);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            Student student = _studentService.Get(id);
            if (student == null)
                return NotFound($"{id} student not found");
            return View(_studentService.Get(id));
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            Student student = _studentService.Get(id);
            if (student == null)
                return NotFound($"{id} student not found");
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _studentService.Update(student);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Student student = _studentService.Get(id);
            if (student == null)
                return NotFound($"{id} student not found");
            return View(_studentService.Get(id));
        }
        //[HttpPost]
        //[Route("/Delete")]
        //public IActionResult DeleteConfigure(Guid id)
        //{
        //    Student student = _studentService.Get(id);
        //    if (student == null)
        //        return NotFound($"{id} student not found");
        //    return RedirectToAction("Index");
        //}
    }
}
