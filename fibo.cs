class Program
{
    static void Main()
    {
        Console.Write("Enter a number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine(n + " is in the Fibonacci sequence.");
        }
        else
        {
            Console.WriteLine(n + " is not in the Fibonacci sequence.");
        }
    }

    static bool IsFibonacci(int number)
    {
        int a = 0;
        int b = 1;

        while (a < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a == number;
    }
}