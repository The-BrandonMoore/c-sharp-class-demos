using Ch017FileIO.Models;

namespace Ch017FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Processing 101!");

            //WRITING AND READING A FILE OF SIMPLE STRINGS

            //page 559 Creating a FileStream object for writing to a file
            //string path = @"C:\files\Names.txt";
            // FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //fs.Close();


            // page 563 Write to a file
            // StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            // textOut.WriteLine("Brandon Moore");
            // textOut.WriteLine("Holly Hoffman");
            // textOut.WriteLine("Chris Silver");
            // textOut.Close();


            // // page 565 read data from a text file
            // StreamReader textIn = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            //string line = textIn.ReadLine();


            // Console.WriteLine("Names: ");
            // while(line != null)
            // {
            //     Console.WriteLine(line);
            //     line = textIn.ReadLine();
            // }

            // READ AND WRITE MULTIPLE FIELDS PER LINE 
            //Create some instances of products
            //Product p1 = new Product("JAVA", "Murach's Java", 57.50m);
            //Product p2 = new Product("C#", "Murach's C#", 59.50m);
            //Product p3 = new Product("ANDR", "Murach's Android", 62.50m);

            //List<Product> products = new List<Product>();
            //products.Add(p1);
            //products.Add(p2);
            //products.Add(p3);
            //Console.WriteLine("Products: ");
            //foreach (Product p in products)
            //{
            //    Console.WriteLine(p);
            //}

            //Console.WriteLine("Write Products to file.");
            //string path = @"C:\files\Products.txt";
            //// "using" eill let C# auto close the file for us
            //using StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            ////parse fields from a product and write as separate fields to each line of a file.
            //foreach (Product p in products)
            //{
            //    // "|" is the separator/delimiter
            //    textOut.Write(p.Code + "|");
            //    textOut.Write(p.Description + "|");
            //    textOut.WriteLine(p.Price);
            //}

            //READ PRODUCTS.TEXT, PARSE THE ROWS INTO PRODUCTS, ADD TO A LIST, THEN PRINT LIST TO CONSOLE

            string path = @"C:\files\Products.txt";
            List<Product> products = new List<Product>();
            using StreamReader textIn = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] fields = row.Split("|"); 
                if (fields.Length == 3) 
                {
                    string code = fields[0]; 
                    string desc = fields[1];
                    decimal price = decimal.Parse(fields[2]);
                    Product p = new(code, desc, price);
                    products.Add(p);
                }

            }
            Console.WriteLine("Products from file:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }








            Console.WriteLine("SEEYA!");
        }
    }
}
