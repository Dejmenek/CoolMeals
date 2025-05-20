namespace CoolMeals.DAL.Models;
public class ShoppingListItem
{
    public int ShoppingListItemId { get; set; }
    public int ShoppingListId { get; set; }
    public int SpoonacularId { get; set; }
    public decimal? Quantity { get; set; }
    public string? Unit { get; set; }
    public bool IsChecked { get; set; } = false;
    public ShoppingList ShoppingList { get; set; } = null!;
}
