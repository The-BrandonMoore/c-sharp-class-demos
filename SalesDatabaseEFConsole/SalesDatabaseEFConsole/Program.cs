using SalesDatabaseEFConsole.Db;
using SalesDatabaseEFConsole.Models;

namespace SalesDatabaseEFConsole
{
    internal class Program
    {
        static CustomerDb customerDb = new();
        static RegionDb regionDb = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sales Database Program!");

            string keepGoing = "y";
            while (keepGoing == "y")
            {//Main Menu While Loop beginning
                DisplayMainMenu();
                string mainMenuCommand = PromptInput("\nPlease Enter a Menu Command: ");

                switch (mainMenuCommand)
                {//Main Menu Switch Case beginning
                    case "customer":
                        bool customerGoBack = false;
                        while (customerGoBack == false)
                        {
                            DisplayCustomerMenu();
                            string customerMenuCommand = PromptInput("\nPlease Enter a Menu Command: ");
                            switch (customerMenuCommand)
                            {//Customer Menu switch case beginning
                                case "list":
                                    ListCustomers();
                                    break;
                                case "get":
                                    GetCustomer();
                                    break;
                                case "add":
                                    AddCustomer();
                                    break;
                                case "del":
                                    RemoveCustomer();
                                    break;
                                case "back":
                                case "exit":
                                    customerGoBack = true;
                                    break;
                                default:
                                    Console.WriteLine("Please Enter a valud menu command");
                                    break;
                            }//Customer Menu switch case end
                        }//end of customer Menu while loop
                        break;
                    case "region":
                        bool regionGoBack = false;
                        while (regionGoBack == false)
                        {//Region while loop beginning
                            DisplayRegionMenu();
                            string regionMenuCommand = PromptInput("\nPlease Enter a Menu Command: ");
                            switch (regionMenuCommand)
                            {//Region switch case beginning
                                case "list":
                                    ListRegions();
                                    break;
                                case "get":
                                    GetRegion();
                                    break;
                                case "add":
                                    AddRegion();
                                    break;
                                case "del":
                                    RemoveRegion();
                                    break;
                                case "back":
                                case "exit":
                                    regionGoBack = true;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid menu command");
                                    break;
                            }//Region switch case end
                        }//Region while loop end
                        break;
                    case "exit":
                        keepGoing = "n";
                        break;
                    default:
                        Console.WriteLine("Please enter a valid Menu command.");
                        break;
                }//Main Menu switch case end
            }//Main Menu while loop end
            Console.WriteLine("BYE");
        }

        //CUSTOMER CRUD
        static void ListCustomers()
        {
            Console.WriteLine("\nCustomer List");
            Console.WriteLine("=============\n");
            List<Customer> customers = customerDb.GetCustomers();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
        static void GetCustomer()
        {
            Console.WriteLine("\nGet Customer by ID number");
            Console.WriteLine("=====================");
            int id = int.Parse(PromptInput("Customer ID: "));
            Customer c = customerDb.FindCustomer(id);
            if (c != null)
            {
                Console.WriteLine($"Customer Found: {c}");
            }
            else
            {
                Console.WriteLine($"No Customer found for ID: {id}");
            }
        }
        static void AddCustomer()
        {//begin AddCustomer Method

            string name = PromptInput("\nEnter Customer Name: ");
            Customer c = new Customer(name);
            customerDb.AddCustomer(c);
            Console.WriteLine($"Customer Added: {c}");
        }//End AddCustomer Method

        static void RemoveCustomer()
        {
            Console.WriteLine("\nRemove Customer");
            Console.WriteLine("=============");
            int id = int.Parse(PromptInput("Customer ID: "));
            Customer c = customerDb.FindCustomer(id);
            if (c != null)
            {
                customerDb.RemoveCustomer(c);
            }
            else
            {
                Console.WriteLine($"No Customer found for ID: {id}");
            }
            Console.WriteLine("Customer Successfully Removed from Database");

        }

        //REGION CRUD
        static void ListRegions()
        {
            Console.WriteLine("\nRegion List");
            Console.WriteLine("=============\n");
            List<Region> regions = regionDb.GetRegion();
            foreach (Region region in regions)
            {
                Console.WriteLine(region);
            }
        }
        static void GetRegion()
        {
            Console.WriteLine("\nGet Region by ID number");
            Console.WriteLine("=====================");
            int id = int.Parse(PromptInput("Region ID: "));
            Region r = regionDb.FindRegion(id);
            if (r != null)
            {
                Console.WriteLine($"Region Found: {r}");
            }
            else
            {
                Console.WriteLine($"No Region found for ID: {id}");
            }
        }
        static void AddRegion()
        {//begin AddCustomer Method

            string name = PromptInput("\nEnter Region Name: ");
            Region r = new Region(name);
            regionDb.AddRegion(r);
            Console.WriteLine($"Region Added: {r}");
        }//End AddCustomer Method

        static void RemoveRegion()
        {
            Console.WriteLine("\nRemove Region");
            Console.WriteLine("=============");
            int id = int.Parse(PromptInput("Region ID: "));
            Region r = regionDb.FindRegion(id);
            if (r != null)
            {
                regionDb.RemoveRegion(r);
            }
            else
            {
                Console.WriteLine($"No Region found for ID: {id}");
            }
            Console.WriteLine("Region Successfully Removed from Database");

        }

        //GENERIC METHODS
        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            string choice = Console.ReadLine().ToLower();
            return choice;
        }

        //MENUS
        static void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("=========");
            Console.WriteLine("customer - enter customer menu");
            Console.WriteLine("region - enter region menu");
            Console.WriteLine("exit - exit application");
        }

        static void DisplayCustomerMenu()
        {
            Console.WriteLine("\nCustomer Menu");
            Console.WriteLine("=========");
            Console.WriteLine("list - list all customers");
            Console.WriteLine("get - get a customer by ID number");
            Console.WriteLine("add - add a customer");
            Console.WriteLine("del - delete a customer");
            Console.WriteLine("back - back to the main menu");
        }

        static void DisplayRegionMenu()
        {
            Console.WriteLine("\nRegion Menu");
            Console.WriteLine("=========");
            Console.WriteLine("list - list all regions");
            Console.WriteLine("get - get a region by ID number");
            Console.WriteLine("add - add a region");
            Console.WriteLine("del - delete a region");
            Console.WriteLine("back - back to the main menu");
        }


    }
}