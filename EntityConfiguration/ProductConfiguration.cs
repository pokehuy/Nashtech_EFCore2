using efcore2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore2.EntityConfugation
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasOne<CategoryModel>()
                .WithMany()
                .HasForeignKey(p => p.CategoryId);
        }
    }
}