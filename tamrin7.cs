using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StringBuilder inputBuilder = new StringBuilder();
        Console.WriteLine("Enter a multi-line text (press Enter on an empty line to finish):");

        while (true)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                break;
            inputBuilder.AppendLine(line);
        }

        string input = inputBuilder.ToString();
        string pattern = @"\b0\d{9}\b";
        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("Valid phone numbers:");
        foreach (Match match in matches)
        {
            string phoneNumber = match.Value;
            if (HasAtLeastTwoDifferentDigits(phoneNumber))
            {
                Console.WriteLine(phoneNumber);
            }
        }
    }

    static bool HasAtLeastTwoDifferentDigits(string number)
    {
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] != number[0])
                return true;
        }
        return false;
    }
}
