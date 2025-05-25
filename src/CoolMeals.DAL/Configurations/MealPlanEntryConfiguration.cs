using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class MealPlanEntryConfiguration : IEntityTypeConfiguration<MealPlanEntry>
{
    public void Configure(EntityTypeBuilder<MealPlanEntry> builder)
    {
        builder.HasKey(mpe => mpe.MealPlanId);
        builder.HasOne(mpe => mpe.MealPlan)
            .WithMany(mp => mp.MealPlanEntries)
            .HasForeignKey(mpe => mpe.MealPlanId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(mpe => mpe.Recipe)
            .WithMany(r => r.MealPlanEntries)
            .HasForeignKey(mpe => mpe.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(mpe => mpe.Type)
            .HasConversion<string>()
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();
    }
}
