
using System;

namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;
        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width", "Width can't be zero or less");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height", "Height can't be zero or less");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
