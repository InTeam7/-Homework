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


        Console.WriteLine(RemoveStartSpaces("a"));
        Console.WriteLine(RemoveStartSpaces(" b"));
        Console.WriteLine(RemoveStartSpaces(" cd"));
        Console.WriteLine(RemoveStartSpaces(" efg"));
        Console.WriteLine(RemoveStartSpaces(" text"));
        Console.WriteLine(RemoveStartSpaces(" two words"));
        Console.WriteLine(RemoveStartSpaces("  two spaces"));
        Console.WriteLine(RemoveStartSpaces("	tabs"));
        Console.WriteLine(RemoveStartSpaces("		two	tabs"));
        Console.WriteLine(RemoveStartSpaces("                             many spaces"));
        Console.WriteLine(RemoveStartSpaces("               "));
        Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));

        Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
        Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
        Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
        Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
        Console.WriteLine(GetMinPowerOfTwoLargerThan(100));

        WriteTextWithBorder("Menu:");
        WriteTextWithBorder("");
        WriteTextWithBorder(" ");
        WriteTextWithBorder("Game Over!");
        WriteTextWithBorder("Select level:");

        GetFirstEvenNumbers(3);

        int[] arr = new int[] { 1, 2, 3, 4, 5, 1, 1, 1, 5 };
        GetElementCount(arr, 2);

        double[] array = new double[] { 1.12, 2.22, 67.1, 100.21, 987.1 };
        MaxIndex(array);

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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
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

    public static string RemoveStartSpaces(string text)
    {
        int index = 0;
        while (char.IsWhiteSpace(text[index]))
        {
            index++;
            if (index == text.Length)
            {
                return null;
            }
        }
        return text.Substring(index);
    }


    private static int GetMinPowerOfTwoLargerThan(int number)
    {
        int result = 1;
        while (!(result > number)) 
        {
            result *= 2;
        }
        return result;
    }

    private static void WriteTextWithBorder(string text)
    {
        string upAndDown = "";
        for (int i = 0; i < text.Length; i++)
        {
            upAndDown += "-";
        }
        Console.WriteLine($"+-{upAndDown}-+");
        Console.WriteLine($"| {text} |");
        Console.WriteLine($"+-{upAndDown}-+");
    }
    public static int[] GetFirstEvenNumbers(int count)
    {
        int[] evenNumbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            evenNumbers[i] = (i+1) *2;
            Console.WriteLine(evenNumbers[i]);
        }
        return evenNumbers;
    }
    public static int GetElementCount(int[] arr, int itemToCount)
    {
        int count = 0;
        for (int i = 0; itemToCount < i; i++)
        {
            if (arr[i] == itemToCount) 
            { 
                count++;
                
            }
            Console.WriteLine(count);
        }
        return count;
    }
    public static double MaxIndex(double[] array)
    {
        double maxNumber = 0;
        int indexOfNumb = 0;
        for (double i = 0; array.Length > i; i++)
        {
            if (maxNumber < array[(int)i])
            {
                maxNumber = array[(int)i];
                indexOfNumb = (int)i;
            }
        }
        Console.WriteLine(maxNumber);
        Console.WriteLine(indexOfNumb);
        return maxNumber;
    }
}