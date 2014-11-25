namespace Shapes
{
    using System;

    class Circle : Shape
    {
        private double radius;

        public Circle()
            : this(0) { }

        public Circle(double radius)
            : base(2 * radius, 2 * radius)
        {
            this.radius = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * radius * radius;
        }
    }
}