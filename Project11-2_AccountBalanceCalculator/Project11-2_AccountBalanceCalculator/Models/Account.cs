

namespace Project11_2_AccountBalanceCalculator.Models
{
    public class Account : Withdrawable, Depositable
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
