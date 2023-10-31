namespace OopInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IObjectWithArea rectangle = new Rectangle(10, 20);
            IObjectWithArea obj = new SomeOtherObjectWithArea(350);

            double totalArea = GeometryUtils.CalculateTotalArea(rectangle, obj);

            Console.WriteLine($"Total area: {totalArea}");
            */


            Shape rectangle = new Rectangle(new Point(10, 10), 10, 20);
            Shape triangle = new Triangle(new Point(15, 15), new Point(23, 30), new Point(50, 25));
            IObjectWithArea o1 = new SomeOtherObjectWithArea(100);
            ITranslatableObject o2 = new OtherTranslatableObject();
            IRotatableObject o3 = new OtherRotatableObject();

            double totalArea = GeometryUtils.CalculateTotalArea(rectangle, triangle, o1);
            Console.WriteLine($"Total area: {totalArea}");

            GeometryUtils.TranslateObjects(30, 50, triangle, rectangle, o2);

            GeometryUtils.RotateObjects(45, triangle, rectangle, o3);

            double totalArea2 = GeometryUtils.CalculateTotalArea(new[] { rectangle, triangle, o1 });

            Console.WriteLine($"Total area after translation and rotation: {totalArea2}");


        }
    }
}