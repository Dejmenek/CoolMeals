using Microsoft.AspNetCore.Identity;

namespace CoolMeals.DAL.Models;
public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public ICollection<UserDiet> UserDiets { get; } = new List<UserDiet>();
    public ICollection<UserIntolerance> UserIntolerances { get; } = new List<UserIntolerance>();
    public ICollection<Pantry> Pantries { get; } = new List<Pantry>();
    public ICollection<MealPlan> MealPlans { get; } = new List<MealPlan>();
    public ICollection<ShoppingList> ShoppingLists { get; } = new List<ShoppingList>();
    public ICollection<Recipe> Recipes { get; } = new List<Recipe>();
}
