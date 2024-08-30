using System.ComponentModel.Design;

namespace Project5_2_DataValidation
{
    internal class Program
    {
        //length App for gathering and checking length input as a valid int.
        static private int LengthInt(string prompt, int minVal, int maxVal)
        {
            int lengthNumber = 0;
           
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    lengthNumber = Int32.Parse(Console.ReadLine());
                    if (lengthNumber < minVal)
                    {
                        Console.WriteLine($"Error: number must be greater than {minVal}.");
                    }
                    else if (lengthNumber >= maxVal) {
                        Console.WriteLine($"Error: number must be less than {maxVal}.");
                       
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }

            
            return lengthNumber;
        }

        static private int WidthInt(string prompt, int minVal, int maxVal)
        {
            int widthNumber = 0;

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    widthNumber = Int32.Parse(Console.ReadLine());
                    if (widthNumber < minVal)
                    {
                        Console.WriteLine($"Error: number must be greater than {minVal}.");
                    }
                    else if (widthNumber >= maxVal)
                    {
                        Console.WriteLine($"Error: number must be less than {maxVal}.");

                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }


            return widthNumber;
        }

        static private int Area()
        {
            int area = widthNumber * LengthInt;
        }

        //static private string Continue(string prompt) 




        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Area and Perimeter Calculator");

            LengthInt("Enter length:  ", 1, 1001);
            WidthInt("Enter length:   ", 1, 1001);








        }
    }
}
