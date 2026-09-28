using System;

class Program
{
    static void Main()
    {
        double radius, diameter, circumference, area;

        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        diameter = 2 * radius;
        circumference = diameter * Math.PI ;
        area = Math.PI * radius * radius;

        Console.WriteLine("\nCircle Details");
        Console.WriteLine("Radius = " + radius);
        Console.WriteLine("Diameter = " + diameter);
        Console.WriteLine("Circumference = " + circumference);
        Console.WriteLine("Area = " + area);
    }
}