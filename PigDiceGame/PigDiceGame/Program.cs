namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPigDice();
            
            bool gameOver = false;
            while (!gameOver)
            {

                Console.Write("\n# of times to play?: ");
                int numberOfGames = int.Parse(Console.ReadLine()); //number of times the player chooses to play

                
                Console.WriteLine("\nHere we go...");    

                int gameCounter = 0; //counts the number of games played
                int rollSum = 0;     //adds up the total of all rolls in a game
                int rollCounter = 0; //counts number of rolls in a game
                int highScore = 0;   //keeps track of the highest total sum 

                for (int i = 0; i < numberOfGames; i++)
                {
                    rollSum = 0;        //rollSum here to reset after each game
                    rollCounter = 0;    //rollCounter here to reset after each game
                    while (true)         //the while true loop keeps rolling until a 1 is rolled
                    {
                        int rollNumber = Roll();
                        if (rollNumber > 1)
                        {
                            rollSum += rollNumber;
                            rollCounter++;
                        }
                        else
                        {
                            highScore = Math.Max(highScore, rollSum); //makes highscore the higher of either "highscore" or "rollSum"
                            gameCounter++;
                            break;
                        }
                    }
                }
                Console.WriteLine($"We Played {gameCounter} games!");
                Console.WriteLine($"Highest Score is {highScore}");
                string rollAgain = RollAgainChoice();
                if (rollAgain == "y")
                {
                    gameOver = false;
                }
                else if (rollAgain == "n")
                {
                    gameOver = true;
                }



            }



            Console.WriteLine("Never tell me the odds!");
        }

        private static string RollAgainChoice()
        {
            string rollDie;
            rollDie = getString("\nPlay Again? (y/n):  ", "y", "n");
            
            return rollDie;
        }

        private static int Roll()
        {
            int dieRoll = new Random().Next(1, 7);
            //Console.WriteLine($"Roll: {dieRoll}");  test for roll function
            return dieRoll;
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


        private static void PrintPigDice()
        {
            string pigDice = @"
.______    __    _______     _______   __    ______  _______ 
|   _  \  |  |  /  _____|   |       \ |  |  /      ||   ____|
|  |_)  | |  | |  |  __     |  .--.  ||  | |  ,----'|  |__   
|   ___/  |  | |  | |_ |    |  |  |  ||  | |  |     |   __|  
|  |      |  | |  |__| |    |  '--'  ||  | |  `----.|  |____ 
| _|      |__|  \______|    |_______/ |__|  \______||_______|  
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 ===========================================================
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
";
            Console.WriteLine(pigDice);
        }

    }
}
