using System;

public class Program
{
    public static void Main()
    {
        string? sentence = Console.ReadLine();
        if(sentence is not null && sentence.Trim() != "") {
            Console.WriteLine(ConvertToUpper(sentence));
        } else {
            Console.WriteLine("T'as pas rentré de chaîne de caractère, t'es neuneu ou quoi ?");
        }
    }

    public static string ConvertToUpper(string text)
    {
       return text.ToUpper();
    }
}