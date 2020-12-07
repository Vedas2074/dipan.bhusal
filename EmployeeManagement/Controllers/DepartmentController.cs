using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
using System.Collections.Generic;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index(){
            Department item1 = new Department(){
            ItemId = 1,
            ItemName = "KitKat",
            InStock = true,
            Price = 200.00f,
            Quantity = 100
            };
            Department item2 = new Department(){
            ItemId = 2,
            ItemName = "JuJu Dhau",
            InStock = true,
            Price = 100.00f,
            Quantity = 50
            };
            Department item3 = new Department(){
            ItemId = 3,
            ItemName = "Flour",
            InStock = false,
            Price = 150.50f,
            Quantity = 0
            };
            
            List<Department> items = new List<Department>{item1, item2, item3};
            return View(items);
        }
    }
}