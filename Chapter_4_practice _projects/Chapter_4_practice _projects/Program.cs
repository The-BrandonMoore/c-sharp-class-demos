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


           // -----Travel Time Calculator-----
            Console.WriteLine("Welcome to the Travel Time Calculator");

            string choice2 = "y";
            while (choice2.ToLower() == "y")
            {
                Console.Write("\nEnter Miles:            ");
                double distance = double.Parse(Console.ReadLine());
                Console.Write("Enter Miles Per Hour:   ");
                double speed = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEstimated Travel Time");
                Console.WriteLine("---------------------");

                double hours = distance / speed;
                int hoursInt = (int)hours;
                Console.WriteLine("Hours: " + hoursInt);

                double minutes = (int)(((distance / speed) - hoursInt) * 60);               
                int minutes1 = (int)minutes;
                Console.WriteLine("Minutes: " + minutes1);

                Console.Write("\nContinue? (y/n):  ");
                choice2 = Console.ReadLine().ToLower();

            }



            //-----interest paid calclulator----

            Console.WriteLine("Welcome to the Interest Calculator");

            string choice3 = "y";
            while (choice3.ToLower() == "y") 
            {
                Console.Write("\nEnter loan amount:    ");
                double ln_amount = double.Parse(Console.ReadLine());
                string ln_amnt = string.Format("{0:#,#.}", ln_amount);
                Console.Write("Enter interest rate:  ");
                double int_rate = double.Parse(Console.ReadLine());
                double int_rate_formatted = (double)Math.Round(int_rate * 100, 2);
                double int_paid = (double)Math.Round(ln_amount * int_rate, 2);

                Console.WriteLine("Loan Amount:      " + "$" +ln_amount);
                Console.WriteLine("Interest rate:    " + int_rate_formatted + "%");
                Console.WriteLine("Interest:         " + "$" + int_paid);

                Console.WriteLine("\nContinue? (y/n): ");
                choice3 = Console.ReadLine().ToLower();
            }


            //-----change calculator-----








        }
    }
}