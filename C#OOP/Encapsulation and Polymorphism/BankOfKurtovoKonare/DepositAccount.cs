using System;

namespace BankOfKurtovoKonare
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {
            
        }

        public override void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException("sum", "You can't deposit sum 0 or less"); 
            }

            this.Balance += sum;
        }

        public override void Withdraw(decimal sum)
        {
            if (this.Balance - sum >= 0)
            {
                this.Balance -= sum;
            }

            else
            {
                Console.WriteLine("Your balance is not enougth for this operation");
            }
        }

        public override void CalculateInterest(int months)
        {
            if (months < 0 || this.Interest < 0)
            {
                throw new ArgumentException("Months and interest can't be zero or less");
            }

            if (this.Balance < 1000)
            {
                Console.WriteLine("Your ballance is less than 1000. You don't get interest under this sum");
            }
            else
            {
                decimal interestForPeriod = this.Balance * months * (this.Interest / 100);
                Console.WriteLine("Interest money for the period of {0} months: {1}", months, interestForPeriod);
            }
        }
    }
}
