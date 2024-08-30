namespace Project_5_3_GuessingGame
{
    internal class Program
    {
        static private int SecretNumber(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }

        static private int PromptGuess(string prompt)
        {
            Console.Write(prompt);
            int guess = int.Parse(Console.ReadLine());
            
            Boolean validEntry = false;
            while (!validEntry) { 
                guess = PromptGuess(prompt);
                if (guess < 1) {
                    Console.WriteLine($"Error! Your guess should be between 1 and 100!");
                }
                else if (guess > 101) {
                    Console.WriteLine($"Error! Your guess should be between 1 and 100!");
                }
                else {
                    validEntry = true;
                }



            }
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("    Welcome to the Guess the Number Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("\nI'm thinking of a number from 1 to 100.");Console.WriteLine("Welcome to the Guess the Number Game");
            Console.WriteLine("Try to guess it.");

            int secretNumber = SecretNumber(1, 101);
            int guess = PromptGuess("Enter Number: ");
             

            Console.WriteLine(guess);

            
            
        }
    }
}
