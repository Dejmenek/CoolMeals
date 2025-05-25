namespace CoolMeals.DAL.Database.Models;
public class UserDiet
{
    public int DietId { get; set; }
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;
    public Diet Diet { get; set; } = null!;
}
