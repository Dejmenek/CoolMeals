using Microsoft.AspNetCore.Identity;

namespace CoolMeals.DAL.Models;
public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
