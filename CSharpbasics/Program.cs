
using System;
using LearningClasses;
namespace CSharpbasics
{
    class Program
    {
        static void Main() 
        {
            var person2 = new Person();
            var person1 = new Person("d", "Kathmandu", 20);  
            Console.WriteLine(person1.Address); 

            var s = Calcalutor.Sum<int>(2,3);

            Rectangle rectangle = new Rectangle(2.3,4.5);
            
            var result = rectangle.GetArea();
            
        }
    }
}


