using System;
namespace Customer
{
    public class Payment
    {
        public Payment(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return String.Format("\n{0} for {1} leva", this.ProductName, this.Price);
        }
    }
}
