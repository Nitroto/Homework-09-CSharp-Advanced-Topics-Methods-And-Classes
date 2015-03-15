using System.Globalization;
using System.Threading;

/// Define a simple class Point(x, y) where x is the x value of the point and y is the y value
/// of the point in a Cartesian coordinate system. In your main class, instantiate a couple of points.
class PointClass
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Point a = new Point(20, 30);
        Point b = new Point(0, 100);
    }
}
