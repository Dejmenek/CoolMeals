namespace CoolMeals.DAL.Models;
public class UserDiet
{
    public int DietId { get; set; }
    public int UserId { get; set; }
    public Diet Diet { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
