namespace OopInterfaces
{
    public abstract class Shape : IObjectWithArea, ITranslatableObject, IRotatableObject
    {
        public Shape(params Point[] points)
        {
            Points = points ?? new Point[0];
        }

        public Point[] Points
        {
            get;
        }

        public abstract double GetArea();

        public void Rotate(double angleDegrees)
        {
            foreach (Point p in this.Points)
            {
                p.Rotate(angleDegrees);
            }
        }

        public void Translate(int dx, int dy)
        {
            foreach (Point p in this.Points)
            {
                p.Translate(dx, dy);
            }
        }
    }
}
