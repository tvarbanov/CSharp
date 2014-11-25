namespace Shapes
{
    using System;

    abstract class Shape
    {
        private double height;
        private double width;

        public Shape()
            : this(0, 0) { }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Height
        {
            get { return this.height; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                this.width = value;
            }
        }

        public abstract double CalculateSurface();
    }
}