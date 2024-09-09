
namespace murachProductManager.Models
{
    internal abstract class Product : WebPrintable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string code, string description, decimal price)
        {
            Id = id;
            Code = code;
            Description = description;
            Price = price;
        }

        public Product()
        {
            Id = 0;
            Code = string.Empty;
            Description = string.Empty;
            Price = 0m;
        }

        public override string ToString()
        {
            return $"Product: id - {Id}, code - {Code}, description - {Description}, price - {Price}";
        }

        public virtual PrintToWeb()
        {
            Console.WriteLine($"{Description} ({ Code}) - $ { Price}");
        }
    }

}