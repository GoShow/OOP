using System;

namespace Shapes
{
    public class Triangle : BasicShape
    {
        private double angleBetweenSides;

        public Triangle(double width, double height, double angleBetweenSides)
            : base(width, height)
        {
            this.AngleBetweenSides = angleBetweenSides;
        }

        public double AngleBetweenSides
        {
            get { return this.angleBetweenSides; }
            set
            {
                if (value < 0 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("angleBetweenSides", "Angle should be in range 0 < angle < 180");
                }

                this.angleBetweenSides = value;
            }
        }

        public override double CalculateArea()
        {
            double area = (Math.Sin(this.AngleBetweenSides * Math.PI / 180) * this.Width * this.Height) / 2;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width + 
                this.Height +
                Math.Sqrt((this.Width * this.Width) + 
                (this.Height * this.Height) - 
                (2 * this.Height * this.Width * Math.Cos(this.AngleBetweenSides * Math.PI / 180)));
            return perimeter;
        }


    }
}
