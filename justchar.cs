char key;

do
{
    key = Console.ReadKey(true).KeyChar;

    if (!char.IsDigit(key) && key != '\r')
    {
        Console.Write(key);
    }

} while (key != '\r');

Console.WriteLine();