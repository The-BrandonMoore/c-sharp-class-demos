namespace CH12ClassDemo_Classes
{
    public class Product
    {
        //define variables/properties
        public string Code { get; set; }
        public string Description { get; set; }
       static public decimal Price { get; set; }
        public int ObjectCount {  get; set; }

        //empty constructor
        public Product() 
        {
            ObjectCount++;
        }

        //declare constructors // fully loaded
        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            ObjectCount++;
        }

        //override ToString() ** must have "override" keyword
        public override string ToString()
        {
            return $"Product: Code - {this.Code}\nDescription - {this.Description}\nPrice - {this.Price}";
        }


    }
}
