using Microsoft.AspNetCore.Mvc;
using Pims.Data;
using Pims.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pims.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly PimsContext _context;

        public DepartmentsController(PimsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Department> department = _context.Departments.ToList();
            return View(department);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department Model)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(Model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int Id)
        {
            var department = _context.Departments.SingleOrDefault(d => d.Id == Id);
            return View(department);
        }

        public IActionResult Update(int Id)
        {
            var department = _context.Departments.SingleOrDefault(d => d.Id == Id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Update(Department model)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int Id)
        {
            var department = _context.Departments.SingleOrDefault(d => d.Id == Id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Department model)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Remove(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}