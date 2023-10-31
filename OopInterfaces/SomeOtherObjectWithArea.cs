namespace OopInterfaces
{
    public class SomeOtherObjectWithArea : IObjectWithArea
    {
        public SomeOtherObjectWithArea(double area)
        {
            Area = area;
        }

        public double Area
        {
            get;
        }

        public double GetArea()
        {
            return Area;
        }
    }
}
