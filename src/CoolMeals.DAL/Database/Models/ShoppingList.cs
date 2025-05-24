namespace CoolMeals.DAL.Database.Models;
public class ShoppingList
{
    public int ShoppingListId { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public ICollection<ShoppingListItem> ShoppingListItems { get; } = new List<ShoppingListItem>();
    public ApplicationUser User { get; set; } = null!;
}
