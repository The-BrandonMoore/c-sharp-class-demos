namespace Chapter09_demo_dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //  DateTime myDate = DateTime.Now;

            // DateTime myDate2 = new DateTime();

            /*  bool correctDate = false;
              while (!correctDate == true)
              {
                  Console.Write("Please enter invoice date (yyyy-mm-dd):  ");
                  var invoiceDate = Console.ReadLine();
                  DateTime dueDate;

                  if (DateTime.TryParse(invoiceDate, out dueDate))
                  {
                      Console.WriteLine($"Invoice Due Date: {dueDate.AddDays(30).ToShortDateString()}");
                      correctDate = true;
                  }
                  else
                  {
                      Console.WriteLine("Bad User. Dishonor on you. Dishonor on your cow.");
                  }
                  // DateTime dueDate = invoiceDate.AddDays(30);

              }

              */


            string quoteVariable = "anyone WHO takes more THAN thirty minutes for lunch is UNPROFESSIONAL.";

            //string quoteLower = quoteVariable.ToLower();
            //string quoteUpper = quoteLower.ToUpper();
            string removeFirstLetter = quoteVariable.ToLower().Substring(1);
            string capitalFirst = removeFirstLetter.Insert(0, "A");
            Console.WriteLine(removeFirstLetter);
            ;
            string sixty = capitalFirst.Replace("thirty", "sixty");

            string fourty = "fourty";

            Console.WriteLine("Anyone who takes more than {fourty} minutes for lunch is unprofessional.");

























        }
    }
}
