using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criar instâncias
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        // Testar métodos
        Console.WriteLine($"Square: Color = {square.Color}, Area = {square.GetArea()}");
        Console.WriteLine($"Rectangle: Color = {rectangle.Color}, Area = {rectangle.GetArea()}");
        Console.WriteLine($"Circle: Color = {circle.Color}, Area = {circle.GetArea()}");

        // Lista de shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("\nIterando pela lista de shapes:");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
