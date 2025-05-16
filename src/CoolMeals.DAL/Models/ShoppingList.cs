namespace CoolMeals.DAL.Models;
public class ShoppingList
{
    public int ShoppingListId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
}
