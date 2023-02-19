namespace StringSearch;
class Program
{
    static void Main(string[] args)
    {
        string input = "HeLLo";
        
        Console.WriteLine(input.ToLower().Contains("ll"));
        ParseContents(input);
        
        Console.WriteLine($"\n{IsAtEvenIndex(input, 'L')}");
    }

    static void ParseContents(string s)
    {
        Console.WriteLine("Option 1");
        
        foreach (char c in s)
        {
            Console.Write($"{c} ");
        }

        Console.WriteLine("\n\nOption 2");

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            Console.Write($"{c} ");
        }
    }

    static bool IsAtEvenIndex(string s, char item)
    {
        if(string.IsNullOrEmpty(s))
        {
            return false;
        }
        
        for(int i = 0; i < s.Length /2 + 1; i+=2)
        {
            if(s[i] == item)
            {
                Console.WriteLine($"\n\nFound at index: {i}");
                return true;
            }
        }

        return false;
    }
}