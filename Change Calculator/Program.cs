namespace Change_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the change calculator");

            String choice;
            do
            {
                //Console.WriteLine("Enter the number of cents: ");
                //int centNum = int.Parse(Console.ReadLine());
                //if (centNum < 0 || centNum > 99)
                //{
                //    Console.WriteLine();
                //}

                int centNum = -1;
                while (centNum < 0 || centNum > 99)
                {
                    Console.Write("Enter the number of cents: ");
                    centNum = int.Parse(Console.ReadLine());
                    if (centNum >= 0 && centNum <= 99)
                    {
                        break; //valid leave loop
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid integer between 0 and 99.");
                    }
                }

                int quarters = centNum / 25;
                centNum %= 25;

                int dimes = centNum / 10;
                centNum %= 10;

                int nickels = centNum / 5;
                centNum %= 5;

                int pennies = centNum;//remainder

                Console.WriteLine("Your coins:");
                Console.WriteLine($"Quarters: {quarters}");
                Console.WriteLine($"Dimes: {dimes}");
                Console.WriteLine($"Nickels: {nickels}");
                Console.WriteLine($"Pennies: {pennies}");

                Console.Write("Would you like to go again? (y/n): ");

                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
        }
    }
}
