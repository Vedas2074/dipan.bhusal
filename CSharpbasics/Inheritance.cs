using System;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Printing shapes....");
    }
}

public class Rectangle : Shape
{

    public Rectangle(double l, double b){
        this.Length = l;
        this.Breadth = b;
    }
     public double Length { get; set; }
     public double Breadth {get; set;}

    public override double GetArea() => Length * Breadth;

    public override double GetPerimeter() => 2 * (Length + Breadth);

    public override void PrintDetails()
    {
        Console.WriteLine($"Length: {Length}");
    }
}
public class Square : Rectangle
{
    public Square(double s) : base(s,s)
    {

    }

}

public class Circle : Shape
{

    public  Circle(double r)
    {
        this.Radius = r;
    }
    public double Radius{get;set;}
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 4 * Math.PI * Radius ;
}