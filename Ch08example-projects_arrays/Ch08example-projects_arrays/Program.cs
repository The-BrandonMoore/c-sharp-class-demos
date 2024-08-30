using System.Globalization;
using System.Numerics;

namespace Ch08example_projects_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chapter 8- Arrays and Collections!");

            // p. 230 One Dimensional Arrays
            // p. 231 Basic Array Demos
            string[] names = { "Sean", "Brandon", "Chris", "Holly", "Sarika", "Brendan", "Graham", "Graydon" };
            int[] numbers = new int[10];//empty array


            // p. 233 Assigning Values to Arrays
            // Add numbers to array
            numbers[0] = 2;
            numbers[1] = 4;
            numbers[2] = 6;
            numbers[3] = 8;
            numbers[4] = 10;
            numbers[5] = 12;
            numbers[6] = 14;


            // Assigning and Creating at the same time
            decimal[] prices = { 25.00m, 14.25m, 9.99m, 1.49m, 99.99m };


            // p. 235 Working w/ Arrays - average, populating
            decimal sum = prices[0] + prices[1] + prices[2] + prices[3] + prices[4];

            decimal avgPrice = sum / prices.Length;

            //For Loop loop through numbers array, print each number, and add it to a sum
            int total = 0;

            for (int i = 0; i < numbers.Length; i++) 
            { 
                Console.WriteLine($"i: {i} - numbers[{i}] = {numbers[i]}");
                total += numbers[i];
            }
            Console.WriteLine($"total: {total}");

            // p. 237 For each loop
            //loop through names, printing each name

            foreach (string name in names)
            {
                Console.WriteLine(name);   
            }

            // add new name to names array
            for (int i = 0;i < names.Length;i++)
            {
                Console.WriteLine($"names[{i}]: {names[i]}");
            }
            //cannot change the size of an array once it's been defined. Cannot just add another person on the end

            // p. 239 Rectangular Arrays -- basically a table
            //create a 2x2 array of our names w/ a header
            string[,] namesTable = new string[5, 2];
            namesTable[0, 0] = "First";
            namesTable[0, 1] = "Last";

            // p. 241 Working with the Numbers Array

            // p. 243 Arrays Class

            // p. 245 Reference to an Array

            // p. 247 

            // p. 249

            // p. 251 More ways to refer to Array elements

            // p. 253 List patterns

            // p. 257 Collections

            // p. 259 List implementations

            // p. 261 List examples

            // p. 263 Create and load a sorted list

            // p. 265 Looking up values based on key

            // p. 267 Queues

            // p. 269 Using ArrayLists

            Console.WriteLine("Bye");
        }
    }
}
