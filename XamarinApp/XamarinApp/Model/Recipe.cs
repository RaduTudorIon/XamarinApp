namespace XamarinApp.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeTitle { get; set; }
        public string Recipeingredients { get; set; }
        public string RecipeText { get; set; }
        public double RecipeCalories { get; set; }
        public int RecipeCookingTime { get; set; }
        public override string ToString()
        {
            return $"({Id}) {RecipeTitle}, {RecipeCookingTime} minutes";
        }
    }
}
