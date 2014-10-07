using System;

class Sale
{
    private string productName;
    private string saleDate;
    private decimal price;

    public Sale(string productName, string saleDate, decimal price)
    {
        this.ProductName = productName;
        this.SaleDate = saleDate;
        this.Price = price;
    }

    public string ProductName
    {
        get
        {
            return this.productName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Product name can't be null or empty");
            }

            this.productName = value;
        }
    }

    public string SaleDate
    {
        get
        {
            return this.saleDate;
        }
        set
        {
            saleDate = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price can't be zero or less");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        return String.Format("product: {0}, price: {1}lv, date sale: {2}", this.ProductName, this.Price, this.SaleDate);
    }
}

