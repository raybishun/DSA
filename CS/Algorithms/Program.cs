namespace Algorithms;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindMaximumOptimized(1, 2, 3));
        Console.WriteLine(FindMaximumOptimized(8, 8, 1));
        Console.WriteLine(FindMaximumOptimized(3, 2, 3));
        Console.WriteLine(FindMaximumOptimized(1, 1, 9));
        Console.WriteLine(FindMaximumOptimized(1, 9, 9));
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

    // Optimized algorithim.
    static int FindMaximumOptimized(int a, int b, int c)
    {
        int max = a;

        if(b > max)
        {
            max = b;
        }

        if(c > max)
        {
            max = c;
        }

        return max;
    }
}