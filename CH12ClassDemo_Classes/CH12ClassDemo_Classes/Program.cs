namespace CH12ClassDemo_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Classes Demo App!");

            //define a class
            // use the class
            // defined a Product named p1 and assigned vaules  .  .  .
            Product p1 = new Product();
            p1.Code = "c#";
            p1.Description = "Murach's C# Programming";
            p1.Price = 57.50m;

            Console.WriteLine($"p1 price: {p1.Price}");

            Product p2 = new Product("java", "Murach's Java Programming", 59.50m);

            Product p3 = new Product("andr", "Murach's Android Programming", 62.50m);


            //list that stores Products

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            Console.WriteLine("List of Products");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }




            Console.WriteLine("Find a product by code: ");
            Console.WriteLine("========================");

            Console.Write("Enter code to find: ");
            string code = Console.ReadLine();
            Product foundProduct = null;
            foreach (Product p in products)
            {
                if (p.Code == code)
                {
                    foundProduct = p;
                    break;
                }
            }
            if (foundProduct != null)
            {
                Console.WriteLine($"Found Product: {foundProduct}");
            }
            else
            {
                Console.WriteLine($"No product found for code: '{code}'");
            }

            // p. 385 Method that accepts parameters

            // p. 387 Constructors

            // p. 389 Static members

            // p. 391 Form - skip

            // p. 403 required parameters - skip

            // p. 405 - skip

            // p. 408 - discuss but skip



            Console.WriteLine("End");
        }
    }
}
