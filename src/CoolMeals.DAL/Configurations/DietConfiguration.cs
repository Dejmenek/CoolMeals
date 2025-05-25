using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class DietConfiguration : IEntityTypeConfiguration<Diet>
{
    public void Configure(EntityTypeBuilder<Diet> builder)
    {
        builder.HasKey(d => d.DietId);
        builder.Property(d => d.Name)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);
        builder.Property(d => d.Description)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(150);
    }
}
