using System;
using System.Globalization;
using System.Threading;

/// Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
class PrimeChecker
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    private static bool IsPrime(long n)
    {
        long sqrtN = (long)Math.Floor(Math.Sqrt(n));
        if (n == 0 || n == 1)
        {
            return false;
        }
        if (n == 2)
        {
            return true;
        }
        for (long i = 2; i <=sqrtN; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
