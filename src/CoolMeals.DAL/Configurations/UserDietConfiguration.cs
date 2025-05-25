using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class UserDietConfiguration : IEntityTypeConfiguration<UserDiet>
{
    public void Configure(EntityTypeBuilder<UserDiet> builder)
    {
        builder.HasKey(ud => new { ud.UserId, ud.DietId });
        builder.HasOne(ud => ud.User)
            .WithMany(u => u.UserDiets)
            .HasForeignKey(ud => ud.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(ud => ud.Diet)
            .WithMany(d => d.UserDiets)
            .HasForeignKey(ud => ud.DietId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
