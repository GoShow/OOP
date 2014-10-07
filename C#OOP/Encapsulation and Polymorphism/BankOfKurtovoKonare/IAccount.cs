namespace BankOfKurtovoKonare
{
    public interface IAccount
    {
        void Deposit(decimal sum);
        void Withdraw(decimal sum);
        void CalculateInterest(int months);
    }
}
