using System;
using System.Collections.Generic;

class Path3D
{
    private List<Point3D> points = new List<Point3D>();
    public Path3D(params Point3D[] points)
    {
        this.points.AddRange(points);
    }


    public List<Point3D> Points
    {
        get
        {
            return this.points;
        }
        set
        {
            if (value.Count < 1)
            {
                throw new ArgumentOutOfRangeException("Points", "There are no points entered!");  
            }
            this.points = value;
        }
    }

    public override string ToString()
    {
        string pathStr = "Path: ";
        string[] pathArr = new string[this.Points.Count];

        for (int i = 0; i < this.Points.Count; i++)
        {
            var currPoint = this.Points[i];
            pathArr[i] = currPoint.X + ", " + currPoint.Y + ", " + currPoint.Z;
        }

        pathStr += string.Join("; ", pathArr);
        return pathStr;
    }
}

