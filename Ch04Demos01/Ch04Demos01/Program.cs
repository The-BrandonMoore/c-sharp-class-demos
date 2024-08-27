namespace Ch04Demos01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Chapter 4 Demos");

            //Constants pp. 96-97
            //Constants are variables with values that CANNOT BE CHANGED.
            const int DaysInNovember = 30;
            //Heres how Sean sees this done almost always
            //must be defined and initialized on the same line.
            const int DAYS_IN_WEEK = 7;

            const int HOURS_IN_DAY = 24;

            //binary operators pp. 98
            // add, subtract, multiply, divide, modulus -- all reaquire two numbers to operate, hence binary
            int a = 5;
            int b = 12;

            int c = a + b; // + is a binary operator.
            int d = b - a; // - is a binary operator.
            int e = b / a;
            int f = b % a; // Modulus operator is the remainder operator

            //String Interpolation
            Console.WriteLine($"a = {a}");//String interpolation (pp 288ff)-- easier way to concatenate
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"f = {f}");


            //doubles is a number with decimal places

            double g = 13;
            double h = 5;
            double i = g / h;
            Console.WriteLine($"i = {i}");

            //unary operators pp. 98
            int count = 0;
            Console.WriteLine($"count: {count}");
            count++;
            Console.WriteLine($"count: {count}");

            //compound assignment operators pp. 101
            count += 5;
            Console.WriteLine($"count: {count}");
            count += 2;
            Console.WriteLine($"count: {count}");
            // equivalent to . . .
            count = count + 10;
            Console.WriteLine($"count: {count}");

            //Math Class pp. 106-107
            double interestRate = .078453;
            Console.WriteLine($"interestRate: {interestRate}");
            
            // round to 2 decimal places

            double interestRateRounded = Math.Round(interestRate, 4);
            Console.WriteLine($"interestRateRounded: {interestRateRounded}");


            //formatting p. 121

            //format as percentage
            Console.WriteLine($"interestRate - formatted: " +  
                $"{interestRate.ToString("p1")}"); //7.9%

            Console.WriteLine($"interestRate - formatted: " +
                $"{interestRate.ToString("p2")}"); //7.85%

            //format currency
            decimal price1 = 34.99m;
            Console.WriteLine($"price1: {price1}");
            Console.WriteLine($"price1 - formatted: : " +
                $"{price1.ToString("c")}");





            Console.WriteLine("bye");
        }
    }
}