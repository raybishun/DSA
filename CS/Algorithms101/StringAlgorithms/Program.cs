using System;
using System.Linq;

namespace StringAlgorithms;
class Program
{
    // Validation algorithm using All() and Any() from LINQ.
    
    static void Main(string[] args)
    {
        // Console.WriteLine(IsUpperCase("hello"));
        // Console.WriteLine(IsUpperCase("HELLO"));
        // Console.WriteLine(IsLowerCase("hello"));
        // Console.WriteLine(IsLowerCase("HELLO"));

        Console.WriteLine(IsPasswordComplex("P@ssw0rd"));
    }

    static bool IsUpperCase(string s)
    {
        // if(s.All(char.IsUpper))
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
        
        return s.All(char.IsUpper);
    }

    static bool IsLowerCase(string s)
    {
        return s.All(char.IsLower);
    }

    static bool IsPasswordComplex(string s)
    {
        return s.Any(char.IsUpper) 
            && s.Any(char.IsLower) 
            && s.Any(char.IsDigit)
            && s.Any(char.IsPunctuation);
    }
}
