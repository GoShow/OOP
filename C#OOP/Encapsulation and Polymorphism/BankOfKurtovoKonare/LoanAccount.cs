
using System.Runtime.InteropServices;

namespace BankOfKurtovoKonare
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
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

        public override void Withdraw(decimal deposit)
        {
        }
        public override void CalculateInterest(int months)
        {
            if (months < 0 || this.Interest < 0)
            {
                throw new ArgumentException("Months and interest can't be zero or less");
            }

            if (this.Customer is CompanyCustomer)
            {
                
                if (months <= 2)
                {
                    Console.WriteLine("No interest for the first 2 months for companies");
                }
                else if (months > 2)
                {
                    decimal interestForPeriod = this.Balance * months * (this.Interest / 100);
                    Console.WriteLine("Interest money for the period of {0} months: {1}", months, interestForPeriod);
                }
            }

            else if (this.Customer is IndividualCustomer)
            {
                if (months <= 2)
                {
                    Console.WriteLine("No interest for the first 3 months for individual accounts");
                }
                else if (months > 2)
                {
                    decimal interestForPeriod = this.Balance * months * (this.Interest / 100);
                    Console.WriteLine("Interest money for the period of {0} months: {1}", months, interestForPeriod);
                }
            }
        }
    }
}
