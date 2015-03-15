using System;
using System.Globalization;
using System.Linq;
using System.Threading;

/// Write a program that calculates the perimeter and the area of given polygon (not necessarily convex)
/// consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal
/// digits after the decimal point. Use the input and output format from the examples. To hold the points,
/// define a Polygon class that will hold a List<Points>. The class will also have a methods called getPerimeter()
/// and getArea() that will calculate the Polygon's perimeter and area. Find in Internet how to calculate the
/// polygon perimeter and how to calculate the area of a polygon.
class MainClass
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        Polygon polygon = new Polygon();
        for (int i = 0; i < n; i++)
        {
            double[] coordinates = Console.ReadLine().Split().Select(c => double.Parse(c)).ToArray();
            double x = coordinates[0];
            double y = coordinates[1];
            polygon.Points.Add(new Point(x, y));
        }
        Console.WriteLine("perimeter = {0:F2}", polygon.GetPerimeter());
        Console.WriteLine("area = {0:F2}", polygon.GetArea());
    }
}
