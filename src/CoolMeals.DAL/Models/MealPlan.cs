namespace CoolMeals.DAL.Models;
public class MealPlan
{
    public int MealPlanId { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}
