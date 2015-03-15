
Problem 1.	Fibonacci Numbers
Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
n	Fib(n)
0	1
1	1
2	2
3	3
4	5
5	8
6	13
11	144
25	121393

Problem 2.	Prime Checker
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
n	IsPrime(n)
0	false
1	false
2	true
3	true
4	false
5	true
323	false
337	true
6737626471	true
117342557809	false

Problem 3.	Primes in Given Range
Write a method that calculates all prime numbers in given range and returns them as list of integers:
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
Examples:
Start number
End number	Output
0
10	2, 3, 5, 7
5
11	5, 7, 11
100 200	101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199
250
950	251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947
100
50	(empty list)

Problem 4.	Difference between Dates
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. Examples:
First date
Second date	Days between
17.03.2014
30.04.2014	44
17.03.2014
17.03.2014	0
14.06.1980
5.03.2014	12317
5.03.2014
3.03.2014	-2

Problem 5.	Point class
Define a simple class Point(x, y) where x is the x value of the point and y is the y value of the point in a Cartesian coordinate system. In your main class, instantiate a couple of points. Example:
static void Main() 
{
    Point a = new Point(20, 30);
    Point b = new Point(0, 100);
}

Problem 6.	*Perimeter and Area of Polygon
Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. Use the input and output format from the examples. To hold the points, define a Polygon class that will hold a List<Points>. The class will also have a methods called getPerimeter() and getArea() that will calculate the Polygon's perimeter and area. Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon. Examples:
Input	Output	Comments
3
0 0
0 1
1 1	perimeter = 3.41
area = 0.50	 
7
-2 1
1 3
5 1
1 2
1 1
3 -2
-2 1	perimeter = 22.64
area = 9.5	 

