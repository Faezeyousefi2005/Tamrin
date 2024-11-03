using System.Numerics;

char key;
BigInteger number = 0;

do
{
    do
    {
        key = Console.ReadKey(true).KeyChar;
    } while (!char.IsDigit(key) && key != '\r');

    if (key != '\r')
    {
        Console.Write(key);
        number = number * 10 + Convert.ToInt32(key.ToString());
    }
} while (key != '\r');

Console.WriteLine();
Console.WriteLine(number);
