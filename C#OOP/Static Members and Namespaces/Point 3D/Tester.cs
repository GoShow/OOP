using System;
class Point3DTester
{
    static void Main()
    {
        Point3D alpha = new Point3D(-7, -4, 3);
        Point3D beta = new Point3D(17, 6, 2.5);
        double distance = DistanceCalculator.CalcDistance(alpha, beta);
        Path3D path = new Path3D(Point3D.StartingPoint, alpha, beta);

        Console.WriteLine(Point3D.StartingPoint);

        Console.WriteLine();
        Console.WriteLine(alpha);
        Console.WriteLine();
        Console.WriteLine(beta);

        Console.WriteLine();
        Console.WriteLine(path);

        Console.WriteLine();    
        Console.WriteLine("Distance between second and third point is {0}.", distance);

        Storage.WriteToFile(path.ToString());

        // working with the path.txt, you can comment the code above to see it's working! :)
        string text = Storage.ReadFromFile("path.txt");
        double[] coordinates = Storage.GetCoordinates(text);
        Point3D[] pointsFromFile = Storage.GetPoints(coordinates);
        Path3D pathFromFile = new Path3D(pointsFromFile);

        Console.WriteLine();
        Console.WriteLine("This is Path generated from text file: {0}", pathFromFile);
    }
}

