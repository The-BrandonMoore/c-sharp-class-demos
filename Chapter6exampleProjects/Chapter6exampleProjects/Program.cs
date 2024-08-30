namespace Chapter6exampleProjects
{
    internal class Program
    {

        private static int RandomNumber(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }


        private static void SnakeEyes()
        {

            string snakeEyes = @"

 _______  _        _______  _        _______             _______           _______  _______ 
(  ____ \( (    /|(  ___  )| \    /\(  ____ \           (  ____ \|\     /|(  ____ \(  ____ \
| (    \/|  \  ( || (   ) ||  \  / /| (    \/           | (    \/( \   / )| (    \/| (    \/
| (_____ |   \ | || (___) ||  (_/ / | (__       _____   | (__     \ (_) / | (__    | (_____ 
(_____  )| (\ \) ||  ___  ||   _ (  |  __)     (_____)  |  __)     \   /  |  __)   (_____  )
      ) || | \   || (   ) ||  ( \ \ | (                 | (         ) (   | (            ) |
/\____) || )  \  || )   ( ||  /  \ \| (____/\           | (____/\   | |   | (____/\/\____) |
\_______)|/    )_)|/     \||_/    \/(_______/           (_______/   \_/   (_______/\_______)
                                                                                            

";
            Console.WriteLine(snakeEyes);
        }
        private static void BoxCars() 
        {
            string boxCars = @"

 .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| |   ______     | || |     ____     | || |  ____  ____  | || |     ______   | || |      __      | || |  _______     | || |    _______   | |
| |  |_   _ \    | || |   .'    `.   | || | |_  _||_  _| | || |   .' ___  |  | || |     /  \     | || | |_   __ \    | || |   /  ___  |  | |
| |    | |_) |   | || |  /  .--.  \  | || |   \ \  / /   | || |  / .'   \_|  | || |    / /\ \    | || |   | |__) |   | || |  |  (__ \_|  | |
| |    |  __'.   | || |  | |    | |  | || |    > `' <    | || |  | |         | || |   / ____ \   | || |   |  __ /    | || |   '.___`-.   | |
| |   _| |__) |  | || |  \  `--'  /  | || |  _/ /'`\ \_  | || |  \ `.___.'\  | || | _/ /    \ \_ | || |  _| |  \ \_  | || |  |`\____) |  | |
| |  |_______/   | || |   `.____.'   | || | |____||____| | || |   `._____.'  | || ||____|  |____|| || | |____| |___| | || |  |_______.'  | |
| |              | || |              | || |              | || |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 

";
            Console.WriteLine(boxCars);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller!");

            Console.Write("\nRoll the dice? (y/n):  ");
            string choice = Console.ReadLine().ToLower();
            while (choice == "y")
            {
                //rolling the dice using the created method and printing the results
                int roll1 = RandomNumber(1, 6);
                Console.WriteLine($"\nDie 1: {roll1}");
                int roll2 = RandomNumber(1, 6);
                Console.WriteLine($"Die 2: {roll2}");
                
                //special rolls
                if (roll1 + roll2 == 2)
                {
                    SnakeEyes();
                }
                else if (roll1 + roll2 == 12)
                {
                    BoxCars();
                }
                
                //printing out the total rols
                Console.WriteLine($"Total: {roll1 + roll2}");

                //asking if they want to roll again
                Console.Write("\nRoll Again? (y/n):  ");
                choice = Console.ReadLine().ToLower();
            }







        }
    }
}
