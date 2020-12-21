 using System.Collections.Generic;
 namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Code { get; set;}
        
    
    public static List<Department> GetDepartments()
    {
        Department item1 = new Department(){
            Id = 1,
            Name = "Human Resource",
            Code = "HR"
            };
            Department item2 = new Department(){
            Id = 2,
            Name = "Software Engineering",
            Code = "SE",
            
            };
            Department item3 = new Department(){
            Id = 3,
            Name = "Graphic Designing",
            Code = "GD",
            };
            
            List<Department> departments = new List<Department>{item1, item2, item3};
            return departments;
    }
    }
}
