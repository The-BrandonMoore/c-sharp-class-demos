using System.ComponentModel;

namespace ClassExerciseClasses
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Desktop desktop1 = new Desktop();
            desktop1.Manufacturer = "HP";
            desktop1.ProductName = "Test";
            desktop1.ProductID = "10001";
            desktop1.Price = 100m;

            Stove stove1 = new Stove();
            stove1.Manufacturer = "General Electric";
            stove1.ProductName = "Big Stove";
            stove1.ProductID = "12345";
            stove1.Price = 1000m;

            Laptop laptop1 = new Laptop();
            laptop1.Manufacturer = "Dell";
            laptop1.ProductName = "Cool Laptop";
            laptop1.ProductID = "13330";
            laptop1.Price = 1200m;

            List<Product> productsList = new List<Product>();
            productsList.Add( desktop1 );
            productsList.Add( laptop1 );
            productsList.Add( stove1 );

          // foreach (Product product in productsList)
            //{
            //
              //  Product.PrintLabel(product);
            //}
            

        }


     



    }
}
