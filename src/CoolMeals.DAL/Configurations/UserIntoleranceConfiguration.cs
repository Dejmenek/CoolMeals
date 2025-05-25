using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class UserIntoleranceConfiguration : IEntityTypeConfiguration<UserIntolerance>
{
    public void Configure(EntityTypeBuilder<UserIntolerance> builder)
    {
        builder.HasKey(ui => new { ui.UserId, ui.IntoleranceId });
        builder.HasOne(ui => ui.User)
            .WithMany(u => u.UserIntolerances)
            .HasForeignKey(ui => ui.UserId);
        builder.HasOne(ui => ui.Intolerance)
            .WithMany(i => i.UserIntolerances)
            .HasForeignKey(ui => ui.IntoleranceId);
    }
}
