﻿
namespace OopInterfaces
{
    public static class GeometryUtils
    {
        public static double CalculateTotalArea(params IObjectWithArea[] objects)
        {
            double area = 0;
            foreach (IObjectWithArea o in objects)
            {
                area += o.GetArea();
            }

            return area;
        }

        public static void TranslateObjects(int dx, int dy, params ITranslatableObject[] objects)
        {
            foreach (ITranslatableObject o in objects)
            {
                o.Translate(dx, dy);
            }
        }

        public static void RotateObjects(double angleDegrees, params IRotatableObject[] objects)
        {
            foreach (IRotatableObject o in objects)
            {
                o.Rotate(angleDegrees);
            }
        }
    }
}
