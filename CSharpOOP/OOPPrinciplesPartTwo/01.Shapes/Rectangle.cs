namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle()
            : this(0, 0) { }

        public Rectangle(double width, double height)
            : base(width, height) { }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}