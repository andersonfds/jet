using Commerce.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.EntityMap
{
    public class UserCartMap : IEntityTypeConfiguration<UserCart>
    {
        public void Configure(EntityTypeBuilder<UserCart> builder)
        {
            builder.ToTable("UserCart");
            builder.HasKey(c => new { c.UserId, c.ProductId });
            builder
                .HasOne(c => c.Product)
                .WithMany(p => p.UsersCart);
            builder
                .HasOne(c => c.User)
                .WithMany(u => u.UserCart);
        }
    }
}
