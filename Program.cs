namespace Assignments_2._2
{
    using System;

    abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Square : Shape
    {
        public double Side { get; set; }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select a shape to calculate area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.Write("Enter your choice (1 or 2): ");

            int choice = int.Parse(Console.ReadLine());
            Shape shape = null;

            switch (choice)
            {
                case 1:
                    shape = new Circle();
                    shape.Name = "Circle";
                    Console.Write("Enter the radius of the circle: ");
                    ((Circle)shape).Radius = double.Parse(Console.ReadLine());
                    break;

                case 2:
                    shape = new Square();
                    shape.Name = "Square";
                    Console.Write("Enter the side length of the square: ");
                    ((Square)shape).Side = double.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.Write("Enter the color of the shape: ");
            shape.Color = Console.ReadLine();

            Console.WriteLine($"\nShape Details:");
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Color: {shape.Color}");
            Console.WriteLine($"Area: {shape.CalculateArea():F2}");
        }
    }
}
