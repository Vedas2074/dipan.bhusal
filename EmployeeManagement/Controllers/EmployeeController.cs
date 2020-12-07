using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee1 = new Employee(){
                Id = 1,
                FirstName = "Dipan",
                LastName = "Bhusal",
                Age = 124, 
                Salary = 4343,
                Address = "Patan"

            };
            Employee employee2 = new Employee(){
                Id = 2,
                FirstName = "Ram",
                LastName = "Bhusal",
                Age = 24, 
                Salary = 434399,
                Address = "Chitwan"


            };
            List<Employee> employees = new List<Employee>(){employee1, employee2};
            return View(employees);
            // return View();
        }
    }
}