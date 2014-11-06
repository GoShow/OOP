using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    class Salad : Meal, ISalad
    {
        private const bool SaladIsVegan = true;

        private bool containsPasta;

        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, MetricUnit.Grams, timeToPrepare, Salad.SaladIsVegan)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta
        {
            get { return this.containsPasta; }
            private set { this.containsPasta = value; }
        }

        public override string ToString()
        {
            string pasta = "no";
            if (ContainsPasta)
            {
                pasta = "yes";
            }

            return "[VEGAN] " + base.ToString() + "\nContains pasta: " + pasta;
        }
    }
}
