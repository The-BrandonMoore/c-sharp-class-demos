namespace Chapter_4_practice__projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// -----Temperature Converter-----
            //Console.WriteLine("Welcome to the Temperature Converter");

            //string choice = "y";
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter degrees in Farenheit: ");
            //    double temperature = double.Parse(Console.ReadLine());

            //    double temp_In_Celsius = Math.Round(((temperature - 32) * 5 / 9), 2);

            //    Console.WriteLine("Degrees in Celsius :" + temp_In_Celsius);

            //    Console.Write("\nContinue? (y/n)");
            //    choice = Console.ReadLine().ToLower();
            //}


            //// -----Travel Time Calculator-----
            // Console.WriteLine("Welcome to the Travel Time Calculator");

            // string choice2 = "y";
            // while (choice2.ToLower() == "y")
            // {
            //     Console.Write("\nEnter Miles:            ");
            //     double distance = double.Parse(Console.ReadLine());
            //     Console.Write("Enter Miles Per Hour:   ");
            //     double speed = double.Parse(Console.ReadLine());

            //     Console.WriteLine("\nEstimated Travel Time");
            //     Console.WriteLine("---------------------");

            //     double hours = distance / speed;
            //     int hoursInt = (int)hours;
            //     Console.WriteLine("Hours: " + hoursInt);

            //     double minutes = (int)(((distance / speed) - hoursInt) * 60);               
            //     int minutes1 = (int)minutes;
            //     Console.WriteLine("Minutes: " + minutes1);

            //     Console.Write("\nContinue? (y/n):  ");
            //     choice2 = Console.ReadLine().ToLower();

            // }



            //-----interest paid calclulator----

            //Console.WriteLine("Welcome to the Interest Calculator");

            //string choice3 = "y";
            //while (choice3.ToLower() == "y") 
            //{
            //    Console.Write("\nEnter loan amount:    ");
            //    double ln_amount = double.Parse(Console.ReadLine());
            //    string ln_amnt = string.Format("{0:#,#.}", ln_amount);
            //    Console.Write("Enter interest rate:  ");
            //    double int_rate = double.Parse(Console.ReadLine());
            //    double int_rate_formatted = (double)Math.Round(int_rate * 100, 2);
            //    double int_paid = (double)Math.Round(ln_amount * int_rate, 2);

            //    Console.WriteLine("Loan Amount:      " + "$" +ln_amount);
            //    Console.WriteLine("Interest rate:    " + int_rate_formatted + "%");
            //    Console.WriteLine("Interest:         " + "$" + int_paid);

            //    Console.WriteLine("\nContinue? (y/n): ");
            //    choice3 = Console.ReadLine().ToLower();
            //}


            ////--------------Table of Powers---------------

            //Console.WriteLine("Welcome to the Squares and Cubes table");

            //string choice6 = "y";
            //while (choice6.ToLower() == "y")
            //{
            //    Console.Write("\nEnter an integer:  ");
            //    int userNum = int.Parse(Console.ReadLine());

            //    Console.WriteLine(); // blank line

            //    Console.WriteLine("Number\tSquared\tCubed"); //   \t is a tab between data
            //    Console.WriteLine("======\t=======\t=====");

            //    for (int i = 1; i <= userNum; i++)
            //    {
            //        int squared = i * i;
            //        int cubed = i * i * i;
            //        Console.WriteLine($"{i}\t{squared}\t{cubed}");
            //    }

            //    Console.WriteLine("\nContinue? (y/n): ");
            //    choice6 = Console.ReadLine().ToLower();

            //}



            //-----TIP calculator----- 4 - 3 exercise



            //Console.WriteLine("\nTip Calculator");

            //string choice4 = "y";

            //while (choice4 == "y")
            //{

            //    Console.Write("\nCost of Meal:  ");
            //    double mealCost = double.Parse(Console.ReadLine());

            //    //15 % calclulation
            //    Console.WriteLine("\n15%");
            //    double fifteen = Math.Round(mealCost * .15, 2);
            //    Console.WriteLine("Tip amount:     $" + fifteen);
            //    double totalFifteen = Math.Round(fifteen + mealCost, 2);
            //    Console.WriteLine("Total aount:    $" + totalFifteen);

            //    //20 % Calculation
            //    Console.WriteLine("\n20%");
            //    double twenty = Math.Round(mealCost * .2, 2);
            //    Console.WriteLine("Tip amount:     $" + twenty);
            //    double totalTwenty = Math.Round(twenty + mealCost, 2);
            //    Console.WriteLine("Total aount:    $" + totalTwenty);

            //    //25% calclulation
            //    Console.WriteLine("\n25%");
            //    double twentyFive = Math.Round(mealCost * .25, 2);
            //    Console.WriteLine("Tip amount:     $" + twentyFive);
            //    double totalTwentyFive = Math.Round(twentyFive + mealCost, 2);
            //    Console.WriteLine("Total aount:    $" + totalTwentyFive);

            //    Console.Write("\nContinue? (y/n):  ");
            //    choice4 = Console.ReadLine().ToLower();
            //}

            //------------ Common Divisor Finder-------------


            string choice5 = "y";
            while (choice5 == "y")
            {
                Console.Write("Enter first number:  ");
                int firstNum = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int secondNum = int.Parse(Console.ReadLine());

                   // do the math part
                if (firstNum > secondNum)
                {
                    while (firstNum > secondNum)
                    {
                        firstNum = firstNum - secondNum;
                    }
                }
                else if (secondNum > firstNum)
                {
                    while (secondNum > firstNum)
                    {
                        secondNum = secondNum - firstNum;
                    }
                }

                   // swap the values
                if (firstNum > secondNum)
                {
                    while (firstNum > secondNum)
                    {
                        firstNum = firstNum - secondNum;
                    }
                }
                else if (secondNum > firstNum)
                {
                    while (secondNum > firstNum)
                    {
                        secondNum = secondNum - firstNum;
                    }
                }
                    // print the divisor
                if (firstNum > secondNum)
                {
                    Console.WriteLine("\nGreatest common divisor: " + secondNum);
                }
                else
                {
                    Console.WriteLine("\nGreatest common divisor: " + firstNum);
                }
                Console.Write("\nContinue? (y/n):  ");
                choice5 = Console.ReadLine().ToLower();
            }
        }
    }
}