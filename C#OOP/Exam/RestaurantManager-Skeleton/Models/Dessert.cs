using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Dessert : Meal, IDessert
    {
        private bool withSugar = true;
        private bool isVegan;

        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, MetricUnit.Grams, timeToPrepare, isVegan)
        {
            this.IsVegan = IsVegan;
        }

        public bool WithSugar
        {
            get { return this.withSugar; }
            private set { this.withSugar = value; }
        }

        public void ToggleSugar()
        {
            if (this.WithSugar)
            {
                this.WithSugar = false;
            }
            else
            {
                this.WithSugar = true;
            }
        }

        public override string ToString()
        {
            string vegan = "";
            string sugar = "";
            if (!WithSugar)
            {
                sugar = "[NO SUGAR] ";
            }

            if (IsVegan)
            {
                vegan = "[VEGAN] ";
            }
            
            string result =  sugar + vegan + base.ToString();
            return result;
        }
    }
}
