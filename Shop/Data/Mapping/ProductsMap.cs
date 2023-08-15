using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Models;

namespace Shop.Data.Mapping
{
    public class ProductsMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(60);
            builder.Property(x => x.CategoryId).HasDefaultValue(0);
            builder.Property(x => x.Description).HasMaxLength(1024);
            builder.Property(x => x.Price)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0.00)
                .HasAnnotation("MinValue", 0.01);
        }
    }
}
