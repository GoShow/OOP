using System;

class Customer : Person
{
    private decimal netPurchaseAmount;

    public Customer(long id, string firstName, string lastName, decimal netPurchaseAmount) : base(id, firstName, lastName)
    {
        this.NetPurchaseAmount = netPurchaseAmount;
    }

    public decimal NetPurchaseAmount
    {
        get
        {
            return this.netPurchaseAmount;
        }

        set
        {
            if (netPurchaseAmount < 0)
            {
                throw new ArgumentException("Amount can't be less than zero");
            }

            this.netPurchaseAmount = value;
        }
    }
}

