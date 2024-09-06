
namespace ClassExerciseClasses
{
    public abstract class Product
    {
        public static void PrintLabel(Product p)
        {
            Console.WriteLine($"{p.ProductID}, {p.Manufacturer}, {p.ProductName}, {p.Price}");
        }
        public string ProductID { get; set; }
        public string Manufacturer { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
    
    //APPLICANCES CATAGORY OF PRODUCTS
       public abstract class Appliances : Product
    {
        public string ApplianceDepartment {  get; set; }

    }

    public class Stove : Appliances
    {
        public string StoveCategory { get; set; } //electric/gas/propane
        public string StoveColor    { get; set; }
       
    }

    //ELECTRONICS CATEGORY OF PRODUCTS
    public abstract class Electronics : Product { 
        public string ElectronicDepartment { get; set;}
    }

    public class TV : Electronics
    {
        public string ScreenSize { get; set; }
        public string ScreenResolution { get; set; }
        public string TVCategory { get; set; }  //LCD/LED/OLED/QLED
    }
    public abstract class Computers : Electronics
    {
        public string ComputerType { get; set; } //laptop / desktop/ tablet
        public string Processor { get; set; }
        public string AmountOfRAM { get; set; }
        public string HardDriveCapacity { get; set;}
    }

    public class Laptop : Computers
    {
        public string ScreenSize { get; set; }
        public string LaptopCategory { get; set; } //gaming/office/chromebook/etc.
    
    }

    public class Desktop : Computers
    { 
    public string  DesktopCategory { get; set; } //gaming/
    }

}
