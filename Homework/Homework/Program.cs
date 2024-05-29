using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(GetMinX(1, 2, 3));
        Console.WriteLine(GetMinX(0, 3, 2));
        Console.WriteLine(GetMinX(1, -2, -3));
        Console.WriteLine(GetMinX(5, 2, 1));
        Console.WriteLine(GetMinX(4, 3, 2));
        Console.WriteLine(GetMinX(0, 4, 5));


        Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
        Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");

        Console.WriteLine(IsLeapYear(2014));
        Console.WriteLine(IsLeapYear(1999));
        Console.WriteLine(IsLeapYear(8992));
        Console.WriteLine(IsLeapYear(1));
        Console.WriteLine(IsLeapYear(14));
        Console.WriteLine(IsLeapYear(400));
        Console.WriteLine(IsLeapYear(600));
        Console.WriteLine(IsLeapYear(3200));

        TestMove("a1", "d4");
        TestMove("f4", "e7");
        TestMove("a1", "a4");

        Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
        Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
        Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
        Console.WriteLine(MiddleOf(2, 3, 2));
        Console.WriteLine(MiddleOf(8, 8, 8));
        Console.WriteLine(MiddleOf(5, 0, 1));
        Console.WriteLine(MiddleOf(55, 65, 75));

    }
    private static string GetMinX(int a, int b, int c)
    {
        string result = "Impossible";
        if (a >= 0)
        {
            var d = -b / (a * 2.0);
            if (!double.IsInfinity(d))
            {
                result = d.ToString(); // ывф
            }
        }
        return result;
    }
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 400 == 0 || !(year % 100 == 0));
    }

    public static void TestMove(string from, string to)
    {
        Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
    }
    public static bool IsCorrectMove(string from, string to)
    {
        var dx = Math.Abs(to[0] - from[0]); 
        var dy = Math.Abs(to[1] - from[1]); 
        return from != to && (dx == 0 || dy == 0 || dx == dy);
    }
    
    public static int MiddleOf(int a, int b, int c)
    {
        if (a >= b)
        {
            if (a <= c) return a;
            else if (b >= c) return b;
            else return c;
        }
        else if (a <= b)
        {
            if (a >= c) return a;
            else if (b <= c) return b;
            else return c;
        }
        return a;
    }
}