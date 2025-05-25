using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class InstructionConfiguration : IEntityTypeConfiguration<Instruction>
{
    public void Configure(EntityTypeBuilder<Instruction> builder)
    {
        builder.HasKey(i => i.InstructionId);
        builder.HasOne(i => i.Recipe)
            .WithMany(r => r.Instructions)
            .HasForeignKey(i => i.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.Property(i => i.Description)
            .IsRequired()
            .HasColumnType("text");
    }
}
