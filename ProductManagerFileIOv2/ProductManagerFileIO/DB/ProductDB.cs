

using ProductManagerFileIOv2.Models;

namespace ProductManagerFileIOv2.DB
{

    /*   Product DB is a class that will
     *   Manage the connection and IO
     *   with our Products.txt file.*/
    public class ProductDB
    {
         List<Product> products = new();
         string productPath = @"C:\files\Products.txt";

        public ProductDB()
        {
            //initialize products list
            LoadProductFile();
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        private  void LoadProductFile()
        {
            using StreamReader textLoad = new(new FileStream(productPath, FileMode.OpenOrCreate, FileAccess.Read));
            while (textLoad.Peek() != -1)
            {
                string row = textLoad.ReadLine() ?? "";
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
        }
        public void SaveProductFile()
        {
            using StreamWriter textSave = new(new FileStream(productPath, FileMode.Create, FileAccess.Write));
            foreach (Product p in products)
            {
                textSave.Write(p.Code + "|");
                textSave.Write(p.Description + "|");
                textSave.WriteLine(p.Price);
                //could also do textSave.WriteLine($"{p.Code}|{p.Description}|{p.Price}");
            }
        }


    }
}
