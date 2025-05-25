using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class PantryConfiguration : IEntityTypeConfiguration<Pantry>
{
    public void Configure(EntityTypeBuilder<Pantry> builder)
    {
        builder.HasKey(p => p.PantryId);
        builder.HasOne(p => p.User)
            .WithMany(u => u.Pantries)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(150);
        builder.Property(p => p.Description)
            .HasColumnType("text");
    }
}
