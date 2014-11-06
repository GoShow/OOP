using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Restaurant : IRestaurant
    {
        private string name;
        private string location;

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null or empty string");
                }

                this.name = value;
            }
        }

        public string Location
        {
            get { return this.location; }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Location cannot be null or empty string");
                }

                this.location = value;
            }
        }

        public IList<IRecipe> Recipes { get; private set; }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            string restaurantInfo = string.Format("***** {0} - {1} *****", this.Name, this.Location);
            StringBuilder result = new StringBuilder();
            result.AppendLine(restaurantInfo);
            if (this.Recipes.Count == 0)
            {
                result.AppendLine("No recipes... yet");
            }
            else
            {
                var drinks = this.Recipes
                    .Where(r => r is Drink)
                    .OrderBy(r => r.Name);
                if (drinks.Count() > 0)
                {
                    result.AppendLine("~~~~~ DRINKS ~~~~~");
                    result.AppendLine(String.Join("\n", drinks));
                }


                var salads = this.Recipes
                    .Where(r => r is Salad)
                    .OrderBy(r => r.Name);
                if (salads.Count() > 0)
                {
                    result.AppendLine("~~~~~ SALADS ~~~~~");
                    result.AppendLine(String.Join("\n", salads));
                }

                var mainCourses = this.Recipes
                    .Where(r => r is MainCourse)
                    .OrderBy(r => r.Name);
                if (mainCourses.Count() > 0)
                {
                    result.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                    result.AppendLine(String.Join("\n", mainCourses));
                }

                var desserts = this.Recipes
                    .Where(r => r is Dessert)
                    .OrderBy(r => r.Name);

                if (desserts.Count() > 0)
                {
                    result.AppendLine("~~~~~ DESSERTS ~~~~~");
                    result.AppendLine(String.Join("\n", desserts));
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
