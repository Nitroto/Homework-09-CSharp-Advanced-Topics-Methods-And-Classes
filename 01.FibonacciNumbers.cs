using System;
using System.Globalization;
using System.Threading;

/// Define a method Fib(n) that calculates the nth Fibonacci number.
class FibonacciNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        long nthFibNum = Fib(n);
        Console.WriteLine(nthFibNum);
    }

    private static long Fib(int n)
    {
        long previousFibNum = 0;
        long currentFibNum = 1;
        for (int i = 0; i < n; i++)
        {
            long nextFibNum = previousFibNum + currentFibNum;
            previousFibNum = currentFibNum;
            currentFibNum = nextFibNum;
        }
        return currentFibNum;
    }
}
