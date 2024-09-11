namespace Make_Chocolate_Class_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(MakeChocolate(4, 1, 9));
            Console.WriteLine(MakeChocolate(4, 1, 10));
            Console.WriteLine(MakeChocolate(4, 1, 7));

            Console.WriteLine("Goodbye, World!");
        }
        public static int MakeChocolate(int small, int big, int goal)
        {
            int bigBarKilos = big * 5;                    //convert big bars into kilos
            int smallRequired; 
            int remainingGoal = goal - bigBarKilos;       //subtract big bars from the goal, leaving the required about of small bars in kilos
            int smallBarsRemain = small - remainingGoal;  // subtract the remaining kilos from small bars
            if (smallBarsRemain < 0) 
            {
                smallRequired = -1;                       //if there are more required kilos of chocolate than amount of small bars, return -1 
            }
            else {
                smallRequired = (small - smallBarsRemain); //if there are enough small bars, subtract small input from small bars remaining to get required small bars
            }
            return smallRequired;                          //returns the int
        }
    }
}
