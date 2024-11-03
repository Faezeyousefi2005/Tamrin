class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the ending number (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime numbers between {0} and {1}:", n, m);

        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
