﻿namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle()
            : this(0, 0) { }

        public Triangle(double width, double height)
            : base(width, height) { }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}