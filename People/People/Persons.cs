
namespace People
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
    }

    internal class Employee : Person 
    {
        public string PayrollID { get; set; }
        public DateTime HireDate { get; set; }
   
    }
    internal class Customer : Person
    {
        public string CustomerID { get; set; }
        public decimal CreditLimit { get; set; }
    }

}
