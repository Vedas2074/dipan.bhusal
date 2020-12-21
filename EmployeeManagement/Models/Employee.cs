using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmployeeManagement.Models{

public class Employee{
    public int Id { get;set;}
    
    [Required(ErrorMessage= "First Name is required")]
    public string FirstName { get;set;}
    [Required(ErrorMessage="Last Name is required")]
    public string LastName { get; set;}
    public string Address { get; set;}
    public byte? Age { get; set;}
    public float? Salary { get; set;}

    public static List<Employee> GetEmployees(){
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
            return employees;
    }
}
}