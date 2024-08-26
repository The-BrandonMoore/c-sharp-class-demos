namespace Demo01StringsInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Strings and Ints demo!");
            //this is a single line comment

            /*multi
             * line
             * comment
             * boom
             */

            //thisIsCamelCase - used for local variables
            //PascalCase or TitleCase - used for Method names and Properties
            //this-is-spinal-case
            //this_is_snake_case

            //variable type (int); variable name (counter) = 1 (the variable value)
            //int counter = 1;

            //Console.WriteLine("Counter is " + counter);



            ////double
            //double price = 32.99;
            //int units = 5;

            //double lineTotal = price * units;
            //double lineTotalRounded = Math.Round(lineTotal, 2);

            //Console.WriteLine("price * units = " + lineTotal);
            //Console.WriteLine("price * units = " + lineTotalRounded);

            //// what about decimal type?
            //decimal price2 = 32.99m;
            //decimal lineTotal2 = price2 * units;
            //Console.WriteLine("lineTotal 2 = " + lineTotal2);

            ////string literal 
            //string helloString = "Hello, ";
            ////string from user input
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();   

            ////print output
            //Console.WriteLine(helloString + name);


            // get numbers from console

            Console.WriteLine("========= get numbers =========");
            Console.Write("Enter a whole number: ");
            int nbr1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a decimal number: ");
            double nbr2 = Double.Parse(Console.ReadLine());
            double product1 = nbr1 * nbr2;
            Console.WriteLine("product 1 = " + product1);

            Console.WriteLine("If Else Statements");
            //if nbr1 > 10 print "greater than 10"
            //else if nbr < 0 print "less than 0"
            //else print "between 0 and 10"

            if (nbr1 > 10)
            {
                Console.WriteLine("Greater than 10");
            }
            else if (nbr1 < 0)
            {
                Console.WriteLine("less than 0");
            }
            else
            {
                Console.WriteLine("between 0 and 10");
            }


            //while loop
            Console.WriteLine("--While Loop: continue until the user enters 'n'--");
            string choice = "";
            while (choice.ToLower() != "n")
            {
                Console.WriteLine("You entered: " + choice);
                Console.Write("Do you want to continue: (y/n)");
                choice = Console.ReadLine();
            }

            




            Console.WriteLine("Bye!");
        }
    }
}