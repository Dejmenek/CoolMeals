namespace CoolMeals.DAL.Database.Models;
public class Diet
{
    public int DietId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<UserDiet> UserDiets { get; } = new List<UserDiet>();
}
