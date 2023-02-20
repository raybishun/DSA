using System.Text;

namespace StringReverseAlgo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseString_UsingStringBuilder("hello World"));
        Console.WriteLine(ReverseString_UsingArrayStaticMethod("hello World"));
    }

    static string ReverseString_UsingStringBuilder(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder reversedString = new StringBuilder(input.Length);

        for(int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write($"{input[i]} --> ");
            reversedString.Append(input[i]);
        }

        return reversedString.ToString();
    }

    static string ReverseString_UsingArrayStaticMethod(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return input;
        }
        
        char[] arr = input.ToCharArray();
        Array.Reverse(arr); // *** Does NOT create a new array ***
        return new string(arr);
    }
}
