using CoolMeals.Shared.Enums;

namespace CoolMeals.DAL.Database.Models;
public class MealPlanEntry
{
    public int MealPlanEntryId { get; set; }
    public int MealPlanId { get; set; }
    public int RecipeId { get; set; }
    public DateOnly Date { get; set; }
    public MealType Type { get; set; }
    public MealPlan MealPlan { get; set; } = null!;
    public Recipe Recipe { get; set; } = null!;
}
