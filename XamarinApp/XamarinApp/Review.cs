using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp
{
    public class Review
    {
        public int Id { get; set; }
        public string recipeTitle { get; set; }
        public string recipeingredients { get; set; }
        public string recipeText { get; set; }
        public double recipeCalories { get; set; }
        public int recipeCookingTime { get; set; }
        public override string ToString()
        {
            return $"({Id}) {recipeTitle}, {recipeCookingTime} minutes";
        }
    }
}
