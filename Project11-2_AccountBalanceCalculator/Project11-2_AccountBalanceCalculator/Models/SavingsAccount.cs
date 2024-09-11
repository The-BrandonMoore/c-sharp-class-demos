
namespace Project11_2_AccountBalanceCalculator.Models
{
    public class SavingsAccount : Account
    {
        public double MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment { get; set; }

        public SavingsAccount(decimal initialBalance, double monthlyInterestRate)
        {
            MonthlyInterestRate = monthlyInterestRate;
            base.Balance = initialBalance;
        }

        public void ApplyPayment()
        {
            MonthlyInterestPayment = base.Balance * (decimal)MonthlyInterestRate;
            base.Balance += MonthlyInterestPayment;

        }

    }
}



