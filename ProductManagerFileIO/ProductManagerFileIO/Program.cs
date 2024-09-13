using ProductManagerFileIO.Models;

namespace ProductManagerFileIO
{
    internal class Program
    {
        static List<Product> products = new();
        // Declare file path for use later
        static string productPath = @"C:\files\Products.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App!");

            // LOAD PRODUCTS FROM FILE - into products list

            GetProductFile();

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
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Product: Code - {products[i].Code} | Description - {products[i].Description} | {products[i].Price}");
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
                foreach (Product p in products)
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
                    Console.WriteLine("Product not found.");
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
                Console.Write("Please Enter the New Product Code: ");
                string newProductCode = Console.ReadLine().ToUpper();
                if (newProductCode == "BACK") {
                    goBackLoop = false;
                    break;
                }
                Console.Write("Please Enter the New Product Description: ");
                string newProductDescription = Console.ReadLine();
                Console.Write("Please Enter the New Product Price: ");
                decimal newProductPrice = decimal.Parse(Console.ReadLine());
                // create new instance of product
                Product newProduct = new(newProductCode, newProductDescription, newProductPrice);
                // add product to list
                products.Add(newProduct);
                Console.WriteLine($"\n{newProduct.Description} Successfully Added");
                // SAVE PRODUCT FILE
                SaveProductFile();
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
                if (deleteProductCode == "BACK") { 
                    getProductCode = false;
                    break;
                }
                foreach (Product p in products)
                {
                    // find product by code
                    if (p.Code == deleteProductCode)
                    {
                        // display product
                        getProductCode = false;
                        products.Remove(p);
                        checkerString = "y";
                        Console.WriteLine($"\n{p.Description} Successfully Deleted");
                        break;
                    }
                }
                if (checkerString == "n")
                {
                    Console.WriteLine("Product not found.");
                    Console.WriteLine("Please Enter a Valid Product Code");
                    getProductCode = true;
                }
            }
            SaveProductFile();
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

        // NEW METHODS:
        // SAVE PRODUCT FILE
        private static StreamWriter SaveProductFile()
        {
            using StreamWriter textSave = new(new FileStream(productPath, FileMode.Create, FileAccess.Write));
            foreach (Product p in products)
            {
                textSave.Write(p.Code + "|");
                textSave.Write(p.Description + "|");
                textSave.WriteLine(p.Price);
            }
            return textSave;
        }
        // LOAD PRODUCTS FROM FILE
        public static void GetProductFile()
        {
            using StreamReader textGet = new(new FileStream(productPath, FileMode.OpenOrCreate, FileAccess.Read));
            while (textGet.Peek() != -1)
            {
                string row = textGet.ReadLine() ?? "";
                string[] fields = row.Split('|');
                if (fields.Length == 3)
                {
                    string code = fields[0];
                    string desc = fields[1];
                    decimal price = Decimal.Parse(fields[2]);
                    Product p = new Product(code, desc, price);
                    products.Add(p);
                }
            }
            textGet.Close();

        }
    }
}

