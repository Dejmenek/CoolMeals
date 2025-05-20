namespace CoolMeals.DAL.Models;
public class Intolerance
{
    public int IntoleranceId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<UserIntolerance> UserIntolerances { get; } = new List<UserIntolerance>();
}
