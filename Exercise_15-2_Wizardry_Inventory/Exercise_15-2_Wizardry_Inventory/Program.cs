using System.ComponentModel.Design;

namespace Exercise_15_2_Wizardry_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Wizard Inventory Game");

            // create an empty list of commands
            const int listItemsMaxSize = 3;
            List<string> menuCommands = new List<string> { "show", "grab", "edit", "drop", "exit" };
            List<string> listItems = new List<string>();
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Menu:");
                foreach (string command in menuCommands)
                {
                    Console.WriteLine($"- {command}");
                }

                Console.Write("Command:  ");
                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "show":
                        listItems.ForEach(Console.WriteLine);
                        break;
                    case "grab":
                        if (listItems.Count >= listItemsMaxSize)
                        {
                            Console.WriteLine("You can't carry any more items. Drop something first.");
                        }
                        else
                        {
                            GetString("Name: ");
                            string newItem = Console.ReadLine();
                            if (!string.IsNullOrEmpty(newItem))
                            {
                                listItems.Add(newItem);
                                Console.WriteLine($"Item '{newItem}' added.");
                            }
                            else
                            {
                                Console.WriteLine("Item cannot be empty.");
                            }
                        }
                        break;
                    case "edit":
                        GetString("Number: ");
                        break;
                    case "drop":
                        GetString("Number: ");
                        break;
                    case "exit":
                        Console.WriteLine();
                        break;
                }


                //dlist of commands
                //show - show all items
                //grab - grab an item
                //edit - edit an item
                //exit - Exit program




                //perform selected command








                Console.WriteLine("End");
            }
        }

            private static string GetString(string prompt)
        {
            Console.Write(prompt);
            string strValue = Console.ReadLine();
            return strValue;
        }








    }
}
