namespace Project_5_3_Number_Guess_Game_Sean_Version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Welcome to the Number Guessing Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");

            string choice = "y";
            const int MAX_NUM = 100;
            while (choice == "y")
            {
                //get the random # - theNumber
                int theNumber = GetRandomNumber(MAX_NUM);
                //guess count -- initialize count to 0
                int count = 0;
                //print the game start message
                Console.WriteLine($"I'm thinking of a number from 1 to {MAX_NUM}. \nTry to Guess it.");

                // count ++ incrementer on valid guess.

                //prompt user for guess
                int guess = GetInt("Enter number: ", 1, MAX_NUM);
                int diff = guess - theNumber;
                count++;
                while (guess != theNumber)
                {

                    //check guess against theNumber
                    // - display "way too low", "too low", "way too high", "too high", "you win"
                    /// - - on "you win"  display appropriate winner message (check count)
                    /// if else statement



                }
                choice = getString("Coninue (y/n)? ", "y", "n");
            }









            Console.WriteLine("Play again soon!");
        }

        private static int GetRandomNumber(int maxVal)
        {
            return new Random().Next(1, maxVal);
        }

        private static string getString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
        }

        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");

                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }

            return number;
        }
    }
}






