using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Drink : Recipe, IDrink
    {
        private bool isCarbonated;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, MetricUnit.Milliliters, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
        }

        public bool IsCarbonated
        {
            get { return this.isCarbonated; }
            private set { this.isCarbonated = value; }
        }

        public override string ToString()
        {
            string carbonated = "no";
            if (IsCarbonated)
            {
                carbonated = "yes";
            }
            return base.ToString() + "\nCarbonated: " + carbonated;
        }
    }
}
