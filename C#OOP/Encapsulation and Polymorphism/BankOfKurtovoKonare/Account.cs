using System.Security.Principal;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IAccount
    {
        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }
  
        public abstract void Deposit(decimal sum);
        public abstract void Withdraw(decimal sum);
        public abstract void CalculateInterest(int months);

    }
}
