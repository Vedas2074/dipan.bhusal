using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using EmployeeManagement.Models;
using EmployeeManagement.Data;

namespace EmployeeManagement.Controllers{
    public class EmployeeController : Controller
    {
        private readonly EMSContext db;
        public EmployeeController(EMSContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var employees = db.Employees.ToList();
            return View(employees);
            // return View();
        }
        public IActionResult Detail(int id){
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        public IActionResult Add(){
            return View();
        }
        
        [HttpPost]
        public ActionResult Add(Employee employee){
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("Index"); 
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit( Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Update(employee);
            db.SaveChanges();

            return RedirectToAction("Index"); 
        }

        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {   
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
    }
}