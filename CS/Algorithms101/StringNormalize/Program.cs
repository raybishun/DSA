namespace StringNormalize;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(NormalizeString("Hello There, BUDDY!    "));
    }

    static string NormalizeString(string input)
    {
        return input.ToLower().Trim().Replace(",", "");
    }
}
