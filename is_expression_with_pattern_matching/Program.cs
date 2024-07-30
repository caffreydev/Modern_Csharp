
public class Program
{

    public static void Main(string[] args)
    {
        double dimension;
        if (!double.TryParse(args[1], out dimension))
        {
            Console.WriteLine("Invalid format provided for dimension");
            return;
        }
        var shape = new Shape();
        string dimensionName;

        if (args[0] == "Square")
        {
            shape = new Square { Size = dimension };
            dimensionName = "side";
        }
        else if (args[0] == "Circle")
        {
            shape = new Circle { Radius = dimension };
            dimensionName = "radius";
        }
        else
        {
            Console.WriteLine("Must specifiy either Circle or Square in first argument!");
            return;
        }

        var area = Area(shape);

        Console.WriteLine($"Shape is a {args[0]}, with {dimensionName} of {dimension} and area of {area}");

    }
    public class Shape { }

    public class Square : Shape
    {
        public double Size;
    }

    public class Circle : Shape
    {
        public double Radius;
    }

    public static double Area(Shape shape)
    {
        if (shape is Square square) return square.Size * square.Size;

        if (shape is Circle circle) return circle.Radius * circle.Radius * Math.PI;

        return 0;
    }
}