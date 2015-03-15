using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

/// Write a method that calculates all prime numbers in given range and returns them as list of integers:
/// static List<int> FindPrimesInRange(startNum, endNum)
/// {
///    …
/// }
/// Write a method to print a list of integers.Write a program that enters two integer numbers(each at a separate line) and 
/// prints all primes in their range, separated by a comma.

class PrimesInGivenRange
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        List<int> primes = FindPrimesInRange(start,end);
        PrintPrimes(primes);

    }
    private static void PrintPrimes(List<int> primes)
    {
        for (int i=0;i<primes.Count;i++)
        {
            if (i < primes.Count - 1)
            {
                Console.Write("{0}, ", primes[i]);
            }
            else
            {
                Console.Write("{0}", primes[i]);

            }
        }
        Console.WriteLine();
    }
    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum;i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    private static bool IsPrime(int n)
    {
        int sqrtN = (int)Math.Floor(Math.Sqrt(n));
        if (n == 0 || n == 1)
        {
            return false;
        }
        if (n == 2)
        {
            return true;
        }
        for (int i = 2; i <= sqrtN; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
