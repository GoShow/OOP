using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private MetricUnit unit;
        private int timeToPrepare;

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get { return this.name; }

            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null or empty string");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Price cannot be 0 or less");
                }

                this.price = value;
            }
        }

        public int Calories
        {
            get { return this.calories; }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Calories cannot be 0 or less");
                }

                this.calories = value;
            }

        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Quantity per serving cannot be 0 or less");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get { return this.unit; }
            
            protected set
            {
                if ((this is Drink) && value != MetricUnit.Milliliters)
                {
                    throw new ArgumentException("value", "Invalid Metric Unit");
                }

                this.unit = value;
            }
        }

        public int TimeToPrepare
        {
            get { return this.timeToPrepare; }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Time to prepare cannot be 0 or less");
                }

                if ((this is Drink) && value > 20)
                {
                    throw new ArgumentOutOfRangeException("value", "Time to prepare dring cannot be more than 20 minutes");
                }

                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            string measureUnit = "g";
            if (this is Drink)
            {
                measureUnit = "ml";
            }

            StringBuilder result = new StringBuilder();
            string nameAndPrice = string.Format("==  {0} == ${1:f2}", this.Name, this.Price);
            string perServing = string.Format("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, measureUnit, this.Calories);
            string preparation = "Ready in " + this.TimeToPrepare + " minutes";
            result.AppendLine(nameAndPrice);
            result.AppendLine(perServing);
            result.AppendLine(preparation);
            return result.ToString().TrimEnd();
        }
    }
}
