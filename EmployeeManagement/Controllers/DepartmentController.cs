using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
using System.Linq;
using System.Collections.Generic;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index(){
            var departments = Department.GetDepartments();
            return View(departments);
        }

        public IActionResult Detail(int id){
            var departments = Department.GetDepartments();
            var detail = departments.FirstOrDefault(x => x.Id == id);
            return View(detail);
        }
        public IActionResult Add(){
            return View();
        }

        [HttpPost]
        public string Add(Department department)
        {
            return "Added Department: " + department.Name;
        }
    }
}