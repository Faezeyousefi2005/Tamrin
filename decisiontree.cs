using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Are you thinking about buying a car? (yes/no)");
        string answer1 = Console.ReadLine();

        if (answer1 == "yes")
        {
            Console.WriteLine("Do you want a new car? (yes/no)");
            string answer2 = Console.ReadLine();

            if (answer2 == "yes")
            {
                Console.WriteLine("Do you have a specific brand in mind? (yes/no)");
                string answer3 = Console.ReadLine();

                if (answer3 == "yes")
                {
                    Console.WriteLine("You can go for that brand.");
                }
                else
                {
                    Console.WriteLine("You can check other brands.");
                }
            }
            else
            {
                Console.WriteLine("Are you looking for a used car? (yes/no)");
                string answer4 = Console.ReadLine();

                if (answer4 == "yes")
                {
                    Console.WriteLine("Do you care about the price? (yes/no)");
                    string answer5 = Console.ReadLine();

                    if (answer5 == "yes")
                    {
                        Console.WriteLine("Do you want an electric car? (yes/no)");
                        string answer6 = Console.ReadLine();

                        if (answer6 == "yes")
                        {
                            Console.WriteLine("This is an electric car.");
                        }
                        else
                        {
                            Console.WriteLine("This is a gasoline car.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Do you want a specific type of car? (yes/no)");
                        string answer7 = Console.ReadLine();

                        if (answer7 == "yes")
                        {
                            Console.WriteLine("Do you want an SUV? (yes/no)");
                            string answer8 = Console.ReadLine();

                            if (answer8 == "yes")
                            {
                                Console.WriteLine("This car is an SUV.");
                            }
                            else
                            {
                                Console.WriteLine("This car is a sedan.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can check other cars.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Maybe you are not ready to buy a car yet.");
                }
            }
        }
        else
        {
            Console.WriteLine("Maybe you are not ready to buy a car yet.");
        }
    }
}
