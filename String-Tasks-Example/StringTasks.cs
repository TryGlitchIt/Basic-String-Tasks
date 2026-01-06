using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

public class StringTasks
{
    public static string GetMiddle(string input)
    {
        int length = input.Length;
        int middle = length / 2;
        return (length % 2 == 0) 
            ? input.Substring(middle - 1, 2)
            : input.Substring(middle, 1);
    }

    public static string ReverseWords(string sentence)
    {
        var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    public static string CamelToKebab(string input)
    {
        return string.Concat(input.Select((c, i) => i > 0 && char.IsUpper(c) 
            ? "-" + char.ToLower(c).ToString() 
            : char.ToLower(c).ToString()));
    }

    public static string KebabToCamel(string input)
    {
        var parts = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
        return parts[0] + string.Concat(parts.Skip(1).Select(p => char.ToUpper(p[0]) + p.Substring(1)));
    }

    public static void BuildWithString()
    {
        var stopwatch = Stopwatch.StartNew();
        string result = "";
        for (int i = 1; i <= 100000; i++)
        {
            result += i.ToString();
        }
        stopwatch.Stop();
        Console.WriteLine($"BuildWithString time: {stopwatch.ElapsedMilliseconds} ms");
    }

    public static void BuildWithStringBuilder()
    {
        var stopwatch = Stopwatch.StartNew();
        var sb = new StringBuilder();
        for (int i = 1; i <= 100000; i++)
        {
            sb.Append(i);
        }
        stopwatch.Stop();
        Console.WriteLine($"BuildWithStringBuilder time: {stopwatch.ElapsedMilliseconds} ms");
    }
}
