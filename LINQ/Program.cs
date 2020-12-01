using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)


        {
            //LINQ - Language Integrated Query

            int[] numbers = {23,45,65,43,12,6,76};

            //Find all the elements from numbers array which are less than and greater than 20
            var result = numbers.Where(x => x < 75 && x > 25).Select(num => num);

            //Query expression syntax
            var result1 = from num in numbers
                            where num > 50
                            select num;
            
            //Restrictions - where
            var result2 = from num in numbers
                            where num > 50 && num < 20
                            select num;

            //Projections - select
            var result3 = from num in numbers   
                            where num % 2 == 0
                            select num * num; 

            //Ordering order by, orderby descending
            var result4 = from num in numbers
                            orderby num descending  
                            select num;

            //Partitioning
            var result5 = numbers.Skip(5).Take(5);

            //Quantifiers
            var result6 = numbers.Any(num => num % 2 == 0);
            var result7 = numbers.All(num => num %2 == 0);
            var result8 = numbers.Contains(25);

            //Generations
            var result9 = Enumerable.Range(1,1000);
            var result10 = Enumerable.Repeat("Hey", 10);
        }
    
        void LearnLinqOnComplexCollection()
        {

            Country c1  = new Country("Nepal", "KTM", "Asia", 23232323);
            Country c2  = new Country("India", "New Delhi", "Asia", 2323122323, DateTime.Parse("1947/11/11"));
            Country c3  = new Country("Australia", "Canberra", "Australia", 28732323);
            Country c4  = new Country("Brazil", "Rio", "South America", 29032323, DateTime.Parse("1986/04/12"));
            Country c5  = new Country("Russia", "Moscow", "Europe", 9932323);
            Country c6  = new Country("England", "GB", "Europe", 99323);
            
            var countries = new List<Country>{c1,c2,c3, c4,c5};

            //List of asian country names
            var result1 = from country in countries 
                            where country.Continent == "Asia"
                            select country.Name;


            //List of all asian countries names which are never invaded
            var result2 = from country in countries
                            where country.Continent == "Asia" && country.IndependanceDay != default
                            select country.Name; 
        
            //List oof all europian country names whose population is less than 500k in ascending order
            var result3 = from country in countries
                            where country.Continent =="Europe" && country.Population < 500000
                            orderby country.Name ascending
                            select country.Name;
                            
        }
    }
}
