

namespace BankingDemo
{
    abstract internal class BankAccount
    {

        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int OwnerID{ get; set; }
        public decimal Balance { get; set; }
        public decimal ClosingFee { get; set; }
        public string BranchManager { get; set; }

        abstract public void CloseAccount()
        { 

        }


    }


    class CheckingAccount : BankAccount
    {
        public int LastCheckNumber { get; set; }
        public override void CloseAccount()
        {
            //TODO: write close code
            throw new NotImplementedException();
        }
    }

    class BusinessCheckingAccount : CheckingAccount
    {
        public int BusinessFedID { get; set; }
    }

        internal class  SavingsAccount : BankAccount 
    {
        //variables
        private decimal defaultInterestRate = .01m;
        
        internal decimal InterestRate { get; set; }
        public string AccountType { get; set; }
        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }
    }






}
