namespace Algorithms;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindMaximum(1, 2, 3));
        Console.WriteLine(FindMaximum(8, 8, 1));
        Console.WriteLine(FindMaximum(3, 2, 3));
        Console.WriteLine(FindMaximum(1, 1, 9));
        Console.WriteLine(FindMaximum(1, 9, 9));
    }

    static int FindMaximum(int a, int b, int c)
    {
        if (a > b)
        {
            if (a > c || a == c)
            {
                return a;
            }
        }

        if (b > c)
        {
            if (b > a || a == b)
            {
                return b;
            }
        }

        return c;
    }
}