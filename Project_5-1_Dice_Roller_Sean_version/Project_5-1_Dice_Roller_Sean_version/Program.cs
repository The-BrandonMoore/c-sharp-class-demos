namespace Project_5_1_Dice_Roller_Sean_version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Let's Roll============");

            //start of the while loop is required to get the initial user input -- done by getString method
            //user input -- done by getString method
            string rollDice = getString("\nRoll the dice? (y/n)  ");
            while (rollDice == "y")
            {

                //biz logic -- roll and calculate the sum

                int die1 = getNumber(7);
                int die2 = getNumber(7);


                //display output

                int totalRoll = die1 + die2;

                Console.WriteLine($"Die 1: {die1}");
                Console.WriteLine($"Die 2: {die2}");
                Console.WriteLine($"Total: {totalRoll}");
                if (totalRoll == 2)
                {
                    Console.WriteLine("\nSnake Eyes!");
                }
                else if (totalRoll == 12)
                {
                    Console.WriteLine("\nBox Cars!");


                    //end the while loop

                }
                    rollDice = getString("\nRoll again? (y/n):  ");
            }
                Console.WriteLine("\nMay the odds be ever in your favor!");
            }

            private static string getString(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine().ToLower();
            }
            private static int getNumber(int maxVal)
            {
                return new Random().Next(1, maxVal);
        }
    }
}