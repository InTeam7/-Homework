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


        Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
        Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
        Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
        Console.WriteLine(MiddleOf(2, 3, 2));
        Console.WriteLine(MiddleOf(8, 8, 8));
        Console.WriteLine(MiddleOf(5, 0, 1));
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