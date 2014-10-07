namespace BankOfKurtovoKonare
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interest)
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

        public override void CalculateInterest(int months)
        {
            if (months < 0 || this.Interest < 0)
            {
                throw new ArgumentException("Months and interest can't be zero or less");
            }

            if (this.Customer is CompanyCustomer)
            {
                decimal currentInterest = (this.Interest / 100) / 2;
                decimal interestSum = 0;
                for (int i = 0; i < months; i++)
                {
                    if (i > 12)
                    {
                        currentInterest = this.Interest / 100;
                    }

                    interestSum += currentInterest * this.Balance;
                }

                Console.WriteLine("Interest money for period of {0} months: {1}", months, interestSum);
            }
            else if (this.Customer is IndividualCustomer)
            {
                decimal currentInterest = 0;
                decimal interestSum = 0;
                for (int i = 0; i < months; i++)
                {
                    if (i > 6)
                    {
                        currentInterest = this.Interest / 100;
                    }

                    interestSum += currentInterest * this.Balance;
                }

                Console.WriteLine("Interest money for period of {0} months: {1}", months, interestSum);
            }
        }
        public override void Withdraw(decimal sum)
        {
        }
    }
}
