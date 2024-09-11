

namespace Project11_2_AccountBalanceCalculator.Models
{
    public interface Balanceable
    {
        decimal getBalance();
        void setBalance(decimal balance);
    }
}
