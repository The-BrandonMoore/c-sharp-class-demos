using Project11_2_AccountBalanceCalculator.Models;

namespace Project11_2_AccountBalanceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Account application\n");

            CheckingAccount ckacct1 = new(1000m, 1m);
            SavingsAccount svacct1 = new(1000.50m, 0.01);

            Console.WriteLine("Starting Balances");
            DisplayBalances(ckacct1, svacct1);

            Console.WriteLine("\nEnter the transactions for the month\n");
            decimal ckbalance = ckacct1.Balance;
            decimal svbalance = svacct1.Balance;
            string keepGoing = "";
            while (keepGoing != "n")
            {
                string wdOrDep = GetString("Withdrawal or deposit? (w/d): ", "w", "d");
                string account = GetString("Checking or Savings account (c/s)? ", "c", "s");

                Account selectedAccount = null;
                decimal maxAmount = decimal.MaxValue;
                decimal minAmount = .01m;
                if (account == "c")
                {
                    selectedAccount = ckacct1;
                }
                else
                {
                    selectedAccount = svacct1;
                }

                if (wdOrDep == "w" && selectedAccount.Balance <= 0)
                {
                    Console.WriteLine("$0 account balance, cannot withdraw funds. Get a better job. Try coding.");
                    continue;
                }
                else if (wdOrDep == "w")
                {
                    maxAmount = selectedAccount.Balance;
                }


                decimal amount = GetDecimal("Amount? ", minAmount, maxAmount);

                if (wdOrDep == "w")
                {
                    selectedAccount.Withdraw(amount);
                }
                else 
                { 
                    selectedAccount.Deposit(amount); 
                }

                keepGoing = GetString("Continue? (y/n)  ", "y", "n");
            }

            svacct1.ApplyPayment();
            ckacct1.SubtractMonthlyFee();

            Console.WriteLine("\nMonthly Payments and Fees: ");
            Console.WriteLine($"Checking fee:             {ckacct1.MonthlyFee:c}");
            Console.WriteLine($"Savings Interest Payment: {svacct1.MonthlyInterestPayment:c}");

            Console.WriteLine("\nFinal Balances");
            DisplayBalances(ckacct1, svacct1);

        }

        private static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
        {
            Console.WriteLine($"Checking: {ca.Balance:c}");
            Console.WriteLine($"Savings:  {sa.Balance:c}");
        }
        private static string CheckingOrSavings()
        {
            string checkOrSav = "";
            while (true)
            {
                checkOrSav = GetString("Checking or savings? (c/s): ", "c", "s");
                if (checkOrSav == "c" || checkOrSav == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid command");
                }
            }
            return checkOrSav;
        }

        //public static string ContinueOrNot()
        //{
        //    string keepGoing;
        //    while (true)
        //    {

        //        keepGoing = GetString("Continue? (y/n)");
        //        if (keepGoing == "y" || keepGoing == "n")
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("invalid command. Please enter either 'y' or 'n'");
        //        }
        //    }
        //    return keepGoing;
        //}

        private static decimal GetAmount()
        {
            Console.Write("Amount?: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            return amount;
        }

        private static string GetString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
        }
        // GetDouble method which uses data validation, rather than exception handling
        private static decimal GetDecimal(string prompt, decimal min, decimal max)
        {
            decimal number = 0.0m;
            Boolean isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                Boolean success = decimal.TryParse(Console.ReadLine(), out number);
                if (!success)
                {
                    Console.WriteLine("Invalid entry: please enter a valid decimal.");
                }
                else
                {
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return number;
        }
    }
}
