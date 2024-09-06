namespace BankingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // BankAccount account = new BankAccount();

            //BankAccount acct2 = new();

            //var acct3 = new BankAccount();
            //account.OwnerID = 1;
            //account.Balance = 1000000;
            //account.AccountName = "Corporate 1";
            //account.AccountNumber = 1000;

            CheckingAccount ck1 = new();
            ck1.AccountNumber = 1234;
            ck1.OwnerID = 100;
            ck1.Balance = 100;
            ck1.AccountName = "toys";
            ck1.LastCheckNumber = 999;

           
            SavingsAccount sa1 = new SavingsAccount();
            sa1.Balance = 100;
            sa1.AccountName = "Savings1";
            sa1.OwnerID = 102;
            sa1.AccountNumber = 1077;







        }
    }
}
