namespace Project_5_2_Data_Validation_Sean_Version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Validator App!");

            const double MIN_DOUBLE_VALUE = 1;
            const double MAX_DOUBLE_VALUE = double.MaxValue;

            //while loop start - choice variable

            string choice = "y";
            while (choice == "y")
            {


                // get input
                // validation:
                /// entries must be doubles
                /// must be greater than 0/no negatives and no 0s
                double length = GetDouble("Enter length: ", MIN_DOUBLE_VALUE, MAX_DOUBLE_VALUE);
                double width = GetDouble("Enter width:   ", MIN_DOUBLE_VALUE, MAX_DOUBLE_VALUE); ;

                //business logic
                double area = length * width;
                double perimeter = (2 * length) + (2 * width);

                //display output
                //== area and permeter
                Console.WriteLine($"Area:      {area}");
                Console.WriteLine($"Perimeter: {perimeter}");



                //while loop end
                //validate the choice (y/n) cannot be empty
                choice = getString("Continue (y/n)?  ", "y", "n");
            }

            Console.WriteLine("Bye");
        }

        //double validation 
        private static double GetDouble(string prompt, double min, double max)
        {
            double number = 0.0;
            Boolean isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = Double.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid Entry: number less than min ({min})");
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid Entry: number greater than max ({max})");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Entry: please enter a valid double.");
                    continue;
                }
            }


            return number;
        }

        //string validation for the while loop
        // get a required string (empty value not accepted) that is either s1 or s2
        private static string getString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Entry required.");
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Please enter either '{s1}' or '{s2}'");
                }
                else
                {
                    break;
                }
            }



            return strValue;
        }

    }
}
