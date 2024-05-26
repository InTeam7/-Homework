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
}