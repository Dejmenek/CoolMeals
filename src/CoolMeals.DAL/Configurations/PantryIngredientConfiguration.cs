using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class PantryIngredientConfiguration : IEntityTypeConfiguration<PantryIngredient>
{
    public void Configure(EntityTypeBuilder<PantryIngredient> builder)
    {
        builder.HasKey(pi => pi.PantryIngredientId);
        builder.HasOne(pi => pi.Pantry)
            .WithMany(p => p.PantryIngredients)
            .HasForeignKey(pi => pi.PantryId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(pi => pi.Quantity)
            .HasPrecision(6, 2);
        builder.Property(pi => pi.Unit)
            .HasColumnType("varchar")
            .HasMaxLength(25);
    }
}
