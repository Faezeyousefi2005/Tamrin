class Program
{
    static void Main()
    {
        Console.Write("Please enter the first number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (n > m)
        {
            int temp = n;
            n = m;
            m = temp;
        }

        Console.WriteLine("Mirror numbers between " + n + " and " + m + " are:");

        for (int i = n; i <= m; i++)
        {
            if (IsMirror(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsMirror(int number)
    {
        string str = number.ToString();
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);

        return str == reversedStr;
    }
}