using System.Collections.Generic;
using System.Linq;
using dotnetT.Models;
using dotnetT.Persistance;
using Microsoft.AspNetCore.Mvc;

namespace dotnetT.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext context;

        public EmployeeController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var emps = context.Employees.ToList();
            return View(emps);
        }
         [HttpGet]
        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model) { 
            if (!ModelState.IsValid) return View(model);
            context.Add(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(int id) { 
            var emp = context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee model) { 
            if (!ModelState.IsValid) return View(model);
            context.Employees.Update(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id){ 
           var emp = context.Employees.Find(id);
           context.Employees.Remove(emp);
           context.SaveChanges();
           return RedirectToAction("index");
        }
    }
}