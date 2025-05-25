namespace CoolMeals.DAL.Database.Models;
public class UserIntolerance
{
    public int IntoleranceId { get; set; }
    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;
    public Intolerance Intolerance { get; set; } = null!;
}
