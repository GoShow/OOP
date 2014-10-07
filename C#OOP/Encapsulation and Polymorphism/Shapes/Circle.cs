using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius", "Radius can't be 0 or less");
                }

                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }
}
