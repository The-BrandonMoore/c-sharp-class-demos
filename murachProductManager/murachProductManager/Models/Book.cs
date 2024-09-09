

namespace murachProductManager.Models
{
    internal sealed class Book : Product
    {
        public string Author { get; set; }

        public Book (int id, string code, string description, decimal price, string author):
            base(id, code, description, price)
        {
            Author = author;
        }

        public override string ToString()
        {
            return base.ToString() + ", Author - " + Author;
        }

    }
}
