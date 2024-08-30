namespace Project_15_2_Wizard_Inventory_Seans_version
{
    internal class Program
    {
        //Being placed in "Program", inventory is now a class property, accessible by all methods throughout program. 
        static List<string> inventory = new List<string>();




        static void Main(string[] args)
        {
            Console.WriteLine("It's Wizard Time, Other Buckets!\n");

            //add initial items to inventory
            inventory.Add("wooden staff");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");

            DisplayMenu();
            string command = "";
            while (command != "exit")
            {
                command = GetString("\nCommand: ");
                switch (command)
                {
                    case "menu":
                        DisplayMenu();
                        break;
                    case "show":
                        ShowInventory();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        int itemNum;
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }

            }
            Console.WriteLine("\nBye. Safe Travels Adventurer.");
        }

        private static void DropItem()
        {
            int itemNum;
            //     - drop: remove an item: prompt user for item number/ remove item by number/ display confirmation 
            Console.WriteLine("Drop item like it is hot:");
            Console.WriteLine("=========================");
            itemNum = GetInt("Delete  Item #: ", 1, inventory.Count());
            string delItem = inventory[itemNum - 1];
            inventory.Remove(delItem);
            Console.WriteLine($"{delItem} was dropped.");
        }

        private static void EditItem()
        {
            //     - edit: prompt user for item #/ new item name/ save updated name/ display confirmation
            Console.WriteLine("Edit Item Name:");
            Console.WriteLine("===============");
            int itemNum = GetInt("Edit Item #:", 1, inventory.Count());
            string updatedName = GetString("Updated Item Name:");
            inventory[itemNum - 1] = (updatedName);
            Console.WriteLine($"Item # {itemNum} was updated.");
        }

        private static void GrabItem()
        {
            //       * limit number of items to 4 -> do this later
            Console.WriteLine("Grab an Item");
            Console.WriteLine("============");
            if (inventory.Count() >= 4)
            {
                Console.WriteLine("You can't carry any more items. Please drop an item first.");
            }
            else
            {
                string newItem = GetString("New Item Name: ");
                inventory.Add(newItem);
                Console.WriteLine($"{newItem} was added.");
            }
        }

        private static void ShowInventory()
        {
            Console.WriteLine("Show All Items:");
            Console.WriteLine("===============");
            for (int i = 0; i < inventory.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\nCOMMAND MENU");
            Console.WriteLine("menu - display menu");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program\n");
        }


        // GetInt
        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = Int32.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }

            return number;
        }


        // Get String

        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();

        }







    }
}
