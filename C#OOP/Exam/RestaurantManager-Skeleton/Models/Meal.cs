using System;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public abstract class Meal : Recipe, IMeal
    {
        private bool isVegan;

        public Meal(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, unit, timeToPrepare)
        {
            this.IsVegan = isVegan;
        }

        public bool IsVegan
        {
            get { return this.isVegan; }
            
            protected set
            {
                this.isVegan = value;
            }
        }

        public void ToggleVegan()
        {
            if (this.IsVegan)
            {
                this.IsVegan = false;
            }
            else
            {
                this.IsVegan = true;
            }
        }

    }
}
