using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
public static class Storage
{
    public static void WriteToFile(string text)
    {
        File.WriteAllText("path.txt", text);
    }

    public static string ReadFromFile(string file)
    {
        return File.ReadAllText(file);
    }

    public static double[] GetCoordinates(string str)
    {
        string pattern = "[A-Za-z: ,;]+";
        string[] coordinatesStr = Regex.Split(str, pattern);
        List<double> tempCoordinates = new List<double>();
        double[] coordinates;

        for (int i = 0; i < coordinatesStr.Length; i++)
        {
            if (!String.IsNullOrEmpty(coordinatesStr[i]))
            {
                tempCoordinates.Add(double.Parse(coordinatesStr[i]));
            }
        }

        coordinates = tempCoordinates.ToArray();
        return coordinates;
    }

    public static Point3D[] GetPoints(double[] arr)
    {
        int pointsCounter = 0;
        Point3D[] points = new Point3D[arr.Length / 3];
        
        for (int i = 0; i < arr.Length - 1; i += 3)
        {
            Point3D currPoint = new Point3D(arr[i], arr[i + 1], arr[i + 2]);
            points[pointsCounter] = currPoint;
            pointsCounter++;
        }

        return points;
    }
}

