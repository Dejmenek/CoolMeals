namespace CoolMeals.DAL.Models;
public class Recipe
{
    public int RecipeId { get; set; }
    public Guid UserId { get; set; }
    public int? SpoonacularId { get; set; }
    public string? Title { get; set; }
    public int? ReadyInMinutes { get; set; }
    public int? Servings { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsFavorite { get; set; }
}
