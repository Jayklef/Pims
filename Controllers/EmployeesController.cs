using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pims.Data;
using Pims.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pims.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly PimsContext _context;

        public EmployeesController(PimsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           IEnumerable<Employee> employee = _context.Employees.ToList();
            return View(employee);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> Dropdown = _context.Departments.Select(d => new SelectListItem
            {
                Text = d.DeptName,
                Value = d.Id.ToString()
            });

            ViewBag.DropDown = Dropdown;
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int Id)
        {
            var employee = _context.Employees.SingleOrDefault(e=> e.Id == Id);
            return View(employee);
        }

        public IActionResult Update(int Id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(Employee model)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int Id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Remove(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
