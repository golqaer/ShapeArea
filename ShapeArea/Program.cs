using GeometryLibrary;

namespace ShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Circle(5),
                new Triangle(3, 4, 5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");

                if (shape is Triangle triangle)
                {
                    Console.WriteLine($"Is Right Triangle: {triangle.IsRightTriangle()}");
                }
            }
        }
    }
}
