using System;

public static class DistanceCalculator
{
    public static double CalcDistance(Point3D alpha, Point3D beta)
    {
        double x1 = alpha.X;
        double y1 = alpha.Y;
        double z1 = alpha.Z;
        double x2 = beta.X;
        double y2 = beta.Y;
        double z2 = beta.Z;

        double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

        return distance;
    }
}

