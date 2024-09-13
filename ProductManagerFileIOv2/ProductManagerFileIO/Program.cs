using ProductManagerFileIOv2.DB;
using ProductManagerFileIOv2.Models;

namespace ProductManagerFileIOv2
{
    internal class Program
    {
        public static ProductDB ProductDB = new ProductDB();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App!");

            // LOAD PRODUCTS FROM FILE - into products list


            DisplayMenu();

            string command = "";
            while (command != "exit")
            {
                Console.Write("\nCommand: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "list":
                        ListProducts();
                        break;
                    case "get":
                        GetProduct();
                        break;
                    case "add":
                        AddProduct();
                        break;
                    case "del":
                        DeleteProduct();
                        break;
                    case "menu":
                        DisplayMenu();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

            Console.WriteLine("Bye");
        }
        static void ListProducts()
        {
            Console.WriteLine("\nProduct List:");
            //Console.WriteLine("Method Not Yet Implemented");
            for (int i = 0; i < ProductDB.GetProducts().Count; i++)
            {
                Console.WriteLine($"Product: Code - {ProductDB.GetProducts()[i].Code} | Description - {ProductDB.GetProducts()[i].Description} | {ProductDB.GetProducts()[i].Price}");
            }
        }

        public static void GetProduct()
        {
            Console.WriteLine("\nGet Product By Code:");
            //Console.WriteLine("Method Not Yet Implemented");

            // find product in list, by code
            bool getNewProductCode = false;
            while (getNewProductCode != true)
            {
                // prompt user for code
                string checkerString = "n";
                Console.Write("Enter Product Code:  ");
                string userEnteredProductCode = Console.ReadLine().ToUpper();
                if (userEnteredProductCode == "BACK")
                {
                    getNewProductCode = true;
                    break;
                }
                foreach (Product p in ProductDB.GetProducts())
                {
                    if (p.Code == userEnteredProductCode)
                    {
                        // display product
                        Console.WriteLine(p);
                        getNewProductCode = true;
                        checkerString = "y";
                        break;
                    }
                }
                if (checkerString == "n")
                {
                    Console.WriteLine($"Product Code {userEnteredProductCode} not found.");
                    Console.WriteLine("Please Enter a Valid Product Code: ");
                    getNewProductCode = false;
                }
            }
        }

        public static void AddProduct()
        {
            bool goBackLoop = false;
            while (!goBackLoop)
            {
                Console.WriteLine("\nAdd a New Product:");
                //Console.WriteLine("Method Not Yet Implemented");
                // prompt user for code, desc, price
                Console.Write("Please Enter the New Product Code:         ");
                string newProductCode = Console.ReadLine().ToUpper();
                if (newProductCode == "BACK")
                {
                    goBackLoop = false;
                    break;
                }
                Console.Write("Please Enter the New Product Description:  ");
                string newProductDescription = Console.ReadLine();
                Console.Write("Please Enter the New Product Price:        ");
                decimal newProductPrice = decimal.Parse(Console.ReadLine());
                // create new instance of product
                Product newProduct = new(newProductCode, newProductDescription, newProductPrice);
                // add product to list
                ProductDB.GetProducts().Add(newProduct);
                Console.WriteLine($"\n{newProduct.Description} Successfully Added");
                // SAVE PRODUCT FILE
                ProductDB.SaveProductFile();
                break;
            }
        }


        public static void DeleteProduct()
        {
            Console.WriteLine("\nDelete a Product By Code:");
            //Console.WriteLine("Method Not Yet Implemented");
            // prompt user for product code
            bool getProductCode = true;
            while (getProductCode)
            {
                string checkerString = "n";
                Console.Write("Enter the Product Code for the Product to be deleted:  ");
                string deleteProductCode = Console.ReadLine().ToUpper();
                if (deleteProductCode == "BACK")
                {
                    getProductCode = false;
                    break;
                }
                foreach (Product p in ProductDB.GetProducts())
                {
                    // find product by code
                    if (p.Code == deleteProductCode)
                    {
                        // display product
                        getProductCode = false;
                        ProductDB.GetProducts().Remove(p);
                        checkerString = "y";
                        Console.WriteLine($"\n{p.Description} Successfully Deleted");
                        break;
                    }
                }
                if (checkerString == "n")
                {
                    Console.WriteLine($"Product Code {deleteProductCode} not found.");
                    Console.WriteLine("Please Enter a Valid Product Code");
                    getProductCode = true;
                }
            }
            ProductDB.SaveProductFile();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("list - list products");
            Console.WriteLine("add  - add a product");
            Console.WriteLine("get  - get a product by code");
            Console.WriteLine("del  - delete a product");
            Console.WriteLine("menu - display menu");
            Console.WriteLine("back - return to the main menu from above options");
            Console.WriteLine("exit - exit app");
        }
    }
}

