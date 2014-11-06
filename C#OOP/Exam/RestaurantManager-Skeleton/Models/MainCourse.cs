using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class MainCourse : Meal, IMainCourse
    {
        private MainCourseType type;
        private string mainCourseAsString;

        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare,bool isVegan, string mainCourseAsString)
            : base(name, price, calories, quantityPerServing, MetricUnit.Grams, timeToPrepare, isVegan)
        {
            this.Type = SetMaincourseType(mainCourseAsString);
        }

        public MainCourseType Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public string MainCourseAsString
        {
            get { return this.mainCourseAsString; }
            private set { this.mainCourseAsString = value; }
        }
        private MainCourseType SetMaincourseType(string mainCourseType)
        {
            switch (mainCourseType)
            {
                case "Soup":
                    return MainCourseType.Soup;
                case "Entree":
                    return MainCourseType.Entree;
                case "Pasta":
                    return MainCourseType.Pasta;
                case "Side":
                    return MainCourseType.Side;
                case "Meat":
                    return MainCourseType.Meat;
                case "Other":
                    return MainCourseType.Other;
                default:
                    throw new ArgumentException("Invalid Main Course Type!");
            }
        }

        public override string ToString()
        {
            string vegan = "";
            
            if (IsVegan)
            {
                vegan = "[VEGAN] ";
            }
            return vegan + base.ToString() + "\nType: " + this.Type;
        }
    }
}
