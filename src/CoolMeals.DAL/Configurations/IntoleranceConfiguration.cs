using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class IntoleranceConfiguration : IEntityTypeConfiguration<Intolerance>
{
    public void Configure(EntityTypeBuilder<Intolerance> builder)
    {
        builder.HasKey(i => i.IntoleranceId);
        builder.Property(i => i.Name)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);
        builder.Property(i => i.Description)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(150);
    }
}
