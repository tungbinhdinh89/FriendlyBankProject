namespace FriendlyBankProject.Models
{
    public class BankAccount
    {

        public string AccountHolderName { get; private set; }
        public string Address { get; private set; }
        public decimal Balance { get; private set; }
        public decimal OverdraftLimit { get; private set; }

        public BankAccount(string accountHolderName, string address, decimal initialBalance, decimal overdraftLimit)
        {
            AccountHolderName = accountHolderName;
            Address = address;
            Balance = initialBalance;
            OverdraftLimit = overdraftLimit;
        }

        public void PayIn(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Successfully deposited ${amount}. New balance: ${Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void ChangeAccountHolderInfo(string newName, string newAddress)
        {
            AccountHolderName = newName;
            Address = newAddress;
            Console.WriteLine("Account holder information updated successfully.");
        }

        public string GetAccountHolderName()
        {
            return AccountHolderName;
        }

        public string GetAccountHolderAddress()
        {
            return Address;
        }

        public void ChangeOverdraftLimit(decimal newLimit)
        {
            OverdraftLimit = newLimit;
            Console.WriteLine($"Overdraft limit updated to ${newLimit}");
        }

        public decimal GetOverdraftLimit()
        {
            return OverdraftLimit;
        }

    }
}


