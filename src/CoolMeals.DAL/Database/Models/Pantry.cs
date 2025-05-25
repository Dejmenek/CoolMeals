namespace CoolMeals.DAL.Database.Models;
public class Pantry
{
    public int PantryId { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<PantryIngredient> PantryIngredients { get; } = new List<PantryIngredient>();
    public ApplicationUser User { get; set; } = null!;
}
