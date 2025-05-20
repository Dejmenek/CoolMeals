namespace CoolMeals.DAL.Models;
public class UserIntolerance
{
    public int IntoleranceId { get; set; }
    public int UserId { get; set; }
    public Intolerance Intolerance { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
}
