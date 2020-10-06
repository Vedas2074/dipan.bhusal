using System;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void PrintDetails()
    {
        Console.WriteLine("Printing shapes....");
    }
}

public class Square : Shape
{
    public double Side { get; set; }
    public override double GetArea()
    {
        return Side * Side;
    }

    public override double GetPerimeter() => 4 * Side;
}

public class Rectangle : Shape
{
     public double Length { get; set; }
     public double Breadth {get; set;}

    public override double GetArea() => Length * Breadth;

    public override double GetPerimeter() => 2 * (Length + Breadth);
}

public class Circle : Shape
{
    public double Radius{get;set;}
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 4 * Math.PI * Radius ;
}