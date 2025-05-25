using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class MealPlanConfiguration : IEntityTypeConfiguration<MealPlan>
{
    public void Configure(EntityTypeBuilder<MealPlan> builder)
    {
        builder.HasKey(mp => mp.MealPlanId);
        builder.HasOne(mp => mp.User)
            .WithMany(u => u.MealPlans)
            .HasForeignKey(mp => mp.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(mp => mp.Title)
            .IsRequired()
            .HasMaxLength(150);
    }
}
