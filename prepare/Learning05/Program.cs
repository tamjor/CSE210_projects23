using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 5);
        double areaS = square.GetArea();
        string colorS = square.GetColor();
        Console.WriteLine($"The {colorS} square has an area of {areaS}");

        Rectangle rect = new Rectangle("red", 5, 6);
        double areaR = rect.GetArea();
        string colorR = rect.GetColor();
        Console.WriteLine($"The {colorR} rectangle has an area of {areaR}");

        Circle circ = new Circle("green", 5);
        double areaC = circ.GetArea();
        string colorC = circ.GetColor();
        Console.WriteLine($"The {colorC} circle has an area of {areaC}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circ);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} circle has an area of {area}");
        }


    }

}