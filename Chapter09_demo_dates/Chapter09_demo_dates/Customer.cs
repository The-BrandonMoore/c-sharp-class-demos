
namespace Chapter09_demo_dates
{
    internal class Customer
    {
        //fields
//public string FirstName;
  //      public string LastName;
        //public string CreditLimit;

        //properties
        private int _creditLimit;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CreditLimit
        {
            get { return _creditLimit; }
            set
            {
                if (value < 0)
                {
                    //Console.WriteLine("Bad");
                    throw new ArgumentException("Bad creditlimit");
                }
                else
                {
                    _creditLimit = value;
                }
            }
        }


    }
}
