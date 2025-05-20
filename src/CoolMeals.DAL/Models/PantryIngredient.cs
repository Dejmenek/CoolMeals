namespace CoolMeals.DAL.Models;
public class PantryIngredient
{
    public int PantryIngredientId { get; set; }
    public int PantryId { get; set; }
    public int SpoonacularId { get; set; }
    public decimal? Quantity { get; set; }
    public string? Unit { get; set; }
    public DateOnly ExpirationDate { get; set; }
    public Pantry Pantry { get; set; } = null!;
}
