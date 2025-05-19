using CoolMeals.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoolMeals.DAL.Database;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public DbSet<Diet> Diets { get; set; }
    public DbSet<Instruction> Instructions { get; set; }
    public DbSet<Intolerance> Intolerances { get; set; }
    public DbSet<MealPlan> MealPlans { get; set; }
    public DbSet<MealPlanEntry> MealPlanEntries { get; set; }
    public DbSet<Pantry> Pantries { get; set; }
    public DbSet<PantryIngredient> PantryIngredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<ShoppingList> ShoppingLists { get; set; }
    public DbSet<ShoppingListItem> ShoppingListItems { get; set; }
    public DbSet<UserDiet> UserDiets { get; set; }
    public DbSet<UserIntolerance> UserIntolerances { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
