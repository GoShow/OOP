namespace Shapes
{
    using System;
    using System.Collections.Generic;
    public class TestShapes
    {
        static void Main()
        {
            IList<IShape> shapes = new List<IShape>();

            Triangle triangle = new Triangle(3, 6, 45);
            Rectangle rectangle = new Rectangle(11.2, 3);
            Circle circle = new Circle(4.2);

            shapes.Add(triangle);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine("area = " + shape.CalculateArea());
                Console.WriteLine("perimeter = " + shape.CalculatePerimeter());
            }
        }
    }
}
