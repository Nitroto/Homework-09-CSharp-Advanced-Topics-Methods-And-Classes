using System;
using System.Collections.Generic;

class Polygon
{
    public List<Point> Points { get; set; }
    public Polygon()
    {
        this.Points = new List<Point>();
    }
    public double GetPerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < this.Points.Count; i++)
        {
            int j = (i + 1) % this.Points.Count;
            perimeter += Point.GetLineLenght(this.Points[i], this.Points[j]);
        }
        return perimeter;
    }
    public double GetArea()
    {
        double area = 0;
        for (int i = 0; i < this.Points.Count; i++)
        {
            int j = (i + 1) % Points.Count;
            area += (this.Points[i].X * this.Points[j].Y) - (this.Points[i].Y * this.Points[j].X);
        }
        area = Math.Abs(area / 2);
        return area;
    }
}
