
using System.Runtime.CompilerServices;

namespace BankOfKurtovoKonare
{
    using System;

    class TestBank
    {
        static void Main()
        {
            CompanyCustomer baiGergiOOD = new CompanyCustomer("Bai Gergi OOD");
            DepositAccount depositAccountGergi = new DepositAccount(baiGergiOOD, 1000, 5);
            Console.WriteLine("Company customer {0}", baiGergiOOD.Name);
            Console.WriteLine("Deposit account:");
            depositAccountGergi.CalculateInterest(1);

            LoanAccount loanAccountGergi = new LoanAccount(baiGergiOOD, 1312, 2.4m);
            Console.WriteLine("Loan account:");
            loanAccountGergi.CalculateInterest(10);

            MortgageAccount mortgageAccountGergi = new MortgageAccount(baiGergiOOD, 52, 3.12m);
            Console.WriteLine("Mortgage account:");
            mortgageAccountGergi.CalculateInterest(42);

            Console.WriteLine();

            IndividualCustomer baiIvan = new IndividualCustomer("Bai Ivan");
            DepositAccount depositAccountIvan = new DepositAccount(baiIvan, 1000, 2.34m);
            Console.WriteLine("Individual customer {0}", baiIvan.Name);
            Console.WriteLine("Deposit account:");
            depositAccountIvan.CalculateInterest(1);

            LoanAccount loanAccountIvan = new LoanAccount(baiIvan, 1312, 2.4m);
            Console.WriteLine("Loan account:");
            loanAccountIvan.CalculateInterest(19);

            MortgageAccount mortgageAccountIvan = new MortgageAccount(baiIvan, 52, 3.12m);
            Console.WriteLine("Mortgage account:");
            mortgageAccountIvan.CalculateInterest(42);

        }
    }
}
