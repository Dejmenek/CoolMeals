using CoolMeals.DAL.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoolMeals.DAL.Configurations;
internal sealed class ShoppingListItemConfiguration : IEntityTypeConfiguration<ShoppingListItem>
{
    public void Configure(EntityTypeBuilder<ShoppingListItem> builder)
    {
        builder.HasKey(sli => sli.ShoppingListItemId);
        builder.HasOne(sli => sli.ShoppingList)
            .WithMany(sl => sl.ShoppingListItems)
            .HasForeignKey(sli => sli.ShoppingListId);
        builder.Property(sli => sli.Unit)
            .HasColumnType("varchar")
            .HasMaxLength(25);
        builder.Property(sli => sli.Quantity)
            .HasPrecision(6, 2);
    }
}
