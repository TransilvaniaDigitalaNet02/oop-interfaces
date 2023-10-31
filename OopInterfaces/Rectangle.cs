namespace OopInterfaces
{
    internal class Rectangle : Shape
    {
        public Rectangle(Point topLeft, double width, double height)
            : base(
                  /* topLeft */     topLeft,
                  /* topRight */    new Point(topLeft.X + width, topLeft.Y),
                  /* bottomRight */ new Point(topLeft.X + width, topLeft.Y + height), 
                  /* bottomLeft */  new Point(topLeft.X, topLeft.Y + height))
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get;
        }

        public double Height
        {
            get;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
