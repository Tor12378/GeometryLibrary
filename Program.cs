using System;
using GeometryLibrary;

class Program
{
    static void Main()
    {
        Circle circle = new Circle { Radius = 5 };
        Triangle triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };


        double circleArea = circle.CalculateArea();
        double triangleArea = triangle.CalculateArea();

        Console.WriteLine($"Circle Area: {circleArea}");
        Console.WriteLine($"Triangle Area: {triangleArea}");


        bool isRightTriangle = triangle.IsRightTriangle();
        Console.WriteLine($"Is Right Triangle: {isRightTriangle}");
    }
}