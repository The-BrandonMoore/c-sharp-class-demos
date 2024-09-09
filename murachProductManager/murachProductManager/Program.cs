using murachProductManager.Models;

namespace murachProductManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");

            Book p1 = new Book(1, "C#", "Murach's C#", 59.5m, "Mike Murach");
            Book p2 = new Book(2, "JAVA", "Murach's Java Programming", 57.5m, "Mike Dingaling");

            Console.WriteLine(p2); // because we used override on the ToString Method, when we call p2, it calls ToString and we get our formatted string

            Book b1 = new Book(3, "mySql", "Murach's MySQL", 54.25m, "Joel Murach");

            Software s1 = new(4, "VSC", "VS Code", 0.0m, "v1.93");


            List<Product> productsList = new List<Product> { p1, p2, b1, s1 };
            PrintProducts(productsList);

            Console.WriteLine("BYE");
        }
        private static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                product.PrintToWeb();
            }
        }
    }
}
